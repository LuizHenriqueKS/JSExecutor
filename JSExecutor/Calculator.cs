using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSExecutor
{
    public class Calculator
    {
        public Result Sum(int param1, int param2)
        {
            Result result = new Result();
            result.Param1 = param1;
            result.Param2 = param2;
            result.Response = param1 + param2;
            return result;
        }
    }
}
