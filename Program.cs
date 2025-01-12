// File: Program.cs
using System;
using csharp_playground.datastructures.LinkedList; // Ensure this matches your namespace
using csharp_playground.datastructures.Arrays; // Ensure this matches your namespace

class Program
{
    static void Main(string[] args)
    {
        // SinglyLinkedListTest singlyLinkedListTest = new();
        // singlyLinkedListTest.RunTest();

        // DoublyLinkedListTest doublyLinkedListTest = new();
        // doublyLinkedListTest.RunTest();

        // FixedArrayTest fixedArrayTest = new();
        // fixedArrayTest.RunTest();
        DynamicArrayTest dynamicArrayTest = new();
        dynamicArrayTest.RunTest();
    }
}
