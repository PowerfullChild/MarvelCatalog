﻿using Marvel_Catalog_App.Data.Models.Contracts;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Marvel_Catalog_App.Data.Models
{
    public class User : IdentityUser, IAuditable, IDeletable
    {
        public User()
        {
            this.FavoritesCharacters = new HashSet<CharacterDataModel>();
            this.FavoritesComics = new HashSet<ComicsDataModel>();
        }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }

        [Index]
        public bool isDeleted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }

        [Display(Name = "FavoritesCharacters"), Required]
        public HashSet<CharacterDataModel> FavoritesCharacters { get; set; }

        [Display(Name = "FavoritesComics"), Required]
        public HashSet<ComicsDataModel> FavoritesComics { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            
            // Add custom user claims here
            return userIdentity;
        }
    }
}
