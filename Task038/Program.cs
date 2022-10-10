Console.Clear();

Console.WriteLine($"Задача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел: \n");

double[] arrayRealNumbers = new double[5];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }
  
  double decision = maxNumber - minNumber;
  
  Console.WriteLine($"-> {decision}");