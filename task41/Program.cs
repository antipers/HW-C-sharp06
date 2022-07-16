System.Console.WriteLine("Сколько чисел вы хотите ввести?");
int Num= int.Parse(Console.ReadLine()!);

int[] array= new int[Num];
int count=0;
for (int i = 0; i < array.Length; i++)
{

    array[i] = int.Parse(Console.ReadLine()!);
    if (array[i]>0) count++;
    
}
System.Console.WriteLine($"Число положительных = {count}");