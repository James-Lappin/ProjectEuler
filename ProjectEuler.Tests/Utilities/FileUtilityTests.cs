using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using ProjectEuler.Domain.Utilities;

namespace ProjectEuler.Tests.Utilities
{
	public class FileUtilityTests
	{
		private FileUtility _fileUtility;
		private string ResourceDirectory => Path.Combine(Directory.GetCurrentDirectory(), "..\\Resources");

		[SetUp]
		public void SetUp()
		{
			_fileUtility = new FileUtility();
		}

		[Test]
		public void GivenReadCsvFile_WhenPopulatedFile_TheListReturned()
		{
			//GivenReadCsvFile
			var actual = _fileUtility.ReadCsvFile(Path.Combine(ResourceDirectory, "csv.txt"));

			//WhenEmptyFile
			//ThenEmptyListReturned
			var values = actual as string[] ?? actual.ToArray();
			Assert.That(values, Has.Count.EqualTo(5));
			Assert.That(values, Has.Exactly(1).EqualTo("LILLIE"));
			Assert.That(values, Has.Exactly(1).EqualTo("CLAUDIA"));
			Assert.That(values, Has.Exactly(1).EqualTo("JACKIE"));
			Assert.That(values, Has.Exactly(1).EqualTo("MARCIA"));
			Assert.That(values, Has.Exactly(1).EqualTo("TANYA"));
		}

		[Test]
		public void GivenReadCsvFile_WhenEmptyFile_ThenEmptyListReturned()
		{
			//GivenReadCsvFile
			var actual = _fileUtility.ReadCsvFile("Resources\\emptyFile.txt");
			//var actual = _fileUtility.ReadCsvFile(Path.Combine(ResourceDirectory, "emptyFile.txt"));

			//WhenEmptyFile
			//ThenEmptyListReturned
			Assert.That(actual, Is.Empty);
		}

		[Test]
		public void GivenReadCsvFile_WhenFileDoesntExist_ThenExceptionThrown()
		{
			//GivenReadCsvFile
			//WhenFileDoesntExist
			//ThenExceptionThrown
			var ex = Assert.Throws<ArgumentException>(() => _fileUtility.ReadCsvFile(ResourceDirectory + "NonExistentFile.txt"));
			Assert.That(ex.Message, Is.EqualTo("File cannot be found"));
		}
	}
}
