﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EC2_1601226.Models
{
    public class Bag
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Brand of Bag")]
        [DataType(DataType.Text)]
        public string Brand { get; set; }
       
        
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Please Enter the Name of the Bag")]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage = "Please Enter Model of Bag")]
        [DataType(DataType.Text)]
        [Display(Name = "Model")]
        [StringLength(6,ErrorMessage= "Model Must be Six Character Long")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please Enter Date Bag was Manufactured")]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime ManufactureDate { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Qunatity of Bags Available")]
        [Display(Name = "Quantity")]
        [Range(1,500,ErrorMessage = "Available Quantity can range from 1 to 500")]
        public int Quantity { get; set; }
        [DataType(DataType.Currency)]
        [Required(ErrorMessage ="Please Enter Price of Bag")]
        [Display(Name="Price")]
        public decimal Price { get; set; }
    }
}
