using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]//確保有輸入東西//
        [MaxLength(30)]
        [DisplayName("類別名稱")]
        public string Name { get; set; }
        [DisplayName("顯示順序")]
        [Range(1,100,ErrorMessage ="輸入範圍需要再1-100之間")]
        public int DisplayOrder { get; set; }   
    }
}
