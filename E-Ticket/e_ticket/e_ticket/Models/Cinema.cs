using e_ticket.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_ticket.Models
{
	public class Cinema:IEntityBase
	{
		[Key]
		public int Id { get; set; }

		[Display(Name="Cinema Logo")]
		[Required(ErrorMessage ="Cinema logo is required")]
		public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
		[Required(ErrorMessage = "Cinema logo is required")]
        public string Name { get; set; }
        [Display(Name = "Cinema Description")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string Description { get; set; }

		//Relationship
		public List<Movie> Movies { get; set; }
	}
}
