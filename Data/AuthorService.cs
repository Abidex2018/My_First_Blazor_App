using System;
using System.Collections.Generic;
using System.Linq;

namespace My_First_Blazor_App.Data
{
    public class AuthorService : IAuthorService
    {
        public List<Author> Authors { get; set; }
        public DateTime CreationDate { get; set; }

        public AuthorService()
        {
            CreationDate = DateTime.Now;

            Authors = new List<Author>();

            Authors.Add(new Author { AuthorId = "1002", FirstName = "Johnson", LastName = "White", City = "Menlo Park", EmailAddress = "johnson@gmail.com", Salary = 50000 });
            Authors.Add(new Author { AuthorId = "1202", FirstName = "Mar ", LastName = "Jorie", City = "Owk Land", EmailAddress = "jorie@yahoo.com", Salary = 45000 });
            Authors.Add(new Author { AuthorId = "1302", FirstName = "cheryl", LastName = "Silver", City = "Barkeley", EmailAddress = "silver@hotmail.com", Salary = 35000 });
            Authors.Add(new Author { AuthorId = "1402", FirstName = "Michael", LastName = "Smith", City = "San Jose", EmailAddress = "micheal.smith@uk.com", Salary = 56000 });
            Authors.Add(new Author { AuthorId = "1502", FirstName = "Dean", LastName = "Doe", City = "Oak Land", EmailAddress = "dean@gmail.com", Salary = 75000 });

        }
        public Author GetAuthorById(string authorId)
        {
            return Authors.FirstOrDefault(author => author.AuthorId == authorId);
        }

        public void SaveAuthor(Author author)
        {
            author = new Author
            {

                FirstName = author.FirstName,
                LastName = author.LastName,
                AuthorId = GetNewId(),
                EmailAddress = author.EmailAddress,
                Salary = author.Salary,
                City = author.City

            };
            Authors.Add(author);
        }

        private string GetNewId()
        {
            string id;
            Random random = new Random();
            id = random.Next(1000, 10000).ToString();

            return id;
        }
        public List<Author> GetAuthors()
        {
            return Authors;
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "V1";
        }

    }
}
