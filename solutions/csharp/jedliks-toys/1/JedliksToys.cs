class RemoteControlCar
{
    int meters = 0;
    int percentage = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();
    public string DistanceDisplay() => $"Driven {meters} meters";

    public string BatteryDisplay() {
        if (percentage>0){
        return $"Battery at {percentage}%";
        }else{
            return "Battery empty";
        }
    }

    public void Drive()
    {
        meters = (percentage >0)? meters + 20:meters;;
        percentage = (percentage >0)? percentage - 1:0;
        
    }
}
