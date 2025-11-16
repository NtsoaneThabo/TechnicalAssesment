namespace TS.TechnicalTest;

public class DeepestPitAnswer
{

    /*
     * A non-empty array A consisting of N integers is given. A pit in this array is any triplet of integers (P, Q, R) such that
        Each element of array A is an integer within the range [−100,000,000..100,000,000].
        •
        Only count the pit if the decline started above ground i.e., 0
        •
        Only count it as a pit if the decline is uninterrupted until the lowest point is reached (No flat line)
        •
        You stop counting when the water reaches the first ridge
        •
        The response must be -1 if there is no pits found in the provided array
     */

    public static int Solution(int[] points)
    {
        //Get Length of points
        int totalPoints = points.Length;

        //Make sure there are atleast 3 points
        if (totalPoints < 3)
        {
            return -1;
        }

        //no pits found
        int deepestDepth = -1;
        int peakIndex = 0;

        while (peakIndex < totalPoints - 2)
        {
            //find the peak, the pit must start after peak
            while (peakIndex < totalPoints - 1 && points[peakIndex] <= points[peakIndex + 1])
                peakIndex++;

            //Peak must be above ground
            if (points[peakIndex] <= 0)
            {
                peakIndex++;
                continue;//no decrease
            }

            //go into pit (consistent decrease)
            int valleyIndex = peakIndex;
            while (valleyIndex < totalPoints - 1 && points[valleyIndex] > points[valleyIndex - 1])
            {
                valleyIndex++;
            }

            if (valleyIndex == peakIndex)
            {
                peakIndex = valleyIndex;
                continue;//no increase
            }

        }

        



        return deepestDepth;
    }
}
