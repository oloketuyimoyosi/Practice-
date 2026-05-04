public struct CurrencyAmount: IComparable<CurrencyAmount>
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }
    public int CompareTo(CurrencyAmount o){
        if (o.currency == this.currency){
            if (this.amount > o.amount){
                return 1;
            }
            if (this.amount < o.amount){
                return -1;
            }
            return 0;
        
        }else{
            throw new ArgumentException("Bobo fix this program");
        }
        
    }

    
    public static bool operator == (CurrencyAmount amount_1, CurrencyAmount amount_2) => amount_1.CompareTo(amount_2) == 0;
    public static bool operator != (CurrencyAmount amount_1, CurrencyAmount amount_2) => amount_1.CompareTo(amount_2) != 0;



    public static bool operator > (CurrencyAmount amount_1, CurrencyAmount amount_2) => amount_1.CompareTo(amount_2) > 0;
    public static bool operator < (CurrencyAmount amount_1, CurrencyAmount amount_2) => amount_1.CompareTo(amount_2) < 0;
    public static CurrencyAmount operator + (CurrencyAmount amount_1, CurrencyAmount amount_2){
        if (amount_1.currency == amount_2.currency){
            return new CurrencyAmount (amount_1.amount + amount_2.amount, amount_1.currency);
        }else{
            throw new ArgumentException("Bobo fix this program");
        }
    }
    public static CurrencyAmount operator - (CurrencyAmount amount_1, CurrencyAmount amount_2){
        if (amount_1.currency == amount_2.currency){
            return new CurrencyAmount (amount_1.amount - amount_2.amount, amount_1.currency);
        }else{
            throw new ArgumentException("Bobo fix this program");
        }
    }
    public static CurrencyAmount operator * (CurrencyAmount amount_1, decimal operand)=> new CurrencyAmount(amount_1.amount * operand, amount_1.currency);
    public static CurrencyAmount operator * (decimal operand, CurrencyAmount amount_1)=> new CurrencyAmount(amount_1.amount * operand, amount_1.currency);
    public static CurrencyAmount operator / (CurrencyAmount amount_1, decimal operand)=> new CurrencyAmount(amount_1.amount / operand, amount_1.currency);
    // TODO: implement comparison operators
    public static explicit operator double (CurrencyAmount amount_1) => (double)amount_1.amount;
    // TODO: implement arithmetic operators
    public static implicit operator decimal (CurrencyAmount amount_1) => (decimal)amount_1.amount;
    // TODO: implement type conversion operators
}
