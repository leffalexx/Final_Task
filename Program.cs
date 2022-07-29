string[] array = {"Car", "wheel", "Fox", "Parliament", "Tree", "322", "sea", "--09"};

void ShowArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
   Console.WriteLine();
}
ShowArray(array);
Console.WriteLine();