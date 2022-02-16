M:
Console.WriteLine("Hi,I can calculate your body mass index. Please enter your weight and height. Thanks ");
Console.WriteLine("Please enter your weight(kilo)");
double BMI;
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter your height(m)");
double height = Convert.ToDouble(Console.ReadLine());
if (weight > 0 && height > 0)
{
    height = height * height;
    BMI = weight / height;
    Console.WriteLine("Your BMI = " + BMI);

}
else
{
    Console.WriteLine("Please enter correct information");
    goto M;
}

