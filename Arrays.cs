using System;
using System.Collections.Generic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' where each element is a total of
    /// 'number' multiplied by the element index + 1. For instance, MultiplesOf(7, 5) will result in:
    /// [7, 14, 21, 28, 35]. Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // STEP 1: Create a new array of doubles with a size equal to 'length'.
        // STEP 2: Loop from index 0 up to 'length - 1'.
        // STEP 3: In each iteration, calculate the multiple by multiplying 'number' by (index + 1).
        // STEP 4: Store the calculated value into the array at the current index.
        // STEP 5: Return the populated array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' list to the right by the 'amount'. For example, if the data is
    /// <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}. The value of amount will be in the range of 1 and data.Count, inclusive.
    ///
    /// Because a result is not returned, the list passed in must be modified.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // STEP 1: Calculate the split index where the elements to be moved start.
        //        Since we rotate right by 'amount', the last 'amount' elements will move to the front.
        //        The starting index for these elements is (data.Count - amount).
        // STEP 2: Use GetRange to slice the tail portion (the last 'amount' elements).
        // STEP 3: Use RemoveRange to remove those last 'amount' elements from the end of the original list.
        // STEP 4: Use InsertRange at index 0 to place the tail slice at the beginning of the list.

        int splitIndex = data.Count - amount;

        List<int> tail = data.GetRange(splitIndex, amount);
        data.RemoveRange(splitIndex, amount);
        data.InsertRange(0, tail);
    }
}