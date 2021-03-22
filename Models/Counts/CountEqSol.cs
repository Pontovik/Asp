using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIB.Models.Counts
{
    public class CountEqSol
    {
        public long X { get; set; }
        public long Y { get; set; }
        public long R { get; set; }
        public long Q { get; set; }
        public List<long> Results { get; set; } = new List<long>();
        public List<long> FromForm { get; set; } = new List<long>();
        public long[,] Matrix { get; set; } = { { 1, 0 }, { 0, 1 } };
        public long[,] Solution()
        {
            FromForm.Add(X);
            FromForm.Add(Y);
            R = 1;
            for(;;)
            {
                Q = X / Y;
                R = X - Y * Q;
                if (R == 0)
                {
                    break;
                }
                X = Y;
                Y = R;
               
                Matrix = MulMatrix(Matrix, new long[,] { { 0, 1 }, { 1, Q * (-1) } }, 2, 2);
                for(int i = 0; i < 2; i++)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        Results.Add(Matrix[i, j]);
                    }
                }
            }
            return Matrix;

        }
        public long[,] MulMatrix(long [,] X,long[,]Y,int n,int m)
        {
            
            Matrix = new long[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    for (int k = 0; k < n; k++) {
                        Matrix[i, j] += X[i, k] * Y[k, j];
                            }
                }
            }
            return Matrix;
        }
    }
}
