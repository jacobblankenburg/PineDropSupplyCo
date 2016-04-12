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
    public class ContactShare
    {
        [Key]
        [Display(Name = "Contact Share ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Contact ID")]
        [Createable(false), Updateable(false)]
        public string ContactId { get; set; }

        [Display(Name = "User/Group ID")]
        [Createable(false), Updateable(false)]
        public string UserOrGroupId { get; set; }

        [Display(Name = "Contact Access")]
        [Createable(false), Updateable(false)]
        public string ContactAccessLevel { get; set; }

        [Display(Name = "Row Cause")]
        [Createable(false), Updateable(false)]
        public string RowCause { get; set; }

        [Display(Name = "Last Modified Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset LastModifiedDate { get; set; }

        [Display(Name = "Last Modified By ID")]
        [Createable(false), Updateable(false)]
        public string LastModifiedById { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

    }
}
