using Strategy_Pattern;

//while (true) { }

Console.WriteLine("How big should the array be?");

int size;

while (!int.TryParse(Console.ReadLine(), out size))
{
    Console.WriteLine("Please enter a valid integer value.");
}

int[] arr = new int[size];

Numbers.Fill(arr);
Numbers.PrintArr(arr);

Console.WriteLine("A: Bubblesort");
Console.WriteLine("B: Selectionsort");
Console.WriteLine("C: Insertionsort");

Numbers.Algorithm(arr);
Numbers.PrintArr(arr);

