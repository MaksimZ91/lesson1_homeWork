//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Введите первое число число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber == secondNumber)
  Console.Write("Вы ввели одинаковые числа " + firstNumber);
else if(firstNumber > secondNumber)
  Console.Write("Число " + firstNumber + " бошьше числа " + secondNumber);
else
  Console.Write("Число " + secondNumber + " бошьше числа " + firstNumber);*/


 //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Введите первое число число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if((firstNumber == secondNumber)&&(secondNumber == thirdNumber))
  Console.Write("Вы ввели одинаковые числа " + firstNumber);
else if((firstNumber >= secondNumber) && (secondNumber >= thirdNumber)) 
  Console.Write("Максимальное число: " + firstNumber);
else if((firstNumber <= secondNumber) && (secondNumber >= thirdNumber))
  Console.Write("Максимальное число: " + secondNumber);
else if((firstNumber <= secondNumber) && (secondNumber <= thirdNumber))
  Console.Write("Максимальное число: " + thirdNumber);
else
  Console.Write("Максимальное число: " + thirdNumber); */
      
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). 

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number % 2) == 0)
    Console.Write("Число является четным");
else
    Console.Write("Число является нечетным");*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.  

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++){
  if(( i % 2 ) == 0)
    Console.Write(i + " ");   
}

