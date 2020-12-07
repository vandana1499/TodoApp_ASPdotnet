using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Tasks:IValidatableObject
    {
        public Tasks()
        {
            TaskList = new List<string>();
        }
        public static int counter=0;

        
        //[Required(ErrorMessage ="List is required")]
        public List<String> TaskList { get; set; }
        public int id { get; set; }

        [Required(ErrorMessage ="Name field is required")]
        [StringLength(30, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]

        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Email should be of valid format")]
        public string Email { get; set; }

        [Display(Name="fav")]
        [Required]
        public string FavouriteThingYouLike { get; set; }

       public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            
            if(FavouriteThingYouLike.Length<10)
            {
                yield return new ValidationResult("Favourite thing you like should have a length more that 10");
            }
            

        }
    }

}
