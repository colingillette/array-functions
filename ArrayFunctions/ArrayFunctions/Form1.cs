using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int firstInstance(int[] array, int target)
        {
            int position = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    position = i;
                }
            }

            return position;
        }

        private string reverseArray(int[] array)
        {
            int temporary;

            string arrayString = "The reveresed array is: ";

            for (int i = 0; i < array.Length / 2; i++)
            {
                temporary = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temporary;
            }

            for (int i = 0; i < array.Length; i++)
            {
                arrayString += $"{array[i]}, ";
            }

            return arrayString;
        }

        private string insert(int[] array, int addition, int index)
        {
            int[] copy = new int[array.Length + 1];
            string arrayString = "The new array is: ";
            
            if (index != 0)
            {
                for (int i = 0; i < index; i++)
                {
                    copy[i] = array[i];
                }
            }

            copy[index] = addition;

            if (index != copy.Length - 1)
            {
                for (int i = index + 1; i < copy.Length; i++)
                {
                    copy[i] = array[i - 1];
                }
            }

            for (int i = 0; i < copy.Length; i++)
            {
                arrayString += $"{copy[i]}, ";
            }

            return arrayString;
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int search = 5;

            int index;

            index = firstInstance(array1, search);

            MessageBox.Show($"The first instance of {search} happens at {index}.");
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            string reversed;

            reversed = reverseArray(array1);

            MessageBox.Show(reversed);
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int index = 6;
            int target = 3;

            string inserted;

            inserted = insert(array, target, index);

            MessageBox.Show(inserted);
        }
    }
}
