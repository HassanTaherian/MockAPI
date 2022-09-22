namespace MockAPI.Model.Product
{
    public class ProductUpdateCountingItemRequestDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public ProductCountingState ProductCountingState { get; set; }

        public override string ToString()
        {
            return $"{nameof(ProductId)}: {ProductId}, {nameof(Quantity)}: {Quantity}, {nameof(ProductCountingState)}: {ProductCountingState}";
        }
    }
}
