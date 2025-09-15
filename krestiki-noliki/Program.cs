namespace krestiki_noliki;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = new int[3, 3]; // 0 -пуста клітина, 1 - клітина X, 2 - клітина O,

        bool is_game = true;

        bool whos_move = true; //  true = X, false = O

        while (is_game)
        {
            ScreenDrawing(matrix);

            System.Console.WriteLine($"{(whos_move ? 'X' : 'O')} хід, ходити ось так '3 3' сначала висота потім ширина ");
            string[] MoveCors = Console.ReadLine().Split(" ");

            int MoveResult = matrix[Convert.ToInt32(MoveCors[0]) - 1, Convert.ToInt32(MoveCors[1]) - 1];

            if (MoveResult != 0)
            {
                if (MoveResult == 1 && whos_move == true)
                {
                    System.Console.WriteLine("Ця клітина вже зайнята вами");
                }
                if (MoveResult == 2 && whos_move == true)
                {
                    System.Console.WriteLine("Ця клітина вже зайнята ворогом");
                }

                if (MoveResult == 2 && whos_move == false)
                {
                    System.Console.WriteLine("Ця клітина вже зайнята вами");
                }
                if (MoveResult == 1 && whos_move == false)
                {
                    System.Console.WriteLine("Ця клітина вже зайнята ворогом");
                }
            }
            else
            {
                matrix[Convert.ToInt32(MoveCors[0]) - 1, Convert.ToInt32(MoveCors[1]) - 1] = whos_move ? 1 : 2;

                System.Console.WriteLine(1);

                // Для Х

                if (matrix[0, 0] == 1 && matrix[0, 1] == 1 && matrix[0, 2] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[1, 0] == 1 && matrix[1, 1] == 1 && matrix[1, 2] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[2, 0] == 1 && matrix[2, 1] == 1 && matrix[2, 2] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[0, 0] == 1 && matrix[1, 0] == 1 && matrix[2, 0] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[0, 1] == 1 && matrix[1, 1] == 1 && matrix[2, 1] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[0, 1] == 1 && matrix[1, 1] == 1 && matrix[2, 1] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[0, 0] == 1 && matrix[1, 1] == 1 && matrix[2, 2] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                if (matrix[0, 2] == 1 && matrix[1, 1] == 1 && matrix[2, 0] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }



                // для О
                if (matrix[0, 0] == 2 && matrix[0, 1] == 2 && matrix[0, 2] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[1, 0] == 2 && matrix[1, 1] == 2 && matrix[1, 2] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[2, 0] == 2 && matrix[2, 1] == 2 && matrix[2, 2] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[0, 0] == 2 && matrix[1, 0] == 2 && matrix[2, 0] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[0, 1] == 2 && matrix[1, 1] == 2 && matrix[2, 1] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[0, 1] == 2 && matrix[1, 1] == 2 && matrix[2, 1] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[0, 0] == 2 && matrix[1, 1] == 2 && matrix[2, 2] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                if (matrix[0, 2] == 2 && matrix[1, 1] == 2 && matrix[2, 0] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                whos_move = !whos_move;
            }

            int[] othersSots = [];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    othersSots.Append(matrix[i, j]);
                }
            }

            if (!othersSots.Contains(0))
            {
                System.Console.WriteLine("Ничія");
                is_game = false;
            }


        }

    }
    static void ScreenDrawing(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + "|");
            }
            System.Console.WriteLine();
        }
    }
}
