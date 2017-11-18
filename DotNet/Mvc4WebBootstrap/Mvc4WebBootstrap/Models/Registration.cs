using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mvc4WebBootstrap.Models
{
    public class Registration
    {       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [DisplayName("Employee ID")]
        public int InfyEmployeeID { get; set; }

        [Required]
        [DisplayName("Employee's Name")]
        public string EmployeeName { get; set; }

        [Required]
        [DisplayName("Visitor's Name")]
        public string VisitorName { get; set; }
        

        [Required]        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Visit Date")]
        public DateTime VisitDate { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [DisplayName("Purpose Of Visit")]
        public string PurposeOfVisit { get; set; }
        
        [Required]
        [DisplayName("Relation")]
        public string RelationWithEmployee { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Employee's Contact")]
        public long EmployeePhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Please Enter Correct Email Address")]
        [DisplayName("E-mail")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Registration Date")]
        public DateTime RegisteredDate { get; set; }
    }
}