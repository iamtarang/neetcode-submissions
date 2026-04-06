public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int volume = 0;

        while(left != right){
            int min = Math.Min(heights[left], heights[right]); 
            int amt = (right - left) * min;

            if(amt > volume){
                volume = amt;
            }

            if(heights[left] > heights[right]){
                right--;
            } else {
                left++;
            }
        }

        return volume;
    }
}
