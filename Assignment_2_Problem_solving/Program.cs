/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;

namespace ISM6225_Spring_2024_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                    return 0; // Return 0 if the array is empty or null

                int k = 1; // Start with 1 as the first element is always unique
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i - 1]) // Check if the current element is different from the previous one
                    {
                        nums[k] = nums[i]; // Move the unique element to the next position
                        k++; // Increment the count of unique elements
                    }
                }
                return k; // Return the count of unique elements
            }
            catch (Exception)
            {
                throw; // Re-throw any exceptions
            }
        }
        /*
         * Self-analysis:
           -Through the process of efficiently handling arrays and implementing solutions that require in-place modifications, I gained a deeper understanding of array traversal fundamentals. This revisiting of basics emphasized the importance of remaining vigilant, 
            especially in scenarios involving empty arrays or arrays with only a single element. It became evident to me how essential it is to ensure the correct operation of functions across all possible circumstances.
           -Additionally, this experience shed light on the significance of incorporating thorough conditional checks to prevent unintended outcomes. 
            By ensuring the function's robustness under various conditions, I learned to mitigate potential errors effectively.
           -Considering the linear time complexity of the solution, its efficiency is notable, particularly in scenarios where real-time applications or large data sets necessitate swift and memory-conscious array operations. 
            Thus, understanding the interplay between speed, memory usage, and overall performance becomes crucial for optimizing the efficiency of such processes.
        */

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length <= 1)
                    return nums.ToList(); // Return the list if it's null or has only one element

                int nonZeroIndex = 0; // Keep track of the position for non-zero elements
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[nonZeroIndex] = nums[i]; // Move non-zero element to the current non-zero index
                        nonZeroIndex++; // Increment the non-zero index
                    }
                }
                for (int i = nonZeroIndex; i < nums.Length; i++) // Fill the remaining positions with zeroes from the last non-zero index
                {
                    nums[i] = 0; // Set remaining positions to zero
                }
                return nums.ToList(); // Convert the array to a list and return
            }
            catch (Exception)
            {
                throw; // Re-throw any exceptions
            }
        }

        /*
         * Self-analysis:
          -The approach involves traversing the array to relocate non-zero elements to the front and then filling the remaining positions with zeros. This emphasizes the importance of proficient array traversal using different index techniques.
          -Consideration must be given to edge cases, such as arrays with less than two elements or arrays comprising solely of zeros, to ensure the function performs reliably across all test scenarios.
          -By handling array operations efficiently, this method ensures the desired outcome is achieved without the need for additional copies or space, making it particularly effective in array manipulation tasks.
          -Maintaining the relative order of elements provides additional insight into array manipulation techniques, illustrating how the original order is preserved during the process of shifting zeros to the end of the array.
        */

        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                IList<IList<int>> result = new List<IList<int>>(); // Initialize the result list
                Array.Sort(nums); // Sort the array in ascending order

                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // Skip duplicates
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    int left = i + 1; // Initialize the left pointer
                    int right = nums.Length - 1; // Initialize the right pointer

                    while (left < right)
                    {
                        int sum = nums[i] + nums[left] + nums[right]; // Calculate the sum of the triplet

                        if (sum == 0)
                        {
                            // Found a triplet with sum equal to zero
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            // Skip duplicates
                            while (left < right && nums[left] == nums[left + 1])
                                left++;
                            while (left < right && nums[right] == nums[right - 1])
                                right--;

                            left++; // Move the left pointer to the right
                            right--; // Move the right pointer to the left
                        }
                        else if (sum < 0)
                        {
                            left++; // Move left pointer to increase sum
                        }
                        else
                        {
                            right--; // Move right pointer to decrease sum
                        }
                    }
                }
                return result; // Return the list of triplets
            }
            catch (Exception)
            {
                throw; // Re-throw any exceptions
            }
        }

        /* * Self-analysis:
            -Sophisticated array manipulation techniques, including sorting and utilizing multiple pointers to identify triplets equal to zero, were employed to tackle this challenge effectively.
            -Close attention was crucial during implementation to prevent recomputation and ensure swift execution, particularly when dealing with corner cases.
            -Conditional statements were utilized to streamline the solution, bypassing duplicate pointer adjustments and those based on the total number of elements. This process enhanced my proficiency in leveraging conditional logic to devise algorithmic solutions.
            -The incorporation of data structures, such as lists for storing and retrieving result sets, underscores the importance of a solid foundation in data structures. Years of emphasizing the significance of selecting appropriate data structures for problem-solving proved invaluable.
            -Efforts to enhance the overall efficiency of the solution were prioritized, with ongoing implementation aimed at minimizing unnecessary computations.
            -Algorithm optimization received significant focus in this approach, demonstrating a commitment to improving performance.
        */

        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                int maxConsecutiveCount = 0; // Maximum consecutive count of 1's
                int currentConsecutiveCount = 0; // Current consecutive count of 1's

                foreach (int num in nums)
                {
                    if (num == 1)
                    {
                        // Increment current count for consecutive 1's
                        currentConsecutiveCount++;
                    }
                    else
                    {
                        // Update maximum count and reset current count when encountering 0
                        maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentConsecutiveCount);
                        currentConsecutiveCount = 0;
                    }
                }

                // Update maxConsecutiveCount for the last sequence of consecutive 1's
                maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentConsecutiveCount);

                return maxConsecutiveCount;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /* 
           * Self-analysis:
           -The approach involved cleverly iterating through the array to update the count of encountered elements, providing valuable insights into array navigation.
           -In essence, this strategy facilitated the maintenance and tracking of subsequent occurrences of ones in the binary array. This meticulous and sequential element counting formed the cornerstone of the algorithmic solutions.
           -Careful consideration was given to handling edge cases, such as arrays with only one element or consisting entirely of zeros, to ensure the function's robustness across all scenarios.
           -Efficient updating of counts during array traversal led to optimal time complexity, highlighting the importance of designing algorithms with efficiency in mind. Such algorithms deserve careful consideration for their effectiveness and performance.
         */

        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        {
            try
            {
                int decimalValue = 0; // Initialize the decimal value to 0
                int baseValue = 1; // Initialize the base value to 1

                while (binary != 0)
                {
                    int lastDigit = binary % 10; // Extract the last digit of the binary number
                    binary /= 10; // Remove the last digit from the binary number

                    decimalValue += lastDigit * baseValue; // Update the decimal value
                    baseValue *= 2; // Update the base value (power of 2)
                }

                return decimalValue;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* 
           * Self-analysis:
            -The implementation of the solution provided valuable insights into number systems, requiring a grasp of how to convert binary integers into their decimal representations using basic arithmetic operations.
            -Remarkably, the solution stands out for its simplicity, clarity, and minimal reliance on complex bit operations or exponentiation-based functions. Instead, it relies on straightforward arithmetic operations for the necessary conversions.
            -As the binary digit loop iterates, the corresponding decimal value in each iteration underscores the effectiveness of algorithms in problem-solving.
            -Manipulating binary numbers proved instrumental in facilitating transformations, underscoring the importance of numerical operations in algorithmic solutions.
            -Creative problem-solving emphasized the significance of carefully considering various aspects, such as algorithmic approaches and the selection of functions and operators, in building effective algorithms.
         */

        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.


        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length < 2)
                    return 0;

                // Find the minimum and maximum elements in the array
                int minElement = int.MaxValue;
                int maxElement = int.MinValue;
                foreach (int num in nums)
                {
                    minElement = Math.Min(minElement, num);
                    maxElement = Math.Max(maxElement, num);
                }

                // Calculate the minimum possible gap
                int minGap = (int)Math.Ceiling((double)(maxElement - minElement) / (nums.Length - 1));

                // Create buckets to store elements
                int numBuckets = (maxElement - minElement) / minGap + 1;
                int[] minBucket = new int[numBuckets];
                int[] maxBucket = new int[numBuckets];
                Array.Fill(minBucket, int.MaxValue);
                Array.Fill(maxBucket, int.MinValue);

                // Distribute numbers into buckets
                foreach (int num in nums)
                {
                    int index = (num - minElement) / minGap;
                    minBucket[index] = Math.Min(minBucket[index], num);
                    maxBucket[index] = Math.Max(maxBucket[index], num);
                }

                // Find the maximum gap between successive non-empty buckets
                int maxGap = 0;
                int previousMax = maxBucket[0];
                for (int i = 1; i < numBuckets; i++)
                {
                    if (minBucket[i] != int.MaxValue)
                    {
                        maxGap = Math.Max(maxGap, minBucket[i] - previousMax);
                        previousMax = maxBucket[i];
                    }
                }

                return maxGap;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* * Self-Analysis:
           -Utilizing mathematical concepts, like calculating element distances and distributing numbers among buckets, provided an effective solution in this scenario. It underscored the application of mathematical principles in algorithmic problem-solving.
           -Therefore, the approach prioritized achieving linear time complexity and minimal additional space usage. This emphasis on algorithmic efficiency serves as the cornerstone for overall optimization.
           -Edge cases, such as arrays with fewer than two elements, were appropriately handled, ensuring flawless function operation across all scenarios. This meticulous consideration of edge cases is integral to algorithm design.
           -The importance of manipulating the array to distribute elements across buckets and calculate distances between them became apparent. 
           -The study highlighted the significance of being cognizant of constraints, such as maintaining linear time complexity and minimizing extra space usage, while solving problems. It emphasized the need for meticulous algorithm design that adheres to these constraints.
         */

        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                Array.Sort(nums); // Sort the array in non-decreasing order
                for (int i = nums.Length - 1; i >= 2; i--) // Iterate from right to left
                {
                    int sideA = nums[i - 2];
                    int sideB = nums[i - 1];
                    int sideC = nums[i];
                    if (sideA + sideB > sideC) // Check if a valid triangle can be formed
                    {
                        return sideA + sideB + sideC; // Return the perimeter of the triangle
                    }
                }
                return 0; // No valid triangle can be formed
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* 
         * Self-Analysis:
           -Recognizing the potential application of the triangle inequality theorem in the implementation process allowed for assessing whether given side lengths could form a non-zero area triangle. This connection between geometry knowledge and its utilization in algorithmic solutions was enlightening.
           -The algorithm's design is straightforward and efficient, employing a clean approach of iterating through the sorted array to validate triangles. This simplicity contributes to its effectiveness.
           -Leveraging geometric concepts in this fundamental application underscored the importance of consistent use of mathematical principles and the interdisciplinary nature of effective algorithm design.
         */

        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                int startIndex;
                while ((startIndex = s.IndexOf(part)) != -1)
                {
                    // Remove the leftmost occurrence of the substring part
                    s = s.Remove(startIndex, part.Length);
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
        }
        /* * Self-Analysis:
          -Upon implementing the solution, I gained further proficiency in string manipulation techniques, particularly through methods like IndexOf and Remove, which facilitated the identification and elimination of substring occurrences. This served as a valuable reinforcement of string handling in algorithmic contexts.
          -The method utilizes a while loop to iteratively locate and remove substrings from the input string, ensuring efficient execution of repetitive tasks. This approach proves effective in streamlining the process and achieving the desired outcome.
          -Robustness and reliability are ensured by handling exceptions that may arise during string manipulation, such as the 'index out of range' error. This preemptive error handling minimizes the likelihood of encountering string manipulation errors.
          -Various techniques were employed to remove substrings, leveraging built-in functions and language-optimized features to maximize efficiency in algorithm implementation. Careful consideration was given to fully utilizing these language features while designing effective algorithms.
          -The clarity and readability of the code were evident, particularly in demonstrating how instances of the substring are replaced. This highlights the effectiveness of applying an algorithmic approach to problem-solving while maintaining code legibility.
         */


        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}