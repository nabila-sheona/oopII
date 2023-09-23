using LAB4_B_210042111;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calculate_horror()
        {
            Movierentalservice service = new Movierentalservice();

            Movie horrorMovie = new Movie
            (
            "Scary Movie",
                Genre.Horror, 120,
                new DateTime(2019, 5, 15)
                
                          );
            double price = service.calculate(horrorMovie);
            Assert.AreEqual(4, price);

        }

        [TestMethod]
        public void calculate_romance()
        {
            Movierentalservice service = new Movierentalservice();

            Movie romance = new Movie
            (
            "Movie",
                Genre.Romantic, 80,
                new DateTime(2022, 5, 15));
            double price = service.calculate(romance);
            Assert.AreEqual(3.5, price);

        }

        [TestMethod]
        public void calculate_thriller()
        {
            Movierentalservice service = new Movierentalservice();

            Movie thriller = new Movie
            (
            "Movie",
                Genre.Thriller, 210,
                new DateTime(2022, 5, 15));

            double price = service.calculate(thriller);
            Assert.AreEqual(4.25, price);

        }
    }
}