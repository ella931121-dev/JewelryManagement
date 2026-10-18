
using System.ComponentModel.DataAnnotations;

namespace JewelryManagement.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入商品名稱")]
        [Display(Name = "商品名稱")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "請輸入商品分類")]
        [Display(Name = "商品分類")]
        public string Category { get; set; } = string.Empty;

        [Range(0, 1000000, ErrorMessage = "商品價格不可小於0")]
        [Display(Name = "商品價格")]
        public decimal Price { get; set; }

        [Range(0, 100000, ErrorMessage = "庫存不可小於0")]
        [Display(Name = "庫存數量")]
        public int Stock { get; set; }

        [Display(Name = "商品描述")]
        public string? Description { get; set; }
    }
}
