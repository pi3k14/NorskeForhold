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
[[ $(git rev-parse --abbrev-ref HEAD) != "develop" ]] && (echo $'ERROR: Checkout develop first\n'; exit 1;)

# Make sure branch is clean
[[ $(git status --porcelain) ]] && (echo $'ERROR: The branch is not clean, commit your changes before creating the feature\n'; exit 1;)

message ">>> Pulling develop"
git pull origin develop

# Get feature name
read -r -p "What feature do you want to create: " FEATURE

# Create feature branch and PR
read -r -p "Do you want to create '$FEATURE' (branched from develop) [Y/n]: " RESPONSE
if [[ $RESPONSE =~ ^([yY][eE][sS]|[yY]|)$ ]]; then
  BRANCH_NAME="feature/$FEATURE"

  message ">>> Creating branch '$BRANCH_NAME' from develop..."
  git checkout -b "$BRANCH_NAME" develop
  git commit --allow-empty -am "New feature '$FEATURE'"
  git push origin "$BRANCH_NAME"

  message ">>> Creating draft pull request for merging '$BRANCH_NAME' back to develop..."
  gh pr create --base develop --head "$BRANCH_NAME" --title "Feature - $FEATURE"  --body-file ".github/pull_request_template.md" --draft
else
  message "Action cancelled, exiting"
  exit 1
fi