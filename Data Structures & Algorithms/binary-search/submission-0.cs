public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
		int end = nums.Length - 1;
		while (start <= end) {

			// * finding the mid element

			// ! might exceed the range of integer
			// ? int mid = (start + end) / 2;

			// * Hence
			int mid = start + (end - start) / 2;

			if (target < nums[mid]) {
				end = mid - 1;
			} else if (target > nums[mid]) {
				start = mid + 1;
			} else {
				return mid;
			}
		}

		return -1;
    }
}
