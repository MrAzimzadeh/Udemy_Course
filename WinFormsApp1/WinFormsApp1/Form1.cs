namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // for (int i = 0; i <= 64; i++)


            Button[,] buttons = new Button[8, 8];

                //Button button = new Button();
                //button.Width = 100;
                //button.Height = 100;
                //button.Text = "My button";
                //button.Margin = ;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {

            }


                this.Controls.Add(button);



            



        }

    }
}