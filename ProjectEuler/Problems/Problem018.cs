
public class Problem18
{

	public int Solve()
	{
		int result = 0;

		int[][] dave = new int[][]{
				new [] {75},
				new [] {95, 64},
				new [] {17, 47, 82},
				new [] {18, 35, 87, 10},
				new [] {20, 04, 82, 47, 65},
				new [] {19, 01, 23, 75, 03, 34},
				new [] {88, 02, 77, 73, 07, 63, 67},
				new [] {99, 65, 04, 28, 06, 16, 70, 92},
				new [] {41, 41, 26, 56, 83, 40, 80, 70, 33},
				new [] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
				new [] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
				new [] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
				new [] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
				new [] {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
				new [] {04, 62, 98, 27, 23, 9, 70, 98, 73, 93, 38, 53, 60, 04, 23}
		};

		int[] maxResult = new int[15];


		maxResult[0] = dave[0][0];

		for (int j = 1; j < dave.Length; j++)
		{
			int[] tempMaxResult = new int[15];
			for (int i = 0; i < dave[j].Length; i++)
			{

				if (i == 0) { tempMaxResult[i] = dave[j][i] + maxResult[i]; }
				else {
					int d1 = dave[j][i] + maxResult[i - 1];
					int d2 = dave[j][i] + maxResult[i];

					if (d1 > d2) { tempMaxResult[i] = d1; }
					else { tempMaxResult[i] = d2; }
				}
			}


			maxResult = tempMaxResult;

		}


		//for (int i = 0; i < maxResult.Length; i++)
		//{
		//	System.out.println(maxResult[i]);
		//}

		return result;
	}

}
