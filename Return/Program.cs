using System;

namespace Return
{
  class Program
  {
    public static string[] fruits = { "Äpple", "Päron", "Banan", "Citron", "Annanas", "Apelsin", "Kiwi", "Mango" };
    public static void Main()
    {
      Console.WriteLine("Välj en av dessa frukter");

      for (int i = 0; i < fruits.Length; i++)
      {
        Console.WriteLine(i + 1 + ". " + fruits[i]);
      }
      ArrayIndex(int.Parse(Console.ReadLine()));
    }
    public static int ArrayIndex(int i)
    {
      string fruit = fruits[i - 1];
      Console.WriteLine($"Du har valt {fruit}");
      return i;
    }
  }
}
