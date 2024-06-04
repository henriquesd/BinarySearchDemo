namespace BinarySearchDemo.Tests
{
    public class BinarySearchTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void FindExactValueApproach_ShouldReturnIndexOfTargetElement(int[] inputArray, int searchedNumber, int? expectedPosition)
        {
            var result = BinarySearch.FindExactValueApproach(inputArray, searchedNumber);

            Assert.Equal(expectedPosition, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void FindRecursiveApproach_ShouldReturnIndexOfTargetElement(int[] inputArray, int searchedNumber, int? expectedPosition)
        {
            var result = BinarySearch.FindRecursiveApproach(inputArray, searchedNumber, 0, inputArray.Length -1);

            Assert.Equal(expectedPosition, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTestUpperBoundApproach))]
        public void FindUpperBoundApproach_ShouldReturnUpperIndexOfTargetElement(int[] inputArray, int searchedNumber, int? expectedPosition)
        {
            var result = BinarySearch.FindUpperBoundApproach(inputArray, searchedNumber);

            Assert.Equal(expectedPosition, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTestLowerBoundApproach))]
        public void FindLowerBoundApproach_ShouldReturnLowerIndexOfTargetElement(int[] inputArray, int searchedNumber, int? expectedPosition)
        {
            var result = BinarySearch.FindLowerBoundApproach(inputArray, searchedNumber);

            Assert.Equal(expectedPosition, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 0 }; // First element;
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, 8 }; // Last element;
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 15, -1 }; // Element not found;
            yield return new object[] { new int[] { -10, -5, 0, 5, 10 }, -10, 0 }; // Negative numbers;
            yield return new object[] { new int[] { }, 3, -1 }; // Empty array
            yield return new object[] { new int[] { 3 }, 3, 0 }; // Single element array
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4, 3 }; // Middle element;
            yield return new object[] { new int[] { 3, 7, 12, 16, 19, 25, 29, 32, 37 }, 12, 2 }; // Random;
        }

        public static IEnumerable<object[]> ValuesToTestLowerBoundApproach()
        {
            yield return new object[] { new int[] { 3, 3, 3, 7, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 37 }, 3, 0 }; // First element;
            yield return new object[] { new int[] { 3, 3, 3, 7, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 37, 37, 37 }, 37, 15 }; // Last element;
            yield return new object[] { new int[] { 3, 7, 12, 12, 12, 12, 16, 19, 25, 29, 32, 37 }, 13, -1 }; // Element not found;
            yield return new object[] { new int[] { -10, -10, -5, -5, 0, 0, 5, 5, 10, 15 }, -5, 2 }; // Negative number;
            yield return new object[] { new int[] { }, 3, -1 }; // Empty array
            yield return new object[] { new int[] { 3 }, 3, 0 }; // Single element array
            yield return new object[] { new int[] { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9 }, 4, 3 }; // Duplicated middle element;
            yield return new object[] { new int[] { 3, 3, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 32, 32, 37 }, 12, 3 }; // Near middle number with multiple duplicates;
            yield return new object[] { new int[] { 3, 7, 12, 16, 19, 25, 29, 32, 37 }, 12, 2 }; // No duplicate numbers;
        }

        public static IEnumerable<object[]> ValuesToTestUpperBoundApproach()
        {
            yield return new object[] { new int[] { 3, 3, 3, 7, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 37 }, 3, 2 }; // First element;
            yield return new object[] { new int[] { 3, 3, 3, 7, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 37, 37, 37 }, 37, 17 }; // Last element;
            yield return new object[] { new int[] { 3, 7, 12, 12, 12, 12, 16, 19, 25, 29, 32, 37 }, 13, -1 }; // Element not found;
            yield return new object[] { new int[] { -10, -10, -5, -5, 0, 0, 5, 5, 10, 15 }, -5, 3 }; // Negative number;
            yield return new object[] { new int[] { }, 3, -1 }; // Empty array
            yield return new object[] { new int[] { 3 }, 3, 0 }; // Single element array
            yield return new object[] { new int[] { 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 9 }, 4, 5 }; // Duplicated middle element;
            yield return new object[] { new int[] { 3, 3, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 32, 32, 37 }, 12, 6 }; // Near middle number with multiple duplicates;
            yield return new object[] { new int[] { 3, 7, 12, 16, 19, 25, 29, 32, 37 }, 12, 2 }; // No duplicate numbers;
        }
    }
}