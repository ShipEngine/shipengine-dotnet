using ShipEngineSDK;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ShipEngineTest
{
    public class MultimapTests
    {
        public class AddWithKeyAndValue
        {
            [Fact]
            public void ShouldAddNewEntry_WhenKeyDoesNotExist()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", "a");

                Assert.Single(map["foo"]);
                Assert.Contains("a", map["foo"]);
            }

            [Fact]
            public void ShouldUpdateExistingEntry_WhenEntryAlreadyExists()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", "a");
                map.Add("foo", "b");

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldAddNewEntry_WhenKeysAreDifferent()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", "a");
                map.Add("bar", "b");

                Assert.Single(map["foo"]);
                Assert.Contains("a", map["foo"]);
                Assert.Single(map["bar"]);
                Assert.Contains("b", map["bar"]);
            }

            [Fact]
            public void ShouldNotAddEntry_WhenValueIsNull()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", (string)null);
                Assert.Empty(map);
            }
        }

        public class AddWithKeyAndList
        {
            [Fact]
            public void ShouldAddNewEntry_WhenKeyDoesNotExist()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", new List<string> { "a", "b" });

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldUpdateExistingEntry_WhenEntryAlreadyExists()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", new List<string> { "a" });
                map.Add("foo", new List<string> { "b" });

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldAddNewEntry_WhenKeysAreDifferent()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", new List<string> { "a" });
                map.Add("bar", new List<string> { "b" });

                Assert.Single(map["foo"]);
                Assert.Contains("a", map["foo"]);
                Assert.Single(map["bar"]);
                Assert.Contains("b", map["bar"]);
            }

            [Fact]
            public void ShouldNotAddEntry_WhenValueIsEmpty()
            {
                var map = new Multimap<string, string>();
                map.Add("foo", Enumerable.Empty<string>().ToList());
                Assert.Empty(map);
            }
        }

        public class AddWithKeyValuePair
        {
            [Fact]
            public void ShouldAddNewEntry_WhenKeyDoesNotExist()
            {
                var map = new Multimap<string, string>();
                map.Add(new KeyValuePair<string, IList<string>>("foo", new List<string> { "a", "b" }));

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldUpdateExistingEntry_WhenEntryAlreadyExists()
            {
                var map = new Multimap<string, string>();
                map.Add(new KeyValuePair<string, IList<string>>("foo", new List<string> { "a" }));
                map.Add(new KeyValuePair<string, IList<string>>("foo", new List<string> { "b" }));

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldAddNewEntry_WhenKeysAreDifferent()
            {
                var map = new Multimap<string, string>();
                map.Add(new KeyValuePair<string, IList<string>>("foo", new List<string> { "a" }));
                map.Add(new KeyValuePair<string, IList<string>>("bar", new List<string> { "b" }));

                Assert.Single(map["foo"]);
                Assert.Contains("a", map["foo"]);
                Assert.Single(map["bar"]);
                Assert.Contains("b", map["bar"]);
            }
        }

        public class AddWithMultimap
        {
            [Fact]
            public void ShouldAddNewEntry_WhenKeyDoesNotExist()
            {
                var map = new Multimap<string, string>();
                map.Add(new Multimap<string, string> { { "foo", new List<string> { "a", "b" } } });

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldUpdateExistingEntry_WhenEntryAlreadyExists()
            {
                var map = new Multimap<string, string>();
                map.Add(new Multimap<string, string> { { "foo", new List<string> { "a" } } });
                map.Add(new Multimap<string, string> { { "foo", new List<string> { "b" } } });

                Assert.Equal(2, map["foo"].Count);
                Assert.Contains("a", map["foo"]);
                Assert.Contains("b", map["foo"]);
            }

            [Fact]
            public void ShouldAddNewEntry_WhenKeysAreDifferent()
            {
                var map = new Multimap<string, string>();
                map.Add(new Multimap<string, string> { { "foo", new List<string> { "a" } } });
                map.Add(new Multimap<string, string> { { "bar", new List<string> { "b" } } });

                Assert.Single(map["foo"]);
                Assert.Contains("a", map["foo"]);
                Assert.Single(map["bar"]);
                Assert.Contains("b", map["bar"]);
            }
        }
    }
}