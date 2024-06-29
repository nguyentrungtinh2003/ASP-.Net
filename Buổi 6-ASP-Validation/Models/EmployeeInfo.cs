using System.ComponentModel.DataAnnotations;

namespace Buổi_6_ASP_Validation.Models
{
    public class EmployeeInfo
    {
        [Required(ErrorMessage = "*")]
        [MinLength(5, ErrorMessage = "Tối thiểu 5 ký tự !")]
        public string FullName { get; set; }

        [Range(18, 65, ErrorMessage = "Tối thiểu từ 18 - 65 tuổi !")]
        public int Age { get; set; }
    }
}
