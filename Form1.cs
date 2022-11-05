using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AsyncrnousApp

{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Async and await make your app responsivens
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private async void LoadDataAsync(object sender, EventArgs e)
        {
            //listOfItems.Items.Add("Please Wait.....");
            //int count = GetItemslenth(fileName.Text);
            //listOfItems.Items.Clear();
            //listOfItems.Items.Add(count);

            // async 
            listOfItems.Items.Add("Please Wait.....");
            Task<int> count = GetItemslenthAsync(fileName.Text);
            int countOfTask = await count;
            listOfItems.Items.Clear();
            listOfItems.Items.Add(countOfTask);

            await LoadingValue();
            MessageBox.Show("All Tasks Are Completed......");
        }

        private void Open(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFile.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileName.Text = @"C:\Users\PC\Documents\textFile.txt";
        }



        private int GetItemslenth(string filename)
        {
            int length = 0;
            StreamReader reader = new StreamReader(filename);
            length = reader.ReadToEnd().Length;

            Thread.Sleep(9000);
            return length;
        }


        private async Task<int> GetItemslenthAsync(string filename)
        {
            int length = 0;
            await Task.Run(async () =>
            {
                StreamReader reader = new StreamReader(filename);
                length = reader.ReadToEnd().Length;

                await Task.Delay(9000);
            });
            return length;
        }
        
        // upsating 
        override void loadingAsync(string[] tasks){
             for (int i = 0; i <tasks.length; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(1000);
                }
        }
        // end updating

        private async Task LoadingValue()
        {
            await Task.Run(async () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    progressBar1.Value = i;
                    await Task.Delay(1000);
                }
            });
        }
    }
}
