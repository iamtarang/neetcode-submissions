public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] sufix = new int[nums.Length];
        int[] res = new int[nums.Length];
        
        int prefProd = 1;
        for(int i = 0; i<nums.Length; i++){
            if(i == 0){
                prefix[i] = prefProd;                
            } else {
                prefProd=prefProd*nums[i-1];    
                prefix[i]=prefProd;
            }
        }
        
        int sufixProd = 1;
        for(int i = nums.Length-1; i>=0; i--){
            if(i == nums.Length-1){
                sufix[i] = sufixProd;                
            } else {
                sufixProd = sufixProd*nums[i+1];                
                sufix[i] = sufixProd;                
            }
        }

         for(int i = 0; i<nums.Length; i++){
            res[i] = prefix[i] * sufix[i];
        }   

        return res;
    }
}
