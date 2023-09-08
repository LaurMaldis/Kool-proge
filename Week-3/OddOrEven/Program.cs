Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if  (result != 0) //!= ei võrdu/ei ole
{
    Console.WriteLine($"Number {userNum} ei ole paarisarv.");
}
else 
{
    Console.WriteLine($"Number {userNum} on paarisarv.");
};