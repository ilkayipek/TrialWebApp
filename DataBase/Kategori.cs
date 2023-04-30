using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrialWebApp.DataBase
{
    [Table("Tbl_Kategoriler")]
    public class Kategori
    {
        [Key]
        public int? kategoriId { get; set; }
        public String? kategoriAd { get; set; }
        public int? kategoriAdet { get; set; }
        public String? kategoriResim { get; set; }
    }
}