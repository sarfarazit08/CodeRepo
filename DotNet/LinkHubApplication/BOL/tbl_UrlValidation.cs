using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class tbl_UrlValidation
    {
        [Required]
        public string UrlTitle { get; set; }
        [Required]
        [Url]
        [UniqueUrl]
        public string Url { get; set; }
        [Required]
        public string UrlDesc { get; set; }
    }

    [MetadataType(typeof(tbl_UrlValidation))]
    public partial class tbl_Url
    {
    }

    public class UniqueUrlAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            LinkHubDbEntities db = new LinkHubDbEntities();
            string urlValue = (value == null ? "" : value.ToString());
            int count = db.tbl_Url.Where(x => x.Url == urlValue).ToList().Count();
            if (count != 0)
                return new ValidationResult("Url already exists.");
            return ValidationResult.Success;
        }
    }
}
