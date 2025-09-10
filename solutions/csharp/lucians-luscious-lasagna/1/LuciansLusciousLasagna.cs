class Lasagna
{

    public int ExpectedMinutesInOven(){
        return 40;
    }

    public int RemainingMinutesInOven(int remaining_time){
        return 40 - remaining_time;
    }
    public int PreparationTimeInMinutes(int layers){
        return layers * 2;
    }
    public int ElapsedTimeInMinutes(int layers, int minutes){
        return layers * 2+ minutes;
    }
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
