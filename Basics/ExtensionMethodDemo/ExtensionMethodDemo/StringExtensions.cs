using System.Text;

namespace ExtensionMethodDemo
{
    public static class StringExtensions
    {
        public static string ToProper(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            var result = new StringBuilder();
            result.Append(char.ToUpper(text[0]));

            for (int i = 1; i < text.Length; i++)
            {
                var previousCharacter = text[i - 1];
                var currentCharacter = text[i];
                if (char.IsWhiteSpace(previousCharacter))
                    currentCharacter = char.ToUpper(currentCharacter);
                else
                    currentCharacter = char.ToLower(currentCharacter);
                result.Append(currentCharacter);
            }

            return result.ToString();
        }
    }
}
