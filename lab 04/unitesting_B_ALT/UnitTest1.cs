using lab4_B_alter;

namespace unitesting_B_ALT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void calculate_horror()
        {

            horror horrorMovie = new horror(
                           "Scary Movie",
                           genre.horror,
                           new DateTime(2019, 5, 15),
                           120
                       );

            // Calculate the rental price for the horror movie
            double price = horrorMovie.calcbill();

            // Assert that the calculated price matches the expected price (4.0)
            Assert.AreEqual(4.0, price);

        }

        [TestMethod]
        public void calculate_romance()
        {
            // Create a romance movie instance
            romance romanceMovie = new romance(
                "Romantic Movie",
                genre.romance,
                new DateTime(2022, 5, 15),
                120
            );

            // Create a service for the romance movie
            service service = new service(romanceMovie);

            // Calculate the rental price using the service
            double price = service.calcbill();

            // Assert that the calculated price matches the expected price (3.5)
            Assert.AreEqual(3.5, price);

        }

        [TestMethod]
        public void calculate_thriller()
        {  // Create a thriller movie instance
            thriller thrillerMovie = new thriller(
                "Thriller Movie",
                genre.thriller,
                new DateTime(2022, 5, 15),
                120
            );

            // Calculate the rental price for the thriller movie
            double price = thrillerMovie.calcbill();

            // Assert that the calculated price matches the expected price (3.5)
            Assert.AreEqual(4.25, price);
        }
    }
}