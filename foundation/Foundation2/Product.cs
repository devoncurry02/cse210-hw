class Product {
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity) {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public decimal GetCost() {
        return _price * _quantity;
    }

    public string GetName() {
        return _name;
    }

    public int GetProductId() {
        return _productId;
    }
}