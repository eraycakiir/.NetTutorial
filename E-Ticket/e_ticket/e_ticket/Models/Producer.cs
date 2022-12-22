using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_ticket.Models
{
	public class Producer
	{
		[Key]
		public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Profile Full Name")]

        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

		//Relationship
		public List<Movie> Movies { get; set; }
	}
}
