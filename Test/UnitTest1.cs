namespace Test;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int number1 = 99;
        int number2 = 89;

        Assert.Equal(99,Program.Max2(number1,number2));
    }

}