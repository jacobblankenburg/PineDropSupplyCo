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
    public class BrandTemplate
    {
        [Key]
        [Display(Name = "Letterhead ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Brand Template Name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Letterhead Unique Name")]
        [StringLength(80)]
        public string DeveloperName { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public string Value { get; set; }

        [Display(Name = "Namespace Prefix")]
        [StringLength(15)]
        [Createable(false), Updateable(false)]
        public string NamespacePrefix { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
