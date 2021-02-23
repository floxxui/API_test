using System;
using RestSharp;
using Newtonsoft.Json;

namespace Api
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");
            RestRequest request = new RestRequest("pokemon/blaziken");
            IRestResponse response = client.Get(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
        }
    }
}
