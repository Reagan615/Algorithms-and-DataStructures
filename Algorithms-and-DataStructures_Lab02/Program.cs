using System.Runtime.CompilerServices;
using System.Text;
//01.A program that produces an array of all of the characters
//that appear more than once in a string.

string str = "Programmatic Python";
char[] str2 = str.ToCharArray();
List<char> newStr = new List<char>();

for (int i = 0; i < str2.Length; i++)
{
    for (int j = 1 + i; j < str2.Length; j++)
    {
        if (str2[i] == str2[j])
        {
            newStr.Add(str2[i]);
        }
    }
}

foreach (char item in newStr)
{
    Console.WriteLine(item);
}


//02.A program returns an array of strings that are unique words found in the argument.

//string str = "To be or not to be";
//string[] str2 = str.ToLower().Split(' ');

//List<string> newStr = new List<string>();

//foreach (string item in str2)
//{
//    if (newStr.Contains(item))
//    {
//        continue;

//    }
//    else
//    {

//        newStr.Add(item);
//    }
//}

//foreach (string item in newStr)
//{
//    Console.Write(item + ' ');
//}


//03.A program that reverses a provided string 

//string str = "Programmatic";
//char[] str2 = str.ToCharArray();
//char[] str3 = new char[str2.Length];
//int j = 0;
//for (int i = 0; i < str2.Length; i++)
//{
//    str3[i] = str2[str2.Length - i - 1];
//}

//foreach (char ele in str3)
//{
//    Console.Write(ele);
//}


//04.A program that finds the longest unbroken word in a string and prints it.

//string str = "Tiptoe through the tulips";

//string[] ary = str.Split(' ');

//string max = "";

//for (int i = ary.Length - 1; i > 0; i--)
//{
//    if (ary[i].Length > ary[i - 1].Length)
//    {
//        max = ary[i];
//    }
//    else
//    {
//        max = ary[i - 1];
//    }
//}
//Console.WriteLine(max);
//
.


