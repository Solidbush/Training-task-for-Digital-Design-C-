using TrainingTaskDigitalDesign.Services;

Console.WriteLine("Input file's path for read: ");
string pathForRead = Console.ReadLine();
Console.WriteLine("Input file's path for write: ");
string pathForWrite = Console.ReadLine();
IWordCounter wordCounter = new WordCounter(pathForRead, pathForWrite);
wordCounter.ReadFile();
wordCounter.SortResult();
wordCounter.WriteToFile();

