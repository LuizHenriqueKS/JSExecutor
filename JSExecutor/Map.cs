using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSExecutor
{
    public class Map
    {
        private Dictionary<String, Object> dict;

        public Map()
        {
            dict = new Dictionary<String, Object>();
        }

        public void Put(String key, Object value)
        {
            dict.Add(key, value);
        }

        public Object Get(String key)
        {
            return dict[key];
        }

    }
}
