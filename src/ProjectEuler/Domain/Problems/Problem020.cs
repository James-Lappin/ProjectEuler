namespace ProjectEuler.Domain.Problems
{
    public class Problem20
    {
        public string Solve()
        {
            //TODO
            throw new System.Exception();
        }

        /*
	public int Solve(){
		int result = 0;
		BigInteger hundredFactoral = new BigInteger("100");

		for(int i = 99; i>0;i--){
			hundredFactoral = hundredFactoral.multiply(new BigInteger(Integer.toString(i)));
		}

		String dave = hundredFactoral.toString();
		System.out.println(hundredFactoral);

		for(int i =0; i<dave.Length();i++){
			result = result + Character.getNumericValue(dave.charAt(i));
		}
		return result;
	}*/
    }
}