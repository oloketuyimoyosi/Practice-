class BirdCount
{
    private int[] birdsPerDay;
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[]last_week = new int[]{0,2,5,3,7,8,4};

        return last_week;
        
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1] = birdsPerDay[birdsPerDay.Length-1]+1;
    }

    public bool HasDayWithoutBirds()
    {
        if (birdsPerDay.Contains(0)){
            return true;
        } else{
            return false;
        }
        
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for (int i = 0; i< numberOfDays; i++){
            sum = birdsPerDay[i]+sum;
        }
        return sum;
        
    }

    public int BusyDays()
    {
        int sum_busy = 0;

        foreach (int num in birdsPerDay){
            if (num >= 5){
                sum_busy++;
            }
        }
        return sum_busy;
    }
}
