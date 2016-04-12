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
    public class PartnerRole
    {
        [Key]
        [Display(Name = "Partner Role Value ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Master Label")]
        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string MasterLabel { get; set; }

        [Display(Name = "Sort Order")]
        [Createable(false), Updateable(false)]
        public int? SortOrder { get; set; }

        [Display(Name = "Reverse Role")]
        [Createable(false), Updateable(false)]
        public string ReverseRole { get; set; }

        [Display(Name = "Created By ID")]
        [Createable(false), Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "System Modstamp")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset SystemModstamp { get; set; }

    }
}
