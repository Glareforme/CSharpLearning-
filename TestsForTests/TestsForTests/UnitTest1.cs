namespace TestsForTests
{
    public class Tests
    {
        [Test]
        public void Task1()
        {
            var a = "aasdadada23131#$@";
            var b = "aasdadada23131#$@";

            Assert.That(a, Is.EqualTo(b));
        }
        [Test]
        public void Task2()
        {
            var first = new List<string>();
            var second = new List<string>();

            first.Add("dsada");
            second.Add("dsada");

            Assert.That(first, Is.EqualTo(second));
        }
        [Test]
        public void Task3()
        {
            var first = new List<string>();
            var pes = "pes";

            first.Add("dsada");
            first.Add("xzczczsad");
            first.Add("pes");

            Assert.Contains(pes, first);
        }
        [Test]
        public void Task4()
        {
            int a = 10;
            int b = 5;
            Assert.IsTrue(a > b);
        }

    }
}