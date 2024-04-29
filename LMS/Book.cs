using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Book
    {
        public enum BookFormat
        {
            Hardcover,
            Paperback,
            EBook
        };

        public string Title;
        public string Author;
        public string ISBN;
        public string Genre;
        public string Publisher;
        public DateTime PublishDate;
        public string Language;
        public int Pages;
        public BookFormat Format;
        public string Description;
        public string Image;
        public int Rating;
        public double Price;
        public int Stock;

        public Book(string title, string author, DateTime publishDate,
            string isbn="", string genre="", string publisher="", 
            string language="English", int pages=1, 
            BookFormat format=BookFormat.Hardcover, string description="", 
            string image="", int rating=5, double price=0, int stock=1)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            Publisher = publisher;
            PublishDate = publishDate;
            Language = language;
            Pages = pages;
            Format = format;
            Description = description;
            Image = image;
            Rating = rating;
            Price = price;
            Stock = stock;
        }
    }
}
