namespace src;

public class Store<T> where T : IHasId
{
  private readonly Dictionary<int, T> _items = new();
  public IReadOnlyDictionary<int, T> Items => _items;

  public void Add(T item)
  {
    ArgumentNullException.ThrowIfNull(item, nameof(item));
    if (_items.ContainsKey(item.Id))
      throw new ArgumentException($"Item with Id {item.Id} already exists.", nameof(item));

    _items.Add(item.Id, item);
  }

  public T? GetById(int id)
  {
    // more safe than using _items[id] because it will 
    // throw an exception if the key does not exist
    if (_items.TryGetValue(id, out var item))
      return item;

    return default; 
  }

  public IReadOnlyDictionary<int, T> GetAll() => Items;
  
  public void Remove(int id)
  {
    var item = GetById(id);

    if (item is not null)
      _items.Remove(item.Id);
  }
}