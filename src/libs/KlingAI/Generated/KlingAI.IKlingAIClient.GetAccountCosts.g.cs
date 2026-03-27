#nullable enable

namespace KlingAI
{
    public partial interface IKlingAIClient
    {
        /// <summary>
        /// Query resource packages<br/>
        /// Query account resource packages and credit consumption.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="resourcePackName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::KlingAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::KlingAI.AccountCostsResponse> GetAccountCostsAsync(
            long startTime,
            long endTime,
            string? resourcePackName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}