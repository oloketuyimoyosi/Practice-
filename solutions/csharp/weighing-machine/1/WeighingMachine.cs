class WeighingMachine
{
    private  double _weight;
    private int _precision;
    private  double _tareadjustment = 5;

    public double Weight {
        get => _weight;
        set{ if (value<0){
            throw new ArgumentOutOfRangeException();
        }else{
            _weight = value  ;
        };}
    }
    // TODO: define the 'Weight' property
    public WeighingMachine(int precision){
        _precision = precision;
    }
    public int Precision {
        get => _precision;
    }
    public string display_weight {get => (_weight - _tareadjustment).ToString($"F{_precision}");}
    public double TareAdjustment{
        set => _tareadjustment = value;

    }
    // TODO: define the 'TareAdjustment' property
    public string DisplayWeight{
        get => $"{display_weight} kg";
    }
    // TODO: define the 'DisplayWeight' property
}
