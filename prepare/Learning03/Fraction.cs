public class Fraction {
    private int _top;
    private int _bottom;

    public Fraction() {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int num) {
        _top = num;
        _bottom = 1;
    }
    public Fraction(int num, int bot) {
        _top = num;
        _top = bot;
    }

    public int GetTop() {
        return _top;
    }
    public int GetBottom() {
        return _bottom;
    }

    public void SetTop(int top) {
        _top = top;
    }
    public void SetBottom(int bot) {
        _bottom = bot;
    }

    public string GetFractionString() {
        return $"{_top}/{_bottom}";
    }
    public double GetDecimalValue() {
        return (double)_top/_bottom;
    }
};