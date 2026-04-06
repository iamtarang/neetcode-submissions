public class Solution {
    public int FindMin(int[] nums) {
        int start = 0;  // Index, not value
        int end = nums.Length - 1;  // Index, not value
        int res = nums[0];
        
        while(start <= end) {
            // If this portion is sorted, minimum is at start
            if(nums[start] <= nums[end]) {
                res = Math.Min(res, nums[start]);
                break;
            }

            int mid = start + (end - start) / 2;
            res = Math.Min(res, nums[mid]);
            
            // Check which half is sorted
            if(nums[mid] >= nums[start]) {
                // Left half is sorted, minimum must be in right half
                start = mid + 1;
            } else {
                // Right half is sorted, minimum must be in left half
                end = mid - 1;
            }
        }

        return res;
    }
}