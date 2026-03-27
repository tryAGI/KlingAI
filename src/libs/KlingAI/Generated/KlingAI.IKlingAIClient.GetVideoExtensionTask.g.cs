#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// Get video extension task<br/>
        /// Query the status and result of a specific video extension task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.TaskResponse> GetVideoExtensionTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}