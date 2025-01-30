using Laba_9;
namespace FunctionTest;

[TestClass]
public class NaNTest
{
    private const double XMin = 0.12;
    private const double XMax = 1;
    private const double Step = 0.1;

    [TestMethod]
    public void MinNotNan()
    {
        Assert.IsTrue(Function.Calc(XMin) is not Double.NaN);
    }
    
    [TestMethod]
    public void MaxNotNan()
    {
        Assert.IsTrue(Function.Calc(XMax) is not Double.NaN);
    }
    
    [TestMethod]
    public void NotNaNAllRange()
    {
        for (double i = XMin; i <= XMax; i += Step)
        {
            Assert.IsTrue(Function.Calc(1) is not Double.NaN);
        }
    }
}