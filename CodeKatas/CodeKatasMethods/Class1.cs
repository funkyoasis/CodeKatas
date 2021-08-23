using System;
using System.Collections.Generic;

namespace CodeKatasMethods
{
	public class CodeKatas
	{
		//returns an array of duplicate characters, spaces included.
		public static char[] duplicateLetters(string input)
		{
			var mystring = input.ToLower();
			var a_list = new List<char>();
			var duplicate_list = new List<char>();
			var duplicates_list2 = new List<char>();
			foreach (var chara in mystring)
			{
				if (duplicate_list.Contains(chara) == false)
				{
					duplicate_list.Add(chara);

				}
				else
				{
					if (duplicates_list2.Contains(chara))
					{
						break;
					}
					else duplicates_list2.Add(chara);
				}
				

			}
			var duplicate_Array = duplicates_list2.ToArray();
			return duplicate_Array;




		}
		public static long FibonacciSummerUpper(int n)
		{
			if (n <= 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			long sum = 0;
			var doubleArray = new long[2] {0,1};
			for (int i = 1; i <= n; i++)
			{
				long newValue = doubleArray[0] + doubleArray[1];
				long oldValue = doubleArray[1];
				doubleArray[0] = oldValue;
				doubleArray[1] = newValue;
				sum += oldValue;
			}
			return sum;
		}
	}
}
