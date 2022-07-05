/*

https://docs.microsoft.com/pt-br/learn/modules/csharp-evaluate-boolean-expressions/6-challenge-2#code-try-18

*/

string permission = "Admin|Manager";
int level = 21;

if(level > 55)
{
    Console.WriteLine("Welcome Super Admin user.");
}
else if(level > 20)
{
    Console.WriteLine("Welcome, Admin User.");
}
else {
    Console.WriteLine("Contact an Admin for access.");
}