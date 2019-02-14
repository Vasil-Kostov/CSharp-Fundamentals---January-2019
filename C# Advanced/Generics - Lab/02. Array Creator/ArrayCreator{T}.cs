namespace GenericArrayCreator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T value)
        {
            T[] array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = value;
            }

            return array;
        }
    }
}
