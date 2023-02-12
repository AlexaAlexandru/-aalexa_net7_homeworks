using System;
using System.Net.Http.Json;
using System.Reflection.Emit;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace GenericsAndAsync.Async
{
	public class FetchUrls
	{
		public async Task CallUrlsSequencellyAsync()
        {
            HttpClient client = new HttpClient();
            await CallCatFactsApi(client);

            Console.WriteLine(" -------- --------");

            await CallFishFactsApi(client);

            Console.WriteLine(" -------- --------");

            await CallBeerFactsApi(client);

            Console.WriteLine(" -------- --------");
        }

        private async Task CallBeerFactsApi(HttpClient client)
        {
            var result3 = await client.GetAsync("https://api.punkapi.com/v2/beers/random");

            var stringJSON3 = await result3.Content.ReadAsStringAsync();

            Console.WriteLine("Beer facts data :");

            Console.WriteLine(stringJSON3.Substring(0, 100));
        }

        private  async Task CallFishFactsApi(HttpClient client)
        {
            var result2 = await client.GetAsync("https://www.fishwatch.gov/api/species");

            var stringJSON2 = await result2.Content.ReadAsStringAsync();

            Console.WriteLine("Fish facts data :");

            Console.WriteLine(stringJSON2.Substring(0, 100));
        }

        private async Task CallCatFactsApi(HttpClient client)
        {
            var result = await client.GetAsync("https://cat-fact.herokuapp.com/facts");

            var stringJSON = await result.Content.ReadAsStringAsync();

            Console.WriteLine("Cat facts data :");

            Console.WriteLine(stringJSON.Substring(0, 100));
        }

        public async Task CallUrlsConcurrently()
		{
			HttpClient client = new HttpClient();

            var result = CallCatFactsApi(client);

            var result2 = CallFishFactsApi(client);

            var result3 = CallBeerFactsApi(client);

			var taskList = new List<Task>();

			taskList.Add(result);
            taskList.Add(result2);
            taskList.Add(result3);

			await Task.WhenAll(taskList);

        }

        public async Task GetCatFacts()
        {
            HttpClient client = new HttpClient();

            var result = await client.GetAsync("https://cat-fact.herokuapp.com/facts");

            var stringJSON = await result.Content.ReadAsStringAsync();
            
            var catData= JsonConvert.DeserializeObject<List<CatFactModel>>(stringJSON);
        }
    }
}

