namespace Simple.Units
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    [DebuggerDisplay("Name = {Name}, Abbreviation = {Abbreviation}")]
    public struct Unit : IEquatable<Unit>
    {
        public sealed class Converter
        {
            private readonly Func<double, double> _convertFunc;
            
            public Unit Unit { get; private set; }
            
            public Converter(Unit unit, Func<double, double> convertFunc)
            {
                Unit = unit;
                _convertFunc = convertFunc;
            }

            public double Convert(double value)
            {
                return _convertFunc(value);
            }

            public double Convert(double value, int precision)
            {
                return Math.Round(_convertFunc(value), precision);
            }
        }

        public bool Equals(Unit other)
        {
            return string.Equals(Name, other.Name);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is Unit && Equals((Unit) obj);
        }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? 0;
        }

        public static bool operator ==(Unit left, Unit right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Unit left, Unit right)
        {
            return !left.Equals(right);
        }

        private readonly Lazy<IEnumerable<KeyValuePair<Unit, Func<double, double>>>> _lazyConversions;

        private Converter[] _converters;

        internal Unit(string name, string abbreviation, Lazy<IEnumerable<KeyValuePair<Unit, Func<double, double>>>> conversions)
        {
            Name = name;
            Abbreviation = abbreviation;

            _converters = null;
            _lazyConversions = conversions;
        }
        
        public string Name { get; }

        public string Abbreviation { get; }

        public IEnumerable<Converter> Converters
        {
            get
            {
                if (_converters != null)
                {
                    return _converters;
                }

                _converters = _lazyConversions.Value
                    .Select(x => new Converter(x.Key, x.Value))
                    .ToArray();

                return _converters;
            }
        }
    }
}