using Contracts.Discount;
using Microsoft.AspNetCore.Mvc;
using MockAPI.Model.Marketing;
using MockAPI.Model.Product;

namespace MockAPI.Controllers
{
    [ApiController, Route("/mock/[controller]/[action]")]
    public class DiscountMockController : Controller
    {
        [HttpPost]
        public IActionResult Index(DiscountRequestDto dto)
        {
            var products = new List<DiscountProductResponseDto>();

            foreach (var discountProductRequestDto in dto.Products)
            {
                var productResponseDto = new DiscountProductResponseDto()
                {
                    ProductId = discountProductRequestDto.ProductId,
                    UnitPrice = discountProductRequestDto.UnitPrice * 0.8
                };
                ;
                products.Add(productResponseDto);
            }

            var item = new DiscountResponseDto()
            {
                TotalPrice = 20_000,
                Products = products
            };

            return Ok(item);
        }

        [HttpPost]
        public IActionResult UpdateProductCounting([FromBody] ICollection<ProductUpdateCountingItemRequestDto> dtos)
        {
            Console.WriteLine(dtos);
            return Ok(dtos);
        }

        [HttpPost]
        public IActionResult Marketing([FromBody] ICollection<MarketingInvoiceRequest> requests)
        {
            return Ok(requests);
        }
    }
}
