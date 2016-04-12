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
    public class FeedComment
    {
        [Key]
        [Display(Name = "Feed Comment ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Feed Item ID")]
        [Updateable(false)]
        public string FeedItemId { get; set; }

        [Display(Name = "Parent ID")]
        [Createable(false), Updateable(false)]
        public string ParentId { get; set; }

        [Display(Name = "Created By ID")]
        [Updateable(false)]
        public string CreatedById { get; set; }

        [Display(Name = "Created Date")]
        [Updateable(false)]
        public DateTimeOffset CreatedDate { get; set; }

        [Display(Name = "Comment Body")]
        public string CommentBody { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "InsertedBy ID")]
        [Createable(false), Updateable(false)]
        public string InsertedById { get; set; }

        [Display(Name = "Comment Type")]
        [Updateable(false)]
        public string CommentType { get; set; }

        [Display(Name = "Related Record ID")]
        [Updateable(false)]
        public string RelatedRecordId { get; set; }

    }
}
