// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);
// Console.WriteLine($"Firstroll: {roll1}");
// Console.WriteLine($"secondroll: {roll2}");
// Console.WriteLine($"Thirdroll: {roll3}");

// dice.Next(1, 7);

// int firstvalue = 500;
// int secondvalue = 600;
// int largevalue;
// largevalue = Math.Max(firstvalue, secondvalue);
// Console.WriteLine(largevalue);

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int rollTotal = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {rollTotal}");
// if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("plus six points +6");
//     rollTotal += 6;
// }
// if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
// {
//     Console.WriteLine("Plus two points +2");
//     rollTotal += 2;
// }

// if (rollTotal >= 15)
// {
//     Console.WriteLine("You Win!");
// }

// if (rollTotal < 15)
// {
//     Console.WriteLine("You Lose");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;
// Console.WriteLine(daysUntilExpiration);

// // Your code goes here
// if (daysUntilExpiration > 5 && daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
// {
//     discountPercentage += 10;
//     Console.WriteLine($"Your subscription expires within a {daysUntilExpiration} day!\nRenew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage += 20;
//     Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");

// }
// else if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }

// string[] fraudulentorderIDs = ["A123", "B456", "C890"];

// // fraudulentorderIDs[3] = "D000";
// Console.WriteLine($"first: {fraudulentorderIDs[0]}");
// Console.WriteLine($"second: {fraudulentorderIDs[1]}");
// Console.WriteLine($"third: {fraudulentorderIDs[2]}");

// fraudulentorderIDs[0] = "f000";
// Console.WriteLine($"reassign first value: {fraudulentorderIDs[0]}");
// Console.WriteLine($"the are {fraudulentorderIDs.Length} frudulent orders to process");

// string[] names = { "Paul", "Peter", "John", };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] invetory = [123, 456, 789, 440, 700];
// int sum = 0;
// int bin = 0;
// foreach (int item in invetory)
// {
//     sum += item;
//     bin++;
//     Console.WriteLine($"bin {bin} = {item} items (runing total: {sum})");
// }
// Console.WriteLine($"we have the {sum} items in invetory");

// string[] names = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
// int bin = 0;
// foreach (string name in names)
// {
//     if (name.StartsWith("B"))
//     {
//         bin++;
//         Console.WriteLine($" {bin}, {name}");
//     }
// }

/*Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}*/



/*The high-level purpose of this code is to reverse a string and 
count the number of times a particular character appears.*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();
Array.Reverse(message);
int x = 0;

foreach (char i in message)
{
    if (i == 'o')
    {
        x++;
    }
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");