using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrialWebApp.DataBase
{
    [Table("Tbl_Kullanicilar")]
    public class Kullanici
    {
        [Key]
        [Column("kullaniciId")]
        public int? id { get; set; }
        [Column("kullaniciKullaniciAdi")]
        public String? kullaniciAdi { get; set; }
        [Column("kullaniciSifre")]
        public String? sifre { get; set; }
        [Column("kullaniciMail")]
        public String? mail { get; set; }
        [Column("kullaniciAdSoyad")]
        public String? adSoyad { get; set; }
        public Boolean? kullaniciTipi { get; set; }
        [Column("kullaniciAvatar")]
        public String? avatar { get; set; }
    }
}