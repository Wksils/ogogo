
Console.WriteLine("Введите число, коэффицент сложения и коэффицент умножения: ");
Console.WriteLine(CalculatFunc.Calculate(double.Parse(Console.ReadLine()!), double.Parse(Console.ReadLine()!), double.Parse(Console.ReadLine()!)))jk;

public interface ICalculation
{
    double Perform(double number);
}
public class Add : ICalculation
{
    private double coefficient;

    public Add( double _coef) => this.Coefficient = _coef;
    
    public double Coefficient {
        get => coefficient; 
        set
        {
            if (value != 0)
            {
                coefficient = value;
            }
        }
    }
    public double Perform(double number)=> number + coefficient;
}
public class Multiply : ICalculation
{
    private double coefficient;

    public Multiply(double coefficient)=>this.coefficient = coefficient;
    public double Coefficient
    {
        get => coefficient;
        set
        {
            if (value != 0)
            {
                coefficient = value;
            }
        }
    }

    public double Perform(double number) => number * coefficient;
}
public class CalculatFunc
{
    public static double Calculate(double number, double num1, double num2)
    {
        Add plus = new Add(num1);
        double result = plus.Perform(number);
        Multiply umnozhenie = new Multiply(num2);
        return result = umnozhenie.Perform(result);
    }
}