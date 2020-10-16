﻿using System.ComponentModel.DataAnnotations;

namespace ArticleManager.Web.Models
{
    public class ArticleItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Title is too long.")]
        public string Title { get; set; }
        public string CategoryId { get; set; }
        public InputSelectItem[] Categories { get; set; }
        public string Content { get; set; }
    }
}
