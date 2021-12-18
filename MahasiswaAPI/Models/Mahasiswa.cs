using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MahasiswaAPI.Models
{
    [Table("Tb_M_Mahasiswa")]
    public class Mahasiswa
    {
        [Key]
        public String Nobp { get; set; }
        public String Nama { get; set; }
        public String Alamat { get; set; }
        public String Nohp { get; set; }
        public Jeniskelamin JenisKelamin { get; set; }
    }
    public enum Jeniskelamin { 
        Pria,
        Wanita
    }
}
