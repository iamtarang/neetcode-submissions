public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> hashSet = new HashSet<int>();
        int[] ans = new int[2];

        foreach (int num in nums)
        {
            hashSet.Add(num);
        }

        for(int i = 0; i<nums.Length; i++){
            if(hashSet.Contains(target - nums[i])){
                if(Array.IndexOf(nums, target - nums[i]) > i){
                    ans[0] = i;
                    ans[1] = Array.IndexOf(nums, target - nums[i]);
                } else {
                    ans[1] = i;
                    ans[0] = Array.IndexOf(nums, target - nums[i]);
                }
            }
        }

        return ans;
    }
}
