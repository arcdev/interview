public interface IDataStore
{
    bool Save(object obj);
    bool GetProductCount(int productId);
}