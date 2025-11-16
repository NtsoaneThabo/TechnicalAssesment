namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
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
            {
                peakIndex++;

            }

            //if towards the end of array and no pit found yet
            if (points[peakIndex] >= totalPoints - 2)
            {
                break;
            }

            //Peak must be above ground
            if (points[peakIndex] <= 0)
            {
                peakIndex++;
                continue;
            }

            //go into pit (consistent decrease)
            int valleyIndex = peakIndex;

            while (valleyIndex < totalPoints - 1 && points[valleyIndex] > points[valleyIndex + 1])
            {
                valleyIndex++;
            }

            if (valleyIndex == peakIndex)
            {
                peakIndex = valleyIndex;
                continue;//no decrease
            }

            //do for the other side
            int ridgeIndex = valleyIndex;
            while(ridgeIndex < totalPoints - 1 && points[ridgeIndex] < points[ridgeIndex + 1])
            {
                ridgeIndex++;
            }

            if (ridgeIndex == valleyIndex) 
            {
                peakIndex = valleyIndex;
                continue; //no incline
            }

            //calculate depth of pit
            int initialSlope = points[peakIndex] - points[valleyIndex]; //starting and depth index
            int finalSlope = points[ridgeIndex] - points[valleyIndex]; //ridge and valley index
            int Pit = Math.Min(initialSlope, finalSlope); //get smallest side of the pit that was found

            deepestDepth = Pit;

            peakIndex = ridgeIndex;//Move forward from where we stopped to look for another pit going forward
        }

        return deepestDepth;
    }
}
