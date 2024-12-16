class Biking : Sport {
    private decimal _speed;

    public Biking(string date, decimal length, decimal speed) : base(date, length) {
        _speed = speed;
    }
    public override decimal Distance() {
        return _speed / 60 * Length();
    }
    public override decimal Speed() {
        return _speed;
    }
    public override decimal Pace() {
        return 60 / _speed;
    }
    public override string Summary() {
        return $"{Date()} Running ({Length()} min)- Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
    }
}