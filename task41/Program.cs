//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int SumDig(int i){
    int sum = 0;
    while(i>0)
{
    Console.Write("Ведите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num>0) sum++;
    i--;
}
return sum;
}
Console.WriteLine("Сколько числел хотите вести?");
int i = Convert.ToInt32(Console.ReadLine());

int res = SumDig(i);
Console.WriteLine($"числел больше нуля --> {res}");