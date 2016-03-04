using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace RestClient
{
    public class Program
    {
        public void Main(string[] args)
        {
            DoWork();
        }

        static async void DoWork()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:4966/api1/v1");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Product>>(json);
                Console.WriteLine(json);
                foreach (var itm in list)
                {
                    Console.WriteLine(itm.Name);
                }
            }
        }
    }
}
