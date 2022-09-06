﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebStore.Services.Core.API.ViewModels.Account
{
    public class VerifyCodeViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        public string Provider { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
