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
            
            // RestRequest request = new RestRequest("pokemon/blaziken");
            // IRestResponse response = client.Get(request);
            // Console.WriteLine(response.Content);
            // Console.ReadLine();

            System.Console.WriteLine("Search for a pokemon");

            while (true)
            {
                string answer = Console.ReadLine();

                RestRequest request = new RestRequest("pokemon/" + answer.ToLower());
                IRestResponse response = client.Get(request);
                //System.Console.WriteLine(response.Content);
                if (response.Content == "Not Found")
                {
                    System.Console.WriteLine("The pokemon could not be found. Do you wish to try again? (y/n)");
                    string tryAgain = Console.ReadLine();
                    
                    if (tryAgain.ToLower() == "y")
                    {
                        System.Console.WriteLine("Search for a pokemon");
                    }
                    else if(tryAgain.ToLower() == "n")
                    {
                        break;
                    }
                }
                else
                {
                    System.Console.WriteLine("The pokemon " + answer.ToLower() + " has been found");
                    System.Console.WriteLine("What would you like to know about the pokemon? You can choose between:\nHealth \tAttack \tDefense \tSpecial Attack \tSpecial Defense \tStat Total \t");
                }
            }
        }
    }
}
