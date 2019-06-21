using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aiursoft.Pylon.Models.API.UserAddressModels
{
    public class SetPrimaryEmailAddressModel : UserOperationAddressModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
