using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CetBookStore.Models
{
    public class Comment
    {
        public int Id{ get; set; }

        [Display(Name = "Başlık")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Başlık Alanı 3 ile 100 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]


        public string Title { get; set; }
        [Display(Name = "Detaylar")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Detay alanı 3 ile 500 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]

        public string Detail { get; set; }
        [Display(Name = "Puan")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]

        public int? Rating { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Yorumun Yapıldığı Kitap")]
        public int BookId { get; set; }
        [Display(Name = "Yorumun Yapıldığı Kitap")]
        public Book Book { get; set; }
    }
}
