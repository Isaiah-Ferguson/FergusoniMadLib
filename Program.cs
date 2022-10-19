//Isaiah Keith Ferguson
//10/17/2022
//Mad Lib
//we will prompt the user to input words an numbers and we will process those into a funny wacky story.


bool truenum = true;
string Sport, reTry, Adjective, Size, Emotion, Food, Restaurant, celebrity, animeCharacter, shoe, num, num1;
int realnum, realnum2, trunum3;
reTry = "";

while(reTry != "end")
{


Console.WriteLine("Enter any number");
num = Console.ReadLine();
truenum = Int32.TryParse(num, out realnum);
Console.WriteLine("Enter any number");
num1 = Console.ReadLine();
bool truenum1 = Int32.TryParse(num1, out realnum2);

if (!truenum || !truenum1)
{
    Console.WriteLine("Please retry and enter a real number next time");
}else
{
Console.WriteLine("Enter a sport");
Sport = Console.ReadLine();

Console.WriteLine("Enter an discriptive Adjective");
Adjective = Console.ReadLine();

Console.WriteLine("Enter a Size");
Size = Console.ReadLine();

Console.WriteLine("Enter an Emotion");
Emotion = Console.ReadLine();

Console.WriteLine("Enter a food");
Food = Console.ReadLine();

Console.WriteLine("Enter your favorite Restaurant");
Restaurant = Console.ReadLine();

Console.WriteLine("Enter your favorite Celebrity");
celebrity = Console.ReadLine();

Console.WriteLine("Enter your favorite Anime character");
animeCharacter = Console.ReadLine();

Console.WriteLine("Enter your favorite Shoes");
shoe = Console.ReadLine();

trunum3 = realnum + realnum2;

Console.WriteLine($"{Sport} Is the best {Adjective} Anime ever!");
Console.WriteLine($"the main character's feet seems kinda {Size}");
Console.WriteLine($"I can't believed they named him after {celebrity}");
Console.WriteLine($"The plot had so many twists i can't believe {animeCharacter} Showed up at the end!");
Console.WriteLine($"did you see when {celebrity} Wore {shoe}'s I really wish he didn't wear those");
Console.WriteLine($"Honestly it made me kind of {Emotion}");
Console.WriteLine($"Anyway, {celebrity} thought that {realnum} + {realnum2} was 21 instead of {trunum3} ! what a memer!!");
Console.WriteLine($"I usually watch it at {Restaurant} I go there so often they usually give me free {Food}");
}
Console.WriteLine("");
Console.WriteLine($"Type {reTry} Please Type 'End' to stop talking to the computer or any other key input to restart");
reTry = Console.ReadLine().ToLower();
}
