namespace Simple.Units.Fixtures
{
    using NUnit.Framework;

    [TestFixture]
    public class Item_DistanceTests
    {
        [Test]
        public void one_centremetre_is_nought_point_three_nine_inches()
        {
            // ARRANGE
            var itemInCentimetres = new Item(1d, Units.Centimetre);

            // ACT
            var itemInInches = itemInCentimetres.ConvertTo(Units.Inch, 2);

            // ASSERT
            Assert.That(itemInInches.Amount, Is.EqualTo(0.39d));
        }

        [Test]
        public void one_centimetre_is_zero_point_zero_one_metres()
        {
            // ARRANGE
            var itemInCentimetres = new Item(1d, Units.Centimetre);

            // ACT
            var itemInMetre = itemInCentimetres.ConvertTo(Units.Metre);

            // ASSERT
            Assert.That(itemInMetre.Amount, Is.EqualTo(0.01d));
        }

        [Test]
        public void ten_thousand_centimetre_is_zero_point_one_kilometres()
        {
            // ARRANGE
            var itemInCentimetres = new Item(10000d, Units.Centimetre);

            // ACT
            var itemInKilometre = itemInCentimetres.ConvertTo(Units.Kilometre);

            // ASSERT
            Assert.That(itemInKilometre.Amount, Is.EqualTo(0.1d));
        }

        [Test]
        public void one_metre_is_one_hundred_centimetres()
        {
            // ARRANGE
            var itemInMetres = new Item(1d, Units.Metre);

            // ACT
            var itemInCentimetres = itemInMetres.ConvertTo(Units.Centimetre);

            // ASSERT
            Assert.That(itemInCentimetres.Amount, Is.EqualTo(100d));
        }

        [Test]
        public void one_thousand_metres_is_one_kilometre()
        {
            // ARRANGE
            var itemInMetres = new Item(1000d, Units.Metre);

            // ACT
            var itemInKilometres = itemInMetres.ConvertTo(Units.Kilometre);

            // ASSERT
            Assert.That(itemInKilometres.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void forty_two_kilometres_is_one_metres()
        {
            // ARRANGE
            var itemInKilometres = new Item(42d, Units.Kilometre);

            // ACT
            var itemInMetres = itemInKilometres.ConvertTo(Units.Metre);

            // ASSERT
            Assert.That(itemInMetres.Amount, Is.EqualTo(42000d));
        }

        [Test]
        public void four_kilometres_is_two_point_four_eight_miles()
        {
            // ARRANGE
            var itemInKilometres = new Item(4d, Units.Kilometre);

            // ACT
            var itemInMiles = itemInKilometres.ConvertTo(Units.Mile, 2);

            // ASSERT
            Assert.That(itemInMiles.Amount, Is.EqualTo(2.49d));
        }

        [Test]
        public void one_metre_is_one_point_zero_nine_yards()
        {
            // ARRANGE
            var itemInMetres = new Item(1d, Units.Metre);

            // ACT
            var itemInYards = itemInMetres.ConvertTo(Units.Yard, 2);

            // ASSERT
            Assert.That(itemInYards.Amount, Is.EqualTo(1.09d));
        }

        [Test]
        public void one_foot_is_twelve_inches()
        {
            // ARRANGE
            var itemInFeet = new Item(1d, Units.Foot);

            // ACT
            var itemInInches = itemInFeet.ConvertTo(Units.Inch);

            // ASSERT
            Assert.That(itemInInches.Amount, Is.EqualTo(12d));
        }

        [Test]
        public void one_thousand_feet_is_three_hundred_and_four_point_eight_kilometre()
        {
            // ARRANGE
            var itemInFeet = new Item(1000d, Units.Foot);

            // ACT
            var itemInMetres = itemInFeet.ConvertTo(Units.Metre);

            // ASSERT
            Assert.That(itemInMetres.Amount, Is.EqualTo(304.8d));
        }

        [Test]
        public void one_mile_is_one_thousand_six_hundred_and_nine_point_three_four_metres()
        {
            // ARRANGE
            var itemInMiles = new Item(1d, Units.Mile);

            // ACT
            var itemInMetres = itemInMiles.ConvertTo(Units.Metre, 2);

            // ASSERT
            Assert.That(itemInMetres.Amount, Is.EqualTo(1609.34d));
        }

        [Test]
        public void one_mile_is_one_point_six_one_kilometres()
        {
            // ARRANGE
            var itemInMiles = new Item(1d, Units.Mile);

            // ACT
            var itemInKilometres = itemInMiles.ConvertTo(Units.Kilometre, 2);

            // ASSERT
            Assert.That(itemInKilometres.Amount, Is.EqualTo(1.61d));
        }

        [Test]
        public void one_mile_is_five_thousand_two_hundred_and_eighty_feet()
        {
            // ARRANGE
            var itemInMiles = new Item(1d, Units.Mile);

            // ACT
            var itemInFoot = itemInMiles.ConvertTo(Units.Foot);

            // ASSERT
            Assert.That(itemInFoot.Amount, Is.EqualTo(5280d));
        }

        [Test]
        public void one_mile_is_one_thousand_seven_hundred_and_sixty_feet()
        {
            // ARRANGE
            var itemInMiles = new Item(1d, Units.Mile);

            // ACT
            var itemInyards = itemInMiles.ConvertTo(Units.Yard);

            // ASSERT
            Assert.That(itemInyards.Amount, Is.EqualTo(1760d));
        }

        [Test]
        public void one_yard_is_ninety_one_point_four_four_centimetres()
        {
            // ARRANGE
            var itemInYards = new Item(1d, Units.Yard);

            // ACT
            var itemInCentimetre = itemInYards.ConvertTo(Units.Centimetre, 2);

            // ASSERT
            Assert.That(itemInCentimetre.Amount, Is.EqualTo(91.44d));
        }

        [Test]
        public void one_yard_is_zero_point_nine_one_metres()
        {
            // ARRANGE
            var itemInYards = new Item(1d, Units.Yard);

            // ACT
            var itemInMetre = itemInYards.ConvertTo(Units.Metre, 2);

            // ASSERT
            Assert.That(itemInMetre.Amount, Is.EqualTo(0.91d));
        }

        [Test]
        public void one_thousand_yards_is_zero_point_nine_one_kilometres()
        {
            // ARRANGE
            var itemInYards = new Item(1000d, Units.Yard);

            // ACT
            var itemInKilometre = itemInYards.ConvertTo(Units.Kilometre, 2);

            // ASSERT
            Assert.That(itemInKilometre.Amount, Is.EqualTo(0.91d));
        }

        [Test]
        public void one_yard_is_three_feet()
        {
            // ARRANGE
            var itemInYards = new Item(1d, Units.Yard);

            // ACT
            var itemInFeet = itemInYards.ConvertTo(Units.Foot);

            // ASSERT
            Assert.That(itemInFeet.Amount, Is.EqualTo(3d));
        }

        [Test]
        public void one_thousand_seven_hundred_and_sixty_yards_is_one_miles()
        {
            // ARRANGE
            var itemInYards = new Item(1760d, Units.Yard);

            // ACT
            var itemInMiles = itemInYards.ConvertTo(Units.Mile);

            // ASSERT
            Assert.That(itemInMiles.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void one_foot_is_thirty_point_four_eight_centimetres()
        {
            // ARRANGE
            var itemInFeet = new Item(1d, Units.Foot);

            // ACT
            var itemInCentimetre = itemInFeet.ConvertTo(Units.Centimetre, 2);

            // ASSERT
            Assert.That(itemInCentimetre.Amount, Is.EqualTo(30.48d));
        }

        [Test]
        public void one_thousand_feet_is_zero_point_three_zero_kilometres()
        {
            // ARRANGE
            var itemInFeet = new Item(1000d, Units.Foot);

            // ACT
            var itemInKilometre = itemInFeet.ConvertTo(Units.Kilometre, 2);

            // ASSERT
            Assert.That(itemInKilometre.Amount, Is.EqualTo(0.30d));
        }

        [Test]
        public void three_feet_is_one_yard()
        {
            // ARRANGE
            var itemInFeet = new Item(3d, Units.Foot);

            // ACT
            var itemInYards = itemInFeet.ConvertTo(Units.Yard, 2);

            // ASSERT
            Assert.That(itemInYards.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void one_inch_is_three_centimetres()
        {
            // ARRANGE
            var itemInInch = new Item(1d, Units.Inch);

            // ACT
            var itemInCentimetre = itemInInch.ConvertTo(Units.Centimetre, 2);

            // ASSERT
            Assert.That(itemInCentimetre.Amount, Is.EqualTo(2.54d));
        }

        [Test]
        public void thirty_six_inches_is_one_yard()
        {
            // ARRANGE
            var itemInInch = new Item(36d, Units.Inch);

            // ACT
            var itemInYards = itemInInch.ConvertTo(Units.Yard, 2);

            // ASSERT
            Assert.That(itemInYards.Amount, Is.EqualTo(1d));
        }

        [Test]
        public void thirty_six_inches_is_three_feet()
        {
            // ARRANGE
            var itemInInch = new Item(36d, Units.Inch);

            // ACT
            var itemInFeet = itemInInch.ConvertTo(Units.Foot, 2);

            // ASSERT
            Assert.That(itemInFeet.Amount, Is.EqualTo(3d));
        }
    }
}
