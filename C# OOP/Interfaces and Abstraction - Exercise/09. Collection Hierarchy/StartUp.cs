namespace CollectionHierarchy
{
    using CollectionHierarchy.Interfaces;
    using Collections;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myListCollection = new MyList();

            string[] elements = Console.ReadLine().Split();

            AddElements(addCollection, elements);
            AddElements(addRemoveCollection, elements);
            AddElements(myListCollection, elements);

            int numberOfElementsToRemove = int.Parse(Console.ReadLine());

            RemoveElements(addRemoveCollection, numberOfElementsToRemove);
            RemoveElements(myListCollection, numberOfElementsToRemove);
        }

        private static void RemoveElements(IAddRemoveCollection collection, int numberOfElementsToRemove)
        {
            for (int i = 0; i < numberOfElementsToRemove; i++)
            {
                Console.Write(collection.Remove() + " ");
            }

            Console.WriteLine();
        }

        private static void AddElements(IAddCollection collection, string[] elements)
        {
            foreach (var element in elements)
            {
                Console.Write(collection.Add(element) + " ");
            }

            Console.WriteLine();
        }
    }
}
