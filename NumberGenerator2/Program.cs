/*
int c = 12;
int b = 25;
bool a = true;

while (a)
{
    if (c < b)
    {
        c++;
        Console.WriteLine(c-1);
    }
    else
    {
        a = false;
    }
}
*/

int userInput1 = 12;
int userInput2 = 25;
int userInput3 = 3;

for (int i = userInput1; i < userInput2; i = i + userInput3)
{
    Console.WriteLine(i);
}

/* Jiný Způsob
string userInput4 = Console.ReadLine();
for (int i = 1; i < 5;i++)
{
    Console.WriteLine(userInput4);
}
*/

string userInput4 = Console.ReadLine();
int userInput5 = 20;

for (int i = 0; i < userInput5; i++)
{
    Console.WriteLine($"{i}. {userInput4}");
}