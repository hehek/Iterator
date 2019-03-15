using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class ConcreteIterator: Iterator
    {
        private ConcreteDatabase _database;
        private int _current = 0;

        // Constructor
        public ConcreteIterator(ConcreteDatabase database)
        {
           _database = database;
        }

        // Gets first iteration item
        public override object First()
        {
            return _database[0];
        }

        // Gets next iteration item
        public override object Next()
        {
            
            if (_current < _database.Count - 1)
            {
                _current++;               
            }
            else
            {
                _current = 0;
            }            
            return _database[_current];
        }

        public override object Prev()
        {         
            if (_current > 0)
            {
                _current--;               
            }
            else
            {
                _current = _database.Count - 1;              
            }
            return _database[_current];
        }


        // Gets current iteration item
        public override object CurrentItem()
        {
            return _database[_current];
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _database.Count;
        }
    }
}

