import time

import _paths
from devgptcap.ag_adapter.agent import Agent
from devgptcap.Config import IGNORED_LOG_CONTEXTS
from devgptcap.runtime_factory import RuntimeFactory

from devgpt import UserProxyAgent

# Filter out some Log message contexts
IGNORED_LOG_CONTEXTS.extend(["BROKER"])


def main():
    # Standard DevGpt
    user_proxy = UserProxyAgent(
        "user_proxy",
        code_execution_config={"work_dir": "coding"},
        is_termination_msg=lambda x: "TERMINATE" in x.get("content"),
    )

    # Wrap DevGpt Agent in CAP
    cap_user_proxy = Agent(user_proxy, counter_party_name="assistant", init_chat=True)
    # Create the message bus
    ensemble = RuntimeFactory.get_runtime("ZMQ")
    # Add the user_proxy to the message bus
    cap_user_proxy.register(ensemble)
    # Start message processing
    ensemble.connect()

    # Wait for the user_proxy to finish
    interact_with_user(ensemble, cap_user_proxy)
    # Cleanup
    ensemble.disconnect()


# Starts the Broker and the Assistant. The UserProxy is started separately.
def interact_with_user(network, cap_assistant):
    user_proxy_conn = network.find_by_name("user_proxy")
    example = "Plot a chart of MSFT daily closing prices for last 1 Month."
    print(f"Example: {example}")
    try:
        user_input = input("Please enter your command: ")
        if user_input == "":
            user_input = example
        print(f"Sending: {user_input}")
        user_proxy_conn.send_txt_msg(user_input)

        # Hang around for a while
        while cap_assistant.running():
            time.sleep(0.5)
    except KeyboardInterrupt:
        print("Interrupted by user, shutting down.")


if __name__ == "__main__":
    main()
