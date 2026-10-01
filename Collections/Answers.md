# Task 2.1 

## IReadOnlyDictionary<TKey, TValue>
- is an interface that represents a read-only dictionary, so we can access the pairs without modifying them.

- the main difference between it and Dictionary is that it doesn't allow modification such as add or remove items.

- public mehtod have to return IReadOnlyDictionary instead of Dictionary, to avoid modifiying the internal state of the dictionary at end I would say **Using IReadOnlyDictionary achive Encapsulation**.


## SortedDictionary<TKey, TValue>
- is same as Dictionary but store the items sorted by key.

- the main difference between it and Dictionary is the ordering & searching time complexity, sorted dictionary is implemented internally as a binary search tree, so the time complexity of searching is O(log n) while in Dictionary it is O(1).

- I would use it if I need to keep the items sorted by key, but I don't need to add or remove items frequently because it adding, removing the items in its right ordered space.

# Task 2.2

- **S1**  Find a student by national ID — thousands of times a day: 
  - I would use Dictionary because we searching frequently and it has O(1) time complexity for searching.
- **S2** Keep the tags of a course. The same tag must never be stored twice:
  - I would use HashSet because it doesn't allow duplicates, also it has O(1) time complexity for searching because it uses a hash table internally.
- **S3** Keep a student's grades in the order they were entered. The same grade can appear more than once:
  - I would use List because it allows duplicates and it keeps the order of the items as they were added.
- **S4** A public method returns the course price list. Callers can read prices but must not add or change any.
  - I would use IReadOnlyDictionary because it doesn't allows the caller to modify the internal state of the dictionary, also it has O(1) time complexity for searching.
- **S5**  A timetable keyed by session start time. Sessions are added at any moment, and it must always print in
time order: 
  - I would use SortedDictionary because it keeps the items sorted by key, also it has O(log n) time complexity for searching.
- **S6**  A method returns results that the caller only loops over once — and may stop early:
  - I would use IEnumerable because it allows the caller to loop over the items and stop early, because it use lazy evaluation ***yield return***.