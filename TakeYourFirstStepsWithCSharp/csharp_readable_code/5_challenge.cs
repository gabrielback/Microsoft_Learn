// Código original:

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");


// Código refatorado:

/*
A finalidade desse código é inverter uma cadeia 
de caracteres e contar o número de vezes que um caractere 
específico é exibido.
*/

string originalString = "The quick brown fox jumps over the lazy dog.";

char[] message = originalString.ToCharArray();
Array.Reverse(message);

int letterCounter = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    {
         letterCounter++; 
    } 
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCounter} times.");