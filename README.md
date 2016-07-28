# Simple.Units

[![Build status](https://ci.appveyor.com/api/projects/status/db6cyf2xksk6sc4o/branch/master?svg=true)](https://ci.appveyor.com/project/oriches/simple-units/branch/master)

This is how I would model 'units of measure' in a system, this came out of discussion around building a system which required the ability to convert between different units of distance.

The easiest way to demostrate is with a unit test:
```C#
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
```

Put simply the unit test, creates a metre measurement and then converts this into cenitmetre measurement and checks the conversion from 1 metre to 100 centimetres has been done.
