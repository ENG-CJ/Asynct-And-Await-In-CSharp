using System;
using System.IO;
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

            Task<int> task = GetItemsLengthAsync(fileName.Text);
            int length = await task;


            listOfItems.Items.Clear();
            listOfItems.Items.Add(length);
        }

        private void Open(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName.Text = openFile.FileName;
            }
        }



        // asynchronous function that returns length of charcts in file
        private async Task<int> GetItemsLengthAsync(string filename)
        {
            int length = 0;
            await Task.Run(async () =>
            {
                await GetCountDown();
                StreamReader reader = new StreamReader(filename);
                length = reader.ReadToEnd().Length;

            });


            return length;
        }



        // normal method that returns length of characters in a file
        private int GetItemsLength(string filename)
        {
            int length = 0;
            StreamReader reader = new StreamReader(filename);
            length = reader.ReadToEnd().Length;
            Task.Delay(5000);

            return length;
        }

        private async Task GetTask()
        {
            int cout = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    listOfItems.Items.Add("The Total Execution is :" + i);

                    System.Threading.Thread.Sleep(1000);
                }
            });

        }

        private async Task GetCountDown()
        {
            await Task.Run(async () =>
            {
                listOfItems.Items.Add("Please Wait.....");
                for (int i = 0; i <= 100; i++)
                {
                    //listOfItems.Items.Add(i);
                    progressBar1.Value = i;
                    await Task.Delay(70);
                    if (i >= 95)
                        await Task.Delay(1000);
                }
            });
        }




    }
}
