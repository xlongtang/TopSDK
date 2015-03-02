using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Schema.Rules
{
    public class DefaultRule : Rule
    {
        public DefaultRule(string name, string value)
            : base(name, value)
        {
        }

        public DefaultRule(string name, string value, string exProperty)
            : base(name, value, exProperty)
        {
        }
    }
}
