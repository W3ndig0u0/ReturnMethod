using System;

namespace Return
{
  class Program
  {
    public static string[] fruits = GetFruits();
    public static void Main()
    {
      // !Ställer frågan
      Question(fruits);
    }

    public static string[] Question(string[] array)
    {

      Console.WriteLine("Välj en av dessa frukter");
      // !Loopar igenom Arrayen
      for (int i = 0; i < fruits.Length; i++)
      {
        Console.WriteLine(i + 1 + ". " + fruits[i]);
      }

      // !Gör svaret till en int som blir Int arrayIndex
      ArrayIndex(int.Parse(Console.ReadLine()));

      return array;
    }
    public static int ArrayIndex(int arrayIndex)
    {
      // !Skriver ut vilket frukt som användaren valde
      string fruit = fruits[arrayIndex - 1];
      Console.WriteLine($"Du har valt {fruit}");
      return arrayIndex;
    }
    static string[] GetFruits()
    {
      // !Retruanas arrayen
      return new[] { "Äpple", "Päron", "Banan", "Citron", "Annanas", "Apelsin", "Kiwi", "Mango" };
    }
  }
}
