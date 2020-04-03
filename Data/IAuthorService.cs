using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_First_Blazor_App.Data
{
    public interface IAuthorService
    {
        List<Author> GetAuthors();

        Author GetAuthorById(string authorId);

        DateTime GetCreatedDate();

        string GetVersion();

        void SaveAuthor(Author author);
    }
}
