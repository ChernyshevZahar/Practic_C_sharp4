// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



// Console.Write("Напишите число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Напишите степень для числа: ");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine(Stepen(num1,num2));

// int Stepen(int num, int step){
//     int end = 1;
//     for (int i = 0; i < step; i++)
//     {
//         end*=num;
//     }
//     return end;
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




// Console.Write("Напишите числа: ");
// string num = Console.ReadLine();

// Console.WriteLine(StringSum(num));

// int StringSum(string num){
//     int sum = 0;
//     for (int i = 0; i < num.Length; i++)
//     {
//        sum+= int.Parse(num[i].ToString());
//     }
//     return sum;
    
// }




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Console.Write("Напишите размер массива: ");
// string num = Console.ReadLine();

// PrintArray(CreateArr(num));


// int[] CreateArr(string num ){
//     int[] arr = new int [int.Parse(num)];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"Напишите {i+1}число массива: ");
//         arr[i] = int.Parse(Console.ReadLine());
//     }
//     return arr;
// }


// void PrintArray( int [] arr){
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if(i+1<arr.Length){
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }


