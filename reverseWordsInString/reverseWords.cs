// Given a string, you need to reverse the order of characters in each word within 
// a sentence while still preserving whitespace and initial word order.
//Ex. Input: "Today is Friday" Output: "yadoT si yadirF"


public string ReverseWords(string s) {
    string[] words = s.Split(" ");
    var result = new StringBuilder();    
    foreach (var word in words)
    {
        for (var i = word.Length - 1; i >= 0; i--) 
        {
            result.Append(word[i]);
        }
        result.Append(" ");
    }
    return result.ToString().Trim();   
}