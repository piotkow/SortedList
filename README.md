# SortedList

# SortedListCollection ReadMe

This C# code defines a `SortedListCollection<T>` class, a custom collection for maintaining a sorted list of elements. The collection allows you to add, remove, and clear elements while keeping them in sorted order. It also provides an option to filter elements using LINQ during iteration.

## Table of Contents
- [Introduction](#introduction)
- [Usage](#usage)
- [Methods](#methods)
- [Example](#example)

## Introduction

The `SortedListCollection<T>` class is designed to provide a sorted collection of elements of type `T`. It uses the `BinarySearch` method to efficiently locate the position to insert or remove elements while maintaining the sorted order. This allows for quick retrieval and modification of elements in a sorted fashion.

## Usage

To use the `SortedListCollection<T>`, you need to create an instance of it, and then you can add, remove, and iterate through elements in sorted order. Additionally, you can apply filtering using LINQ during iteration.

## Methods

### Add
```csharp
public void Add(T item)

## Remove
```csharp
public void Remove(T item)

## RemoveClear
```csharp
public void Clear()

## GetEnumerator
```csharp
public IEnumerator<T> GetEnumerator()

## Filter
```csharp
public IEnumerable<T> Filter(Func<T, bool> predicate)

## Example
```csharp
class Program
{
    static void Main()
    {
        // Create an instance of the custom collection
        var sortedListCollection = new SortedListCollection<int>();

        // Add elements to the collection
        sortedListCollection.Add(5);
        sortedListCollection.Add(3);
        sortedListCollection.Add(8);
        sortedListCollection.Add(1);

        // Display elements in the sorted order
        Console.WriteLine("Sorted List:");
        foreach (var item in sortedListCollection)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        sortedListCollection.Remove(3);

        // Display elements after removal
        Console.WriteLine("\nAfter Removal:");
        foreach (var item in sortedListCollection)
        {
            Console.WriteLine(item);
        }

        // Filter elements using LINQ during iteration
        Console.WriteLine("\nFiltered Elements (Greater than 4):");
        foreach (var item in sortedListCollection.Filter(x => x > 4))
        {
            Console.WriteLine(item);
        }
    }
}

