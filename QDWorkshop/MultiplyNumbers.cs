namespace QDWorkshop
{
    public interface IConjoin
    {
        string ConjoinFunc();
    }
    public class Conjoin : IConjoin
    {
        public string FirstNumber { get; set; }
        public string SecondNumber { get; set; }
        public string Message { get; set; }
        public Conjoin(string firstNumber, string secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }

        public string ConjoinFunc()
        {
            return $"x + y = " + FirstNumber + SecondNumber;
        }
    }
}
