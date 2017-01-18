using System;
namespace Parser
{
	public class Parser
	{
		public string Read(string fileName)
		{
			return System.IO.File.ReadAllText(fileName);
		}
	}
}
