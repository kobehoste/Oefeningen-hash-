namespace DictionaryOef3;
using System;
using System.Collections.Generic;

public class DictionaryBook
{
    public static void Main(string[] args)
    {
        Dictionary<int, Book> library = new Dictionary<int, Book>();
        Book book1 = new Book("mijn verhaal", "klaudius", 1996);
        Book book2 = new Book("boom", "pieter-jan", 2009);
        Book book3 = new Book("treebuilder", "pigeon", 2010);

        library[126554] = book1;
        library[669543] = book2;
        library[126565] = book3;
        Console.WriteLine("Geef een boek-id in : ");
        int id = Convert.ToInt32(Console.ReadLine());
        if (library.ContainsKey(id))
        {
            Console.WriteLine(library[id]);
        }
        else{Console.WriteLine("Geef een juist id in. ");}
    }
}