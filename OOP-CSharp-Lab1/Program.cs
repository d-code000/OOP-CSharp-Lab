



var random = new Random();
var hiddenNum = random.Next(1, 1000);
var countTry = 10;

int intNum;

do
{
    intNum = 0;
    while (intNum == 0)
    {
        var writeNum = Console.ReadLine();
        try
        {
            intNum = int.Parse(writeNum);
        }
        catch (FormatException)
        {
            Console.WriteLine("Число нераспознано как целое");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число слишком большое");
        }
    }
    if (intNum > hiddenNum) Console.WriteLine("Число больше задуманного");
    else if (intNum < hiddenNum) Console.WriteLine("Число меньше задуманного");
    countTry--;

} while (intNum != hiddenNum && countTry > 0);

if (countTry == 0)
{
    Console.WriteLine("Looser !!!");
    Console.WriteLine("Hidden num is {0}", hiddenNum);
}
else
{
    Console.WriteLine("Oooo No !!");
}
