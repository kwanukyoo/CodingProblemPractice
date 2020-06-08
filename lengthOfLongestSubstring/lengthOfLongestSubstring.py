# Given a string, find the length of the longest Substring without repeating characters.
# Input : "abcdabcdd" Output : 4 ("abcd")
# Input : "aaaa" Output : 1 ("a")


def len_of_longest_substring(word):
    int_longest = 0
    current_word = ""
    r = 0
    l = 0

    while(r < len(word)):
        if(len(word) == 1):
            int_longest = 1

        if (r > 0 and current_word.__contains__(word[r])):
            if (int_longest < r - l):
                int_longest = r - l
            l = r
            current_word = ""
        current_word = current_word + word[r]
        r = r + 1
        
    print(int_longest)
    return int_longest

# Test
len_of_longest_substring("abcdabcdd")
len_of_longest_substring("aaaa")
len_of_longest_substring("a")

        


        
