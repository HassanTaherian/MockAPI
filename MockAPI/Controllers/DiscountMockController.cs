using Contracts.Discount;
using Microsoft.AspNetCore.Mvc;
using MockAPI.Model.Marketing;
using MockAPI.Model.Product;
using MockAPI.Model.Recommendation;

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
            foreach (var productUpdateCountingItemRequestDto in dtos)
            {
                Console.WriteLine(productUpdateCountingItemRequestDto);
            }

            return Ok(dtos);
        }

        [HttpPost]
        public IActionResult Marketing([FromBody] ICollection<MarketingInvoiceRequest> requests)
        {
            foreach (var marketingInvoiceRequest in requests)
            {
                Console.WriteLine(marketingInvoiceRequest);

            }
            return Ok(requests);
        }

        [HttpPost]
        public IActionResult Recommendation([FromBody] ProductRecommendRequestDto requests)
        {
            var list = new List<ProductRecommendResponseDto>();
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                list.Add(new ProductRecommendResponseDto
                {
                    ProductId = random.Next(20, 30)
                });
            }
            return Ok(list);
        }
    }
}
