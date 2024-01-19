using System.ComponentModel.DataAnnotations;

namespace ValidotinExample_1.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Bu alan zorunludur!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [MinLength(2, ErrorMessage = "Adınız en az iki karakter olmalıdır!")]
        [MaxLength(50, ErrorMessage = "Adınız en fazla 50 karakter olmalıdır!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur!")]
        [MinLength(2, ErrorMessage = "Soyadınız en az iki karakter olmalıdır!")]
        [MaxLength(50, ErrorMessage = "Soyadınız en fazla 50 karakter olmalıdır!")]
        public string LastName { get; set; }

        [StringLength(100, ErrorMessage = "Mesleğiniz 100 karakterden fazla olmamalı!")]
        [Display(Name = "Meslek")]
        public string Job { get; set; }

        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Parolalar uyuşmuyor!")]
        [Display(Name = "Parola Tekrarı")]
        public string RePassword { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta giriniz!")]
        [Display(Name = "E-Posta Adresi")]
        public string MailAddress { get; set; }

        [Phone(ErrorMessage = "Geçerli bir telefon numarası giriniz!")]
        [Display(Name = "Telefon Numarası")]
        public string Phone { get; set; }

        [Range(1, 81, ErrorMessage = "Bulunduğunuz şehrin plaka numarasını giriniz!")]
        [Display(Name = "Şehir Id")]
        public int CityId { get; set; }

        [Url(ErrorMessage = "Varsa web adresinizi giriniz.")]
        [Display(Name = "Web Adresi")]
        public string WebAddress { get; set; }
    }
}
