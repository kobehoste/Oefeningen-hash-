using System;
using System.Collections.Generic;

public class Book
{
    private string title { get; set; }
    private string author { get; set; }
    private int year {  get; set; }

    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    public override string ToString()
    {
        return string.Format("Title: {0}, Author: {1}, Year: {2}", title, author, year);
    }


}