using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScholarshipProgramProject.Models
{
    public class Student
    {
        [Key]
        [DisplayName("National ID")]
        public string National_id { get; set; }
        [DisplayName("First Name")]
        public string First_name { get; set; }
        [DisplayName("Last Name")]
        public string Last_name { get; set; }
        [DisplayName("Email")]
        public string Email_address { get; set; }
        [DisplayName("Password")]
        public string Login_password { get; set; }
        [DisplayName("Birth Date")]
        public DateTime Birth_date { get; set; }
        [DisplayName("University")]
        public string University_name { get; set; }
        [DisplayName("Major")]
        public string Major_name { get; set; }
        [DisplayName("GPA")]
        [Column(TypeName = "Decimal(4,2)")]
        public double Gpa { get; set; }
        [DisplayName("Resume")]
        public byte[]? Resume_file { get; set; }
    }
}
