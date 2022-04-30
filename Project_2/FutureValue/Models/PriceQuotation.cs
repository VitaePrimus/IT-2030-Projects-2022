using System.ComponentModel.DataAnnotations;


namespace Project_2.Models

{
    public class PriceQuotation
    {
        [Required(ErrorMessage = "Please enter subtotal price.")]
        [Range(1, 9999999, ErrorMessage = "Subtotal price amount must be between 1 and 9999999.")]
        public double Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent")]
        [Range(0, 100, ErrorMessage = "Discount percent must be between 0 and 100")]
        public double Discount { get; set; }

        public double CalculateDiscount()
        {
            double discount = Subtotal * (Discount * 0.01);

            return discount;
        }

        public double CalculateTotal()
        {
            double discount = Subtotal * (Discount * 0.01);
            double total = Subtotal - discount;

            return total;
        }

    }
}