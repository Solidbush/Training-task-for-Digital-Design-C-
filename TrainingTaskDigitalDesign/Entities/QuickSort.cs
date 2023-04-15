using TrainingTaskDigitalDesign.Models;

namespace TrainingTaskDigitalDesign.Entities;

public class QuickSort
{
    public WordQuantityContainer[] QuickSortAlgorithm(WordQuantityContainer[] array, Int64 minIndex, Int64 maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        Int64 pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

        QuickSortAlgorithm(array, minIndex, pivotIndex - 1);

        QuickSortAlgorithm(array, pivotIndex + 1, maxIndex);

        return array;
    }

    private static Int64 GetPivotIndex(WordQuantityContainer[] array, Int64 minIndex, Int64 maxIndex)
    {
        Int64 pivot = minIndex - 1;

        for (Int64 i = minIndex; i <= maxIndex; i++)
        {
            if (array[i].GetQuantity() < array[maxIndex].GetQuantity())
            {
                pivot++;
                Swap(array, pivot, i);
            }
        }

        pivot++;
        Swap(array, pivot, maxIndex);

        return pivot;
    }

    private static void Swap(WordQuantityContainer[] array, Int64 leftItem, Int64 rightItem)
    {
        WordQuantityContainer temp = array[leftItem];
        array[leftItem] = array[rightItem];
        array[rightItem] = temp;
    }
}
