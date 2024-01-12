var numbers = new int[]
{
    0,1,2,2,3,0,4,2
};
var value = 2;

Console.WriteLine(RemoveElement(numbers, value));

int RemoveElement(int[] nums, int val)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = 0; j < nums.Length - 1; j++)
        {
            if (nums[j] == val)
            {
                var temp = nums[j + 1];
                nums[j + 1] = nums[j];
                nums[j] = temp;
            }
        }

        if(i == nums.Length - 1){
            nums = nums.Where(x => x != val).ToArray();
        }
    }
    
    return nums.Length;
}