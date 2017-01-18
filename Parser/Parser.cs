using System;
using System.Collections.Generic;

namespace Parser
{
	public class Parser
	{
		public string Read(string fileName)
		{
			return System.IO.File.ReadAllText(fileName);
		}

		public Dictionary<string, int> CountWords(string contents)
		{
			throw new NotImplementedException();
		}
	}
}
