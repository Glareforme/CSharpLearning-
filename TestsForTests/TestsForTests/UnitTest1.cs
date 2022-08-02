namespace TestsForTests
{
    public class Tests
    {
        [Test]
        public void Task1()
        {
            string a = "aasdadada23131#$@";
            string b = "aasdadada23131#$@";

            Assert.That(a, Is.EqualTo(b));
        }
        [Test]
        public void Task2()
        {
            List <string> first = new List<string>();
            List <string> second = new List<string>();

            first.Add("dsada");
            second.Add("dsada");

            Assert.That(first, Is.EqualTo(second));
        }
        [Test]
        public void Task3()
        {
            List<string> first = new List<string>();
            string pes = "pes";

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