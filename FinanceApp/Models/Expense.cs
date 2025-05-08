using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        //adding validation rules using data annotations are attributes set to each property so we can restrict data user can input 
        public int Id { get; set; }
        //description required
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range (0.01, double.MaxValue, ErrorMessage = "Amount needs to be higher than 0 ")]
        public double Amount { get; set; }
        [Required]
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now; //curr date


    }
}
