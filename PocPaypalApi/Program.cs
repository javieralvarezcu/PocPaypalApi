using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PocPaypalApi.Model;
using System.Net.Http.Headers;
using System.Text;

namespace PocPaypalApi
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Authorization", "Bearer A21AALLiQeWsh36KRldjebVk6M5zGZZwCPhDiuf2Q9pXIW1CVCnkVS-FMn6BrKVjNkxhiG2YW1OxK82BOsCq7xo45ZRcABFGA");

            var stringTask = client.GetStringAsync("https://api-m.sandbox.paypal.com/v1/reporting/transactions?start_date=2022-05-06T00:00:00Z&end_date=2022-05-09T00:00:00Z");

            var feed = System.Text.Json.JsonSerializer.Deserialize<Rootobject>(stringTask.Result);

            Console.WriteLine("\n\n-----DESERIALIZED DATA DEMO-----\n\n");
            Console.WriteLine($"Total items: {feed.total_items}");
            Console.WriteLine($"Total pages: {feed.total_pages}");
            Console.WriteLine($"Start date: {feed.start_date}");
            Console.WriteLine($"End date: {feed.end_date}");

            Console.WriteLine("\n\n-----RAW JSON DATA DEMO-----\n\n");
            string jsonFormatted = JValue.Parse(stringTask.Result).ToString(Formatting.Indented);
            Console.WriteLine(jsonFormatted);
        }
    }
}
