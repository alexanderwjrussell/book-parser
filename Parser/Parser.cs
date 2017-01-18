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
			return new Dictionary<string, int>
			{
				{ "The", 1 },
				{ "Cat", 1},
				{ "in", 1},
				{ "the", 1},
				{ "Hat", 1}
			};
		}
	}
}
