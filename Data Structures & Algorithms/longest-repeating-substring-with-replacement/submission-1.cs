public class Solution {
    public int CharacterReplacement(string s, int k) {

        Dictionary<char, int> count = new Dictionary<char, int>();
        int res = 0;

        int l = 0, maxf = 0;
             
        for(int i=0; i < s.Length; i++){
            // check for char in hmap
            if(count.ContainsKey(s[i])) {
                // increment if found
                count[s[i]]++;
            } else {
                // initialize with 1 if not
                count[s[i]] = 1;
            }

            // max freq is higher of maxf and no. of times that char appears
            maxf = Math.Max(maxf, count[s[i]]);

            // while diff of r - l is > k
            while ((i - l + 1) - maxf > k){
                // decrement the count of char where L is pointing
                count[s[l]]--;
                // move the pointer ahead
                l++;
            }

            // res would be higher btwn res and diff
            res = Math.Max(res, i - l + 1);
        }

        return res;
    }
}
