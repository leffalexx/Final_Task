string[] array = {"Car", "wheel", "Fox", "Parliament", "Tree", "322", "sea", "--09"};

void ShowArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
   Console.WriteLine();
}

string[] ThreeDigitArray(string[] array)
{
   int resultArraySize = 0;
   int resultArrayIndex = 0;

   for (int i = 0; i < array.Length; i++) 
   {
      if (array[i].Length <= 3)
      {
         resultArraySize++;
      }
   }

}

ShowArray(array);
Console.WriteLine();