# basic setup
FROM python:3.10
RUN apt-get update && apt-get -y update
RUN apt-get install -y sudo git npm

# Setup user to not run as root
RUN adduser --disabled-password --gecos '' devgpt-dev
RUN adduser devgpt-dev sudo
RUN echo '%sudo ALL=(ALL) NOPASSWD:ALL' >> /etc/sudoers
USER devgpt-dev

# Pull repo
RUN cd /home/devgpt-dev && git clone https://github.com/khulnasoft/devgpt.git
WORKDIR /home/devgpt-dev/devgpt

# Install devgpt (Note: extra components can be installed if needed)
RUN sudo pip install -e .[test]

# Install precommit hooks
RUN pre-commit install

# For docs
RUN sudo npm install --global yarn
RUN sudo pip install pydoc-markdown
RUN cd website
RUN yarn install --frozen-lockfile --ignore-engines

# override default image starting point
CMD /bin/bash
ENTRYPOINT []
