using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidKinder.Models.Entities
{
    public class SendMessageViewModel
    {
        [Required (ErrorMessage ="Lütfen ad alanını boş geçmeyin")]
        [StringLength(30,ErrorMessage ="Lütfen en fazla 30 karakter olacak şekilde giriniz.")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Lütfen ad alanını boş geçmeyin")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karakter olacak şekilde giriniz.")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir mail adresi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen ad alanını boş geçmeyin")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karakter olacak şekilde giriniz.")]
        [MinLength(5,ErrorMessage = "Lütfen 5 karakterden uzun bir metin giriniz")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Lütfen ad alanını boş geçmeyin")]
        [StringLength(30, ErrorMessage = "Lütfen en fazla 30 karakter olacak şekilde giriniz.")]
        public string Message { get; set; }
    }
}