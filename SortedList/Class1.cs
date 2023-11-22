using System.Collections;
public class CustomSortedCollection<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>

{
    private List<KeyValuePair<TKey, TValue>> items = new List<KeyValuePair<TKey, TValue>>();

    public void AddElement(TKey key, TValue value)
    {
        items.Add(new KeyValuePair<TKey, TValue>(key, value));
        items = items.OrderBy(item => item.Key).ToList();
    }

    public bool RemoveElement(TKey key)
    {
        int indexToRemove = items.FindIndex(item => EqualityComparer<TKey>.Default.Equals(item.Key, key));

        if (indexToRemove >= 0)
        {
            items.RemoveAt(indexToRemove);
            return true;
        }

        return false;
    }

    public void DisplayElements()
    {
        Console.WriteLine("Elements in the collection:");
        foreach (var item in items)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}