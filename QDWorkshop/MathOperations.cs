namespace QDWorkshop
{
    public interface IMathOperations
    {
        string Multiply();
       
    }
    public class MathOperations : IMathOperations
    {
       
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Message { get; set; }
        public MathOperations(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public string Multiply()
        {
            return $"x * y = {FirstNumber * SecondNumber}";
        }

        public string Divide()
        {
          
            if (SecondNumber == 0) return $"x / 0 = you are stupid";

            return $"x / y = {System.Convert.ToDouble(FirstNumber) / System.Convert.ToDouble(SecondNumber)}";
        }
    }
}
