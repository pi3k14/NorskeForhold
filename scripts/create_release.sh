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

gh auth status
echo # give som space, show status to let user verify

# Make sure branch is set to develop
[[ $(git rev-parse --abbrev-ref HEAD) != "develop" ]] && (echo "ERROR: Checkout develop first"; exit 1;)

# Make sure branch is clean
[[ $(git status --porcelain) ]] && (echo "ERROR: The branch is not clean, commit your changes before creating the release"; exit 1;)

message ">>> Pulling develop"
git pull origin develop

message ">>> Pulling tags"
git fetch --prune --prune-tags origin

# Get version
read -r -p "What version (Major.Minor) do you want to create:  " RELEASE_VERSION
[[ $RELEASE_VERSION =~ ^([1-9]\d*)\.(0|[1-9]\d*)$ ]] || ( echo "'$RELEASE_VERSION' is invalid"; exit 1; )

LATEST_TAG=$(git describe --tags "$(git rev-list --tags --max-count=1)") # gets tags across all branches, not just the current branch

# Create release branch and PR
read -r -p "Last released version was '$LATEST_TAG', do you want to create '$RELEASE_VERSION' [Y/n]:  " RESPONSE
if [[ $RESPONSE =~ ^([yY][eE][sS]|[yY]|)$ ]]; then
  BRANCH_NAME="release-$RELEASE_VERSION"

  message ">>> Creating branch '$BRANCH_NAME' from develop..."
  git checkout -b "$BRANCH_NAME" develop
  git commit --allow-empty -am "Release '$RELEASE_VERSION'"
  git push origin "$BRANCH_NAME"

  message ">>> Creating pull request for merging '$BRANCH_NAME' to main..."
  gh pr create --base main --head "$BRANCH_NAME" --title "Release $RELEASE_VERSION" --body-file ".github/pull_request_template.md"
else
  message "Action cancelled, exiting"
  exit 1
fi