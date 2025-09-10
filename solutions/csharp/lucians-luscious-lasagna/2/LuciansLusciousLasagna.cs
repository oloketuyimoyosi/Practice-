class Lasagna
{

    public int ExpectedMinutesInOven()=> 40;
    public int RemainingMinutesInOven(int remaining_time)=> 40 - remaining_time;

        
    public int PreparationTimeInMinutes(int layers)=> layers * 2;
    public int ElapsedTimeInMinutes(int layers, int minutes)=>layers * 2+ minutes;
        
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
