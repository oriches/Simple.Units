namespace Simple.Units.Fixtures
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class MeasurementTests
    {
        [Test]
        public void measurement_is_formatted()
        {
            // ARRANGE
            var measurement = new Measurement(42.42, Units.Celsuis);

            // ACT
            var toString = measurement.ToString();

            // ASSERT
            Assert.That(toString, Is.EqualTo("42.42 °C"));
        }

        [Test]
        public void measurements_are_equal()
        {
            // ARRANGE
            var measurement1 = new Measurement(1d, Units.Metre);
            var measurement2 = new Measurement(1d, Units.Metre);

            // ACT
            // ASSERT
            Assert.That(measurement1, Is.EqualTo(measurement2));
        }

        [Test]
        public void measurements_are_not_equal()
        {
            // ARRANGE
            var measurement1 = new Measurement(1d, Units.Metre);
            var measurement2 = new Measurement(1d, Units.Kilometre);

            // ACT
            // ASSERT
            Assert.That(measurement1, Is.Not.EqualTo(measurement2));
        }

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
    }
}
