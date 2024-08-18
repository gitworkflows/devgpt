/**
 * Creating a sidebar enables you to:
 - create an ordered group of docs
 - render a sidebar for each doc of that group
 - provide next/previous navigation

 The sidebars can be generated from the filesystem, or explicitly defined here.

 Create as many sidebars as you want.
 */

module.exports = {
  docsSidebar: [
    "Getting-Started",
    {
      type: "category",
      label: "Installation",
      collapsed: true,
      items: ["installation/Docker", "installation/Optional-Dependencies"],
      link: {
        type: "doc",
        id: "installation/Installation",
      },
    },
    {
      type: "category",
      label: "Tutorial",
      collapsed: false,
      link: {
        type: "generated-index",
        title: "Tutorial",
        description: "Tutorial on the basic concepts of DevGpt",
        slug: "tutorial",
      },
      items: [
        {
          type: "doc",
          id: "tutorial/introduction",
          label: "Introduction",
        },
        {
          type: "doc",
          id: "tutorial/chat-termination",
          label: "Chat Termination",
        },
        {
          type: "doc",
          id: "tutorial/human-in-the-loop",
          label: "Human in the Loop",
        },
        {
          type: "doc",
          id: "tutorial/code-executors",
          label: "Code Executors",
        },
        {
          type: "doc",
          id: "tutorial/tool-use",
          label: "Tool Use",
        },
        {
          type: "doc",
          id: "tutorial/conversation-patterns",
          label: "Conversation Patterns",
        },
        {
          type: "doc",
          id: "tutorial/what-next",
          label: "What Next?",
        },
      ],
    },
    { "Use Cases": [{ type: "devgpterated", dirName: "Use-Cases" }] },
    {
      type: "category",
      label: "User Guide",
      collapsed: false,
      link: {
        type: "generated-index",
        title: "User Guide",
        slug: "topics",
      },
      items: [{ type: "devgpterated", dirName: "topics" }],
    },
    {
      type: "link",
      label: "API Reference",
      href: "/docs/reference/agentchat/conversable_agent",
    },
    {
      type: "doc",
      label: "FAQs",
      id: "FAQ",
    },

    {
      type: "category",
      label: "DevGpt Studio",
      collapsed: true,
      items: [
        {
          type: "doc",
          id: "devgpt-studio/getting-started",
          label: "Getting Started",
        },
        {
          type: "doc",
          id: "devgpt-studio/usage",
          label: "Using DevGpt Studio",
        },
        {
          type: "doc",
          id: "devgpt-studio/faqs",
          label: "DevGpt Studio FAQs",
        },
      ],
      link: {
        type: "generated-index",
        title: "DevGpt Studio",
        description: "Learn about DevGpt Studio",
        slug: "devgpt-studio",
      },
    },
    {
      type: "category",
      label: "Ecosystem",
      link: {
        type: "generated-index",
        title: "Ecosystem",
        description: "Learn about the ecosystem of DevGpt",
        slug: "ecosystem",
      },
      items: [{ type: "devgpterated", dirName: "ecosystem" }],
    },
    {
      type: "category",
      label: "Contributor Guide",
      collapsed: true,
      items: [{ type: "devgpterated", dirName: "contributor-guide" }],
      link: {
        type: "generated-index",
        title: "Contributor Guide",
        description: "Learn how to contribute to DevGpt",
        slug: "contributor-guide",
      },
    },
    "Research",
    "Migration-Guide",
  ],
  // pydoc-markdown auto-generated markdowns from docstrings
  referenceSideBar: [require("./docs/reference/sidebar.json")],
  notebooksSidebar: [
    {
      type: "category",
      label: "Notebooks",
      items: [
        {
          type: "devgpterated",
          dirName: "notebooks",
        },
      ],
      link: {
        type: "doc",
        id: "notebooks",
      },
    },
  ],
};
