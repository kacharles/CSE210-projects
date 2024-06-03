public class Running:Activity {
    private int _speed; 
    private int _distance; 
    private int _pace; 
    private int _duration;

    

    public Running(string name, int distance, int duration):base(name) {
        _name = name; 
        _distance = distance;
        _duration = duration;
        
    }

    public override int CaculatePace()
    {
        _pace = _duration/_distance;
        return _pace;
    }
    public override int CaculateSpeed()
    {
        _speed = _distance/_duration * 60;
        return _speed;
    }

    public override string GetSummary() { 
        return ($"{_date.ToString("dd")} {_date.ToString("MMM")} {_date.ToString("yyyy")} {_name} - ({_duration} min) - Distance {_distance} km - Speed: {CaculateSpeed()} kph - Pace: {CaculatePace()} mpkm"); 
    }


}

