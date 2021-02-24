using Microsoft.ClearScript.V8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            V8ScriptEngine eng = new V8ScriptEngine();
            Map map = new Map();
            eng.AddHostObject("calculator", new Calculator());
            eng.AddHostObject("map", map);
            eng.Execute("let result = calculator.Sum(1, 2);");
            eng.Execute("map.Put('#ref', {r: result});");
            Console.WriteLine(eng.Evaluate("map.Get('#ref').r.Response"));
            Console.Read();
        }
    }
}
