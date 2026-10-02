public class Solution {
    public bool IsPalindrome(int x) {
        string textnumber = x.ToString();
        char[] number = textnumber.ToCharArray();
        for (int i = 0; i < number.Length/2; i++)
        {
            if (number[i] != number[number.Length-1-i])
            {
                return false;
            }
        }
        return true;
        
    }
}