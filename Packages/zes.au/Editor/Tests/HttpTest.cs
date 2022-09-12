using Au.Net;
using NUnit.Framework;

public class HttpTest
{
    [Test]
    public async void GetRequestSucc()
    {
        var conn = new HttpConnector("http://www.baidu.com");
        var text = await conn.Get("/more");
        Assert.IsFalse(text.Failed);
    }
    [Test]
    public async void GetRequestFailed()
    {
        var conn = new HttpConnector("http://www.baidu.com.obj/");
        var text = await conn.Get("/more");
        Assert.IsTrue(text.Failed);
    }

    [Test]
    public async void GetRequest404()
    {
        var conn = new HttpConnector("http://www.baidu.com");
        var text = await conn.Get("/test");
        Assert.AreEqual(text.error, 404);
    }

    [Test]
    public async void PostRequestSucc()
    {
        var conn = new HttpConnector("http://www.baidu.com/");
        var text = await conn.Post("/more", "");
        Assert.IsFalse(text.Failed);
    }

}
