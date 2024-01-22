namespace CSharpProblemSolving;

public class NonRepeatTest
{
    [Fact]
    public void TestFindFirstNonRepeatedCharacter()
    {
        // Arrange
        string input1 = "aabbccdeeffg";
        string input2 = "hello world";
        string input3 = "abcabc";

        // Act
        char result1 = Method.FindFirstNonRepeatedCharacter(input1);
        char result2 = Method.FindFirstNonRepeatedCharacter(input2);
        char result3 = Method.FindFirstNonRepeatedCharacter(input3);

        //    // Assert
        Assert.Equal('d', result1);
        Assert.Equal('h', result2);
        Assert.Equal('\0', result3);
    }

    [Fact]
    public void TestFindFirstNonRepeatedCharacter_EmptyString()
    {
        // Arrange
        string input = "";

        // Act
        char result = Method.FindFirstNonRepeatedCharacter(input);

        // Assert
        Assert.Equal(default(char), result);
    }

    [Fact]
    public void TestFindFirstNonRepeatedCharacter_AllRepeated()
    {
        // Arrange
        string input = "aabbcc";

        // Act
        char result = Method.FindFirstNonRepeatedCharacter(input);

        // Assert
        Assert.Equal(default(char), result);
    }
}
