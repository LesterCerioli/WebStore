using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure
{
    public class Result<TValue> : Result
    {
        public TValue Value { get; set; }
        
        protected internal Result(TValue value, bool success, string error)
            : base(success, error)
        {
            value = value;
        }
    }
}
