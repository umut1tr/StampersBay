using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace StampersBay.Areas.Identity.Data;

// Add profile data for application users by adding properties to the MyApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string SecretToken { get; set; }

    [Required]
    public bool isStampedIn { get; set; }
}

