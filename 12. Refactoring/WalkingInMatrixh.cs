namespace MatrixWalking
{
    using System;

    class WalkingInMatrix
    {
        static void Change(ref int directionX, ref int directionY)
        {
            int[] chanceDirectionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] changeDirectionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < chanceDirectionX.Length; count++)
            {
                if (chanceDirectionX[count] == directionX && changeDirectionY[count] == directionY)
                {
                    cd = count; 
                    break;
                }
            }

            if (cd == 7)
            {
                directionX = chanceDirectionX[0];
                directionY = changeDirectionY[0];
                return;
            }

            directionX = chanceDirectionX[cd + 1];
            directionY = changeDirectionY[cd + 1];
        }
        static bool Check(int[,] matrix, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < dirX.Length; i++)
            {
                if (x + dirX[i] >= matrix.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= matrix.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < dirY.Length; i++)
            {
                if (matrix[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void FindCell(int[,] matrix, out int dimensionX, out int dimensionY)
        {
            dimensionX = 0;
            dimensionY = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(0); cols++)
                {
                    if (matrix[rows, cols] == 0)
                    {
                        dimensionX = rows;
                        dimensionY = cols;
                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int matrixSize = 0;
            //while ( !int.TryParse( input, out matrixSize ) || matrixSize < 0 || matrixSize > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}
            int matrixSize = 5;
            int[,] matrix = new int[matrixSize, matrixSize];
            int step = matrixSize, k = 1, matrixRow = 0, matrixCol = 0, dimensionX = 1, dimensionY = 1;

            while (true)
            {
                matrix[matrixRow, matrixCol] = k;

                if (!Check(matrix, matrixRow, matrixCol))
                {
                    break;
                } 


                if (matrixRow + dimensionX >= matrixSize || matrixRow + dimensionX < 0 || matrixCol + dimensionY >= matrixSize || matrixCol + dimensionY < 0 || matrix[matrixRow + dimensionX, matrixCol + dimensionY] != 0)

                { 
                    while ((matrixRow + dimensionX >= matrixSize || matrixRow + dimensionX < 0 || matrixCol + dimensionY >= matrixSize || matrixCol + dimensionY < 0 || matrix[matrixRow + dimensionX, matrixCol + dimensionY] != 0))
                    {
                        Change(ref dimensionX, ref dimensionY);
                    }
                }

                matrixRow += dimensionX;
                matrixCol += dimensionY;
                k++;
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }

            FindCell(matrix, out matrixRow, out matrixCol);

            if (matrixRow != 0 && matrixCol != 0)
            { 
                dimensionX = 1;
                dimensionY = 1;

                while (true)
                {
                    matrix[matrixRow, matrixCol] = k;

                    if (!Check(matrix, matrixRow, matrixCol))
                    {
                        break; 
                    }

                    var caseOne = matrixRow + dimensionX >= matrixSize;
                    var caseTwo = matrixRow + dimensionX < 0;
                    var caseThree = matrixCol + dimensionY >= matrixSize;
                    var caseFour = matrixCol + dimensionY < 0;
                    var caseFive = matrix[matrixRow + dimensionX, matrixCol + dimensionY];

                    ChanceDirection(ref dimensionX, ref dimensionY, caseOne, caseTwo, caseThree, caseFour, caseFive);

                    matrixRow += dimensionX;
                    matrixCol += dimensionY;
                    k++;
                    
                }
            }

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void ChanceDirection(ref int dimensionX, ref int dimensionY, bool caseOne, bool caseTwo, bool caseThree, bool caseFour, int caseFive)
        {
            if (caseOne || caseTwo || caseThree || caseFour || caseFive != 0)
            {
                while ((caseOne || caseTwo || caseThree || caseFour || caseFive != 0))
                {
                    Change(ref dimensionX, ref dimensionY);
                }
            }
        }
    }
}
