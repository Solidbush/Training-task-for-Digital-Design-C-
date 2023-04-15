using TrainingTaskDigitalDesign.Models;

namespace TrainingTaskDigitalDesign.Entities;

public class HashTable
{
    private Dictionary<String, WordQuantityContainer> hashTable;
    private const string NullString = "";
    public HashTable()
    {
        hashTable = new Dictionary<String, WordQuantityContainer>();
    }

    public string WordHandler(string wordSample)
    {
        string word = wordSample.Trim().ToLower();
        word = word.Trim(new Char[]
        {
            ',', '.', '!', '?', ':', ';', '-', '–', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')', ']', '{',
            '(', '{', '[', '"', '\''
        });
        return word;
    }

    public void AddWord(string word)
    {
        if (word == NullString)
            return;
        if (hashTable.ContainsKey(word))
        {
            hashTable[word].IncreaseQuantity();
            return;
        }
        hashTable.Add(word, new WordQuantityContainer(word));
    }

    public Int64 GetHashTableSize()
    {
        return hashTable.Count;
    }
    
    public WordQuantityContainer[] GetAllWordQuantityContainers(Int64 size)
    {
        ulong lastIndex = 0;
        WordQuantityContainer[] arrayWordQuantityContainers = new WordQuantityContainer[size];
        foreach (var tempContainer in hashTable.Values)
        {
            arrayWordQuantityContainers[lastIndex] = tempContainer;
            lastIndex++;
        }
        return arrayWordQuantityContainers;
    }
}