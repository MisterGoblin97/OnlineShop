namespace ShopOnline.Models.Dtos;

public class CartItemDto
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int Qty { get; set; }
    public int ProductName { get; set; }
    public string ProductDescription{ get; set; }
}
