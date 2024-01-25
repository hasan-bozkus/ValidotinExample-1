using System.ComponentModel.DataAnnotations;

namespace ValidotinExample_1.Models
{
    public class Complaint
    {
        [Display(Name = "Kimlik No")]
        public int Id { get; set; }

        [WordCountValidation(ErrorMessage = "Şikayetiniz ne fazla 250 kelime olabilir.", MaxWordCount = 25)]
        [Display(Name = "Şikayet Metni")]
        public string ComplaintText { get; set; }
    }
}
