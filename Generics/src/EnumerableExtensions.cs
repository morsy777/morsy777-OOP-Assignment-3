using System.Security.Cryptography.X509Certificates;

namespace src;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
      // newSource = span(pageNumber * pageSize, pageSize)
      // var newSource = new Span<T>(source.ToArray(), pageNumber * pageSize, pageSize);
      // foreach (var item in newSource)
      //   yield return item;

      // int startIndex = pageNumber * pageSize;
      // int endIndex = startIndex + pageSize;

      // for (int i = startIndex; i < endIndex && i < source.Count(); i++) //source.Count() to avoid exception when the last page has fewer items than pageSize
      // {
      //   yield return source[i];
      // } // IEnumerable<T> does not support indexing.

      // this some thing like a window in ps.
      int startIndex = pageNumber * pageSize;
      int endIndex = startIndex + pageSize;
      int ptr = 0; // if we make ptr = startIndex, we will skip the first pageSize items in the source, which is not what we want.
      foreach (var item in source)
      {
        if (ptr >= startIndex && ptr < endIndex)
          yield return item;
        
        ptr++;
      }
    }

    public static IEnumerable<T> FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
    {
      foreach (var item in source)
      {
        if (item.Id == id)
          yield return item;
      }
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {
      var dict = new Dictionary<int, T>();
      foreach (var item in source)
      {
        if(dict.ContainsKey(item.Id))
          continue;
        
        dict.Add(item.Id, item);
      }
      return dict;
    }
}