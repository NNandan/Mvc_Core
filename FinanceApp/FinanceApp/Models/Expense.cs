using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range(0, double.MaxValue, ErrorMessage ="Amount needs to be")]
        public double Amount { get; set; }
        [Required]
        public string Category {  get; set; }=null!;
    
        public DateTime date { get; set; } = DateTime.Now;

    }
}
