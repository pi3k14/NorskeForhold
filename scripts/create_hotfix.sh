#!/bin/bash
set -e

message() {
  echo
  echo "$1"
  echo
}

message ">>> Verify prerequisites"

# Verify tools
[[ ! -x "$(command -v gh)" ]] && (echo $'gh not found, you need to install github CLI\n'; exit 1;)

[[ ! -x "$(command -v git)" ]] && (echo $'git not found, you need to install git CLI\n'; exit 1;)

[[ ! -x "$(command -v dotnet-gitversion)" ]] && (echo $'dotnet-gitversion not found, you need to install gitversion CLI'; exit 1;)

gh auth status
echo # give som space, show status to let user verify

# Make sure branch is set to main
[[ $(git rev-parse --abbrev-ref HEAD) != "main" ]] && echo "ERROR: Checkout main first" && exit 1

#  Make sure branch is clean
[[ $(git status --porcelain) ]] && echo "ERROR: The branch is not clean, commit your changes before creating the release" && exit 1

message ">>> Pulling main"
git pull origin main

message ">>> Pulling tags"
git fetch --prune --tags

RELEASE_VERSION=$(dotnet-gitversion -showvariable MajorMinorPatch)

message ">>> Hotfix: $RELEASE_VERSION"

# Create hotfix branch and PR
BRANCH_NAME="hotfix-"$RELEASE_VERSION

read -r -p "Are you sure you want to create the branch '$BRANCH_NAME' [Y/n]:  " RESPONSE
if [[ $RESPONSE =~ ^([yY][eE][sS]|[yY]|)$ ]]; then
  message ">>> Creating branch '$BRANCH_NAME' from main..."
  git checkout -b "$BRANCH_NAME" main
  git commit --allow-empty -am "Hotfix '$RELEASE_VERSION'"
  git push origin "$BRANCH_NAME"

  message ">>> Creating draft pull request for merging '$BRANCH_NAME' back to main..."
  gh pr create --base main --head "$BRANCH_NAME" --title "Hotfix $RELEASE_VERSION" --template "pull_request_template.md" --draft
else
  message "Action cancelled, exiting"
  exit 1
fi