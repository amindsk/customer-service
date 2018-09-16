using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace ui.Models
{
    public class APIClient
    {
        private string baseURL = "http://localhost:3000";
        private RestClient client;
        private RestRequest request;
        public List<Customer> GetRequest(string url, string token)
        {
            client = new RestClient(baseURL + url);
            request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "Bearer " + token);
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            return JsonConvert.DeserializeObject<List<Customer>>(response.Content);
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response =>
            {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}