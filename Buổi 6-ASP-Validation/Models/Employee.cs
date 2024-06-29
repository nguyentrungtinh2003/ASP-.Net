using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Buổi_6_ASP_Validation.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Display(Name = "Mã nhân viên")]
        public string EmployeeNo { get; set; }
        [Display(Name = "Họ tên")]
        [MinLength(3, ErrorMessage = "Tối thiểu 3 kí tự")]
        [StringLength(100)]
        public string FullName { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [Display(Name = "Website")]
        [Url(ErrorMessage = "URL không hợp lệ")]
        public string Website { get; set; }
        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date, ErrorMessage = "Ngày sinh không hợp lệ")]
        public DateTime BirthDate { get; set; }

         [Display(Name = "Giới tính")]
        public string Gender { get; set; }
        [Display(Name = "Lương")]
        [Range(0, 10000000, ErrorMessage = "Lương không hợp lệ")]
        public double Salary { get; set; }
        [Display(Name = "Bán thời gian")]
        public bool IsPartTime { get; set; }
        [Display(Name = "Địa chỉ")]
        [RegularExpression("[a-zA-Z 0-9]*", ErrorMessage = "Địa chỉ không hợp lệ")]
        public string Address { get; set; }
        [Display(Name = "Điện thoại")]
        [RegularExpression(@"0[37895]\d{8}", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }
        [Display(Name = "Số tài khoản")]
        [CreditCard]
        [DataType(DataType.CreditCard, ErrorMessage = "Tài khoản không hợp lệ")]
        public string? CreditCard { get; set; }
        [Display(Name = "Thông tin thêm")]
        [DataType(DataType.MultilineText, ErrorMessage = "Thông tin không hợp lệ")]
        public string Description { get; set; }

        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Tối thiểu 6 kí tự")]
        public string Password { get; set; }

    }
}
