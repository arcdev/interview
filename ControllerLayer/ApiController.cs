public class ApiController
{
    public int GetProductCount(int productId)
    {
        var service = new ServiceLayer.InventoryService();
        return service.GetProductCount(productId);
    }
}