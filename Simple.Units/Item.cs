namespace Simple.Units
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    [DebuggerDisplay("Amount = {Amount}, Units = {Units.Name}")]
    public sealed class Item : IEquatable<Item>
    {
        public bool Equals(Item other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Amount.Equals(other.Amount) && Units.Equals(other.Units);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is Item && Equals((Item) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Amount.GetHashCode()*397) ^ Units.GetHashCode();
            }
        }

        public static bool operator ==(Item left, Item right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Item left, Item right)
        {
            return !Equals(left, right);
        }

        public Item(double amount, Unit units)
        {
            Amount = amount;
            Units = units;
        }

        public double Amount { get; private set; }

        public Unit Units { get; private set; }

        public Item ConvertTo(Unit newUnits)
        {
            return ConvertTo(newUnits, null);
        }

        public Item ConvertTo(Unit newUnits, int? precision)
        {
            var converter = Units.Converters.SingleOrDefault(x => x.Unit == newUnits);
            if (converter == null)
            {
                throw new ArgumentException(string.Format("Converter not defined, {0} -> {1}", Units.Name, newUnits.Name));
            }

            return precision.HasValue ?
                new Item(converter.Convert(Amount, precision.Value), newUnits) :
                new Item(converter.Convert(Amount), newUnits);
        }
    }
}