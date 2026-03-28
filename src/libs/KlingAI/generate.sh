#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# Kling AI has no public OpenAPI spec — openapi.yaml is manually maintained from API docs
autosdk generate openapi.yaml \
  --namespace KlingAI \
  --clientClassName KlingAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
