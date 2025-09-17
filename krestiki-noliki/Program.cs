namespace krestiki_noliki;

class Program
{
    static void Main(string[] args)
    {

        int[] matrix = new int[9];
        // int[,] matrix = new int[3, 3]; // 0 -пуста клітина, 1 - клітина X, 2 - клітина O,

        bool is_game = true;

        bool whos_move = true; //  true = X, false = O

        while (is_game)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                // for (int j = 0; j < 1; j++)
                // {
                System.Console.Write(matrix[i] + "|");
                // }
                switch (i)
                {
                    case 2:
                        System.Console.WriteLine();
                        break;
                    case 5:
                        System.Console.WriteLine();
                        break;
                    case 8:
                        System.Console.WriteLine();
                        break;
                    
                }

                // System.Console.WriteLine();
            }

            System.Console.WriteLine($"{(whos_move ? 'X' : 'O')} хід, напишіть номер ячейки від 1 до 9 ");
            string MoveCords = Console.ReadLine();

            int MoveResult = matrix[Convert.ToInt32(MoveCords) -1];

            if (MoveResult != 0)
            {
                System.Console.WriteLine("Ця ячейка вже зайнята");
            }
            else
            {
                matrix[Convert.ToInt32(MoveCords) - 1] = whos_move ? 1 : 2;

                System.Console.WriteLine(1);

                // Для Х

                if (matrix[0] == 1 && matrix[1] == 1 && matrix[2] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[3] == 1 && matrix[4] == 1 && matrix[5] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[6] == 1 && matrix[7] == 1 && matrix[8] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[0] == 1 && matrix[3] == 1 && matrix[6] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[1] == 1 && matrix[4] == 1 && matrix[7] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[2] == 1 && matrix[5] == 1 && matrix[8] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[0] == 1 && matrix[4] == 1 && matrix[8] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }

                else if (matrix[2] == 1 && matrix[4] == 1 && matrix[6] == 1)
                {
                    System.Console.WriteLine("X вийграв");
                    is_game = false;
                }



                // для О

                if (matrix[0] == 2 && matrix[1] == 2 && matrix[2] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[3] == 2 && matrix[4] == 2 && matrix[5] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[6] == 2 && matrix[7] == 2 && matrix[8] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[0] == 2 && matrix[3] == 2 && matrix[6] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[1] == 2 && matrix[4] == 2 && matrix[7] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[2] == 2 && matrix[5] == 2 && matrix[8] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[0] == 2 && matrix[4] == 2 && matrix[8] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                else if (matrix[2] == 2 && matrix[4] == 2 && matrix[6] == 2)
                {
                    System.Console.WriteLine("O вийграв");
                    is_game = false;
                }

                whos_move = !whos_move;
            }

            bool hasZero = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i] == 0)
                {
                    hasZero = true;
                    break;
                }
                if (hasZero) break;
            }

            if (!hasZero)
            {
                System.Console.WriteLine("Ничія");
                is_game = false;
            }



        }

    }
}
