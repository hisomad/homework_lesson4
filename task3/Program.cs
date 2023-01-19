Console.Write("Введите количество элементов массива: ");
    
int elementsCount = int.Parse(Console.ReadLine());
int[] array = new int[elementsCount];

 for (int i = 0; i < array.Length; i++)
 {
     Console.Write($"\nВведите элемент массива под индексом {i}: ");
     array[i] = int.Parse(Console.ReadLine());
 }
 
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.WriteLine("]");

