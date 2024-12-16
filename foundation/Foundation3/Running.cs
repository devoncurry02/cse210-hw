class Running : Sport {
    private decimal _miles;

    public Running(string date, decimal length, decimal miles) : base(date, length) {
        _miles = miles;
    }
    public override decimal Distance() {
        return _miles;
    }
    public override decimal Speed() {
        return _miles / Length() * 60;
    }
    public override decimal Pace() {
        return Length() / _miles;
    }
    public override string Summary() {
        return $"{Date()} Running ({Length()} min)- Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
    }
}