
class Program
{
    static void Main()
    {
        string input = "aabbccdeeffg";
        char result = Method.FindFirstNonRepeatedCharacter(input);

        Console.WriteLine("First non-repeated character: " + result);
    }


}

public static class Method {

    public static char FindFirstNonRepeatedCharacter(string str)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach (char c in str)
        {
            if (charCount[c] == 1)
            {
                return c;
            }
        }

        return default(char);
    }
}
