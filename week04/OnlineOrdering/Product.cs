public class Product
{
    private string _name;
    private int _product_id;
    private float _product_price;
    private int _quantity;

    public Product(string name, int product_id, float product_price, int quantity)
    {
        _name = name;
        _product_id = product_id;
        _product_price = product_price;
        _quantity = quantity;
    }
    
    public float TotalCost()
    {
        return _product_price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId() {
        return _product_id;
    }
}