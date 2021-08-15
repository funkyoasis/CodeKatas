using System;
using System.Collections.Generic;

namespace CodeKatas
{
	public class CodeKatas
	{
		//create a method that reads a string then returns an array of duplicate characters

		public static char[] duplicateLetters(string mystring)
		{
			//var string_Array = mystring.ToCharArray();
			var duplicate_Array = new char[50];
			var duplicate_list = new List<char>();
			foreach (var chara in mystring)
			{
				if (duplicate_list.Contains(chara) == false)
				{
					duplicate_list.Add(chara);
				}
				
			}
			for (int i =0; i<=duplicate_list.Count-1; i++)
			{
				duplicate_Array.SetValue(duplicate_list[i], i);
			}
			return duplicate_Array;
		



		}
	}
}
