namespace Simple.Units
{
    using System;
    using System.Linq;

    public struct Measurement : IEquatable<Measurement>
    {
        public bool Equals(Measurement other)
        {
            return Amount.Equals(other.Amount) && Equals(Units, other.Units);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Measurement && Equals((Measurement) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Amount.GetHashCode()*397) ^ (Units != null ? Units.GetHashCode() : 0);
            }
        }

        public static bool operator ==(Measurement left, Measurement right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Measurement left, Measurement right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return $"{Amount} {Units.Abbreviation}";
        }

        public Measurement(double amount, Unit units) : this()
        {
            Amount = amount;
            Units = units;
        }

        public double Amount { get; }

        public Unit Units { get; }

        public Measurement ConvertTo(Unit newUnits)
        {
            return ConvertTo(newUnits, null);
        }

        public Measurement ConvertTo(Unit newUnits, int? precision)
        {
            var converter = Units.Converters.SingleOrDefault(x => x.Unit == newUnits);
            if (converter == null)
            {
                throw new ArgumentException($"Converter not defined, {Units.Name} -> {newUnits.Name}");
            }

            return precision.HasValue ?
                new Measurement(converter.Convert(Amount, precision.Value), newUnits) :
                new Measurement(converter.Convert(Amount), newUnits);
        }
    }
}