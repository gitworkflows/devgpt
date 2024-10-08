import json
import os

import testbed_utils

import devgpt

testbed_utils.init()
##############################

config_list = devgpt.config_list_from_json("OAI_CONFIG_LIST")

assistant = devgpt.AssistantAgent(
    "assistant",
    is_termination_msg=lambda x: x.get("content", "").find("TERMINATE") >= 0,
    llm_config=testbed_utils.default_llm_config(config_list, timeout=180),
)

user_proxy = devgpt.UserProxyAgent(
    "user_proxy",
    human_input_mode="NEVER",
    system_message="A human who can run code at a terminal and report back the results.",
    is_termination_msg=lambda x: x.get("content", "").find("TERMINATE") >= 0,
    code_execution_config={
        "work_dir": "coding",
        "use_docker": False,
    },
    max_consecutive_auto_reply=10,
    default_auto_reply="",
)

third_agent = devgpt.AssistantAgent(
    "__3RD_AGENT_NAME__",
    system_message="""
__3RD_AGENT_PROMPT__
""".strip(),
    is_termination_msg=lambda x: x.get("content", "").find("TERMINATE") >= 0,
    llm_config=testbed_utils.default_llm_config(config_list, timeout=180),
)

groupchat = devgpt.GroupChat(
    agents=[user_proxy, assistant, third_agent],
    messages=[],
    speaker_selection_method="__SELECTION_METHOD__",
    allow_repeat_speaker=False,
    max_round=12,
)

manager = devgpt.GroupChatManager(
    groupchat=groupchat,
    is_termination_msg=lambda x: x.get("content", "").find("TERMINATE") >= 0,
    llm_config=testbed_utils.default_llm_config(config_list, timeout=180),
)

user_proxy.initiate_chat(
    manager,
    message="""
__PROMPT__
""".strip(),
)

##############################
testbed_utils.finalize(agents=[assistant, user_proxy, third_agent, manager])
