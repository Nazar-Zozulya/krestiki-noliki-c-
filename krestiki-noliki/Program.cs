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
            ScreenDrawing();
            System.Console.WriteLine($"{(whos_move ? 'X' : 'O')} хід, напишіть номер ячейки від 1 до 9 ");

            int MoveCords = Convert.ToInt32(Console.ReadLine());

            int MoveResult = matrix[MoveCords - 1];

            if (MoveResult != 0)
            {
                System.Console.WriteLine("Ця ячейка вже зайнята");
            }
            else
            {
                matrix[MoveCords - 1] = whos_move ? 1 : 2;

                System.Console.WriteLine();


                Flex(1);

                Flex(2);

                whos_move = !whos_move;
            }



            bool hasZero = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                System.Console.WriteLine("Ничія");
                is_game = false;
            }


            void Flex(int k)
            {
                if (matrix[0] == k && matrix[1] == k && matrix[2] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[3] == k && matrix[4] == k && matrix[5] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[6] == k && matrix[7] == k && matrix[8] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[0] == k && matrix[3] == k && matrix[6] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[1] == k && matrix[4] == k && matrix[7] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[2] == k && matrix[5] == k && matrix[8] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[0] == k && matrix[4] == k && matrix[8] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }

                else if (matrix[2] == k && matrix[4] == k && matrix[6] == k)
                {
                    System.Console.WriteLine((k == 1 ? "X" : "O") + " вийграв");
                    is_game = false;
                    ScreenDrawing();
                }
            }

            void ScreenDrawing()
            {
                for (int i = 0; i < matrix.Length; i++)
                {


                    switch (matrix[i])
                    {
                        case 1:
                            System.Console.Write("X" + "|");
                            break;
                        case 2:
                            System.Console.Write("O" + "|");
                            break;
                        case 0:
                            System.Console.Write(matrix[i] + "|");
                            break;

                            // default:
                    }

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

                }
            }
        }

    }
}
