using ShipEngineSDK;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xunit;

namespace ShipEngineTest
{
    public class ClientUtilsTests
    {
        public class ParameterToMultiMap
        {
            [Fact]
            public void WithCollectionAndMultiFormat_ShouldReturnCorrectMultimap()
            {
                var collection = new List<string> { "value1", "value2" };
                var expected = new Multimap<string, string> { { "key", "value1" }, { "key", "value2" } };

                var result = ClientUtils.ParameterToMultiMap("multi", "key", collection);

                Assert.Equal(expected, result);
            }


            [Fact]
            public void WithSingleValue_ShouldReturnMultimap()
            {
                var result = ClientUtils.ParameterToMultiMap("", "key", "value");
                Assert.Single(result);
                Assert.Contains("key", result.Keys);
                Assert.Contains("value", result["key"]);
            }

            [Fact]
            public void TestDictionaryWithDefaultFormat()
            {
                var dictionary = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
                var result = ClientUtils.ParameterToMultiMap("", "", dictionary);
                Assert.Equal(dictionary.Count, result.Count);
                foreach (var kvp in dictionary)
                {
                    Assert.Contains(kvp.Key, result.Keys);
                    Assert.Contains(kvp.Value, result[kvp.Key]);
                }
            }

            [Fact]
            public void WithDeepObject_ShouldReturnMultimap()
            {
                var dictionary = new Dictionary<string, string> { { "key1", "value1" }, { "key2", "value2" } };
                var result = ClientUtils.ParameterToMultiMap("deepObject", "obj", dictionary);
                foreach (var kvp in dictionary)
                {
                    var expectedKey = $"obj[{kvp.Key}]";
                    Assert.Contains(expectedKey, result.Keys);
                    Assert.Contains(kvp.Value, result[expectedKey]);
                }
            }

            [Fact]
            public void WithUnsupportedCollectionFormat_ShouldReturnMultimap()
            {
                var collection = new List<string> { "value1", "value2" };
                var result = ClientUtils.ParameterToMultiMap("csv", "key", collection);
                Assert.Single(result);
                Assert.Contains("key", result.Keys);
            }
        }

        public class ParameterToString
        {
            public enum TestEnum
            {
                [EnumMember(Value = "TestValue")]
                WithAttribute,
                WithoutAttribute
            }

            [Fact]
            public void WithDateTime_ShouldReturnIso8601String()
            {
                var dateTime = new DateTime(2020, 1, 1, 12, 0, 0, DateTimeKind.Utc);
                var result = ClientUtils.ParameterToString(dateTime);
                Assert.Equal("2020-01-01T12:00:00.0000000Z", result);
            }

            [Fact]
            public void WithDateTimeOffset_ShouldReturnIso8601String()
            {
                var testDateTimeOffset = new DateTimeOffset(2020, 1, 1, 12, 0, 0, TimeSpan.Zero);
                string result = ClientUtils.ParameterToString(testDateTimeOffset);
                Assert.Equal("2020-01-01T12:00:00.0000000+00:00", result);
            }

            [Theory]
            [InlineData(true, "true")]
            [InlineData(false, "false")]
            public void WithBoolean_ShouldReturnBooleanString(bool value, string expected)
            {
                string result = ClientUtils.ParameterToString(value);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void WithCollectionOfStrings_ShouldReturnCommaSeparatedList()
            {
                var testList = new List<string> { "one", "two", "three" };
                string result = ClientUtils.ParameterToString(testList);
                Assert.Equal("one,two,three", result);
            }

            [Theory]
            [InlineData(TestEnum.WithAttribute, "TestValue")]
            [InlineData(TestEnum.WithoutAttribute, "WithoutAttribute")]
            public void WithEnum_ShouldReturnAttributeOrName(TestEnum value, string expected)
            {
                string result = ClientUtils.ParameterToString(value);
                Assert.Equal(expected, result);
            }

            [Fact]
            public void WithNull_ShouldReturnEmptyString()
            {
                string result = ClientUtils.ParameterToString(null);
                Assert.Empty(result);
            }
        }
    }
}