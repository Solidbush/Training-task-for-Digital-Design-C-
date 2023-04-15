using System.Threading.Channels;
using TrainingTaskDigitalDesign.Entities;
using TrainingTaskDigitalDesign.Exceptions;
using TrainingTaskDigitalDesign.Models;

namespace TrainingTaskDigitalDesign.Services;

public class WordCounter : IWordCounter
{
    private HashTable hashTable;
    private WordQuantityContainer[] sortedArray;
    private FileInfo fileForRead;
    private FileInfo fileForWrite;
    
    public WordCounter(string pathFileForRead, string pathFileForWrite)
    {
        fileForRead = new FileInfo(pathFileForRead);
        fileForWrite = new FileInfo(pathFileForWrite);
        if (!fileForRead.Exists)
            throw new NonExistentFileException($"File with path: {fileForRead.FullName} doesn't exists!");
        if (!fileForWrite.Exists)
        {
            var forRead = File.Create(fileForRead.FullName);
            forRead.Close();
        }
            
        hashTable = new HashTable();
    }
    public void ReadFile()
    {
        foreach (var line in File.ReadLines(fileForRead.FullName))
        {
            var words = line.Split(" ");
            foreach(var word in words)
            {
                hashTable.AddWord(hashTable.WordHandler(word));
            }
        }
        
        Console.WriteLine($"File from {fileForRead.FullName} read successfully!");
    }

    public void SortResult()
    {
        sortedArray =
            new QuickSort().QuickSortAlgorithm(hashTable.GetAllWordQuantityContainers(hashTable.GetHashTableSize()), 0,
                hashTable.GetHashTableSize() - 1);
        
        Console.WriteLine("Words sorted successfully!");
    }

    public void WriteToFile()
    {
        StreamWriter fileWriter = new StreamWriter(fileForWrite.FullName);
        foreach (var wordCountContainer in sortedArray.Reverse())
        {
            fileWriter.WriteLine($"{wordCountContainer.Word} {wordCountContainer.GetQuantity()}");
        }
        fileWriter.Close();
        Console.WriteLine($"Words have been successfully written to file: {fileForWrite.FullName}");
        Console.WriteLine($"Total: {hashTable.GetHashTableSize()}");
    }
}