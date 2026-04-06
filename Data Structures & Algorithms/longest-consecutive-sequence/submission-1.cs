public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        
        HashSet<int> hset = new HashSet<int>(nums);
        int maxStreak = 1;
        
        foreach (int num in hset) {
            // Only start checking sequences from the smallest number in the sequence
            if (!hset.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;
                
                // Keep checking for consecutive numbers
                while (hset.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }
                
                maxStreak = Math.Max(maxStreak, currentStreak);
            }
        }
        
        return maxStreak;
    }
}