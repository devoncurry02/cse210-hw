public class Square : Shape {
    private double _side;
    public Square(string squareColor, double sideLength) : base(squareColor) {
        _side = sideLength;
    }

    public override double GetArea() {
        return _side * _side;
    }
}