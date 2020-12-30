using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework;

namespace WebApplication3.Models
{
    public class User : IdentityUser
    {
        public override string Id { get; set; }
        public override string Email { get; set; }

        [DefaultValue("'{}'::text[]")]
        public List<string> FavoriteTracks { get; set; }
    }
}