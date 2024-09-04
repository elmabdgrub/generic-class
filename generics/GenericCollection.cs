public class GenericCollection<T> where T : struct
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T GetItem(int index)
    {
        return items[index];
    }

    public List<T> SortDescending()
    {
        return items.OrderByDescending(x => x).ToList();
    }
}
