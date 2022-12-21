
Console.WriteLine("Введите первое слово для массива");
string text1 = Console.ReadLine();
Console.WriteLine("Введите второе слово для массива");
string text2 = Console.ReadLine();
Console.WriteLine("Введите  третье слово для массива");
string text3 = Console.ReadLine();

string[] MyArray(string arg1, string arg2, string arg3)
{
string[] myArray = new string[3];
myArray[0] = arg1;
myArray[1] = arg2;
myArray[2] = arg3;
return myArray;
}

string[] myArray = MyArray(text1, text2, text3);

void ShowArray(string[] myArray)
{
    for(int i = 0;  i < myArray.Length; i ++)
    {
    Console.WriteLine(" ");
    Console.WriteLine(myArray[i] + " ");
    }
    Console.WriteLine(" ");
}


string[] ChekArr(string[] arg) 
{
    int sizeArray = 0;

    for (int i = 0; i < arg.Length; i++)
        if (arg[i].Length <= 3) sizeArray++;

    string[] newArr = new string[sizeArray];

    for (int i = 0, j = 0; i < arg.Length; i++)
        if (arg[i].Length <= 3)
        {
            newArr[j] = arg[i];
            j++;
        }

    return  newArr;
}


string[] NewArr = ChekArr(myArray);
ShowArray(NewArr);

