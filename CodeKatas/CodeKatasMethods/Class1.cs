using System;
using System.Collections.Generic;

namespace CodeKatasMethods
{
	public class CodeKatas
	{
		public static char[] duplicateLetters(string mystring)
		{
			//var string_Array = mystring.ToCharArray();
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
	}
}
