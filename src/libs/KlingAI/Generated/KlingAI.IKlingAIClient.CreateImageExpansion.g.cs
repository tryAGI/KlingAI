#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// Create image expansion task<br/>
        /// Expand an image by extending its borders.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.CreateTaskResponse> CreateImageExpansionAsync(

            global::KlingAI.CreateImageExpansionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create image expansion task<br/>
        /// Expand an image by extending its borders.
        /// </summary>
        /// <param name="image">
        /// Input image as Base64 string or URL.
        /// </param>
        /// <param name="prompt">
        /// Text prompt to guide the expansion.
        /// </param>
        /// <param name="expansionRatio"></param>
        /// <param name="aspectRatio">
        /// Target aspect ratio.
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.CreateTaskResponse> CreateImageExpansionAsync(
            string image,
            global::KlingAI.ExpansionRatio expansionRatio,
            string? prompt = default,
            global::KlingAI.CreateImageExpansionRequestAspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}