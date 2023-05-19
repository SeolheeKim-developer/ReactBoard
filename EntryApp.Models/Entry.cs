using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntryApp.Models
{
    /// <summary>
    /// Base class
    /// </summary>
    public class EntryBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "번호")]
        public long Id { get; set; }

        [Required(ErrorMessage = "이름을 입력하세요.")]
        [MaxLength(255)]
        [Display(Name = "작성자")]
        [Column(TypeName = "NVarChar(255)")]
        public string Name { get; set; }

        [MaxLength(255)]
        [Required(ErrorMessage = "제목을 입력하세요.")]
        [Display(Name = "제목")]
        [Column(TypeName = "NVarChar(255)")]
        public string Title { get; set; }

        [Display(Name = "내용")]
        public string Content { get; set; }

        public DateTime? Created { get; set; }
    }
    /// <summary>
    /// Model Class : Entry model class is mapping with Entries table 
    /// </summary>
    [Table("Entries")]
    public class Entry : EntryBase
    {
    }
}
