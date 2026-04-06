public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> count = new Dictionary<char, int>();
        int res = 0;

        int l = 0, maxf = 0;
             
        for(int i=0; i < s.Length; i++){
            if(count.ContainsKey(s[i])) {
                count[s[i]]++;
            } else {
                count[s[i]] = 1;
            }

            maxf = Math.Max(maxf, count[s[i]]);

            while ((i - l + 1) - maxf > k){
                count[s[l]]--;
                l++;
            }

            res = Math.Max(res, i - l + 1);
        }

        return res;
    }
}
