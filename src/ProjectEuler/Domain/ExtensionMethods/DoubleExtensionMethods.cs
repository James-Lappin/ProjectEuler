using System;

namespace ProjectEuler.Domain.ExtensionMethods
{
    public static class DoubleExtensionMethods
    {
        public static bool HasRemainder(this double value)
        {
            return value.Equals(Math.Floor(value));
        }
    }
}
