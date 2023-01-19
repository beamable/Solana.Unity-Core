using Solana.Unity.Rpc.Utilities;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Solana.Unity.Rpc.Core.Http;

/// <summary>
/// Provide a convenient way to make HTTP requests inside and outside Unity.
/// </summary>
public static class CrossHttpClient
{
    /// <summary>
    /// Send an async request using HttpClient or UnityWebRequest if running on Unity
    /// </summary>
    /// <param name="httpClient"></param>
    /// <param name="httpReq"></param>
    /// <returns></returns>
    public static async Task<HttpResponseMessage> SendAsyncRequest(HttpClient httpClient, HttpRequestMessage httpReq)
    {
        return await httpClient.SendAsync(httpReq).ConfigureAwait(false);
    }
}