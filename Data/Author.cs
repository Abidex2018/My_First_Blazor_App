using System.ComponentModel.DataAnnotations;

namespace My_First_Blazor_App.Data
{
    public class Author
    {
        public string AuthorId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

       
        [Range(1000,9999999,ErrorMessage = "Salary should be greater than $1000 ")]
        public double Salary { get; set; }

        [EmailAddress(ErrorMessage = "Please Enter a Valid Email")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [StringLength(20,ErrorMessage = "City name cannot be longer than 20 character")]
        public string City { get; set; }

        public Author()
        {
            
        }

        public Author(string authorId, string firstName, string lastName, string emailAddress, double salary,string city)
        {
            AuthorId = authorId;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            EmailAddress = emailAddress;
            City = city;
        }
    }
}
