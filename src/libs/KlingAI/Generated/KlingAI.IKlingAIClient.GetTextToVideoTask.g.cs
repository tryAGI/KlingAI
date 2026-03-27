#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// Get text-to-video task<br/>
        /// Query the status and result of a specific text-to-video task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.TaskResponse> GetTextToVideoTaskAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}