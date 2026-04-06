public class Solution {
    public int Search(int[] nums, int target) {
        int start = 0;
        int end = nums.Length - 1;
        int pivot = findPivot(nums); 

        // Array is not rotated
        if(pivot == -1){
            return binarySearch(nums, target, start, end);
        }

        // Check if pivot itself is the target
        if(nums[pivot] == target){
            return pivot;
        }

        // Search in the appropriate half
        if(target >= nums[0]){
            return binarySearch(nums, target, 0, pivot - 1);
        }
        
        return binarySearch(nums, target, pivot + 1, nums.Length - 1);
    }

    public int binarySearch(int[] nums, int target, int start, int end){
        while (start <= end) {
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

    public int findPivot(int[] nums){
        int start = 0;
        int end = nums.Length - 1;

        while(start <= end) {
            int mid = start + (end - start) / 2;

            if(mid < end && nums[mid] > nums[mid + 1]){
                return mid;
            }
            if(mid > start && nums[mid] < nums[mid - 1]){
                return mid - 1;
            }
            if(nums[mid] <= nums[start]){
                end = mid - 1;
            } else {
                start = mid + 1;
            }
        }
        return -1;
    }
}