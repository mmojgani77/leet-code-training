// namespace ArraysAndStrings.InsertDeleteGetRandom;
//
// public class RandomizedSet
// {
//     class Cell(int value, bool isRewritable)
//     {
//         public int Value { get; set; } = value;
//         public bool IsRewritable { get; set; } = isRewritable;
//     };
//
//     private const int Capacity = 8;
//     private readonly Cell?[] _hashset;
//
//     public RandomizedSet()
//     {
//         _hashset = new Cell?[Capacity];
//     }
//
//     public bool Insert(int val)
//     {
//         var hashCode = val % Capacity;
//         hashCode = Math.Abs(hashCode);
//         if (_hashset[hashCode] == null || _hashset[hashCode]!.IsRewritable)
//         {
//             _hashset[hashCode] = new Cell(val, false);
//             return true;
//         }
//
//         do
//         {
//             if (_hashset[hashCode] == null)
//             {
//                 _hashset[hashCode] = new Cell(val, false);
//                 return true;
//             }
//
//             if (_hashset[hashCode]!.IsRewritable)
//             {
//                 _hashset[hashCode]!.Value = val;
//                 _hashset[hashCode]!.IsRewritable = false;
//                 return true;
//             }
//
//             if (_hashset[hashCode]!.Value == val)
//                 return false;
//
//             hashCode = (hashCode + 1) % Capacity;
//         } while (true);
//
//         return false;
//     }
//
//     public bool Remove(int val)
//     {
//         var hashCode = val % Capacity;
//         hashCode = Math.Abs(hashCode);
//         if (_hashset[hashCode] != null && _hashset[hashCode]!.Value == val && !_hashset[hashCode]!.IsRewritable)
//         {
//             _hashset[hashCode]!.IsRewritable = true;
//             return true;
//         }
//
//         do
//         {
//             if (_hashset[hashCode] == null)
//                 return false;
//
//             if (_hashset[hashCode]!.Value == val)
//             {
//                 if (_hashset[hashCode]!.IsRewritable)
//                     return false;
//
//                 _hashset[hashCode]!.IsRewritable = true;
//                 return true;
//             }
//
//             hashCode = (hashCode + 1) % Capacity;
//         } while (true);
//
//         return false;
//     }
//
//     public int GetRandom()
//     {
//         var hashCode = Random.Shared.Next(Capacity);
//
//         if (_hashset[hashCode] != null && !_hashset[hashCode]!.IsRewritable)
//         {
//             return _hashset[hashCode]!.Value;
//         }
//
//         do
//         {
//             if (_hashset[hashCode] != null && !_hashset[hashCode]!.IsRewritable)
//             {
//                 return _hashset[hashCode]!.Value;
//             }
//
//             hashCode = (hashCode + 1) % Capacity;
//         } while (true);
//
//         return 0;
//     }
// }
//
// public class Solution
// {
//     // public static void Main()
//     // {
//     //     Console.WriteLine();
//     //     RandomizedSet randomizedSet = new RandomizedSet();
//     //     Console.WriteLine(randomizedSet.Insert(1)); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
//     //     Console.WriteLine(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
//     //     Console.WriteLine(randomizedSet.Insert(2)); // Inserts 2 to the set, returns true. Set now contains [1,2].
//     //     Console.WriteLine(randomizedSet.GetRandom()); // getRandom() should return either 1 or 2 randomly.
//     //     Console.WriteLine(randomizedSet.Remove(1)); // Removes 1 from the set, returns true. Set now contains [2].
//     //     Console.WriteLine(randomizedSet.Insert(2)); // 2 was already in the set, so return false.
//     //     Console.WriteLine(randomizedSet.GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
//     // }
//     //
//     
//     public static void Main()
//     {
//         Console.WriteLine();
//         RandomizedSet randomizedSet = new RandomizedSet();
//         Console.WriteLine(randomizedSet.Insert(6));
//         Console.WriteLine(randomizedSet.Insert(7));
//         Console.WriteLine(randomizedSet.Insert(10));
//         Console.WriteLine(randomizedSet.Insert(3));
//         Console.WriteLine(randomizedSet.Insert(8));
//         Console.WriteLine(randomizedSet.GetRandom());
//         Console.WriteLine(randomizedSet.GetRandom());
//         Console.WriteLine(randomizedSet.GetRandom());
//         Console.WriteLine(randomizedSet.GetRandom());
//         Console.WriteLine(randomizedSet.GetRandom());
//         
//     }
// }