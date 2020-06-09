# Given a list of strings words representing an English Dictionary, find the longest word in words that can be built one character at a time by other words in words. 
# If there is more than one possible answer, return the longest word with the smallest lexicographical order.
# Ex. Input : ["w","wo","wor","worl", "world"] Output : "world"
# Ex. Input : ["a", "banana", "app", "appl", "ap", "apply", "apple"] Output : "apple"

def longest_word_in_dictionary(array_words):
    array_words.sort()
    str_set = set()
    str_result = ""
    for word in enumerate(array_words):        
        # wordSubstring = word[0:len(word)-1]
        if (str_set.__contains__(word[0:len(word)-1]) == True or len(word) == 1):
            str_result = word if len(word) > len(str_result) else str_result
            str_set.add(word)

    print(str_result)
    return str_result


# Test
longest_word_in_dictionary(["w","wo","wor","worl", "world"])
longest_word_in_dictionary(["a", "banana", "app", "appl", "ap", "apply", "apple"])