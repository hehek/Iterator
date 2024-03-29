﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteDatabase:  Database
    {
        private ArrayList _items = new ArrayList();

        public ConcreteDatabase(int n)
        {
             for (int i =1; i<n+1; i++)
            _items.Add(String.Format("{0} item",i));         

        }


        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        
        public int Count
        {
            get { return _items.Count; }
        }

        
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
