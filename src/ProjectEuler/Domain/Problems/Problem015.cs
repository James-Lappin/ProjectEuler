using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem015 : IProblem
    {
        public string Solve()
        {
            //TODO
            throw new System.Exception();
        }

        /*
    public BigInteger Solve(){
        BigInteger numberator = new BigInteger("1");
        BigInteger dinominator = new BigInteger("1");

        for(int i =21; i<41;i++){
            BigInteger iAsBigInteger = new BigInteger(Integer.toString(i));

            numberator = numberator.multiply(iAsBigInteger);
        }

        for(int i = 2; i<21; i++){
            BigInteger iAsBigInteger = new BigInteger(Integer.toString(i));

            dinominator = dinominator.multiply(iAsBigInteger);
        }

        System.out.println("Top: " + numberator + " Bottom: " + dinominator + " Max Value of long: \nTop: " + Long.MAX_VALUE);

        return numberator.divide(dinominator);
    }*/
    }
}