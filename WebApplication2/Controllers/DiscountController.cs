namespace WebApplication2.Controllers;
using WebApplication2.Dtos;
using WebApplication2.Models;
using WebApplication2.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/discount")]
public class DiscountController : ControllerBase
{
    private readonly DiscountService _discountService = new();

    [HttpPost("check")]
    public IActionResult CheckDiscount([FromBody] DiscountRequest request)
    {
        var product = new Product { Type = request.ProductType, Price = request.ProductPrice };
        var discountedPrice = _discountService.CalculateDiscount(request.MembershipStatus, product);

        return Ok(new DiscountResponse
        {
            OriginalPrice = product.Price,
            DiscountedPrice = discountedPrice
        });
    }

    [HttpGet("membership/status")]
    public IActionResult GetMembershipStatuses()
        => Ok(new[] { "gold", "silver", "regular" });

    [HttpGet("product/types")]
    public IActionResult GetProductTypes()
        => Ok(new[] { "electronic", "book", "other" });
}