// C# Certifications PART 2 - Microsoft Learn



// Call Methods From the .NET Class Library Using C# (Second Part)
Random dice = new Random();
Console.WriteLine(dice.Next(1, 7));

// First exercise
Random newDice = new Random();
int roll1 = newDice.Next();
int roll2 = newDice.Next(101);
int roll3 = newDice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Second exercise
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
///////////////////////////////////////////////////:



// Add Decision Logic to Your Code Using if, else, and else if statements in C#
// First exercise
Random secondDice = new Random();
int newRoll1 = secondDice.Next(1, 7);
int newRoll2 = secondDice.Next(1, 7);
int newRoll3 = secondDice.Next(1, 7);

newRoll1 = 6;
newRoll2 = 6;
newRoll3 = 6;

int total = newRoll1 + newRoll2 + newRoll3;
Console.WriteLine($"Dice roll: {newRoll1} + {newRoll2} + {newRoll3} = {total}");

if ((newRoll1 == newRoll2) || (newRoll2 == newRoll3) || (newRoll1 == newRoll3)) {    
   if ((newRoll1 == newRoll2) && (newRoll2 == newRoll3)) {
    Console.WriteLine("You rolled triples! +6 bonus to total");
    total+=6;
}  else {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total+=2;
}
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

// Challenge 
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
///////////////////////////////////////////////////////////////////////////////////



// Store and Iterate Through Sequences of Data Using Arrays and the foreach Statement in C#
// First exercise
/*string[] fraudulentOrderIds = new string[3];
fraudulentOrderIds[0] = "A123";
fraudulentOrderIds[1] = "B456";
fraudulentOrderIds[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIds = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");

Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

// Second exercise
int [] inventory = { 200, 450, 700, 175, 250 };

int firstSum = 0;
int bin = 0;
foreach (int items in inventory) {
  firstSum+= items;
  bin++;
  Console.WriteLine($"Bin {bin} = {items} (Running total: {firstSum})");
}   
Console.WriteLine($"We have {firstSum} items in inventory.");

// Challenge
string[] newOrders = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string items in newOrders) {
    if(items.StartsWith("B")) {
        Console.WriteLine(items);
    }
}
////////////////////////////////////////////////////////////////////////////////////////


// Create Readable Code with Conventions, Whitespace, and Comments in C#
// First exercise

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random anotherRandom = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = anotherRandom.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = anotherRandom.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// Challenge
string newStr = "The quick brown fox jumps over the lazy dog.";
// Convert the message into a char array
char[] charMessage = newStr.ToCharArray();
// Reserve the chars
Array.Reverse(charMessage);
int x = 0;
// Count the o's
foreach (char i in charMessage) { if (i == 'o') { x++;} }
// Convert it back to a string
string new_message = new string(charMessage);
// Print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
//////////////////////////////////////////////////////////////////////////////////////////