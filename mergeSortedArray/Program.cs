
var numbers1 = new int[] { 0,0,0,0,0};

var numbers2 = new int[] { 1,2,3,4,5 };

Merge(numbers1, 0, numbers2, 5);

void Merge(int[] nums1, int m, int[] nums2, int n) {
    
    
    for (int i = 0; i < nums2.Length; i++)
    {
        nums1[m] = nums2[i];
        m++;
    }

    for (int i = 0; i < nums1.Length; i++)
    {
        for (int j = 0; j < nums1.Length - 1; j++)
        {
            if (nums1[j] > nums1[j + 1])
            {
                var temp = nums1[j + 1];
                nums1[j + 1] = nums1[j];
                nums1[j] = temp;
            }
        }
    }

    foreach (var nm in nums1)
    {
        Console.WriteLine(nm);
    }
    
}
