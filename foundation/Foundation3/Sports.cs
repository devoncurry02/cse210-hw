abstract class Sport {
    private string _date;
    private decimal _length;

    public Sport(string date, decimal length) {
        _date = date;
        _length = length;
    }
    public virtual string Summary() {
        return "";
    }

    public string Date() {
        return _date;
    }
    public decimal Length() {
        return _length;
    }
    public abstract decimal Distance();
    public abstract decimal Speed();
    public abstract decimal Pace();


}