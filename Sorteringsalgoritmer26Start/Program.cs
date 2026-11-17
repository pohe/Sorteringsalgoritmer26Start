using System.Diagnostics;

Console.WriteLine("Hello, Sortering");
// Start tidsmåling med Stopwatch
//int[] numbers = new int[] { 7, 3, 10, 5, 8, 6 };
int[] numbers = ReadNumbersFromFile("100.txt");
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start(); // Kald din sorteringsalgoritme her ..... 

int[] sortedNumbers = BubleSort(numbers);

//int[] sortedNumbers = InsertionSort(ReadNumbersFromFile("100.txt"));


// Stop tidsmåling
stopwatch.Stop(); // Udskriv tiden, det tog at sortere arrayet



Console.WriteLine($"Tid til at sortere: {stopwatch.Elapsed.TotalMilliseconds} ms");
PrintNumbers(sortedNumbers);
static int[] ReadNumbersFromFile(string filePath)
{
    try
    { // Læs hele filens indhold som en enkelt streng
        string fileContent = File.ReadAllText(filePath);
        // Split strengen ved kommaer for at få alle tal
        string[] stringNumbers = fileContent.Split(',');
        // Opret et int-array af samme længde som antallet af tal
        int[] numbers = new int[stringNumbers.Length];
        // Konverter hvert tal fra string til int og gem det i arrayet
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            numbers[i] = int.Parse(stringNumbers[i].Trim());
        }
        return numbers;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Fejl under læsning af fil: " + ex.Message);
        return new int[0];
        // Returner et tomt array i tilfælde af fejl
    }
}

static int[] BubleSort(int[] numbers)
{
    //    procedure BubbleSort(array)
    //    n = længden af array
    //    repeat
    //        swapped = false
    //        for i = 0 to n - 2 do
    //            if array[i] > array[i + 1] then
    //                bytte array[i] og array[i + 1]
    //                swapped = true
    //            end if
    //        end for
    //        n = n - 1
    //    until not swapped
    //end procedure

    
    return numbers;
}


static int[] InsertionSort(int[] numbers)
{
    //    rocedure InsertionSort(array)
    //    n = længden af array


    //    for i = 1 til n - 1 gør
    //        nuværendeElement = array[i]
    //        j = i - 1


    //        mens j >= 0 og array[j] > nuværendeElement gør
    //            array[j + 1] = array[j]
    //            j = j - 1
    //        slut mens


    //        array[j + 1] = nuværendeElement
    //    slut for
    //slut procedure

   
    return numbers;
}

void PrintNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 10 == 0 )
        {
            Console.WriteLine(numbers[i]);
        }
        else Console.Write(numbers[i] + "\t");
    }
}
