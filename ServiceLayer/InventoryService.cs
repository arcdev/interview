public class InventoryService
{
    private IDataStore _dataStore;
    public InventoryService(IDataStore dataStore)
    {
        _dataStore = dataStore;
    }

    public int GetProductCount(int productId)
    {
        // does some work to get the actual count of the product
        return _dataStore.GetProductCount(productId);
    }

    private void StoreResponse<T>(T responseObject)
    {
        _dataStore.Save(responseObject);
    }
}