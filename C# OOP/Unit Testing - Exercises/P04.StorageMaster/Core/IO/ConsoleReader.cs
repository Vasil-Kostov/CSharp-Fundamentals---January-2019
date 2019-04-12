namespace P04.StorageMaster.Core.IO
{
	using System;
	using Contracts;

	public class ConsoleReader : IReader
	{
		public string ReadLine()
		{
			return Console.ReadLine();
		}
	}
}