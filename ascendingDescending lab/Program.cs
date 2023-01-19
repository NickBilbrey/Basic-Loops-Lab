bool continuebool = false;
do
{
    Console.WriteLine("Hello World! \n Would you like to continue (Y/N)?");
    string userinput = Console.ReadLine();
    if (userinput == "Y")
    {
        continuebool = true;
    }
    else if (userinput == "N")          //I'm not sure where to put ToLower() in order to make it so regardless of caps you can continue
    { 
        continuebool = false;
    }

} while (continuebool == true);