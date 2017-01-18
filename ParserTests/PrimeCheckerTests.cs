using NUnit.Framework;

namespace PrimeCheckerTests
{
	[TestFixture]
	public class PrimeCheckerTests
	{
		[TestCase(3, true)]
		public void Should_IdentifyIfNumberIsPrime(int number, bool result)
		{
			var primeChecker = new Parser.PrimeChecker();

			Assert.That(primeChecker.IsPrime(number), Is.EqualTo(result));
		}
	}
}
