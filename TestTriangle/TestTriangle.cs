using OOP_lab1_1;
namespace TestTriangle
{
    public class Tests
    {
        [Test]
        public void FindDistance_2_0and5_0and3_3_returned3()
        {
            int[] a = { 2, 0 };
            int[] b = { 5, 0 };
            int[] c = { 3, 3 };
            double expected = 3;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.FindDistance(a, b);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Perimeter_0_0and0_4and3_0_returned6()
        {
            int[] a = { 0, 0 };
            int[] b = { 0, 4 };
            int[] c = { 3, 0 };
            double expected = 12;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.Perimeter();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Area_0_0and0_4and3_0_returned6()
        {
            int[] a = { 0, 0 };
            int[] b = { 0, 4 };
            int[] c = { 3, 0 };
            double expected = 6;

            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.Area();

            Assert.AreEqual(expected, actual);
        }
    }
}