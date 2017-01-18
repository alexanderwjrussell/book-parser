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
			var words = contents.Split(' ');
			var countedWords = new Dictionary<string, int>();

			foreach (var word in words)
			{
				if (!countedWords.ContainsKey(word))
					countedWords.Add(word, 1);
				else
					countedWords[word] += 1;
			}

			return countedWords;
		}
	}
}
