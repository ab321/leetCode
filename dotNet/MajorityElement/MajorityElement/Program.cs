Console.WriteLine("Hello, World!");

var nums = new int[] { 6,5,5};

Console.WriteLine(majorityElement(nums));

int majorityElement(int[] nums)
{
    var numbersDic = new Dictionary<int, int>();

    foreach (var number in nums)
    {
        if (!numbersDic.TryAdd(number, 1))
        { 
            numbersDic.TryGetValue(number, out var currentCount);
            numbersDic[number] =  currentCount + 1;
        }
    }
    
    return numbersDic.MaxBy(x => x.Value).Key;
}