using Au;
using NUnit.Framework;
using UnityEngine;

public class TagsTest
{
    [Test]
    public void TestGet()
    {
        var go = new GameObject("TagsTest");
        var tags = go.AddComponent<Tags>();
        tags.items = new Tag[]
        {
            new Tag{ name="111", target = go },
        };

        Assert.IsNotNull(tags.Get("111"));
        Assert.IsNull(tags.Get("222"));
    }
}
