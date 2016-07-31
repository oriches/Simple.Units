﻿namespace Simple.Units
{
    using System;
    using System.Collections.Generic;

    public static class Units
    {
        private sealed class LazyConversions : Lazy<IEnumerable<KeyValuePair<Unit, Func<double, double>>>>
        {
            public LazyConversions(Func<IEnumerable<KeyValuePair<Unit, Func<double, double>>>> conversionFuncs)
                : base(conversionFuncs)
            {
            }
        }

        public static readonly Unit Celsuis = new Unit("Celsuis", "°C", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Fahrenheit, value =>(value * 9d / 5d) + 32 },
            { Kelvin, value => value + 273.15 }
        }));

        public static readonly Unit Fahrenheit = new Unit("Fahrenheit", "°F", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Celsuis, value => ((value - 32) * 5) / 9d },
            { Kelvin, value => (((value - 32) * 5) / 9d) + 273.15 }
        }));

        public static readonly Unit Kelvin = new Unit("Kelvin", "°K", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Celsuis, value => value - 273.15 },
            { Fahrenheit, value => ((value - 273.15) * 9d / 5d) + 32 }
        }));

        public static readonly Unit Centimetre = new Unit("Centimetre", "cm", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Metre, value => value / 100d },
            { Kilometre, value => (value / 100d) / 1000d },
            { Inch, value => value * 0.393701d },
        }));

        public static readonly Unit Metre = new Unit("Metre", "m", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Centimetre, value => value * 100d },
            { Kilometre, value => value / 1000d },
            { Yard, value => value / 0.9144d },
        }));

        public static readonly Unit Kilometre = new Unit("Kilometre", "km", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Metre, value => value * 1000d },
            { Mile, value => value / 1.609344d },
        }));

        public static readonly Unit Mile = new Unit("Mile", "mi", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Metre, value => value * 1609.344d },
            { Kilometre, value => value * 1.609344d },
            { Foot, value => value * 5280d },
            { Yard, value => value * 1760d },
        }));

        public static readonly Unit Yard = new Unit("Yard", "yd", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Centimetre, value => value * 91.44d },
            { Metre, value => value * 0.9144d },
            { Kilometre, value => (value * 0.9144d) / 1000d },
            { Foot, value => value * 3d },
            { Mile, value => value / 1760d },
        }));

        public static readonly Unit Foot = new Unit("Foot", "ft", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Centimetre, value => value * 30.48d },
            { Metre, value => value * 0.3048d },
            { Kilometre, value => value * 0.0003048d },
            { Inch, value => value * 12d },
            { Yard, value => value * 0.333333d },
        }));

        public static readonly Unit Inch = new Unit("Inch", "in", new LazyConversions(() => new Dictionary<Unit, Func<double, double>>
        {
            { Centimetre, value => value / 0.393700d },
            { Yard, value => value * 0.0277778d },
            { Foot, value => value * 0.0833333d },
        }));
    }
}