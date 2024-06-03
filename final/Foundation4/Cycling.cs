public class Cycling:Activity { 


    private int _speed; 
    private int _pace;

    public Cycling(string name, int speed): base(name) { 
        _name = name; 
        _speed = speed;
    }

    public override int CaculatePace()
    {
        _pace = (60) / (_speed);
        return _pace; 
    }

    public override string GetSummary()
    {
        return ($"{_date.ToString("dd")} {_date.ToString("MMM")} {_date.ToString("yyyy")} {_name} - Speed: {_speed} kph - Pace: {CaculatePace()} hpkm");
    }
}