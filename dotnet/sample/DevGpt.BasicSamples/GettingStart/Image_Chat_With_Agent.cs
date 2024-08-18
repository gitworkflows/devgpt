// Copyright (c) Khulnasoft Ltd. All rights reserved.
// Image_Chat_With_Agent.cs

#region Using
using DevGpt.Core;
using DevGpt.OpenAI;
using DevGpt.OpenAI.Extension;
using Azure.AI.OpenAI;
#endregion Using
using FluentAssertions;

namespace DevGpt.BasicSample;

public class Image_Chat_With_Agent
{
    public static async Task RunAsync()
    {
        #region Create_Agent
        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY") ?? throw new Exception("Please set OPENAI_API_KEY environment variable.");
        var model = "gpt-4o"; // The model needs to support multimodal inputs
        var openaiClient = new OpenAIClient(apiKey);

        var agent = new OpenAIChatAgent(
            openAIClient: openaiClient,
            name: "agent",
            modelName: model,
            systemMessage: "You are a helpful AI assistant")
            .RegisterMessageConnector() // convert OpenAI message to DevGpt message
            .RegisterPrintMessage();
        #endregion Create_Agent

        #region Prepare_Image_Input
        var backgoundImagePath = Path.Combine("resource", "images", "background.png");
        var imageBytes = File.ReadAllBytes(backgoundImagePath);
        var imageMessage = new ImageMessage(Role.User, BinaryData.FromBytes(imageBytes, "image/png"));
        #endregion Prepare_Image_Input

        #region Prepare_Multimodal_Input
        var textMessage = new TextMessage(Role.User, "what's in the picture");
        var multimodalMessage = new MultiModalMessage(Role.User, [textMessage, imageMessage]);
        #endregion Prepare_Multimodal_Input

        #region Chat_With_Agent
        var reply = await agent.SendAsync("what's in the picture", chatHistory: [imageMessage]);
        // or use multimodal message to generate reply
        reply = await agent.SendAsync(multimodalMessage);
        #endregion Chat_With_Agent

        #region verify_reply
        reply.Should().BeOfType<TextMessage>();
        #endregion verify_reply
    }
}
