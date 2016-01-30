
public class Problem10 {
	public static long Solve(){ 
		 long result = 0;
		 for(int i=2; i<2000000;i++){
			 if(runner.isPrime(i)){
				 result = result + i;
			 }
		 }
		 return result;
	 }
}
