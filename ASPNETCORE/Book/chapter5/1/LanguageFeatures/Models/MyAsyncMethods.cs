using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {

        public static async Task<long?> GetPageLength()
        {

            //HttpClient client = new HttpClient();

            //var httpMessage =  client.GetAsync("http://google.com");

            //return httpMessage.ContinueWith(
            //    (HttpResponseMessage result) => {
            //        return result.Content.Headers.ContentLength
            //    }
            //    );

            HttpClient client
                = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;

        }

        public static async IAsyncEnumerable<long?> GetPageLengths(List<string> output, params string[] urls)
        {
            HttpClient httpClient = new HttpClient();
            foreach (var url in urls)
            {
                output.Add($"started request for URL");
                var httpMessage = await httpClient.GetAsync($"http://{url}");
                output.Add($"Completed request for URL");
                yield return httpMessage.Content.Headers.ContentLength;
            }

        }

            //public static async IAsyncEnumerable<long?> GetPageLengths(List<string> output, params string[] urls)
            //{
            //    HttpClient client = new HttpClient();
            //    foreach (string url in urls)
            //    {
            //        output.Add($"Started request for {url}");
            //        var httpMessage = await client.GetAsync($"http://{url}");
            //        output.Add($"Completed request for {url}");
            //        yield return httpMessage.Content.Headers.ContentLength;
            //    }
            //}

            //public static async Task<IEnumerable<long?>> GetPageLengths(List<string> output, params string[] urls)
            //{
            //    List<long?> results = new List<long?>();
            //    HttpClient client = new HttpClient();
            //    foreach (string url in urls)
            //    {
            //        output.Add($"Started request for {url}");
            //        var httpMessage = await client.GetAsync($"http://{url}");
            //        results.Add(httpMessage.Content.Headers.ContentLength);
            //        output.Add($"Completed request for {url}");
            //    }
            //    return results;
            //}
        }
    }

