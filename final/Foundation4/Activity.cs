public class Activity { 
    protected string _name;
    protected DateTime _date = DateTime.Now;

    public Activity(string name) { 
        _name = name;
        
    
    }

    public virtual string GetSummary() {
        return ""; 
    }
    public virtual int CaculateDistance() {
        return 0;
    } 
    public virtual int CaculateSpeed() { 
        return 0;
    }
    public virtual int CaculatePace() { 
        return 0;
    }
    

}