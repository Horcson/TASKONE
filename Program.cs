//Array with variables
double[] Nums = {3.4,6.7, 8.3, 9.0, 2.4};
double sum = 0;

//For Loop for calaculating sum total of Array
for (int i = 0; i <Nums.Count(); i++)
{
    sum += Nums[i];
    Console.WriteLine(sum);
}
//Write Line where the mean of the array is printed
Console.WriteLine("The mean is  " + sum / Nums.Count());

Console.ReadKey(); 