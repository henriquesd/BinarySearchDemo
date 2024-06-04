namespace BinarySearchDemo
{
    public static class BinarySearch
    {
        public static int FindExactValueApproach(int[] nums, int target)
        {
            // Initialize the left and right pointers for the search range;
            var left = 0;
            var right = nums.Length - 1;

            // Perform binary search as long as the search range is valid;
            while (left <= right)
            {
                // Calculate the middle index of the current search range;
                // Continuously divide the search range in half until the target element is found or the search range becomes empty;
                var middle = left + (right - left) / 2; // It avoids potential overflow errors that might occur if simply calculating (left + right) / 2 when dealing with large arrays or very large integer values;

                // If the middle element is the target, return its index;
                if (nums[middle] == target) return middle;

                // If the target is greater than the middle element, search the right half;
                if (nums[middle] < target) left = middle + 1;

                // If the target is smaller than the middle element, search the left half;
                if (nums[middle] > target) right = middle - 1;
            }

            // If the target is not found, return -1;
            return -1;
        }

        public static int FindRecursiveApproach(int[] nums, int target, int left, int right)
        {
            // If the search range is invalid, return -1;
            if (left > right) return -1;

            // Calculate the middle index of the current search range;
            var middle = left + (right - left) / 2;

            // If the middle element is the target, return its index;
            if (nums[middle] == target) return middle;

            // If the target is greater than the middle element, search the right half;
            if (nums[middle] < target)
            {
                return FindRecursiveApproach(nums, target, middle + 1, right);
            }
            // If the target is smaller than the middle element, search the left half;
            else
            {
                return FindRecursiveApproach(nums, target, left, middle - 1);
            }
        }

        public static int FindLowerBoundApproach(int[] nums, int target)
        {
            // Initialize the left and right pointers for the search range;
            var left = 0;
            var right = nums.Length;

            // Continue the loop as long as the left boundary is less than the right boundary;
            while (left < right)
            {
                // Calculate the middle index of the current search range;
                var middle = left + (right - left) / 2;

                // If the middle element is greater than or equal to the target,
                // move the right boundary to middle;
                if (nums[middle] >= target)
                {
                    right = middle;
                }
                // If the middle element is less than the target,
                // move the left boundary to the right of middle;
                else
                {
                    left = middle + 1;
                }
            }

            // After exiting the loop, check if the left boundary element is equal to the target;
            if (left < nums.Length && nums[left] == target)
            {
                return left;
            }
            // If the target is not found, return -1;
            else
            {
                return -1;
            }
        }

        public static int FindUpperBoundApproach(int[] nums, int target)
        {
            // Initialize the left and right pointers for the search range;
            var left = 0;
            var right = nums.Length;

            // Continue the loop as long as the left boundary is less than the right boundary;
            while (left < right)
            {
                // Calculate the middle index of the current search range;
                var middle = left + (right - left) / 2;

                // If the middle element is less than or equal to the target,
                // move the left boundary to the right of middle;
                if (nums[middle] <= target)
                {
                    left = middle + 1;
                }
                // If the middle element is greater than the target,
                // move the right boundary to the middle;
                else
                {
                    right = middle;
                }
            }

            // After exiting the loop, check if the element just before the left boundary
            // is equal to the target. If so, return its index;
            if (left > 0 && nums[left - 1] == target)
            {
                return left - 1;
            }
            // If the target is not found, return -1;
            else
            {
                return -1;
            }
        }
    }
}