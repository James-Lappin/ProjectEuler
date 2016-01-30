using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
	public class Problem017 : IProblem
	{
		private readonly int[] OneToNineteenLengths = { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
		private readonly int[] TensWrittenAsWords = { 0, 0, 6, 6, 5, 5, 5, 7, 6, 6 };

		private const int HundredWrittenLength = 7;
		private const int ThousandWrittenLength = 8;

		public int StartingNumber { get; set; } = 1;
		public int FinishingNumber { get; set; } = 1000;

		public virtual string Solve()
		{
			if (StartingNumber <= 0 || StartingNumber >= 10000)
			{
				throw new NotImplementedException("Please choose a valid starting number between 1 and 9,999");
			}

			var result = 0;
			for (int currentNumber = StartingNumber; currentNumber <= FinishingNumber; currentNumber++)
			{
				var numberQueue = NumbersIn(currentNumber);

				if (numberQueue.Count == 4) result += GetThousandsResult(numberQueue);
				if (numberQueue.Count == 3) result += GetHundredsResult(numberQueue);
				if (numberQueue.Count == 2) result += GetTensResult(numberQueue);
				if (numberQueue.Count == 1) result += GetSinglesResult(numberQueue);
			}

			return result.ToString();
		}

		private int GetThousandsResult(Queue<int> numberQueue)
		{
			var thousands = numberQueue.Dequeue();
			if (thousands == 0) { return 0; }

			var result = OneToNineteenLengths[thousands] + ThousandWrittenLength;

			if (ShouldAddAnd(numberQueue)) result += 3;

			return result;
		}

		private int GetHundredsResult(Queue<int> numberQueue)
		{
			var hundreds = numberQueue.Dequeue();
			if (hundreds == 0) { return 0; }

			var result = OneToNineteenLengths[hundreds] + HundredWrittenLength;

			if (ShouldAddAnd(numberQueue)) result += 3;

			return result;
		}

		private bool ShouldAddAnd(Queue<int> numberQueue)
		{
			//This is annoying. As we don't need to add 3 characters for the word and on One Hundred and One thousand, this is needed.
			//Queue might no long be the best solution for this. Nice try.
			var tempQueue = new Queue<int>();
			var result = false;
			while (numberQueue.Count > 0)
			{
				var tempDigit = numberQueue.Dequeue();

				if (result == false && tempDigit != 0) { result = true; }
				tempQueue.Enqueue(tempDigit);
			}

			while (tempQueue.Count > 0)
			{
				numberQueue.Enqueue(tempQueue.Dequeue());
			}

			return result;
		}

		private int GetTensResult(Queue<int> numberQueue)
		{
			var tens = numberQueue.Dequeue();

			if (tens == 1)
			{
				var single = numberQueue.Dequeue();
				var teens = (tens * 10) + single;
				return OneToNineteenLengths[teens];
			}

			return TensWrittenAsWords[tens];
		}

		private int GetSinglesResult(Queue<int> numberQueue)
		{
			var single = numberQueue.Dequeue();
			return OneToNineteenLengths[single];
		}

		public Queue<int> NumbersIn(int value)
		{
			if (value == 0) return new Queue<int>();

			var numbers = NumbersIn(value / 10);
			numbers.Enqueue(value % 10);

			return numbers;
		}
	}
}
