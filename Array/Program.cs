void Array()
{ int[] nums = new int[15];
int max = 0;
int min = 1000;
Random a = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = a.Next(1, 1000);
    if (nums[i]>max)
    {
        max = nums[i];

    }
    if (nums[i]<min)
    {
        min = nums[i];

    }
}
Console.WriteLine("Unsorted");
for (int i = 0; i<nums.Length;i++)
{
    Console.WriteLine(nums[i] + " "); 
}
int point;
for (int i =0; i<nums.Length-1;i++)
{
    if (nums[i]>nums [i+1])
    {
        for (int l = i+1;l>0;l--)
        {
            if(nums[l]< nums[l-1])
            {
                point = nums[l];
                nums[l] = nums[l - 1];
                nums[l - 1] = point;
            }
        }
    }
}
Console.WriteLine("\nSorted");
for (int i=0;i<nums.Length;i++)
    {
    Console.Write(nums[i] + " ");

    }
Console.WriteLine("\nMax:" + max + "\nMin " + min);
Console.ReadLine();
}
Array();


