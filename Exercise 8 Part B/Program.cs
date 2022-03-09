/* Exercise 8 Part B */

Console.WriteLine("This Program Will Write Even Numbers From 1-100");

// User Input
Console.WriteLine("Enter An Amount Of Even Numbers: ");
int amount = Convert.ToInt32(Console.ReadLine());

/* If counter Is <= amount(*2 To Make Even), counter++, If counter % 2 == 0, Only Then It'll Print */
for (int counter = 1; counter <= amount * 2; counter++)
{
    if (counter % 2 == 0)
    {
        Console.WriteLine(counter);
    }

}
