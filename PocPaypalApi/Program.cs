// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Text;

namespace PocPaypalApi // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();
        HttpContent httpContent = new StringContent("json", Encoding.UTF8, "application/json");

        static async Task Main(string[] args)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer A21AALLiQeWsh36KRldjebVk6M5zGZZwCPhDiuf2Q9pXIW1CVCnkVS-FMn6BrKVjNkxhiG2YW1OxK82BOsCq7xo45ZRcABFGA");

            var stringTask = client.GetStringAsync("https://api-m.sandbox.paypal.com/v1/invoicing/invoices");

            var msg = await stringTask;
            Console.Write(msg);
        }
    }
}