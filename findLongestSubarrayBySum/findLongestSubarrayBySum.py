# With array of numbers (not sorted) and a number of sum, write a function that finds the longest subarray within the array
# Return left and right bounds of the subarray, if there is no sum found return [-1]
# Ex. int_array = [1, 2, 4, 7, 6], int_sum = 13, result = [2, 4]

# O(N) solution, Window Sliding Technique
def find_longest_subarray_by_sum(int_array, int_sum):
    result = [-1]
    total_sum = 0
    left_index = 0
    right_index = 0
    while right_index < len(int_array):
        total_sum += int_array[right_index]
        while left_index < right_index and total_sum > int_sum:
            total_sum -= int_array[left_index]
            left_index += 1
        if (total_sum == int_sum and (len(result) == 1 or (right_index - left_index) > (result[1] - result[0] -1))):
            result = [left_index + 1, right_index + 1]
        
        right_index += 1
    
    print(result)
    return result


find_longest_subarray_by_sum([1, 2, 4, 7, 6], 13)
find_longest_subarray_by_sum([1, 2, 3, 4, 0, 0, 0, 6, 7, 8, 9, 10], 15)
find_longest_subarray_by_sum([1, 3], 4)
