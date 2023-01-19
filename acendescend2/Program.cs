string usercontinue = null;
do
{
    Console.WriteLine("please enter a number");
    int usernumber = int.Parse(Console.ReadLine());

    for (int i = usernumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    for (int i = 0; i <= usernumber; i++)       // Again just unsure where to put ToLower, i'm going to work on this more
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Would you like to continue? Y or N" );
    usercontinue = Console.ReadLine();

} while(usercontinue == "Y"); 