using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetWonderAdoption.Models
{
    public class Pet
    {
        /// <summary>
        /// Unique ID number for the game
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// The title the pet will be called as
        /// </summary>
        [Required]
        [StringLength(90)]
        public string Title { get; set; }

        /// <summary>
        /// The type of catagory the pet counts as
        /// </summary>
        public string Breed { get; set; }

        /// <summary>
        /// market price for pet
        /// </summary>
        public string Description { get; set; }
        [Range(0.01, 999.99)]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}
