#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// List video extension tasks<br/>
        /// Query a paginated list of video extension tasks.
        /// </summary>
        /// <param name="pageNum">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.TaskListResponse> ListVideoExtensionTasksAsync(
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}