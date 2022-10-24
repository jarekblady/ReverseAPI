namespace ReverseAPI.Services
{
    public class ReverseService : IReverseService
    {
        public string StringReverse(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
                return value[value.Length - 1] + StringReverse(value.Substring(0, value.Length - 1));
            else
                return null;
        }

    }
}