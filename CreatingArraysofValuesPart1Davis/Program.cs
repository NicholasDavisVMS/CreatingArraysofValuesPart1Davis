using System;

namespace CreatingArraysofValuesPart1Davis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //An "array" is a bucket that contains other buckets, or a collection of data
            //In an array, you declare how many "subbickets" you have in the array
            //After that, one can quickly access any of the sequences in the array
            //Arrays use the "[]" not the "{}"

            /*
            int[] numbers = new int[5];
            // the int[5] declares the array will have 5 values, which will be counted starting at 0
            //Meaning arrays are 0 based, start to count from 0 not 1!!!
            //The "[]" are array or 'index' operators

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //The above set the values/element/index of the array equal to a number


            //If you try to add another value to the array that will make it bigger than the size of
            //the array, it will generate an error. (here: numbers[5] = 42;). 
            //AKA stuffing 6 items into a thing designed to hold only 5 items
*/

            /*
            //This is another way to declare an array
            int[] numbers = new int[] { 4, 8, 16, 23, 42 };
            //Here 6 items initialized, so upper bound would be five(0 to 5)
            //Functions related to the array like the Console.WriteLine(); below would still work the same


            //Below we will access the value of the array and print it out, here the 2nd element 
            //or position 1
            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
            */

            //ARRAYS CAN BE USED TO STORE ANY DATA TYPE, NOT JUST INTEGERS SEE BELOW!!!
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            //below is another form/version of the for loop
            foreach (string name in names) 
            {
                Console.WriteLine(name);
            }

        }
    }
}
