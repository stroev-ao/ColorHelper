namespace ColorHelper
{
    public static class CStringExtension
    {
        public static string[] Split(this string text, int value)
        {
            int count = text.Length / value;
            if (text.Length % value != 0)
                count++;

            string[] result = new string[count];

            for (int i = 0; i < count; i++)
                result[i] = text.Substring(i * value, value);

            return result;
        }
    }
}
