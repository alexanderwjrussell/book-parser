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
	}
}
