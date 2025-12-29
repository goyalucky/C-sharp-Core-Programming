using System;

class Program
{
	static void Main(string[] args)
	{
		// Create an object to call the string compression method
		StringCompression sc = new StringCompression();
		sc.CompressString();

		// Create an object to call the reverse string method
		ReverseStringExcept r = new ReverseStringExcept();
		r.ReverseString();
	}
}
