using NUnit.Framework;

namespace StringConcatBenchmark
{
    public class Tests
    {
        private TestHarness _tests;

        [SetUp]
        public void Setup()
        {
            _tests = new TestHarness();
        }

        [Test]
        public void StringPlus()
        {
            var result = _tests.StringPlus();
            Assert.AreEqual(result, SampleData.Result);
        }

        [Test]
        public void StringPlusEquals()
        {
            var result = _tests.StringPlusEquals();
            Assert.AreEqual(result, SampleData.Result);
        }

        [Test]
        public void StringInterpolation()
        {
            var result = _tests.StringInterpolation();
            Assert.AreEqual(result, SampleData.Result);
        }

        [Test]
        public void StringFormat()
        {
            var result = _tests.StringFormat();
            Assert.AreEqual(result, SampleData.Result);
        }

        [Test]
        public void StringConcat()
        {
            var result = _tests.StringConcat();
            Assert.AreEqual(result, SampleData.Result);
        }

        [Test]
        public void StringJoin()
        {
            var result = _tests.StringJoin();
            Assert.AreEqual(result, SampleData.Result);
        }

        [Test]
        public void StringBuilder()
        {
            var result = _tests.StringBuilder();
            Assert.AreEqual(result, SampleData.Result);
        }
    }
}