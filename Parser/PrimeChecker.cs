namespace Parser
{
	public class PrimeChecker
	{
		public bool IsPrime(int number)
		{
			if (number == 1) return false;
			if (number == 2) return true;

			if (number % 2 == 0) return false; //Even number     

			for (int i = 3; i < number; i += 2)
			{
				if (number % i == 0) return false;
			}

			return true;
		}
	}
}
