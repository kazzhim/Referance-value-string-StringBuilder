using System.Text;

string sentence = Console.ReadLine();


StringBuilder sentence2 = new StringBuilder();

string[] array = sentence.Split(' ');
for (int i = 0; i < array.Length; i++)
{
    for (int j = array[i].Length - 1; j >= 0; j--)
    {
        sentence2.Append(array[i][j]);
    }
    sentence2.Append(' ');
}



//for (int i = sentence.Length - 1; i >= 0; i--)
//{   


//    sentence2.Append(sentence[i]);
//}
Console.WriteLine(sentence2);