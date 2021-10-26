using System.ComponentModel.DataAnnotations;


namespace Web.Models
{
    // Эта модель описывает ответ пользователя, то есть содержит данные формы
    public class GuestResponse
    {
        // Атрибуты описывают требования к полям

        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string Name { get; set; }

        // например, валидный email задан регулярным выражением
        [Required(ErrorMessage = "Пожалуйста, введите email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, укажите, примите ли участие в вечеринке")]
        public bool? WillAttend { get; set; }
    }
}
