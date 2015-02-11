using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLearningAlgorithm
{
 
    public class NumberTable
    {
        public double[] data;
        public int rowCount;
        public int colCount;

        public NumberTable(int rowCount, int colCount, double? defaultValue)
        {
            this.rowCount = rowCount;
            this.colCount = colCount;
            var rand = new Random();
            data = new double[rowCount*colCount];
            for (var i = 0; i < rowCount*colCount; i++)
            {
                data[i] = defaultValue ?? (double)rand.Next(0, 2000);
            }

            //data = Enumerable.Repeat<double>(rand.Next()*10, rowCount * colCount).ToArray();
        }

        public void UpdateValue(int row, int col, double value)
        {
            data[row * colCount + col] = value;
        }

        public void AddValue(int row, int col, double value)
        {
            data[row * colCount + col] += value;
        }

        public double GetValue(int row, int col)
        {
            return data[row*colCount + col];
        }

        public int GetRowMaxColumn(int row)
        {
            var maxIndex = -1;
            var maxUtility = Double.MinValue;
            for (var i = row*colCount; i < (row + 1)*colCount; i++)
            {
                if (data[i] > maxUtility)
                {
                    maxIndex = i;
                    maxUtility = data[i];
                }
            }
            return maxIndex%colCount;
        }
    }
}
