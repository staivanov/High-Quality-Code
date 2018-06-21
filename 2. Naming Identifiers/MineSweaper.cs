using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper
{
    public class Mines
    {
        public class Points
        {
            private string _name;
            private int _point;

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }

            public int Point
            {
                get
                {
                    return _point;
                }
                set
                {
                    _point = value;
                }
            }

            public Points() { }

            public Points(string name, int point)
            {
                this.Name = name;
                this.Point = point;
            }
        }

        static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] field = createField();
            char[,] mines = setBombs();
            int counter = 0;
            bool isBang = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool isFlag = true;
            const int max = 35;
            bool isFlag2 = false;

            do
            {
                if (isFlag)
                {
                    Console.WriteLine("Lets play MiNES. Try your luck if you are brave." +
                    " Command 'top' show current table, 'restart' creat new game, 'exit' leave you from game");
                    dumpp(field);
                    isFlag = false;
                }

                Console.Write("Enter row and col : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        RankMeter(champions);
                        break;
                    case "restart":
                        field = createField();
                        mines = setBombs();
                        dumpp(field);
                        isBang = false;
                        isFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye");
                        break;
                    case "turn":

                        if (mines[row, col] != '*')
                        {

                            if (mines[row, col] == '-')
                            {
                                NextMove(field, mines, row, col);
                                counter++;
                            }

                            if (max == counter)
                            {
                                isFlag2 = true;
                            }

                            else
                            {
                                dumpp(field);
                            }
                        }

                        else
                        {
                            isBang = true;
                        }

                        break;

                    default:
                        Console.WriteLine("\nError! Invallind command!\n");
                        break;
                }

                if (isBang)
                {
                    dumpp(mines);
                    Console.Write("\nHrrrrrr! Your points are {0} . " +
                        "Enter your name: ", counter);
                    string nickname = Console.ReadLine();
                    Points t = new Points(nickname, counter);

                    if (champions.Count < 5)
                    {
                        champions.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Point < t.Point)
                            {
                                champions.Insert(i, t);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Point.CompareTo(r1.Point));
                    RankMeter(champions);

                    field = createField();
                    mines = setBombs();
                    counter = 0;
                    isBang = false;
                    isFlag = true;
                }

                if (isFlag2)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    dumpp(mines);
                    Console.WriteLine("Enter your name, dude : ");
                    string name = Console.ReadLine();
                    Points point = new Points(name, counter);
                    champions.Add(point);
                    RankMeter(champions);
                    field = createField();
                    mines = setBombs();
                    counter = 0;
                    isFlag2 = false;
                    isFlag = true;
                }
            }

            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void RankMeter(List<Points> point)
        {
            Console.WriteLine("\nPoints:");

            if (point.Count > 0)
            {
                for (int i = 0; i < point.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxs", i + 1, point[i].Name, point[i].Point);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty table!\n");
            }
        }

        private static void NextMove(char[,] field,
            char[,] mines, int row, int col)
        {
            char HowMuchBombi = HowMuch(mines, row, col);
            mines[row, col] = HowMuchBombi;
            field[row, col] = HowMuchBombi;
        }

        private static void dumpp(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] createField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] setBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();

            while (r3.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);

                if (!r3.Contains(randomNumber))
                {
                    r3.Add(randomNumber);
                }
            }

            foreach (int i2 in r3)
            {
                int col = (i2 / cols);
                int row = (i2 % cols);
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = cols;
                }

                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void GetNewField(char[,] field)
        {
            int cols = field.GetLength(0);
            int rows = field.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    if (field[col, row] != '*')
                    {
                        char HowMucho = HowMuch(field, col, row);
                        field[col, row] = HowMucho;
                    }
                }
            }
        }

        private static char HowMuch(char[,] r, int rr, int rrr)
        {
            int counter = 0;
            int rows = r.GetLength(0);
            int kols = r.GetLength(1);

            if (rr - 1 >= 0)
            {
                if (r[rr - 1, rrr] == '*')
                {
                    counter++;
                }
            }

            if (rr + 1 < rows)
            {
                if (r[rr + 1, rrr] == '*')
                {
                    counter++;
                }
            }

            if (rrr - 1 >= 0)
            {
                if (r[rr, rrr - 1] == '*')
                {
                    counter++;
                }
            }
            if (rrr + 1 < kols)
            {
                if (r[rr, rrr + 1] == '*')
                {
                    counter++;
                }
            }

            if ((rr - 1 >= 0) && (rrr - 1 >= 0))
            {
                if (r[rr - 1, rrr - 1] == '*')
                {
                    counter++;
                }
            }

            if ((rr - 1 >= 0) && (rrr + 1 < kols))
            {
                if (r[rr - 1, rrr + 1] == '*')
                {
                    counter++;
                }
            }

            if ((rr + 1 < rows) && (rrr - 1 >= 0))
            {
                if (r[rr + 1, rrr - 1] == '*')
                {
                    counter++;
                }
            }

            if ((rr + 1 < rows) && (rrr + 1 < kols))
            {
                if (r[rr + 1, rrr + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}