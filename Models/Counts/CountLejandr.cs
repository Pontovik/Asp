using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.Counts
{
    
        
    
    public class CountLejandr : CountExp
    {
        public List<long> ResultLejandr { get; set; } = new List<long>();
        public long Lejandr()
        {
            this.Degree = (this.Module - 1)/2;   
            return this.Exp();
        }
        public long Answer()
        {
            var count = new CountLejandr();
            count *= this;
            if (count.Data > count.Module)
            {
                count.Data = count.Mod(new CountLejandr { Res = count.Data, Module = count.Module });
            }
            long result = count.Res;
            if (result == 1)
            {
                for (long i = 1; i < count.Degree; i++)
                {
                    result = count.Pow(i, 2);
                    result = count.Mod(new CountLejandr { Res = result, Module = count.Module });                   
                        if (result == count.Data)
                        {
                            result = i;
                            break;
                        }
                    
                }
            }   
            return result;
        }       
        public static CountLejandr operator *(CountLejandr first, CountLejandr second)
        {
            first.Data = second.Data;
            first.Module = second.Module;
            first.Degree = second.Degree;
            first.Res = second.Res;
            return  first;
        }
    }
}
