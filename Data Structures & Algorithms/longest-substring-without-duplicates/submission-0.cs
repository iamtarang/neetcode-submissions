public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> hSet = new HashSet<char>();

        int l = 0;
        int res = 0;

        for(int i = 0; i < s.Length; i++){
            while (hSet.Contains(s[i])){
                hSet.Remove(s[l]);
                l++;
            }
            hSet.Add(s[i]);
            res = Math.Max(res, i - l + 1);
        }

        return res;
    }
}
