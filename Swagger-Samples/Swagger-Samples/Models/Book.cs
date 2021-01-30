using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_Samples.Models
{
    public class Book
    {
        public Guid Book_Id { get; set; }

        public string Title { get; set; }

        public string AuthorName { get; set; }

        public string Genre { get; set; }

        public int TotalAmountOfPages { get; set; }
    }
}
