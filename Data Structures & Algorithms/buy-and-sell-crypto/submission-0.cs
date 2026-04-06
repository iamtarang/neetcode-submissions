public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;   // Buy pointer
        int right = 1;  // Sell pointer
        int maxProfit = 0;

        while(right < prices.Length) {
            // If we can make profit
            if(prices[right] > prices[left]) {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            } else {
                // Found a lower price, update buy pointer
                left = right;
            }
            right++;
        }

        return maxProfit;
    }
}