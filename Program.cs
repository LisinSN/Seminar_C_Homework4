// Домашнее задание 4. 
//Урок 4. Функции продолжение
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine (" "); Console.WriteLine ("*** Давайте найдём число A в степени B ***"); Console.WriteLine (" ");
// Цикл возведения в степень 
void Degree(int a, int b){
    int result = 1;
    for (int i = 1; i <= b; i++){
        result = result * a;
    }
    Console.Write ($"число {a} в степени {b} равно: {result}"); 
    Console.WriteLine ("");
}
// Ввод данных
Console.Write ("# Введите число А: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("# Введите число B: "); 
int b = Convert.ToInt32(Console.ReadLine());
if (b<= 0) Console.WriteLine ("# Некорректный ввод"); 
else Degree(a,b); //Degree - степень


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine (""); Console.WriteLine ("*** Давайте найдем сумму всех цифр в числе ***"); 
Console.WriteLine ("");

// Создание массива из числа
int [] Disassembly(int num){
    int [] array = new int [num];
   // while(num>1){
        for (int i = 0; num>1; i++){
        array[i] = num%10;
        num=num/10;
        }
        
    //}    
    return array;
}
// Цикл суммы цифр и вывод массива
void ShowSum (int[] array){
    int result = 0;
    for (int i=0; i<array.Length; i++){
        result= result + array [i];
    }
    Console.WriteLine ($"# Сумма всех цифр в числе ровна: {result}"); Console.WriteLine (" ");
}
// Ввод данных
Console.Write ("# Введите любое число: "); 
int num = Convert.ToInt32(Console.ReadLine());
if (num<= 0) Console.WriteLine ("# Сумма ровна нулю");
else ShowSum (Disassembly(num)); 



// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine ("*** Давайте создадим массив из случайных чисел случайного количества***"); 
Console.WriteLine (" ");

// Массив случайных чисел
int [] CreateRandomArrey (int size, int min, int max){
    int [] array = new int [size];
    Console.Write ("[ ");
    for (int i = 0; i<size; i++){
        array[i] = new Random().Next(min,max);
        Console.Write (array[i]+" ");
    }
    Console.WriteLine ("]");
    Console.WriteLine ("");
    Console.WriteLine ($"# Массив состоит из {size} чисел, где минимальное значение: {min}, а максимальное: {max}");
    Console.WriteLine ("");
    return array;
}
// Ввод данных // Ограничения количества цифр
int size = new Random().Next(0,1000);
int min = new Random().Next(-1000,0);
int max = new Random().Next(1,1000);
CreateRandomArrey(size, min, max);

