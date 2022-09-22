namespace Contracts.Discount
{
    public class DiscountResponseDto
    {
        public double TotalPrice { get; set; }

        public ICollection<DiscountProductResponseDto>? Products { get; set; }
    }
}
