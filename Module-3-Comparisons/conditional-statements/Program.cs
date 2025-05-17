int age = 17;

if (age >= 18){
    Console.WriteLine("You are eligible to vote.");
} else {
    Console.WriteLine("You are not eligible to vote.");
};

// Multiple conditions
int temperature = 5;

if (temperature >= 30){
    Console.WriteLine("It's a hot day");
} 
else if (temperature > 20) {
    Console.WriteLine("It's a warm day");
}
else if (temperature > 10) {
    Console.WriteLine("It's a cool day");
}
else {
    Console.WriteLine("It's a cold day");
};