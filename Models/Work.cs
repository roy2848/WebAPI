using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Work
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string EQPID { get; set; }
        [Required]
        public List<File> FILES { get; set; }
    }

    public class File
    {
        [Key]
        public int FID { get; set; }
        [Required]
        public string FileSN { get; set; }
        [Required]
        public string FileOrder { get; set; }
        [Required]
        public string ModelName { get; set; }
        public int WorkID { get; set; }
    }
}
