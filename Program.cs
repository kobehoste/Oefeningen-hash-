using System;
using System.Collections.Generic;

public class Supermarket
{
    public static void Main(string[] args)
    {
        Dictionary<string,double> prices = new Dictionary<string, double>();
        prices["aardappel"] = 1.96;
        prices["rode paprika"] = 0.96;
        prices["stofzuiger"] = 19.99;
        Console.WriteLine("wat wil je kopen ?");
        string userInput = Console.ReadLine();
        if (prices.ContainsKey(userInput))
        {
            Console.WriteLine(userInput + " kost " + prices[userInput]);
        }
        
        else {Console.WriteLine("Dit bestaat niet, kies een bestaand product.");}
    }
}