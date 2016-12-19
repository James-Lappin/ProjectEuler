namespace ProjectEuler.Domain.Generators
{
    /// <summary>
    /// Generate Numbers for Euler problem 150 under the Linear Congruential Generator formula: 
    /// t := 0 
    ///for k = 1 up to k = 500500: 
    ///    t := (615949*t + 797807) modulo 2^20
    ///    sk := t−2^19
    /// </summary>
    public class LinearCongruentialGenerator
    {
        private static int _previous;

        public LinearCongruentialGenerator()
        {
            _previous = 0;
        }

        public int Next()
        {
            _previous = (615949 * _previous + 797807) & ((1 << 20) - 1);
            return _previous - (1 << 19);
        }
    }
}
