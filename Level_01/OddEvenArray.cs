using System;

class OddEvenArray
{
	public void CheckOddEven()
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int[] odd = new int[n / 2 + 1];
		int[] even = new int[n / 2 + 1];
		int oddidx = 0;
		int eveidx = 0;
		for (int i = 1; i <= n; i++)
		{
			
			if(i%2 == 0)
			{
				even[eveidx] = i;
				eveidx++;
			}
			else
			{
				odd[oddidx] = i;
				oddidx++;
			}
		}
		Console.WriteLine("Odd Numbers:");
		for(int i = 0; i < oddidx; i++)
		{
			Console.WriteLine(odd[i]);
		}
		for(int i = 0;i < eveidx; i++)
		{
			Console.WriteLine(even[i]);
		}
	}
}