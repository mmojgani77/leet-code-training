// using System.Runtime.InteropServices;
//
// namespace ArraysAndStrings.InsertDeleteGetRandom;
//
// public class RandomizedSet
// {
//     private readonly Dictionary<int, int> _map;
//     private readonly Dictionary<int, int> _revMap;
//     private int _nextIdx;
//     
//     public RandomizedSet()
//     {
//         _map = new Dictionary<int, int>();
//         _revMap = new Dictionary<int, int>();
//         _nextIdx = 0;
//     }
//
//     public bool Insert(int val)
//     {
//         if (_map.ContainsKey(val))
//             return false;
//
//         var idx = _nextIdx++;
//         
//         _map[val] = idx;
//         _revMap[idx] = val;
//
//         return true;
//     }
//
//     public bool Remove(int val)
//     {
//         if (!_map.Remove(val, out var idx))
//             return false;
//
//         int lastIdx = _nextIdx - 1;
//         
//         if (lastIdx == idx)
//         {
//             _nextIdx--;
//             _revMap.Remove(idx);
//             return true;
//         }
//
//         _revMap.Remove(lastIdx, out var newVal);
//
//         _map[newVal] = idx;
//
//         _revMap[idx] = newVal;
//
//         _nextIdx--;
//
//         return true;
//     }
//
//     public int GetRandom()
//     {
//         var idx = Random.Shared.Next(_nextIdx);
//         return _revMap[idx];
//     }
// }
//
// public class Solution3
// {
//     public static void Main()
//     {
//         Console.WriteLine();
//         RandomizedSet randomizedSet = new RandomizedSet();
//
//         // // Console.WriteLine(randomizedSet.GetRandom()); // Returns false as 2 does not exist in the set.
//         //
//         // Console.WriteLine(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
//         // Console.WriteLine(randomizedSet.Remove(1)); // Returns false as 2 does not exist in the set.
//         // Console.WriteLine(randomizedSet.Remove(3)); // Returns false as 2 does not exist in the set.
//         // Console.WriteLine(randomizedSet.Insert(1)); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
//         // Console.WriteLine(randomizedSet.Insert(2)); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
//         // Console.WriteLine(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
//         // Console.WriteLine(randomizedSet.Remove(1)); // Returns false as 2 does not exist in the set.
//         // Console.WriteLine(randomizedSet.Remove(1)); // Returns false as 2 does not exist in the set.
//         //
//         // Console.WriteLine(randomizedSet.Insert(int.MinValue)); // Inserts 2 to the set, returns true. Set now contains [1,2].
//         // // Console.WriteLine(randomizedSet.GetRandom()); // getRandom() should return either 1 or 2 randomly.
//
//
//         Console.WriteLine(randomizedSet.Insert(1)); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
//         Console.WriteLine(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
//         Console.WriteLine(randomizedSet.Insert(2)); // Inserts 2 to the set, returns true. Set now contains [1,2].
//         Console.WriteLine(randomizedSet.GetRandom()); // getRandom() should return either 1 or 2 randomly.
//         Console.WriteLine(randomizedSet.Remove(1)); // Removes 1 from the set, returns true. Set now contains [2].
//         Console.WriteLine(randomizedSet.Insert(2)); // 2 was already in the set, so return false.
//         Console.WriteLine(randomizedSet.GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
//     }
//
//
//     // public static void Main()
//     // {
//     //     Console.WriteLine();
//     //     RandomizedSet randomizedSet = new RandomizedSet();
//     //     Console.WriteLine(randomizedSet.Insert(6));
//     //     Console.WriteLine(randomizedSet.Insert(7));
//     //     Console.WriteLine(randomizedSet.Insert(10));
//     //     Console.WriteLine(randomizedSet.Insert(3));
//     //     Console.WriteLine(randomizedSet.Insert(8));
//     //     Console.WriteLine(randomizedSet.GetRandom());
//     //     Console.WriteLine(randomizedSet.GetRandom());
//     //     Console.WriteLine(randomizedSet.GetRandom());
//     //     Console.WriteLine(randomizedSet.GetRandom());
//     //     Console.WriteLine(randomizedSet.GetRandom());
//     //     
//     // }
// }