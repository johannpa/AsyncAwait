using System;
using System.Net.Http;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();

            string url = "https:/...";

            Console.Write("Téléchargement...");
            var task = httpClient.GetStringAsync(url);
            task.Wait();

            Console.WriteLine("OK");

            Console.WriteLine(task.Result);
        }

        
    }
}
