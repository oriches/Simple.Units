namespace Simple.Units.Fixtures
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ItemTests
    {
        [Test]
        public void items_are_equal()
        {
            // ARRANGE
            var item1 = new Item(1d, Units.Metre);
            var item2 = new Item(1d, Units.Metre);

            // ACT
            // ASSERT
            Assert.That(item1, Is.EqualTo(item2));
        }

        [Test]
        public void items_are_not_equal()
        {
            // ARRANGE
            var item1 = new Item(1d, Units.Metre);
            var item2 = new Item(1d, Units.Kilometre);

            // ACT
            // ASSERT
            Assert.That(item1, Is.Not.EqualTo(item2));
        }

        [Test]
        public void throws_exception_when_trying_invalid_conversion()
        {
            // ARRANGE
            var itemInCelsuis = new Item(42d, Units.Celsuis);

            // ACT
            ArgumentException exception = null;
            try
            {
                itemInCelsuis.ConvertTo(Units.Metre);
            }
            catch (ArgumentException exn)
            {
                exception = exn;
            }

            // ASSERT
            Assert.That(exception, Is.Not.Null);
        }
    }
}
