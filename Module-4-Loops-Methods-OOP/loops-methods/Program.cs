// For loops

for (int i = 1; i <= 10; i++) {
    Console.WriteLine(i);
}

// While loops

int x = 1;

while (x <= 10) {
    Console.WriteLine(x);
    x++;
}

// Methods - Functions

int AddNumbers (int firstNumber, int secondNumber) {
    int results = firstNumber + secondNumber;

    return results;
}

int sum = AddNumbers(10, 5);
Console.WriteLine("The sum of these two numbers is " + sum);