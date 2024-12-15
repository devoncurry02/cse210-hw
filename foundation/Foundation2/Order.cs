class Order {
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer) {
        this._products = new List<Product>();
        this._customer = customer;
    }

    public void AddProduct(Product product) {
        _products.Add(product);
    }

    public decimal CalculatePrice() {
        decimal totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetCost();
        }

        decimal shippingCost = _customer.IsInUSA() ? 5m : 35m;

        return totalCost + shippingCost;
    }

    public string PackingLabel() {
        string label = "Packing Label:\n";
        foreach (var product in _products) {
            label += $"{product.GetName()}\n";
        }
        return label;
    }
    public string ShippingLabel() {
        string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}\n";
        return label;
    }
}