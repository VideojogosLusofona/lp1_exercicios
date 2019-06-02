using System;

namespace LP1_Exercises
{

    /// <summary>
    /// Class for testing an array of structs, namely how an array of structs
    /// behaves when the individual struct values are modified within a method.
    /// </summary>
    class TestArrayOfStructs
    {
        /// <summary>
        /// The entry point of the program, where the program control starts
        /// and ends.
        /// </summary>
        public static void Main()
        {
            TestArrayOfStructs taos = new TestArrayOfStructs();
            taos.PerformTest();
        }

        /// <summary>
        /// Tests how an array of structs behaves when the individual
        /// struct values are modified within a method.
        /// </summary>
        void PerformTest()
        {
            // Create an array of structs
            MyStruct[] ams = new MyStruct[2];

            // Initialize individual structs with some values
            // (note: all positive values)
            ams[0].x = 0;
            ams[0].y = 0.1f;
            ams[0].z = new double[] { 0.2, 0.3, 0.4 };

            ams[1].x = 1;
            ams[1].y = 1.1f;
            ams[1].z = new double[] { 1.2, 1.3, 1.4 };

            // Try and change structs in array within a method
            TryAndChangeStructsInArray(ams);

            // Print individual structs in array.
            PrintArrayOfStructs(ams);
        }

        /// <summary>
        /// Try and change structs in array from within method.
        /// </summary>
        /// <param name="ams">Array of structs to try and change.</param>
        void TryAndChangeStructsInArray(MyStruct[] ams)
        {
            // The only change that we will make is to negate (multiply by
            // -1) all values in the structs within the array.
            for (int i = 0; i < ams.Length; i++)
            {
                ams[i].x *= -1;
                ams[i].y *= -1;
                for (int j = 0; j < ams[i].z.Length; j++)
                {
                    ams[i].z[j] *= -1;
                }
            }
        }

        /// <summary>
        /// Prints the array of structs.
        /// </summary>
        /// <param name="ms">Array of structs to print.</param>
        void PrintArrayOfStructs(MyStruct[] ams)
        {
            foreach (MyStruct ms in ams)
            {
                Console.WriteLine("---- Struct contents ----");
                Console.WriteLine($"\t x = {ms.x}");
                Console.WriteLine($"\t y = {ms.y}");
                Console.Write($"\t z = ");
                foreach (double d in ms.z)
                {
                    Console.Write(d + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
