namespace CollectionHierarchy.Collections
{
    using CollectionHierarchy.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class MyList : AddRemoveCollection, IMyList
    {
        public int Used => base.Collection.Count;

        public override string Remove()
        {
            string firstElement = base.Collection.First();
            base.Collection.RemoveAt(0);
            return firstElement;
        }
    }
}
