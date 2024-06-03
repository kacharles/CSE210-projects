public class Swimming:Activity { 

    private int _distance;
    private int _length; 
    private int _swimLaps;


    public Swimming(string name, int swimLap):base(name) { 
        _name = name;
        _swimLaps = swimLap;
        _length = 50;
    }

    public override int CaculateDistance()
    {
        _distance = _swimLaps * _length / 1000;
        return _distance;
    }

    public override string GetSummary()
    {
        return ($"{_date.ToString("dd")} {_date.ToString("MMM")} {_date.ToString("yyyy")} {_name} - Laps: {_swimLaps} - Length: {_length} km - Distance: {CaculateDistance()} km");
    }

}