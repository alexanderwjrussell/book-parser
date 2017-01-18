using NUnit.Framework;

namespace PrimeCheckerTests
{
	[TestFixture]
	public class PrimeCheckerTests
	{
		[TestCase(2, true)]
		[TestCase(3, true)]
		[TestCase(4, false)]
		[TestCase(5, true)]
		[TestCase(6, false)]
		[TestCase(7, true)]
		[TestCase(1123, true)]
		public void Should_IdentifyIfNumberIsPrime(int number, bool result)
		{
			var primeChecker = new Parser.PrimeChecker();

			Assert.That(primeChecker.IsPrime(number), Is.EqualTo(result));
		}
	}
}
