var nums1 = new int[] { 1, 2, 3, 0, 0 , 0 };
var m = 3;
var nums2 = new int[] { 2, 5, 6 };
var n = 3;

var mergedArr = new int[m + n];

var currentFirstElement = 0;
var currentSecondElement = 0;
var currentCount = 0;

while (true)
{

    if (currentCount >= m + n)
    {
        break;
    }

    if (currentCount <= m + n)
    {
        if (nums1.Length > 0 && nums2.Length > 0 && nums1[currentFirstElement] <= nums2[currentSecondElement] && nums1[currentFirstElement] != 0)
        {
            mergedArr[currentCount] = nums1[currentFirstElement];
            currentFirstElement++;
            currentCount++;
        }
        else if(nums2.Length > 0)
        {
            mergedArr[currentCount] = nums2[currentSecondElement];
            currentSecondElement++;
            currentCount++;
        } else
        {
            mergedArr[currentCount] = nums1[currentFirstElement];
            currentFirstElement++;
            currentCount++;
        }
    }
    else
    {
        currentCount++;
    }
}

for (int i = 0; i < mergedArr.Length; i++)
{
    Console.WriteLine(mergedArr[i]);
}