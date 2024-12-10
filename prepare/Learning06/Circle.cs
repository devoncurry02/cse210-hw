public class Circle : Shape {
    private double circleRadius;

    public Circle(string circleColor, double radius) : base(circleColor) {
        circleRadius = radius;
    }

    public override double GetArea() {
        return Math.PI * circleRadius * circleRadius;
    }
}
