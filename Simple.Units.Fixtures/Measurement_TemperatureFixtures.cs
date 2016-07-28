namespace Simple.Units.Fixtures
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class Measurement_TemperatureFixtures
    {
        [Test]
        public void throws_exception_when_trying_invalid_conversion()
        {
            // ARRANGE
            var measurementInCelsuis = new Measurement(42d, Units.Celsuis);

            // ACT
            ArgumentException exception = null;
            try
            {
                measurementInCelsuis.ConvertTo(Units.Metre);
            }
            catch (ArgumentException exn)
            {
                exception = exn;
            }

            // ASSERT
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void zero_degrees_celsuis_is_thirty_two_degrees_fahrenheit()
        {
            // ARRANGE
            var measurementInCelsuis = new Measurement(0d, Units.Celsuis);
            
            // ACT
            var measurementInFahrenheit = measurementInCelsuis.ConvertTo(Units.Fahrenheit);
            
            // ASSERT
            Assert.That(measurementInFahrenheit.Amount, Is.EqualTo(32d));
        }

        [Test]
        public void one_hundred_degrees_celsuis_is_two_hundred_and_twelve_degrees_fahrenheit()
        {
            // ARRANGE
            var measurementInCelsuis = new Measurement(100d, Units.Celsuis);

            // ACT
            var measurementInFahrenheit = measurementInCelsuis.ConvertTo(Units.Fahrenheit);

            // ASSERT
            Assert.That(measurementInFahrenheit.Amount, Is.EqualTo(212d));
        }

        [Test]
        public void forty_two_degress_celsuis_is_three_hundred_and_fifteen_point_one_five_degrees_kelvin()
        {
            // ARRANGE
            var measurementInCelsuis = new Measurement(42d, Units.Celsuis);

            // ACT
            var measurementInKelvin = measurementInCelsuis.ConvertTo(Units.Kelvin);

            // ASSERT
            Assert.That(measurementInKelvin.Amount, Is.EqualTo(315.15d));
        }

        [Test]
        public void forty_two_degrees_fahrenheit_is_one_hundred_and_seven_point_six_degrees_celsuis()
        {
            // ARRANGE
            var measurementInFahrenheit = new Measurement(42d, Units.Fahrenheit);

            // ACT
            var measurementInCelsuis = measurementInFahrenheit.ConvertTo(Units.Celsuis, 2);

            // ASSERT
            Assert.That(measurementInCelsuis.Amount, Is.EqualTo(5.56d));
        }

        [Test]
        public void forty_two_degrees_fahrenheit_is_one_hundred_and_seven_point_six_degrees_kelvin()
        {
            // ARRANGE
            var measurementInFahrenheit = new Measurement(42d, Units.Fahrenheit);

            // ACT
            var measurementInKelvin = measurementInFahrenheit.ConvertTo(Units.Kelvin, 2);

            // ASSERT
            Assert.That(measurementInKelvin.Amount, Is.EqualTo(278.71d));
        }

        [Test]
        public void forty_two_degrees_kelvin_is_minus_two_hundred_an_thirty_one_point_one_five_degrees_celsuis()
        {
            // ARRANGE
            var measurementInKelvin = new Measurement(42d, Units.Kelvin);

            // ACT
            var measurementInCelsuis = measurementInKelvin.ConvertTo(Units.Celsuis, 2);

            // ASSERT
            Assert.That(measurementInCelsuis.Amount, Is.EqualTo(-231.15d));
        }

        [Test]
        public void one_thousand_and_forty_two_degrees_kelvin_is_one_thousand_four_hundred_and_fifteen_point_nice_three_degrees_fahrenheit()
        {
            // ARRANGE
            var measurementInKelvin = new Measurement(1042d, Units.Kelvin);

            // ACT
            var measurementInFahrenheit = measurementInKelvin.ConvertTo(Units.Fahrenheit, 2);

            // ASSERT
            Assert.That(measurementInFahrenheit.Amount, Is.EqualTo(1415.93d));
        }
    }
}
