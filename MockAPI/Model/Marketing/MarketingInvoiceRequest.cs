namespace MockAPI.Model.Marketing
{
    public class MarketingInvoiceRequest
    {
        public long InvoiceId { get; set; }
        public int UserId { get; set; }
        public InvoiceState InvoiceState { get; set; }
        public DateTime? ShopDateTime { get; set; }

        public override string ToString()
        {
            return $"{nameof(InvoiceId)}: {InvoiceId}, {nameof(UserId)}: {UserId}, {nameof(InvoiceState)}: {InvoiceState}, {nameof(ShopDateTime)}: {ShopDateTime}";
        }
    }
}
