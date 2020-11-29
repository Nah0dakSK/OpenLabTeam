using System;

using System.Collections.Generic;

using System.Text;



namespace NP

{



    class Grade

    {

        static bool ReadInteger(out int n)

        {

            string input = System.Console.ReadLine();

            n = 0;

            try

            {

                n = Convert.ToInt32(input);

                return true;

            }

            catch (System.Exception)

            {

                System.Console.WriteLine("Error in the input format\n\n");

                return false;

            }

        }



        static void Main(string[] args)

        {

            System.Console.WriteLine("Vyhodnotenie študentov.");



            const int MAX_STUDENTS = 10;



            int[] arrMark = new int[MAX_STUDENTS];

            string grade = "";



            for (int i = 0; i < MAX_STUDENTS; i++)

            {

                System.Console.Write("Zadaj body študenta {0} : ", i + 1);

                ReadInteger(out arrMark[i]);

            }

            System.Console.Write("\n\nŽiak\tBody\tZnámka\n");



            for (int i = 0; i < MAX_STUDENTS; i++)

            {

                if (arrMark[i] > 100)

                    grade = "Error";

                else if (arrMark[i] == 100)

                    grade = "1*";

                else if (arrMark[i] > 90)

                    grade = "1";

                else if (arrMark[i] == 90)

                    grade = "1";

                else if (arrMark[i] > 70)

                    grade = "2";

                else if (arrMark[i] == 70)

                    grade = "2";

                else if (arrMark[i] > 50)

                    grade = "3";

                else if (arrMark[i] == 50)

                    grade = "3";

                else if (arrMark[i] > 30)

                    grade = "4";

                else if (arrMark[i] == 30)

                    grade = "4";

                else

                    grade = "5";

                System.Console.Write("{0}\t{1}\t{2}\n", i + 1, arrMark[i], grade);

            }



        }

    }



}
