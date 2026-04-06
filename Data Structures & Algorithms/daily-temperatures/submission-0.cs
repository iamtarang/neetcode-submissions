public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int[]> temps = new Stack<int[]>();
        int[] result = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length; i++) {
            int t = temperatures[i];
            while (temps.Count > 0 && t > temps.Peek()[0]) {
                int[] pair = temps.Pop();
                result[pair[1]] = i - pair[1];
            }

            temps.Push(new int[] {t, i});
        }
        return result;
    }
}
