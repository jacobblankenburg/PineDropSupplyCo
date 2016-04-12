﻿using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PineDropSupplyCo.Models.Salesforce
{
    public class Name
    {
        [Key]
        [Display(Name = "ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        [JsonProperty("Name")]
        public string Name_Property { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string LastName { get; set; }

        [Display(Name = "First Name")]
        [StringLength(40)]
        [Createable(false), Updateable(false)]
        public string FirstName { get; set; }

        [Createable(false), Updateable(false)]
        public string Type { get; set; }

        [StringLength(8)]
        [Createable(false), Updateable(false)]
        public string Alias { get; set; }

        [Display(Name = "Role ID")]
        [Createable(false), Updateable(false)]
        public string UserRoleId { get; set; }

        [Display(Name = "Record Type ID")]
        [Createable(false), Updateable(false)]
        public string RecordTypeId { get; set; }

        [Display(Name = "Active")]
        [Createable(false), Updateable(false)]
        public bool IsActive { get; set; }

        [Display(Name = "Profile ID")]
        [Createable(false), Updateable(false)]
        public string ProfileId { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Title { get; set; }

        [EmailAddress]
        [Createable(false), Updateable(false)]
        public string Email { get; set; }

        [Phone]
        [Createable(false), Updateable(false)]
        public string Phone { get; set; }

        [StringLength(80)]
        [Createable(false), Updateable(false)]
        public string Username { get; set; }

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

    }
}
