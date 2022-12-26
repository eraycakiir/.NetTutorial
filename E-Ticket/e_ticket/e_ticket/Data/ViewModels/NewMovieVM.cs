using e_ticket.Data.Enums;
using e_ticket.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace e_ticket.Data.ViewModels
{
    public class NewMovieVM
    {
        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        


        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }


        [Display(Name = "Movie Poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageUrl { get; set; }



        [Display(Name = "Movie Start date")]
        [Required(ErrorMessage = "Movie Start date is required")]
        public DateTime StartDate { get; set; }


        [Display(Name = "Movie End date")]
        [Required(ErrorMessage = "Movie End date is required")]
        public DateTime EndDate { get; set; }


        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }


        //Relationships
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Movie cinmea is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Movie producer  is required")]
        public int ProducerId { get; set; }
    }
    
}
