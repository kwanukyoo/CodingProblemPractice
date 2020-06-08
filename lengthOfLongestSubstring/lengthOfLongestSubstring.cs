// Given a string, find the length of the longest Substring without repeating characters.
// Input : "abcdabcdd" Output : 4 ("abcd")
// Input : "aaaa" Output : 1 ("a")

public static int LengthOfLongestSubstring(string s)
{
    int r = 0;
    int l = 0;
    int result = 0;
    string temp = String.Empty;

    while (r < s.Length)
    {
        char currChar = s[r];

        if (!temp.Contains(currChar) && result <= r - l)
        {
            result = r - l + 1;
        }

        if (temp.Contains(currChar))
        {
            temp = String.Empty;
            l = r;
        }
        temp += currChar;
        r++;
    }
    return result;
}