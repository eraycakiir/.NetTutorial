using e_ticket.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_ticket.Models
{
	public class Actor:IEntityBase
	{
		[Key]
		public int Id { get; set; }
		[Display(Name ="Profile Picture")]
		[Required(ErrorMessage ="Profile Picture is required")]
		public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
		[StringLength(50,MinimumLength =3,ErrorMessage ="Full name must be between 3 and 50 chars")]
        public string Bio { get; set; }	

		//Relationship

		public List<Actor_Movie> Actors_Movies { get; set; }
	}
}
