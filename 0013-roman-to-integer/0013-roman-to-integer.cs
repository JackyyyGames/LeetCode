public class Solution {

    public int GetValue(char c) {
        if (c == 'I') return 1;
        if (c == 'V') return 5;
        if (c == 'X') return 10;
        if (c == 'L') return 50;
        if (c == 'C') return 100;
        if (c == 'D') return 500;
        if (c == 'M') return 1000;
        return 0;
    }

    public int RomanToInt(string s) {
        int sum = 0;

        for (int i = 0; i < s.Length; i++) {
            int current = GetValue(s[i]);

            if (i < s.Length - 1 && current < GetValue(s[i + 1])) {
                sum -= current;
            } else {
                sum += current;
            }
        }

        return sum;
    }
}