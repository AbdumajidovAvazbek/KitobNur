using System;
using System.Collections.Generic;
using KitobNur.Domain.Entities.Books;
using KitobNur.Domain.Entities.Categories;

namespace KitobNur.Data.SeedDatas
{
    public static class SeedData
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Fiction", CreatedAt = DateTime.UtcNow },
                new Category { Id = 2, Name = "Non-fiction", CreatedAt = DateTime.UtcNow }
            };
        }

        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "To Kill a Mockingbird",
                    Description = "A novel by Harper Lee",
                    Author = "Harper Lee",
                    counte = 10,
                    Balance = 100,
                    ImagePath = "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg",
                    CategoryId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 2,
                    Name = "1984",
                    Description = "A novel by George Orwell",
                    Author = "George Orwell",
                    counte = 8,
                    Balance = 90,
                    ImagePath = "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg",
                    CategoryId = 1,
                    CreatedAt = DateTime.UtcNow
                },
                new Book
                {
                    Id = 3,
                    Name = "Sapiens: A Brief History of Humankind",
                    Description = "A book by Yuval Noah Harari",
                    Author = "Yuval Noah Harari",
                    counte = 15,
                    Balance = 120,
                    ImagePath = "C:\\Users\\User\\source\\repos\\KitobNur\\KitobNur\\src\\KitobNur.Data\\photo_5217546724271315430_x.jpg",
                    CategoryId = 2,
                    CreatedAt = DateTime.UtcNow
                }
            };
        }
    }
}
