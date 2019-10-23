
namespace QDWorkshop
{
    public interface IStringOperations
    {
        string Uppercase(string str);
    }
    public class StringOperations : IStringOperations
    {
        public StringOperations()
        {

        }

        public string Uppercase(string str)
        {
            return str.ToUpper();
        }
    }
}
