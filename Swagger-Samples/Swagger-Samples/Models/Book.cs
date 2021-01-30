using System;
using System.ComponentModel.DataAnnotations;

namespace Swagger_Samples.Models
{
    public class Book
    {
        [Required]
        public Guid Book_Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorName { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int TotalAmountOfPages { get; set; }
    }
}
