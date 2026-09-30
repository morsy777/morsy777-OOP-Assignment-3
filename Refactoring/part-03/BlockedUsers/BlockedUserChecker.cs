using System.Diagnostics;

namespace RefactoringLab.Part03.BlockedUsers;

public static class BlockedUserChecker
{
    public static int CountBlocked(HashSet<int> blockedIds, int[] requestIds)
    {
        var blocked = 0;
        foreach (var id in requestIds) // O(n)
        {
            if (blockedIds.Contains(id)) // O(1) after using HashSet, List was O(n) before
                blocked++;
        }
        return blocked;
    }

  // In adding we can use list because it is O(1) amortized for adding
  // but I well use HashSet, because I will pass it to CoutBlocked().
    public static HashSet<int> BuildBlockedIds(int count)
    {
        var set = new HashSet<int>();
        for (var i = 0; i < count; i++)
            set.Add(i);
        return set;
    }

    public static int[] BuildRequestIds(int count, int maxId, int seed = 42)
    {
        var rnd = new Random(seed);
        var ids = new int[count];
        for (var i = 0; i < count; i++)
            ids[i] = rnd.Next(maxId);
        return ids;
    }

    public static long MeasureMs(HashSet<int> blockedIds, int[] requestIds, out int found)
    {
        var sw = Stopwatch.StartNew();
        found = CountBlocked(blockedIds, requestIds);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
}
