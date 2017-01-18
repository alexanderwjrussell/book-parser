using NUnit.Framework;
using System;
using Parser;
namespace ParserTests
{
	[TestFixture]
	public class ParserTests
	{
		[Test]
		public void Should_ReturnContentsFromBook_WhenAccessedFromFile()
		{
			var parser = new Parser.Parser();

			Assert.That(parser.Read("Cat.txt"), Is.Not.Null);
		}
	}
}
