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
    public class Case
    {
        [Key]
        [Display(Name = "Case ID")]
        [Createable(false), Updateable(false)]
        public string Id { get; set; }

        [Display(Name = "Deleted")]
        [Createable(false), Updateable(false)]
        public bool IsDeleted { get; set; }

        [Display(Name = "Case Number")]
        [StringLength(30)]
        [Createable(false), Updateable(false)]
        public string CaseNumber { get; set; }

        [Display(Name = "Contact ID")]
        public string ContactId { get; set; }

        [Display(Name = "Account ID")]
        public string AccountId { get; set; }

        [Display(Name = "Asset ID")]
        public string AssetId { get; set; }

        [Display(Name = "Parent Case ID")]
        public string ParentId { get; set; }

        [Display(Name = "Name")]
        [StringLength(80)]
        public string SuppliedName { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress]
        public string SuppliedEmail { get; set; }

        [Display(Name = "Phone")]
        [StringLength(40)]
        public string SuppliedPhone { get; set; }

        [Display(Name = "Company")]
        [StringLength(80)]
        public string SuppliedCompany { get; set; }

        [Display(Name = "Case Type")]
        public string Type { get; set; }

        public string Status { get; set; }

        [Display(Name = "Case Reason")]
        public string Reason { get; set; }

        [Display(Name = "Case Origin")]
        public string Origin { get; set; }

        [StringLength(255)]
        public string Subject { get; set; }

        public string Priority { get; set; }

        public string Description { get; set; }

        [Display(Name = "Closed")]
        [Createable(false), Updateable(false)]
        public bool IsClosed { get; set; }

        [Display(Name = "Closed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? ClosedDate { get; set; }

        [Display(Name = "Escalated")]
        public bool IsEscalated { get; set; }

        [Display(Name = "Owner ID")]
        [Updateable(false)]
        public string OwnerId { get; set; }

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

        [Display(Name = "Last Viewed Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastViewedDate { get; set; }

        [Display(Name = "Last Referenced Date")]
        [Createable(false), Updateable(false)]
        public DateTimeOffset? LastReferencedDate { get; set; }

        [Display(Name = "Engineering Req Number")]
        [StringLength(12)]
        public string EngineeringReqNumber__c { get; set; }

        [Display(Name = "SLA Violation")]
        public string SLAViolation__c { get; set; }

        [Display(Name = "Product")]
        public string Product__c { get; set; }

        [Display(Name = "Potential Liability")]
        public string PotentialLiability__c { get; set; }

    }
}
