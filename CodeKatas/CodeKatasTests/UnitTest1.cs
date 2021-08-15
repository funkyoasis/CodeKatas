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

		[TestCase(("samurai"), new char[] {'a'})]
		[TestCase(("biing  "), new char[] {'i',' '})]
		public void givenAString_DuplicateLetters_Returns_Correct_ArrayOfDuplicates(string my_string, char[] my_array)
		{
			var result_array = CodeKatas.duplicateLetters(my_string);
			var expected_array = my_array;
			Assert.That(result_array, Is.EqualTo(expected_array));
		}


	}
}