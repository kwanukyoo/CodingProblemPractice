    // Given a list of strings words representing an English Dictionary, find the longest word in words that can be built one character at a time by other words in words. 
    // If there is more than one possible answer, return the longest word with the smallest lexicographical order.
    // Ex. Input : ["w","wo","wor","worl", "world"] Output : "world"
    // Ex. Input : ["a", "banana", "app", "appl", "ap", "apply", "apple"] Output : "apple"

    public string LongestWord(string[] words) {
        Array.Sort(words);
        var result = String.Empty;
        var possAns = new HashSet<string>();
        
        foreach (var word in words) {
            if (word.Length == 1 || possAns.Contains(word.Substring(0, word.Length - 1))) {
                if (word.Length > result.Length) result = word;
                possAns.Add(word);
            }
        }
        return result;
    }