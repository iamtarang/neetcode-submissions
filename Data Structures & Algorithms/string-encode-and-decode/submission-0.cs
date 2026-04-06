public class Solution {
    public string Encode(IList<string> strs) {
        if (strs == null) {
            throw new ArgumentNullException(nameof(strs));
        }

        StringBuilder lengths = new StringBuilder();
        StringBuilder content = new StringBuilder();

        foreach (string str in strs) {
            lengths.Append(str?.Length ?? 0).Append(',');
            content.Append(str ?? "");
        }

        return lengths.Append('#').Append(content).ToString();
    }

    public List<string> Decode(string s) {
        if (s == null) {
            throw new ArgumentNullException(nameof(s));
        }

        if (s.Length == 0 || s == "#") {
            return new List<string>();
        }

        var result = new List<string>();
        int delimiterIndex = s.IndexOf('#');
        
        if (delimiterIndex == -1) {
            throw new ArgumentException("Invalid encoded string format: missing delimiter", nameof(s));
        }

        string[] lengths = s.Substring(0, delimiterIndex).Split(',', StringSplitOptions.RemoveEmptyEntries);
        int currentPosition = delimiterIndex + 1;

        foreach (string lengthStr in lengths) {
            if (!int.TryParse(lengthStr, out int length)) {
                throw new ArgumentException($"Invalid length value: {lengthStr}", nameof(s));
            }

            if (currentPosition + length > s.Length) {
                throw new ArgumentException("Invalid encoded string format: string too short", nameof(s));
            }

            result.Add(s.Substring(currentPosition, length));
            currentPosition += length;
        }

        return result;
    }
}