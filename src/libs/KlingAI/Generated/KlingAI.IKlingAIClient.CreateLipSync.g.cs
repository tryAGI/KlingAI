#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// Create lip-sync task<br/>
        /// Create a lip-sync video by syncing audio to a video. Provide either audio_url or tts_text/tts_voice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.CreateTaskResponse> CreateLipSyncAsync(

            global::KlingAI.CreateLipSyncRequest request,
            global::KlingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create lip-sync task<br/>
        /// Create a lip-sync video by syncing audio to a video. Provide either audio_url or tts_text/tts_voice.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modelName">
        /// Model to use for lip-sync.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.CreateTaskResponse> CreateLipSyncAsync(
            global::KlingAI.LipSyncInput input,
            string? modelName = default,
            string? callbackUrl = default,
            global::KlingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}