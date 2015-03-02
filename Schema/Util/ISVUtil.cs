using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Values;

namespace Top.Schema.Util
{
    public class ISVUtil
    {
        public static List<Value> GetValueListFromString(List<String> values)
        {
            if (values == null)
            {
                return null;
            }
            List<Value> result = new List<Value>();
            foreach (string v in values)
            {
                Value value = new Value();
                value.PropertyValue = v;
                result.Add(value);
            }
            return result;
        }
    }
}
