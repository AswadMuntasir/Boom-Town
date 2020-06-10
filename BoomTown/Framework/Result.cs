using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoomTown.Framework
{
    public class Result<T>
    {
        public T Data { get; set; }
        public int Count { get; set; }
        public bool HasError { get; set; }
        public string Message { get; set; }
    }
}
