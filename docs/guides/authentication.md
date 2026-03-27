# Authentication

Kling AI uses JWT-based Bearer token authentication.

## Getting an API Key

1. Sign up at [klingai.com](https://klingai.com)
2. Navigate to your account settings to obtain your **Access Key** and **Secret Key**
3. Generate JWT tokens using HS256 with your Access Key as the `iss` claim

## Usage

```csharp
using KlingAI;

// Pass your API key (JWT token) to the client
using var client = new KlingAIClient(apiKey);
```

## Environment Variables

For integration tests, set the `KLINGAI_API_KEY` environment variable:

```bash
export KLINGAI_API_KEY="your-jwt-token"
```

## JWT Token Generation

Kling AI requires JWT tokens with a 30-minute expiry. The token payload should include:

| Claim | Description |
|-------|-------------|
| `iss` | Your Access Key |
| `exp` | Expiration time (Unix timestamp, max 30 minutes from now) |
| `nbf` | Not-before time (Unix timestamp, typically current time - 5 seconds) |

Sign the token using **HS256** with your Secret Key.
