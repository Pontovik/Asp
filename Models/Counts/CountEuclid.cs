using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIB.Models.Counts.Lists;
namespace UIB.Models.Counts
{
    public class Arr3
    {
        public Arr3() { A1 = A2 = A3 = 0; }
        public long A1 { get; set; }
        public long A2 { get; set; }
        public long A3 { get; set; }
    }

    public class CountEuclid : EuclidLists
    {
        public long Index1 { get; set; }
        public long Index2 { get; set; }
       
       
        public void Euclid()
        {
            long more = Index1;
            long less = Index2;
            if (more < less)
            {
                var temp = more;
                more = less;
                less = temp;
            }
          
           
            Arr3 U = new Arr3 { A1 = more, A2 = 1, A3 = 0 };
            Arr3 V = new Arr3 { A1 = less, A2 = 0, A3 = 1 };

            long q;long rem; 
            while (V.A1 != 0)
            {
                 q = U.A1 / V.A1;
                rem = U.A1 % V.A1;
                Remainders.Add(rem);
                Factors.Add(q);
                Quots.Add(V.A1);
                TempResults.Add(U.A1);
                Arr3 T = new Arr3 { A1 = U.A1 % V.A1, A2 = U.A2 - q * V.A2, A3 = U.A3 - q * V.A3 };
                U = V;
                V = T;
            }
            this.Results.AddRange(new List<long> {  U.A2, U.A3 });

        }
        
        public void ReverseEuclid( )
        {
            
        }
    }
}
