using NUnit.Framework;
using ShipEngine.Models.JsonRpc;

namespace ShipEngine.Tests
{
    public class JsonRpcModelTest
    {
        public class P
        {
            public string Foo = "foo";
            public P() { }
        };


        [Test]
        public void RequestIdTest()
        {
            var res1 = new JsonRpcRequest<string>("foo/bar", "hello");
            var res2 = new JsonRpcRequest<string>("foo/bar", "hello");
            Assert.That(res1.Id, Is.Not.EquivalentTo(res2.Id));
            Assert.That(res1.Id.StartsWith("req_"), Is.True);
            Assert.That(res1.Id.Length, Is.EqualTo(26));
            Assert.That(res2.Id.Length, Is.EqualTo(26));
        }

    }

}