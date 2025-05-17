bool strawberry = true;
bool banana = false;

if (strawberry && banana) {
    Console.WriteLine("You can make a smoothie");
}
else if (strawberry || banana) {
    Console.WriteLine("You can eat a piece of fruit");
}
else {
    Console.WriteLine("You do not have the ingredients");
}

bool raining = true;

if (!raining) {
    Console.WriteLine("It's not raining outside");
}
else {
    Console.WriteLine("Remember your umbrella");
}