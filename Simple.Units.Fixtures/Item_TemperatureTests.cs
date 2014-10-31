namespace Simple.Units.Fixtures
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Item_TemperatureTests
    {
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

        [Test]
        public void zero_degress_celsuis_is_thirty_two_degrees_fahrenheit()
        {
            // ARRANGE
            var itemInCelsuis = new Item(0d, Units.Celsuis);
            
            // ACT
            var itemInFahrenheit = itemInCelsuis.ConvertTo(Units.Fahrenheit);
            
            // ASSERT
            Assert.That(itemInFahrenheit.Amount, Is.EqualTo(32d));
        }

        [Test]
        public void one_hundred_degress_celsuis_is_two_hundred_and_twelve_degrees_fahrenheit()
        {
            // ARRANGE
            var itemInCelsuis = new Item(100d, Units.Celsuis);

            // ACT
            var itemInFahrenheit = itemInCelsuis.ConvertTo(Units.Fahrenheit);

            // ASSERT
            Assert.That(itemInFahrenheit.Amount, Is.EqualTo(212d));
        }

        [Test]
        public void forty_two_degress_celsuis_is_three_hundred_and_fifteen_point_one_five_degrees_kelvin()
        {
            // ARRANGE
            var itemInCelsuis = new Item(42d, Units.Celsuis);

            // ACT
            var itemInKelvin = itemInCelsuis.ConvertTo(Units.Kelvin);

            // ASSERT
            Assert.That(itemInKelvin.Amount, Is.EqualTo(315.15d));
        }

        [Test]
        public void forty_two_degress_fahrenheit_is_one_hundred_and_seven_point_six_degrees_celsuis()
        {
            // ARRANGE
            var itemInFahrenheit = new Item(42d, Units.Fahrenheit);

            // ACT
            var itemInCelsuis = itemInFahrenheit.ConvertTo(Units.Celsuis, 2);

            // ASSERT
            Assert.That(itemInCelsuis.Amount, Is.EqualTo(5.56d));
        }

        [Test]
        public void forty_two_degress_fahrenheit_is_one_hundred_and_seven_point_six_degrees_kelvin()
        {
            // ARRANGE
            var itemInFahrenheit = new Item(42d, Units.Fahrenheit);

            // ACT
            var itemInKelvin = itemInFahrenheit.ConvertTo(Units.Kelvin, 2);

            // ASSERT
            Assert.That(itemInKelvin.Amount, Is.EqualTo(278.71d));
        }

        [Test]
        public void forty_two_degress_kelvin_is_minus_two_hundred_an_thirty_one_point_one_five_degrees_celsuis()
        {
            // ARRANGE
            var itemInKelvin = new Item(42d, Units.Kelvin);

            // ACT
            var itemInCelsuis = itemInKelvin.ConvertTo(Units.Celsuis, 2);

            // ASSERT
            Assert.That(itemInCelsuis.Amount, Is.EqualTo(-231.15d));
        }

        [Test]
        public void one_thousand_and_forty_two_degress_kelvin_is_one_thousand_four_hundred_and_fifteen_point_nice_three_degrees_fahrenheit()
        {
            // ARRANGE
            var itemInKelvin = new Item(1042d, Units.Kelvin);

            // ACT
            var itemInFahrenheit = itemInKelvin.ConvertTo(Units.Fahrenheit, 2);

            // ASSERT
            Assert.That(itemInFahrenheit.Amount, Is.EqualTo(1415.93d));
        }
    }
}
