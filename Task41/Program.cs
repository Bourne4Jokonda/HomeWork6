// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int[]numbers=new int[5];
int sum=0;
for(int i=0;i<numbers.Length;i++)
{
      Console.Write($"Введите число {i+1}: ");
      numbers[i]=Convert.ToInt32(Console.ReadLine());
      if(numbers[i]>=1)
      {
            sum++;
      }
}
Console.WriteLine("Количество чисел больше 0 : "+sum);