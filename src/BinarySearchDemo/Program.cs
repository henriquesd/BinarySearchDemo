using BinarySearchDemo;

var nums = new int[] { 3, 7, 12, 16, 19, 25, 29, 32, 37 };
var numsWithDuplicates = new int[] { 3, 3, 7, 12, 12, 12, 12, 16, 19, 19, 25, 29, 32, 32, 32, 37 };
var target = 12;

var findExactValueApproachResult = BinarySearch.FindExactValueApproach(nums, target);
var findRecursiveApproachResult = BinarySearch.FindRecursiveApproach(nums, target, 0, nums.Length - 1);
var findLowerBoundApproachResult = BinarySearch.FindLowerBoundApproach(numsWithDuplicates, target);
var findUpperBoundApproachResult = BinarySearch.FindUpperBoundApproach(numsWithDuplicates, target);

Console.WriteLine($"{nameof(nums)}: {string.Join(", ", nums)}");
Console.WriteLine($"{nameof(numsWithDuplicates)}: {string.Join(", ", numsWithDuplicates)}");
Console.WriteLine($"{nameof(target)}: {target}");
Console.WriteLine();
Console.WriteLine($"Find Exact Value Approach - Index: {findExactValueApproachResult}");
Console.WriteLine($"Find Recursive Approach - Index: {findRecursiveApproachResult}");
Console.WriteLine($"Find Lower Bound Approach - Index: {findLowerBoundApproachResult}");
Console.WriteLine($"Find Upper Bound Approach - Index: {findUpperBoundApproachResult}");