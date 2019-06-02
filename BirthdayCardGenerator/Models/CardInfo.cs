using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CardGenerator.Models
{
    public class CardInfo
    {
        [Required(ErrorMessage = "Your name is required")]
        public string From { get; set; }
        [Required(ErrorMessage = "Recipient's name is required")]
        public string To { get; set; }
        [Required(ErrorMessage = "Your message is required")]
        public string Message { get; set; }

    }
}