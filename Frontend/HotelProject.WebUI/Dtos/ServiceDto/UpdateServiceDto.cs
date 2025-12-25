using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage="Servis ikon linki giriniz.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage="Servis başlığı giriniz.")]
        [StringLength(100, ErrorMessage="Servis başlığı en fazla 100 karakter olabilir.")]

        public string Title { get; set; }

        [Required(ErrorMessage="Servis açıklaması giriniz.")]
        [StringLength(500, ErrorMessage="Servis açıklaması en fazla 500 karakter olabilir.")]

        public string Description { get; set; }
    }
}
