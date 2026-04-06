public class Solution {
    public bool IsAnagram(string s, string t) {
        // First, check if lengths are different
        if (s.Length != t.Length) {
            return false;
        }

        // Create dictionaries to count character frequencies
        Dictionary<char, int> s_dict = new Dictionary<char, int>();
        Dictionary<char, int> t_dict = new Dictionary<char, int>();

        // Count character frequencies in s
        for (int i = 0; i < s.Length; i++) {
            // For s string
            if (!s_dict.ContainsKey(s[i])) {
                s_dict[s[i]] = 1;
            } else {
                s_dict[s[i]] += 1;
            }

            // For t string
            if (!t_dict.ContainsKey(t[i])) {
                t_dict[t[i]] = 1;
            } else {
                t_dict[t[i]] += 1;
            }
        }

        // Compare the dictionaries
        foreach (var ch in s_dict) {
            // Check if the character exists in t_dict
            if (!t_dict.ContainsKey(ch.Key)) {
                return false;
            }

            // Check if the frequency matches
            if (ch.Value != t_dict[ch.Key]) {
                return false;
            }
        }

        return true;
    }
}