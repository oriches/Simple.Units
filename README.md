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

Put simply the unit test creates a metre measurement and then converts this into a cenitmetre measurement and checks the conversion from 1 metre to 100 centimetres was correct.

Hopefuilly what you can see is there are 3 class involved here - **Measurement**, **Units** & **Unit**:

#### Measurement
Contains the actual measured value and units (of measure) - represents the measurement. 

The important\interesting part is the **ConvertTo** method, as the name says it invokes the conversion, but does not actual do the conversion, this is the responiblity of the Unit instance.

#### Unit
Defines a 'unit of measure' as being a Name, an Abrevation and set of Conversions to other units.






