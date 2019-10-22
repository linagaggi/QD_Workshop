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
    }
}
