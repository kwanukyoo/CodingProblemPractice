# With sorted array of integers write a function that returns a sorted array containing the squares of those integers
# Ex. [-4, -2, 1, 3] => [1, 4, 9, 16]
# Ex. [-6, -4, 1, 2, 3, 5] => [1, 4, 9, 16, 25, 36]
# Ex. [-7, -3, -1, 4, 8, 12] => [1, 9, 16, 49, 64, 144]

# O(N) Solution
def sorted_squared_array(sorted_array):
    # Initialize fix sized array
    result_array = ["none"] * len(sorted_array)
    result_array_index = len(result_array) - 1

    # Set counter index
    left_index = 0
    right_index = len(sorted_array) - 1
    
    for int_num in sorted_array:
        if abs(sorted_array[left_index]) > sorted_array[right_index]:
            result_array[result_array_index] = abs(sorted_array[left_index]) * abs(sorted_array[left_index])
            result_array_index = result_array_index - 1
            left_index = left_index + 1
        else:
            result_array[result_array_index] = abs(sorted_array[right_index]) * abs(sorted_array[right_index])
            result_array_index = result_array_index - 1
            right_index = right_index - 1

    print(result_array)            
    return result_array            


# TEST
sorted_squared_array([-4, -2, 1, 3])
sorted_squared_array([-6, -4, 1, 2, 3, 5])        
sorted_squared_array([-7, -3, -1, 4, 8, 12])    