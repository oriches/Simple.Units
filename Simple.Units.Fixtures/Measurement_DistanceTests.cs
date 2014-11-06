namespace Simple.Units.Fixtures
{
    using NUnit.Framework;

    [TestFixture]
    public class Measurement_DistanceTests
    {
        [Test]
        public void one_centrimetre_is_nought_point_three_nine_inches()
        {
            // ARRANGE
            var measurementInCentimetres = new Measurement(1d, Units.Centimetre);
            
            // ACT
            var measurementInInches = measurementInCentimetres.ConvertTo(Units.Inch, 2);

            // ASSERT
            Assert.That(measurementInInches.Amount, Is.EqualTo(0.39d));
        }

        [Test]
        public void one_centimetre_is_zero_point_zero_one_metres()
        {
            // ARRANGE
            var measurementInCentimetres = new Measurement(1d, Units.Centimetre);

            // ACT
            var measurementInMetres = measurementInCentimetres.ConvertTo(Units.Metre);

            // ASSERT
            Assert.That(measurementInMetres.Amount, Is.EqualTo(0.01d));
        }

        [Test]
        public void ten_thousand_centimetres_is_zero_point_one_kilometres()
        {
            // ARRANGE
            var measurementInCentimetres = new Measurement(10000d, Units.Centimetre);

            // ACT
            var measurementInKilometres = measurementInCentimetres.ConvertTo(Units.Kilometre);

            // ASSERT
            Assert.That(measurementInKilometres.Amount, Is.EqualTo(0.1d));
        }

        [Test]
        public void one_metre_is_one_hundred_centimetres()
        {
            // ARRANGE
            var measurementInMetres = new Measurement(1d, Units.Metre);

            // ACT
            var measurementInCentimetres = measurementInMetres.ConvertTo(Units.Centimetre);

            // ASSERT
            Assert.That(measurementInCentimetres.Amount, Is.EqualTo(100d));
        }

        [Test]
        public void one_thousand_metres_is_one_kilometre()
        {
            // ARRANGE
            var measurementInMetres = new Measurement(1000d, Units.Metre);

            // ACT
            var measurementInKilometres = measurementInMetres.ConvertTo(Units.Kilometre);

            // ASSERT
            Assert.That(measurementInKilometres.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void forty_two_kilometres_is_forty_two_thousand_metres()
        {
            // ARRANGE
            var measurementInKilometres = new Measurement(42d, Units.Kilometre);

            // ACT
            var measurementInMetres = measurementInKilometres.ConvertTo(Units.Metre);

            // ASSERT
            Assert.That(measurementInMetres.Amount, Is.EqualTo(42000d));
        }

        [Test]
        public void four_kilometres_is_two_point_four_eight_miles()
        {
            // ARRANGE
            var measurementInKilometres = new Measurement(4d, Units.Kilometre);

            // ACT
            var measurementInMiles = measurementInKilometres.ConvertTo(Units.Mile, 2);

            // ASSERT
            Assert.That(measurementInMiles.Amount, Is.EqualTo(2.49d));
        }

        [Test]
        public void one_metre_is_one_point_zero_nine_yards()
        {
            // ARRANGE
            var measurementInMetres = new Measurement(1d, Units.Metre);

            // ACT
            var measurementInYards = measurementInMetres.ConvertTo(Units.Yard, 2);

            // ASSERT
            Assert.That(measurementInYards.Amount, Is.EqualTo(1.09d));
        }

        [Test]
        public void one_foot_is_twelve_inches()
        {
            // ARRANGE
            var measurementInFeet = new Measurement(1d, Units.Foot);

            // ACT
            var measurementInInches = measurementInFeet.ConvertTo(Units.Inch);

            // ASSERT
            Assert.That(measurementInInches.Amount, Is.EqualTo(12d));
        }

        [Test]
        public void one_thousand_feet_is_three_hundred_and_four_point_eight_kilometres()
        {
            // ARRANGE
            var measurementInFeet = new Measurement(1000d, Units.Foot);

            // ACT
            var measurementInMetres = measurementInFeet.ConvertTo(Units.Metre);

            // ASSERT
            Assert.That(measurementInMetres.Amount, Is.EqualTo(304.8d));
        }

        [Test]
        public void one_mile_is_one_thousand_six_hundred_and_nine_point_three_four_metres()
        {
            // ARRANGE
            var measurementInMiles = new Measurement(1d, Units.Mile);

            // ACT
            var measurementInMetres = measurementInMiles.ConvertTo(Units.Metre, 2);

            // ASSERT
            Assert.That(measurementInMetres.Amount, Is.EqualTo(1609.34d));
        }

        [Test]
        public void one_mile_is_one_point_six_one_kilometres()
        {
            // ARRANGE
            var measurementInMiles = new Measurement(1d, Units.Mile);

            // ACT
            var measurementInKilometres = measurementInMiles.ConvertTo(Units.Kilometre, 2);

            // ASSERT
            Assert.That(measurementInKilometres.Amount, Is.EqualTo(1.61d));
        }

        [Test]
        public void one_mile_is_five_thousand_two_hundred_and_eighty_feet()
        {
            // ARRANGE
            var measurementInMiles = new Measurement(1d, Units.Mile);

            // ACT
            var measurementInFeet = measurementInMiles.ConvertTo(Units.Foot);

            // ASSERT
            Assert.That(measurementInFeet.Amount, Is.EqualTo(5280d));
        }

        [Test]
        public void one_mile_is_one_thousand_seven_hundred_and_sixty_feet()
        {
            // ARRANGE
            var measurementInMiles = new Measurement(1d, Units.Mile);

            // ACT
            var measurementInYards = measurementInMiles.ConvertTo(Units.Yard);

            // ASSERT
            Assert.That(measurementInYards.Amount, Is.EqualTo(1760d));
        }

        [Test]
        public void one_yard_is_ninety_one_point_four_four_centimetres()
        {
            // ARRANGE
            var measurementInYards = new Measurement(1d, Units.Yard);

            // ACT
            var measurementInCentimetres = measurementInYards.ConvertTo(Units.Centimetre, 2);

            // ASSERT
            Assert.That(measurementInCentimetres.Amount, Is.EqualTo(91.44d));
        }

        [Test]
        public void one_yard_is_zero_point_nine_one_metres()
        {
            // ARRANGE
            var measurementInYards = new Measurement(1d, Units.Yard);

            // ACT
            var measurementInMetres = measurementInYards.ConvertTo(Units.Metre, 2);

            // ASSERT
            Assert.That(measurementInMetres.Amount, Is.EqualTo(0.91d));
        }

        [Test]
        public void one_thousand_yards_is_zero_point_nine_one_kilometres()
        {
            // ARRANGE
            var measurementInYards = new Measurement(1000d, Units.Yard);

            // ACT
            var measurementInKilometres = measurementInYards.ConvertTo(Units.Kilometre, 2);

            // ASSERT
            Assert.That(measurementInKilometres.Amount, Is.EqualTo(0.91d));
        }

        [Test]
        public void one_yard_is_three_feet()
        {
            // ARRANGE
            var measurementInYards = new Measurement(1d, Units.Yard);

            // ACT
            var measurementInFeet = measurementInYards.ConvertTo(Units.Foot);

            // ASSERT
            Assert.That(measurementInFeet.Amount, Is.EqualTo(3d));
        }

        [Test]
        public void one_thousand_seven_hundred_and_sixty_yards_is_one_miles()
        {
            // ARRANGE
            var measurementInYards = new Measurement(1760d, Units.Yard);

            // ACT
            var measurementInMiles = measurementInYards.ConvertTo(Units.Mile);

            // ASSERT
            Assert.That(measurementInMiles.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void one_foot_is_thirty_point_four_eight_centimetres()
        {
            // ARRANGE
            var measurementInFeet = new Measurement(1d, Units.Foot);

            // ACT
            var measurementInCentimetres = measurementInFeet.ConvertTo(Units.Centimetre, 2);

            // ASSERT
            Assert.That(measurementInCentimetres.Amount, Is.EqualTo(30.48d));
        }

        [Test]
        public void one_thousand_feet_is_zero_point_three_zero_kilometres()
        {
            // ARRANGE
            var measurementInFeet = new Measurement(1000d, Units.Foot);

            // ACT
            var measurementInKilometres = measurementInFeet.ConvertTo(Units.Kilometre, 2);

            // ASSERT
            Assert.That(measurementInKilometres.Amount, Is.EqualTo(0.30d));
        }

        [Test]
        public void three_feet_is_one_yard()
        {
            // ARRANGE
            var measurementInFeet = new Measurement(3d, Units.Foot);

            // ACT
            var measurementInYards = measurementInFeet.ConvertTo(Units.Yard, 2);

            // ASSERT
            Assert.That(measurementInYards.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void one_inch_is_three_centimetres()
        {
            // ARRANGE
            var measurementInInch = new Measurement(1d, Units.Inch);

            // ACT
            var measurementInCentimetres = measurementInInch.ConvertTo(Units.Centimetre, 2);

            // ASSERT
            Assert.That(measurementInCentimetres.Amount, Is.EqualTo(2.54d));
        }

        [Test]
        public void thirty_six_inches_is_one_yard()
        {
            // ARRANGE
            var measurementInInch = new Measurement(36d, Units.Inch);

            // ACT
            var measurementInYards = measurementInInch.ConvertTo(Units.Yard, 2);

            // ASSERT
            Assert.That(measurementInYards.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void thirty_six_inches_is_three_feet()
        {
            // ARRANGE
            var measurementInInch = new Measurement(36d, Units.Inch);

            // ACT
            var measurementInFeet = measurementInInch.ConvertTo(Units.Foot, 2);

            // ASSERT
            Assert.That(measurementInFeet.Amount, Is.EqualTo(3d));
        }
    }
}
