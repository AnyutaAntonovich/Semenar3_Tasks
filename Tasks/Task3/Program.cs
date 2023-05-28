// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Inpu the number");
int cubeOfNumber = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cubeOfNumber)
{
  int i = 0;
  int length = cubeOfNumber.Length;
  while (i <  length)
  {
    cubeOfNumber[i] = Convert.ToInt32(Math.Pow(i, 3));
    i++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int ind = 0;
  while(ind < count)
  {
    Console.Write(coll[ind]+ " ");
    ind++;
  }
} 

int[] array = new int[cubeOfNumber+1];
Cube(array);
PrintArry(array);