Console.Clear();
// // вид 1
// // void Method1()
// // {
// //     Console.WriteLine("Автор....");
// // }
// // Method1();


// //Вид2


// // void Method2( string msg)
// // {
// //     Console.WriteLine(msg);
// // } 
// //  Method2( msg :"Текст сообщения");




//  void Method21( string msg, int count )
// {
//     int i =0;
//     while (i < count )
//     {
//     Console.WriteLine(msg);
//     i++;  // инкремент
//     }
// } 
//  Method21( msg: "Текст сообщения" , count: 4); // запустить текст сообщения 4 раза



// вид 3
// int Method3()
// {
//     return DateTime.Now.Year;

// }
// int year = Method3(); // присвоили определенному значению то
//                       // то произошло в методе
// Console.WriteLine(year);   // вывели то что присвоили


// вид 4


// string Method4(int count, string text)          // строку text будем формировать count раз
// {
//     int i =0;
//     string result = String.Empty;                 // присвоили пустое значение

//     while (i < count ) 
//     {
//         result = result + text;
//         i++;
//     }
//     return result; // возвращаем результат
// }
// string res = Method4(10, "z ");
// Console.WriteLine(res);


// string Method5(int count, string text)          // строку text будем формировать count раз
// {

// string result = String.Empty;                 // присвоили пустое значение
// for (int i = 0; i < count; i++)
// {
//     result = result + text;
// }
// return result; // возвращаем результат
// }
// string res = Method5(10, "z ");
// Console.WriteLine(res);



//                             // ТАБЛИЦА УМНОЖЕНИЯ

//    for (int i = 2; i <= 10; i++)  
//    {
//     for (int j = 2; j <= 10; j++)
//     {
//        Console.WriteLine($"{i}x{j}={i*j}"); 
//     }
//     Console.WriteLine();
//    }                       




//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?


// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 + "ежели бы вас послали вместо нашего милого Винценгероде,"
//                 + "вы бы взяли приступом согласие прусского короля."
//                 + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]  // r

//   string Replace(string text, char oldValue, char newValue)    // для каждой строки будем возвращаться
//   {
//     string result = String.Empty;

//     int length =text.Length;
//     for (int i = 0; i < length; i++) 
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}"; //если элемент совпал то в результт мыдолжны положить новое значение
//         else  result = result + $"{text[i]}";
//     } 

//     return result;
//   }


// string newText = Replace (text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace (newText, 'к', 'К');

// newText = Replace (newText, 'а', 'А');

// Console.WriteLine(newText);





//сортировка массива

int[] arr = { 5, 6, 93, 8, 74, 3, 52, 4, 5, 12, 2, 11, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);


void Selection(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition1 = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition1]) minPosition1 = j;
        }
        {


            int temporary = array[i];
            array[i] = array[minPosition1];
            array[minPosition1] = temporary;



        }

    }
}    
    Selection(arr);
    PrintArray(arr);