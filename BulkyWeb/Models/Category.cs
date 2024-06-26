﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]  //add data annotation to make it a primary key
        public int Id { get; set; }
        [Required] //not null value
        [MaxLength(30)]
        //[DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
