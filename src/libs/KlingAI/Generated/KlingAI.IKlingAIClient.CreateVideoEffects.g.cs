#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// Create video effects task<br/>
        /// Apply AI special effects to images, such as old photo restoration, holiday themes, and dual-character effects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.CreateTaskResponse> CreateVideoEffectsAsync(

            global::KlingAI.CreateVideoEffectsRequest request,
            global::KlingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create video effects task<br/>
        /// Apply AI special effects to images, such as old photo restoration, holiday themes, and dual-character effects.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="modelName">
        /// Model to use for effects generation.
        /// </param>
        /// <param name="duration">
        /// Duration of the output video.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.CreateTaskResponse> CreateVideoEffectsAsync(
            global::KlingAI.EffectsInput input,
            string? modelName = default,
            string? duration = default,
            string? callbackUrl = default,
            global::KlingAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}