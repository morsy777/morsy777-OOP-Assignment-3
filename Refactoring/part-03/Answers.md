# Part 03 — answers

---

## BlockedUsers

- Time complexity before:
> for CountBlocked() the time complexity was O(n^2), O(n) for the outer loop and O(n) for the searching in list (Contains() method).
> for BuildBlockedIds() the time complexity was O(n) for the outer loop and O(1) for the Adding to list (Add() method).
> for BuildRequestIds() the time complexity was O(n) for the outer loop and O(1) for direct access from the list (ids[i]).

- Time (ms) before:
> The actual time is 25ms whichs bad.

- What did you change?
> I changed the data structure for blockedIds from List<int> to HashSet<int> in CountBlocked() becase it provide O(1) time complexity for searching (Contains() method) instead of O(n) for List<int>. I also changed the return type of BuildBlockedIds() to HashSet<int> to match the new data structure.

- Time complexity after:
> for CountBlocked() the time complexity is O(n), O(n) for the outer loop and O(1) for the searching in HashSet (Contains() method).

- Time (ms) after:
> The actual time is 0ms which is much better than before.

---

## Students

- What was the problem?
> The GetAllStudents() method because it make **eager creation** by creating a list of all students in memory, which was inefficient for large datasets.

- What did you change?
> I changed the GetAllStudents() method to make it as iterator method that return an IEnumerable<Student> instead of a List<Student>, allowing for lazy evaluation and better memory usage.

> I test my solution by make a break point at yield line to ensure that the method will return only the 3 students and then break and doesn't create all students in memory.

> **Iterator method** is the method that returns more than one time, get the value return it and then continue until the end of the method.