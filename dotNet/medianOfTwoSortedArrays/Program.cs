
var num1 = new int[] { 1,3 };

var num2 = new int[] { 2 };

FindMedianSortedArrays(num1, num2);

double FindMedianSortedArrays(int[] nums1, int[] nums2)
{
        var newArray = new int[nums1.Length + nums2.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
                newArray[i] = nums1[i];
        }

        int counter = 0;
        
        for (int j = nums1.Length; j < nums1.Length + nums2.Length; j++)
        {
                newArray[j] = nums2[counter];
                counter++;
        }
        

        for (int i = 0; i < newArray.Length - 1; i++)
        {
                for (int j = 0; j < newArray.Length - 1; j++)
                {
                        if (newArray[j] > newArray[j+1])
                        {
                                var temp = newArray[j+1];
                                newArray[j+1] = newArray[j];
                                newArray[j] = temp;
                        } 
                }
        }
        
        double median = 0.00;

        if (newArray.Length % 2 != 0)
        {
                median = newArray[newArray.Length / 2];
        }
        else
        {
                median = (newArray[newArray.Length / 2] + newArray[(newArray.Length / 2) - 1]) / 2.00;
        }
        return median;
}