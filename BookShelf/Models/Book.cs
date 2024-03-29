﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
