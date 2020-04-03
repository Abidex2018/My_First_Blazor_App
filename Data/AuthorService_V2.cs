using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_Blazor_App.Data
{
    public class AuthorService_V2 : IAuthorService
    {
        public List<Author> Authors { get; set; }
        public DateTime CreationDate { get; set; }

        public AuthorService_V2()
        {



            CreationDate = DateTime.Now;

            Authors = new List<Author>();

            Authors.Add(new Author { AuthorId = "454.456.001", FirstName = "Johnson", LastName = "White", City = "Menlo Park", EmailAddress = "johnson@gmail.com", Salary = 50000 });
            Authors.Add(new Author { AuthorId = "454.456.002", FirstName = "Mar ", LastName = "Jorie", City = "Owk Land", EmailAddress = "jorie@yahoo.com", Salary = 45000 });
            Authors.Add(new Author { AuthorId = "454.456.003", FirstName = "cheryl", LastName = "Silver", City = "Barkeley", EmailAddress = "silver@hotmail.com", Salary = 35000 });
            Authors.Add(new Author { AuthorId = "454.456.004", FirstName = "Michael", LastName = "Smith", City = "San Jose", EmailAddress = "micheal.smith@uk.com", Salary = 56000 });
            Authors.Add(new Author { AuthorId = "454.456.005", FirstName = "Dean", LastName = "Doe", City = "Oak Land", EmailAddress = "dean@gmail.com", Salary = 75000 });

        }
        public Author GetAuthorById(string authorId)
        {
            return Authors.FirstOrDefault(author => author.AuthorId == authorId);
        }

        public List<Author> GetAuthors()
        {
            foreach (var author in Authors)
            {
                author.FirstName = author.FirstName.ToLower();
                author.City = author.LastName.ToLower();

                author.City = author.City.ToLower();

            }
            return Authors;
        }

        public void SaveAuthor(Author author)
        {
            author = new Author
            {
                FirstName = author.FirstName,
                LastName = author.LastName,
                AuthorId = Guid.NewGuid().ToString(),
                EmailAddress = author.EmailAddress,
                Salary = author.Salary,
                City = author.City

            };
            Authors.Add(author);
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "V2";
        }
    }
}
