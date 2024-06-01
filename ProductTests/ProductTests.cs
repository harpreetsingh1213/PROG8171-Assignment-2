using Assignment2;
namespace ProductTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckProductID1()
        {
            var product = new Product(1, "Silver", 10.0, 100);
            product.ProductID = 1;
            Assert.That(product.ProductID, Is.EqualTo(1));
        }

        [Test]
        public void CheckProductID2()
        {
            var product = new Product(2, "Silver", 10.0, 100);
            product.ProductID = 2;
            Assert.That(product.ProductID, Is.EqualTo(2));
        }

        [Test]
        public void CheckProductID3()
        {
            var product = new Product(3, "Silver", 10.0, 100);
            product.ProductID = 3;
            Assert.That(product.ProductID, Is.EqualTo(3));
        }

        [Test]
        public void CheckProductName1()
        {
            var product = new Product(1, "Platinum", 20.0, 200);
            product.ProductName = "Platinum";
            Assert.That(product.ProductName, Is.EqualTo("Platinum"));
        }

        [Test]
        public void CheckProductName2()
        {
            var product = new Product(2, "Gold", 20.0, 200);
            product.ProductName = "Gold";
            Assert.That(product.ProductName, Is.EqualTo("Gold"));
        }

        [Test]
        public void CheckProductName3()
        {
            var product = new Product(3, "Silver", 20.0, 200);
            product.ProductName = "Silver";
            Assert.That(product.ProductName, Is.EqualTo("Silver"));
        }

        [Test]
        public void CheckPrice1()
        {
            var product = new Product(1, "Diamond", 10.0, 300);
            product.Price = 10.0;
            Assert.That(product.Price, Is.EqualTo(10.0));
        }

        [Test]
        public void CheckPrice2()
        {
            var product = new Product(2, "Diamond", 20.0, 300);
            product.Price = 20.0;
            Assert.That(product.Price, Is.EqualTo(20.0));
        }

        [Test]
        public void CheckPrice3()
        {
            var product = new Product(3, "Diamond", 30.0, 300);
            product.Price = 30.0;
            Assert.That(product.Price, Is.EqualTo(30.0));
        }

        [Test]
        public void CheckStock1()
        {
            var product = new Product(1, "Diamond", 40.0, 100);
            product.Stock = 100;
            Assert.That(product.Stock, Is.EqualTo(100));
        }

        [Test]
        public void CheckStock2()
        {
            var product = new Product(2, "Diamond", 40.0, 200);
            product.Stock = 200;
            Assert.That(product.Stock, Is.EqualTo(200));
        }

        [Test]
        public void CheckStock3()
        {
            var product = new Product(3, "Diamond", 40.0, 300);
            product.Stock = 300;
            Assert.That(product.Stock, Is.EqualTo(300));
        }

        [Test]
        public void IncreaseStock1()
        {
            var product = new Product(1, "Chocolate", 10.0, 100);
            product.IncreaseStock(10);
            Assert.That(product.Stock, Is.EqualTo(110));
        }

        [Test]
        public void IncreaseStock2()
        {
            var product = new Product(2, "Chocolate", 10.0, 100);
            product.IncreaseStock(20);
            Assert.That(product.Stock, Is.EqualTo(120));
        }

        [Test]
        public void IncreaseStock3()
        {
            var product = new Product(3, "Chocolate", 10.0, 100);
            product.IncreaseStock(30);
            Assert.That(product.Stock, Is.EqualTo(130));
        }

        [Test]
        public void DecreaseStock1()
        {
            var product = new Product(1, "Gold", 10.0, 100);
            product.DecreaseStock(10);
            Assert.That(product.Stock, Is.EqualTo(90));
        }

        [Test]
        public void DecreaseStock2()
        {
            var product = new Product(1, "Gold", 10.0, 100);
            product.DecreaseStock(20);
            Assert.That(product.Stock, Is.EqualTo(80));
        }

        [Test]
        public void DecreaseStock3()
        {
            var product = new Product(1, "Gold", 10.0, 100);
            product.DecreaseStock(30);
            Assert.That(product.Stock, Is.EqualTo(70));
        }

    }
}