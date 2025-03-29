public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer { get; set; }

    public Order(Customer customer, List<Product> products) {
        _customer = customer;
        _products = products;
    }

    public float TotalCost() {
        float total = 0;
        foreach (Product product in _products) {
            total += product.TotalCost();
        }
        return total;
    }

    public float GetShippingCost() {
        if (_customer.GetAddress().IsUSA()) {
            return 5;
        } else {
            return 35;
        }
    }
    public string GetPackingLabel() {
        string result = "";
        foreach (Product product in _products) {
            result += product.GetProductId() + ":" + " " + product.GetName() + "\n";
        }
        return result;
    }

    public string GetShippingLabel() {
        return _customer.GetName() + "\n" + _customer.GetFullAddress();
    }
}