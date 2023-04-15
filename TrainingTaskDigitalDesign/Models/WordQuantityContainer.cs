namespace TrainingTaskDigitalDesign.Models;

public class WordQuantityContainer
{
    private const int StartConditions = 1;
    private int quantity;
    public WordQuantityContainer(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            throw new ArgumentNullException(word);
        Word = word;
        quantity = StartConditions;
    }
    
    public string Word { get; }

    public void IncreaseQuantity()
    {
        quantity++;
    }

    public int GetQuantity()
    {
        return quantity;
    }
}