using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.Counts
{
    public static class MyMethod
    {
        public static List<long> ReverseList(this List<long> list)
        {
            var counts = new List<long>();
            var TempList = list;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                counts.Add(TempList[i]);
            }
            return counts;
        }

    }
    public class CountExp
    {

        public long Data { get; set; }
        public long Degree { get; set; }
        public long Module { get; set; }
        public long Res { get; set; }
        public List<long> Counts { get;set;}
        public List<long> TempRes { get; set; } = new List<long>();
        public List<long> ToBinary()
        {

            var counts = new List<long>();
            long temp = 0;
            var count = this.Degree;
            for (; count != 0;)
            {
                temp = count % 2;
                count /= 2;
                counts.Add(temp);
            }

            return counts;

        }
        public long Exp()
        {
            var result = this.Data;
            var x = this.Data;
            if (result > this.Module)
            {
                this.Res = result;
                result = this.Mod(this);
                x = result;
            }

            Counts = this.ToBinary().ReverseList();
            this.TempRes.Add(result);
            for (int i = 1; i < Counts.Count(); i++)
            {
                result = this.Pow(result, 2) * this.Pow(x, Counts[i]);

                this.Res = result;
                result = this.Mod(this);
                this.TempRes.Add(result);
            }
            return result;
        }
        public long Mod(CountExp count)
        {
            count.Res = count.Res - count.Module * (count.Res / count.Module);

            return count.Res;
        }
        public long SubMod(long x)
        {
            
            x = this.Module - x;
            return x;
        }
        
        public long Pow(long count, long x)
        {
            var res = count;
            if (x == 0)
            {
                res = 1;
            }
            else
            {
                for (int i = 0; i < x - 1; i++)
                {

                    res *= count;
                }
            }
            return res;
        }

    }
}


