namespace WebApplication2.Services;
using WebApplication2.Models;

public class DiscountService
{
    public decimal CalculateDiscount(string membership,Product product)
    {
        
        
        if (product.Type == "book")
            return product.Price;
        if (membership == "gold")
            return product.Price * 0.8m; 
        if (product.Type == "electronic" && product.Price > 1000)
            return product.Price * 0.9m; 

        return product.Price;
    }
}