using lab4_B_alter;

namespace unitesting_B_ALT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calculate_horror()
        {
            releasetime service = new releasetime();

            Movie horrorMovie = new Movie
            (
            "Scary Movie",
                genre.horror,
                new DateTime(2019, 5, 15),
                120
                          );
            double price = service.calculate(horrorMovie);
            Assert.AreEqual(4, price);

        }

        [TestMethod]
        public void calculate_romance()
        {
            releasetime service = new releasetime();

            Movie romance = new Movie
            (
            "Movie",
                genre.romance,
                new DateTime(2022, 5, 15),
                120);
            double price = service.calculate(romance);
            Assert.AreEqual(3.5, price);

        }

        [TestMethod]
        public void calculate_thriller()
        {
            releasetime service = new releasetime();

            Movie thriller = new Movie
            (
            "Movie",
                genre.thriller,
                new DateTime(2022, 5, 15),
                120);

            double price = service.calculate(thriller);
            Assert.AreEqual(4.25, price);

        }
    }
}

