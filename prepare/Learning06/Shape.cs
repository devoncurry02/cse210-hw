public class Shape {
    private string _color;
    public Shape(string initialColor) {
        _color = initialColor;
    }

    public string GetShapeColor() {
        return _color;
    }
    public void SetShapeColor(string newColor) {
        _color = newColor;
    }

    public virtual double GetArea() {
        return 0;
    }

}