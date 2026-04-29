public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        if (operation == "/"){
            if (operand2 > 0){
                return $"{operand1} / {operand2} = {operand1/operand2}";
            }else{
                return "Division by zero is not allowed.";
            }
            
        }else{
        int result = (operation == "+") ? operand1 + operand2 : (operation == "*") ? operand1 * operand2 : (operation == "")? throw new ArgumentException(): (operation == null) ? throw new ArgumentNullException() : throw new ArgumentOutOfRangeException()  ;
        return $"{operand1} {operation} {operand2} = {result}";
        }

    }
}
