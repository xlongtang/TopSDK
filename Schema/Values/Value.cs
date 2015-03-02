using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Schema.Values
{
    public class Value
    {
        protected string id;
        protected string value;

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string PropertyValue
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Value()
        {
        }
        public Value(string value)
        {
            this.value = value;
        }
        public Value(string id, string value)
        {
            this.value = value;
            this.id = id;
        }
    }
}
