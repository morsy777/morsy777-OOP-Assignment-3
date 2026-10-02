namespace src;

public class Store<T> where T : IHasId
{
  private readonly List<T> _items = new();
  public IReadOnlyList<T> Items => _items;

  public void Add(T item)
  {
    ArgumentNullException.ThrowIfNull(item, nameof(item));
    _items.Add(item);
  }

  public T? GetById(int id)
  {
    foreach (var item in _items)
    {
      if (item.Id == id)
        return item;
    }

    return default; 
  }

  public IReadOnlyList<T> GetAll() => Items;
  
  public void Remove(int id)
  {
    var item = GetById(id);

    if (item is not null)
      _items.Remove(item);
  }
}