using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Companion.Models
{
    public class SUModel
    {
        [Display(Name = "Логин")]
        public string login { get; set; }


        [Display(Name = "Пароль")]
        public string password { get; set; }


        [Display(Name = "Имя")]
        public string name { get; set; }


        [Display(Name = "Город")]
        public string city { get; set; }
    }
}
