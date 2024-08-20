var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
var val = 2;
var expectedNums = new int[nums.Length];

var k = 0;

var index = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] != val)
    {
        k++;
        expectedNums[index] = nums[i];
        index++;
    }
}

Console.WriteLine(k);

Console.WriteLine(string.Join(", ", expectedNums.Take(index)));