Console.WriteLine("Welcome to our Budget Tracker App!");
// 1. Create a variable called groceryBudget and set a monthly budget
double groceryBudget = 200.00;

// 2. Create a variable called entertainmentBudget and set a monthly budget
double entertainmentBudget = 250.00;

// 3. Use Console.WriteLine() to output these variables to the console
Console.WriteLine($"Grocery Budget: {groceryBudget}");
Console.WriteLine($"Entertainment Budget: {entertainmentBudget}");

// 4. Create an Array called fixedExpenses to store 3 double variables (one for rent, one for electricity and one for water)
// double[] fixedExpenses = {1200.00, 150.00, 50.00};

// // and output the contents of the array to the console
// Console.WriteLine("Fixed Expenses: ");
// Console.WriteLine("Rent: " + fixedExpenses[0]);
// Console.WriteLine("Electricity: "  + fixedExpenses[2]);
// Console.WriteLine("Water: " + fixedExpenses[2]);

// 5. Replace the Array with a List
List<double> fixedExpenses = new List<double> {1200.00, 150.00, 50.00};

Console.WriteLine("Fixed Expenses: ");
Console.WriteLine("Rent: " + fixedExpenses[0]);
Console.WriteLine("Electricity: "  + fixedExpenses[2]);
Console.WriteLine("Water: " + fixedExpenses[2]);

// 6. Add some new expenses to the List using List methods

fixedExpenses.Add(35);
fixedExpenses.Add(9.99);

Console.WriteLine("Internet: " + fixedExpenses[3]);
Console.WriteLine("Spotify: " + fixedExpenses[4]);

// 7. Add two new variables called grocerySpent and entertainmentSpent and assign them values

double grocerySpent = 350.00;
double entertainmentSpent = 100.00;

// 8. Use an if statement to check whether grocerySpent is higher than the groceryBudget and do the same for entertainment

if ( grocerySpent > groceryBudget) {
    Console.WriteLine("You are over budget on groceries!");
} 
else {
    Console.WriteLine("You are within budget on groceries!")
;}

if ( entertainmentSpent > entertainmentBudget) {
    Console.WriteLine("You are over budget on entertainment!");
} 
else {
    Console.WriteLine("You are within budget on entertainment!")
;}

// 9. Calculate the remaining budget by doing groceryBudget - grocerySpent using arithmetic operations

double remainingGroceryBudget = groceryBudget - grocerySpent;

double remainingEntertainmentBudget = entertainmentBudget - entertainmentSpent;

Console.WriteLine($"Remaining Grocery Budget:  {remainingGroceryBudget}");

Console.WriteLine($"Remaining Entertainment Budget:  {remainingEntertainmentBudget}");

// 10. Create an if statement to check if w are within budget for groceries and entertainment, using logic operators

if (grocerySpent <= groceryBudget && entertainmentSpent <= entertainmentBudget) {
    Console.WriteLine("You are within budget for groceries and entertainment");
}
else if (grocerySpent <= groceryBudget || entertainmentSpent <= entertainmentBudget) {
    Console.WriteLine("You are within budget for one of your spending limits");
}
else {
    Console.WriteLine("You are over budget for both groceries and entertainment");
}

// 11. Declare a list of expenses with the values 700, 50, 150, 25, 30

List<double> expenses = new List<double> { 700, 50, 150, 25, 30 };

// 12. Create a for loop to calculate the total expenses

// double totalExpenses = 0;

// for (int i = 0; i < expenses.Count; i++)
// {
//     totalExpenses = totalExpenses + expenses[i];
// }
// Console.WriteLine("The total of our expenses is: " + totalExpenses);

// 13. Create a method called CalculateTotalExpenses to calculate the total expenses

double CalculateTotalExpenses(List<double> expenses)
{
    double totalExpenses = 0;

    for (int i = 0; i < expenses.Count; i++)
    {
        totalExpenses = totalExpenses + expenses[i];
    }

    return totalExpenses;
}

// 14. Call the method CalculateTotalExpenses

Console.WriteLine("The total of our expenses is: " + CalculateTotalExpenses(expenses));

// 15. Create a variable called spendingLimit and set it to 900

double spendingLimit = 900;

// 16. Use a while loop to add expenses from the list until the limit is reached or exceeded

int i = 0;
double currentTotal = 0;

while (i < expenses.Count && currentTotal < spendingLimit)
{
    currentTotal = currentTotal + expenses[i];
    i++;
}

Console.WriteLine("The total cost of expenses: " + currentTotal);
