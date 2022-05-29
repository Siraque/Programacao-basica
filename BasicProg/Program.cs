using BasicProg;

GreetCountries.Countries();

Console.ReadKey();

int x = 20;
int y = 0;

if(y == 0)
{
    throw new FailException();
}
else
{
    Console.WriteLine(x/y);
}
