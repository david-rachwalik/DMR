using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DMR.WebApp.Services;

namespace DMR.WebApp.Models
{
    public abstract class Asset : IAuditService
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Display name cannot be longer than 50 characters.")]
        [Display(Name = "Display Name")]
        public string Title { get; set; }
        public string? Description { get; set; }
        [Display(Name = "Token")]
        public Guid Who { get; set; }
        public char What { get; set; }
        public DateTime When { get; set; }
        public Stage Stage { get; set; }
    }


    // Amended vs Emendated: https://writingexplained.org/amend-vs-emend-difference
    //   - Amended because the whole asset could change for the better, not just fixing typos
    public enum Stage
    {
        Archived = -1,
        Template,
        Draft,
        Submitted,
        Amended,
        Approved,
        Live
    }
}
