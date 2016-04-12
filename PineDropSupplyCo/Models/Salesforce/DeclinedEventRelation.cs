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
    public class DeclinedEventRelation
    {
        [Key]
        [Display(Name = "Event Relation ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Relation ID")]
        [Createable(false), Updateable(false)]
        public string RelationId { get; set; }

        [Display(Name = "Event ID")]
        [Createable(false), Updateable(false)]
        public string EventId { get; set; }

        [Display(Name = "Response Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? RespondedDate { get; set; }

        [StringLength(255)]
        [Createable(false), Updateable(false)]
        public string Response { get; set; }

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

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [StringLength(50)]
        [Createable(false), Updateable(false)]
        public string Type { get; set; }

    }
}
