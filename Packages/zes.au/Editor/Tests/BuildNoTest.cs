using Au;
using NUnit.Framework;

public class BuildNoTest
{
    [Test]
    public void IncBuildNo()
    {
        int code = BuildNo.Get();
        int newCode = BuildNo.Inc();
        Assert.AreEqual(newCode, code + 1);
    }

}
