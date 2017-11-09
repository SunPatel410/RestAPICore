using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.API.Models
{
    public class AuthorForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Genre { get; set; }


        //create a child resource that be linked to the parent resource
        public ICollection<BookForCreationDto> Books { get; set; }
                = new List<BookForCreationDto>();
    }
}
