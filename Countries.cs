namespace Oefeningen25_26;
using System;
using System.Collections.Generic;


public class Countries
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> countries = new Dictionary<string, string>();
        countries["Albania"] = "Tirana";
        countries["Belgium"] = "Brussels";
        countries["Spain"] = "Madrid";
        countries["United States"] = "Washington D.C.";

        foreach (string key in countries.Keys)
        {
            Console.WriteLine(key);
        }
        Console.WriteLine();
        
        foreach (string value in countries.Values)
        {
            Console.WriteLine(value);
        }

        foreach (KeyValuePair<string, string> country in countries)
        {
            Console.WriteLine(country.Value+" : "+country.Key );
        }
    }

}