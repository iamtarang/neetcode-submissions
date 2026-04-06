public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> numCount = new Dictionary<int, int>();

        foreach(int num in nums){
            if(numCount.ContainsKey(num)){
                numCount[num] += 1;
            } else {
                numCount.Add(num, 1);
            }
        }

         // Create result array
        int[] res = new int[k];
        int index = 0;
        
        // Take top k elements by frequency
        foreach (var item in numCount.OrderByDescending(key => key.Value)) {
            if (index >= k) break;
            res[index] = item.Key;
            index++;
        }
        
        return res;
    }
}
