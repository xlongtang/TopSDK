using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Schema.Property
{
    public class Property
    {
        protected string key;

        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        protected string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public Property(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
