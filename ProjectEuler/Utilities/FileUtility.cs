using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Utilities
{
	public class FileUtility : IFileUtility
	{
		public IEnumerable<string> ReadCsvFile(string fileName)
		{
			if (!File.Exists(fileName)) { throw new ArgumentException($"File cannot be found. Filename: {fileName}"); }

			return File.ReadAllLines(fileName).SelectMany(a => a.Split(','));


		}
	}

	public interface IFileUtility
	{
		IEnumerable<string> ReadCsvFile(string fileName);
	}
}
