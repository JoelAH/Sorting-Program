using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sorting_Program
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        const int SIZE = 10000; //constant value setfor array size


        int[] originalarr = new int[SIZE]; //original array intialized with size of SIZE(10000)


        private void btnGenerate_Click(object sender, EventArgs e)
        {

            /*Description: This funtion is invoked when the generate button is clicked. The function assigns 10,000 random values to the original array
             * (Arguments)->return type: (object,EventArgs)->void
             *Precondition: Button must be clicked and original array already initialized
             * Postcondition:10,000 numbers are stored in original array and first five printed to text box
             * Example(s): button is clicked and 10,000 numbers are sent to the array*/


            txtGenerate.Clear();

            Random random = new Random();

            for (int x = 0; x < SIZE; x++)
            {

                originalarr[x] = random.Next(1, 5001);

            }




            for (int g = 0; g < 5; g++)
            {
                txtGenerate.Text += originalarr[g].ToString() + ", ";

            }


        }

        private int[] insertionSort(int[] arr, int last)
        {
            /*Description: This funtion sorts values in an array using insertion sort
             * (Arguments)->return type: (int[],int)->int[]
             *Precondition: array must exist and its correct last index must be passed
             * Postcondition:a sorted array is returned
             * Example(s): int[] arr={6,1,8}, int last=2; insertiionSort(arr,last)={1,6,8}*/


            int current = 1, hold = 0, walker = 0;

            while (current <= last)
            {
                hold = arr[current];
                walker = current - 1;
                while (walker >= 0 && hold < arr[walker])
                {
                    arr[walker + 1] = arr[walker];
                    walker = walker - 1;
                }

                arr[walker + 1] = hold;
                current = current + 1;

            }


            return arr;

        }

        private int[] shellSort(int[] arr, int last)
        {

            /*Description: This funtion sorts values in an array using shell sort
             * (Arguments)->return type: (int[],int)->int[]
             *Precondition: array must exist and its correct last index must be passed
             * Postcondition:a sorted array is returned
             * Example(s): int[] arr={6,1,8}, int last=2; insertiionSort(arr,last)={1,6,8}*/


            int increment = last / 2, current = 0, walker = 0, hold = 0;

            while (increment != 0)
            {
                current = increment;
                while (current <= last)
                {
                    hold = arr[current];
                    walker = current - increment;
                    while (walker >= 0 && hold < arr[walker])
                    {
                        arr[walker + increment] = arr[walker];
                        walker = walker - increment;
                    }

                    arr[walker + increment] = hold;
                    current = current + 1;
                }

                increment = increment / 2;
            }

            return arr;
        }



        private int[] bubbleSort(int[] arr, int last)
        {

            /*Description: This funtion sorts values in an array using bubble sort
             * (Arguments)->return type: (int[],int)->int[]
             *Precondition: array must exist and its correct last index must be passed
             * Postcondition:a sorted array is returned
             * Example(s): int[] arr={6,1,8}, int last=2; insertiionSort(arr,last)={1,6,8}*/

            int walker = 0, temp = 0;
            int length = last + 1;
            bool swapped = true;

            while (swapped)
            {
                swapped = false;
                walker++;

                for (int i = 0; i < length - walker; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            }



            return arr;
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {

            /*Description: This funtion is invoked when the insertion button is clicked. The function passes the original array to the insertion sort function and prints first five sorted numbers to textbox
             * (Arguments)->return type: (object,EventArgs)->void
             *Precondition: Button must be clicked and original array already initialized
             * Postcondition:a sorted array is returned
             * Example(s): button is clicked and unsorted array is passed to function and a sorted array is received*/

            txtInsertion.Clear();

            int[] arr = new int[SIZE];
            int[] sortedArray=new int[SIZE];
            originalarr.CopyTo(arr, 0);
            insertionSort(arr, SIZE - 1).CopyTo(sortedArray, 0);



            for (int s = 0; s < 5; s++)
            {
                txtInsertion.Text += sortedArray[s].ToString() + ", ";

            }


        }

        private void btnShell_Click(object sender, EventArgs e)
        {

            /*Description: This funtion is invoked when the shell button is clicked. The function passes the original array to the shell sort function and prints first five sorted numbers to textbox
             * (Arguments)->return type: (object,EventArgs)->void
             *Precondition: Button must be clicked and original array already initialized
             * Postcondition:a sorted array is returned
             * Example(s): button is clicked and unsorted array is passed to function and a sorted array is received*/


            txtShell.Clear();

            int[] arr = new int[SIZE];
            int[] sortedArray = new int[SIZE];
            originalarr.CopyTo(arr, 0);
            shellSort(arr, SIZE - 1).CopyTo(sortedArray, 0);

            for (int s = 0; s < 5; s++)
            {
                txtShell.Text += sortedArray[s].ToString() + ", ";

            }


        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            /*Description: This funtion is invoked when the bubble button is clicked. The function passes the original array to the bubble sort function and prints first five sorted numbers to textbox
             * (Arguments)->return type: (object,EventArgs)->void
             *Precondition: Button must be clicked and original array already initialized
             * Postcondition:a sorted array is returned
             * Example(s): button is clicked and unsorted array is passed to function and a sorted array is received*/


            txtBubble.Clear();

            int[] arr = new int[SIZE];
            int[] sortedArray = new int[SIZE];
            originalarr.CopyTo(arr, 0);
            bubbleSort(arr, SIZE - 1).CopyTo(sortedArray, 0);

            for (int s = 0; s < 5; s++)
            {
                txtBubble.Text += sortedArray[s].ToString() + ", ";

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //exits application

            Application.Exit();


        }




       
    }
}
