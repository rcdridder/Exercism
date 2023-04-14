using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Constructors
{
    internal class RailFenceCipher
    {
        int rails;
        public RailFenceCipher(int rails) => this.rails = rails;

        public string Encode(string input)
        {
            char[,] matrix = new char[rails, input.Length];
            bool goDown = false;
            int row = 0, col = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if(row == 0 || row == rails - 1)
                    goDown = !goDown;
                matrix[row, col] = input[i];
                col++;
                if (goDown)
                    row++;
                else
                    row--;
            }
            
            string encodedMessage = string.Empty;
            for (int i = 0; i < rails; i++)
                for (int j = 0; j < input.Length; j++)
                    if (matrix[i, j] != 0)
                        encodedMessage += matrix[i, j];
            return encodedMessage;
        }

        public string Decode(string input)
        {
            char[,] matrix = new char[rails, input.Length];
            bool goDown = false;
            int row = 0, col = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (row == 0 || row == rails - 1)
                    goDown = !goDown;
                matrix[row, col] = '*';
                col++;
                if (goDown)
                    row++;
                else
                    row--;
            }
            
            int index = 0;
            for(int i = 0; i < rails; i++)
                for(int j = 0; j < input.Length; j++)
                    if(matrix[i, j] == '*' && index < input.Length)
                    {
                        matrix[i, j] = input[index];
                        index++;
                    }
            
            string decodedMessage = string.Empty;
            goDown= false; 
            row = 0; col = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (row == 0 || row == rails - 1)
                    goDown = !goDown;
                decodedMessage += matrix[row, col];
                col++;
                if (goDown)
                    row++;
                else
                    row--;
            }
            return decodedMessage;
        }
    }
}
