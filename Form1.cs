namespace Binary_Search
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Sorted array
            int[] arr = new int[10]
            { 1, 2, 4, 11, 20, 28, 48, 84, 96, 106 };

            int searchnumber = Convert.ToInt32(txtSearchNumber.Text);

            //int index1 = arr.ToList().BinarySearch(20);
            //int index2 = BinarySearchIterative(arr, 20);
            //int index3 = BinarySearchRecursive(arr, 20, 0, arr.Length - 1);
            int index1 = arr.ToList().BinarySearch(searchnumber);
            int index2 = BinarySearchIterative(arr, searchnumber);
            int index3 = BinarySearchRecursive(arr, searchnumber, 0, arr.Length - 1);

            //Add to Console
            Console.WriteLine("Index of 20 value in list is " + index1.ToString() + " (using .NET Framework)");
            Console.WriteLine("Index of 20 value in list is " + index2.ToString() + " (using BinarySearchIterative method)");
            Console.WriteLine("Index of 20 value in list is " + index3.ToString() + " (using BinarySearchRecursive method)");

            //Update Text Boxes
            txt_Index1.Text = index1.ToString();
            txt_Index2.Text = index2.ToString();
            txt_Index3.Text = index3.ToString();

            //Output:
            //Index of 20 value in list is 4 (using .NET Frameowork)
            //Index of 20 value in list is 4 (using BinarySearchIterative method)
            //Index of 20 value in list is 4 (using BinarySearchRecursive method)
        }

        private int BinarySearchIterative(int[] arr, int searchNumber)
        {
            int left = 0;
            int right = arr.Length - 1;

            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchNumber))
                {
                    case -1: left = middle + 1; break;
                    case 0: return middle;
                    case 1: right = middle - 1; break;
                }
            }
            return -1;
        }

        private int BinarySearchRecursive(int[] arr, int searchnum, int left, int right)
        {
            int middle;
            while (left <= right)
            {
                middle = (left + right) / 2;
                switch (Compare(arr[middle], searchnum))
                {
                    case -1: return BinarySearchRecursive(arr, searchnum, middle + 1, right);
                    case 0: return middle;
                    case 1: return BinarySearchRecursive(arr, searchnum, left, middle - 1);
                }
            }
            return -1;
        }

        private int Compare(int x, int y)
        {
            return x < y ? -1 : (y < x ? 1 : 0);
        }

    }
}