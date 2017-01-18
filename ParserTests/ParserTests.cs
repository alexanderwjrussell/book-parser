using System.Collections.Generic;
using NUnit.Framework;

namespace ParserTests
{
	[TestFixture]
	public class ParserTests
	{
		[TestCase("Charlie.txt", "Charlie and the Chocolate Factory")]
		[TestCase("Cat.txt", "The Cat in the Hat")]
		public void Should_ReturnContentsFromBook_WhenAccessedFromFile(string fileName, string text)
		{
			var parser = new Parser.Parser();

			Assert.That(parser.Read(fileName), Is.Not.Null);
			Assert.That(parser.Read(fileName), Is.EqualTo(text));
		}

		[Test]
		public void Should_CountEachTimeEachWordAppearsInABook()
		{
			var parser = new Parser.Parser();

			var words = new Dictionary<string, int>
			{
				{"The", 1},
				{"Cat", 1},
				{"in", 1},
				{"the", 1},
				{"Hat", 1}
			};

			Assert.That(parser.CountWords("The Cat in the Hat"), Is.EqualTo(words));
		}

		[Test]
		public void Should_CountEachTimeEachWordAppearsInADifferentBook()
		{
			var parser = new Parser.Parser();

			var words = new Dictionary<string, int>
			{
				{"Charlie", 1},
				{"and", 1},
				{"the", 1},
				{"Chocolate", 1},
				{"Factory", 1}
			};

			Assert.That(parser.CountWords("Charlie and the Chocolate Factory"), Is.EqualTo(words));
		}

		[Test]
		public void Should_CountEachTimeEachWordAppearsRandomRepeatedString()
		{
			var parser = new Parser.Parser();

			var words = new Dictionary<string, int>
			{
				{"Test", 3},
				{"test", 3},
				{"TEST", 3},
			};

			Assert.That(parser.CountWords("Test Test test test TEST TEST test Test TEST"), Is.EqualTo(words));
		}
	}
}
