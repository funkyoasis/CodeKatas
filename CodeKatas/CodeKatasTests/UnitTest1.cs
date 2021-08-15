using NUnit.Framework;
using CodeKatasMethods;
namespace CodeKatasTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(("samuurai"), new char[] {'a','u'})]
		[TestCase(("biing  "), new char[] {'i',' '})]
		[TestCase(("all work and no play"), new char[] {'a','l','o','n',' '})]
		public void givenAString_DuplicateLetters_Returns_Correct_ArrayOfDuplicates(string my_string, char[] my_array)
		{
			var result_array = CodeKatas.duplicateLetters(my_string);
			var expected_array = my_array;
			//Assert.That(result_array, Is.EqualTo(expected_array));
			foreach (char chara in result_array)
			{
				Assert.That(expected_array, Contains.Item(chara));
			}
			
		}


	}
}