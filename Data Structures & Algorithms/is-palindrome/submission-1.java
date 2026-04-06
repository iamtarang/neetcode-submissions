class Solution {
    public boolean isPalindrome(String s) {
        s = s.replaceAll("\\s", "").replaceAll("[^a-zA-Z0-9]", "").toUpperCase();
        char[] arr = s.toCharArray();
        int maxLen = arr.length;

        for(int i = 0; i < maxLen; i++){
            if(i == maxLen - i - 1){
                if(arr[i] == arr[maxLen - i -1]){
                    return true;
                }
            }
            if(i > maxLen - i - 1){
                return true;
            }
            
            if(arr[i] == arr[maxLen - i -1]){
                    continue;
            } else {
                return false;
            }
        }

        return true;
    }
}
