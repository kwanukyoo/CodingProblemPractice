# This is first none repeating character problem sovled in python
# question : find first non repeating character, return '_' if nothing found
# Ex. abccdddefg return 'a'
# Finding first non repeating character in a string in O(N) time complexity
def firstNonRepeatingCharacter(word):    
    dictionary = {}
    # Fill in dictionary charac, numOfCharacter pair O(N)
    for character in word:
        if character in dictionary:
            dictionary[character] = dictionary[character] + 1
        else:
            dictionary[character] = 1

    # Iterate through word again O(N) but with lookup table which is dictinoary O(1)        
    for character in word:        
        if dictionary.get(character) == 1:    
            print(character)        
            return character
    
    # If not found, return '_'
    print('_')
    return '_'
        

# Test        
firstNonRepeatingCharacter("aabcdd")
firstNonRepeatingCharacter("aabbcdef")
firstNonRepeatingCharacter("abccdd")
firstNonRepeatingCharacter("aabbcc")


