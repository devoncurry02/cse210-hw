class Swimming : Sport {
    private decimal _laps;

    public Swimming(string date, decimal length, decimal laps) : base(date, length) {
        _laps = laps;
    }
    public override decimal Distance() {
        return _laps * 50 / 1000 * 0.62m;
    }
    public override decimal Speed() {
        return Distance() / Length() * 60;
    }
    public override decimal Pace() {
        return Length() / Distance();
    }
    public override string Summary() {
        return $"{Date()} Running ({Length()} min)- Distance {Distance()} miles, Speed {Speed()} mph, Pace: {Pace()} min per mile";
    }
}