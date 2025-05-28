namespace WebApplication2.Dtos;

public class DiscountRequest
{
    public string MembershipStatus { get; set; }
    public string ProductType { get; set; }
    public decimal ProductPrice { get; set; }
}