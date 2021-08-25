using NUnit.Framework;
using CodeKatasMethods;
using System;

namespace CodeKatasTests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[TestCase(("sAmuurai"), new char[] { 'a', 'u' })]
		[TestCase(("biing  "), new char[] { 'i', ' ' })]
		[TestCase(("all work and no play"), new char[] { 'a', 'l', 'o', 'n', ' ' })]
		[TestCase(("Nishant Mandal"), new char[] { 'n', 'a' })]
		[Category("DuplicateLetters")]
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

		//FibonacciSummerUpper Tests

		[TestCase(1,1)]
		[TestCase(0, 0)]
		[TestCase(3, 4)]
		[TestCase(15, 1596)]
		[TestCase(5, 12)]
		public void givenARangeOfValues_FibonacciSummerUpper_Returns_ExpectedOutput(int n, long sum)
		{
			var expectedsum = sum;
			var resultsum = CodeKatas.FibonacciSummerUpper(n);
			Assert.That(expectedsum, Is.EqualTo(resultsum));
		}

		//[TestCase(0)]
		[TestCase(-10)]
		public void givenZeroOrANumberLessThan_FibonacciSummerUpper_ThowsException(int n)
		{
			Assert.That(() => CodeKatas.FibonacciSummerUpper(n), Throws.TypeOf<ArgumentOutOfRangeException>());
			/*
			try
			{
				CodeKatas.FibonacciSummerUpper(n);
				Assert.Fail();
			}
			catch (ArgumentOutOfRangeException e)
			{
				Assert.Pass();
			}
			*/
		}

	}
}