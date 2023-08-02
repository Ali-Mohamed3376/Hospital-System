using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BL.ViewModels.Doctors
{
    public class DoctorAddVM
    {
        [Required(ErrorMessage = "{0} Is Required!!!")]
        [MaxLength(25, ErrorMessage ="Take Care! Your {0} MaxLenth is 20 character.")]
        [MinLength(5, ErrorMessage ="Take Care! Your {0} MinLenth is 5 character.")]
        [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "Please Enter a Valid {0}.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} Is Required!!!")]
        [MaxLength(55, ErrorMessage = "Take Care! Your {0} MaxLenth is 50 character.")]
        [MinLength(5, ErrorMessage = "Take Care! Your {0} MinLenth is 5 character.")]
        public string Specialization { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} Is Required!!!")]
        //[MaxLength(6, ErrorMessage = "Take Care! Your {0} MaxLenth is 5 Numbers.")]
        //[MinLength(4, ErrorMessage = "Take Care! Your {0} MinLenth is 5 Numbers.")]
        [Range(5000, 10000, ErrorMessage = "{0} Must Be In [{1}, {2}].")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "{0} Is Required!!!")]
        //[MaxLength(4, ErrorMessage = "Take Care! Your {0} MaxLenth is 3 Number.")]
        //[MinLength(1, ErrorMessage = "Take Care! Your {0} MinLenth is 1 Number.")]
        [RegularExpression("^(100(\\.0+)?|[1-9]?\\d(\\.\\d+)?)$", ErrorMessage = "Please Enter a Valid {0} Rate [0% : 100%].")]
        public int PerofrmancRate { get; set; }
    }
}
