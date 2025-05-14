namespace JP.MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionsTests
{
    [TestMethod]    
    public void ShouldContertDecimalToInt()
    {
        decimal valor = 298.40M;
        var result = valor.ToCents();
        
        Assert.AreEqual(29840, result);
    }
}