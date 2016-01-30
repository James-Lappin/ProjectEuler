public class Problem22
{
	public int Solve()
	{

		int result = 0;

		string nameFile = readFile("src/names.txt");
		string[] nameArray = nameFile.Split(',');

		for (int i = 0; i < nameArray.Length; i++)
		{
			nameArray[i] = nameArray[i].Substring(1, nameArray[i].Length - 1);
		}

		nameArray[0] = "COLIN";

		return result;
	}

	public string readFile(string fileName)
	{
		throw new System.NotImplementedException("this fucked up y'all");
		//BufferedReader br = new BufferedReader(new FileReader(fileName));
		/*try {
	    StringBuilder sb = new StringBuilder();
			string line = br.readLine();

	    while (line != null) {
	      sb.Append(line);
	      sb.Append("\n");
	      line = br.readLine();
	    }
	    return sb.toString();
	  } finally {
	    br.close();
	  }*/
	}

}





//Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. 
//Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
//For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 x 53 = 49714.
//What is the total of all the name scores in the file?