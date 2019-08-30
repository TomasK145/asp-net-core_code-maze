using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NetCoreTutorialCodeMaze.Models
{
    public class Book
    {
        //Data annotation
        /*
            - The Required  attribute indicates that a property must have a value.    
            - Using a MinimumLength attribute indicates that the property should have a minimum length which also means it cannot be empty.
            - The RegularExpression attribute is used to limit what characters can be input.
            - By using the Range attribute, we can constrain the value of a property within a specified range.
            - The StringLength attribute lets us set the maximum length of a string property, and optionally its minimum length.
            - DataTypes are used to specify the data type of the fields and are inherently required and don’t need the Required attribute. 
        */

        public int Id { get; set; }

        [Display(Name = "Book Title")]
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "The Title length should be between 2 and 20.", MinimumLength = 2)]
        public string Title { get; set; }

        public string Genre { get; set; }

        public List<string> Authors { get; set; }

        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Display(Name = "Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
