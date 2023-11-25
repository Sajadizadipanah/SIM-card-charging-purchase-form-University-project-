namespace SIM_card_charging_purchase_form_University_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.Visible = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Visible = true;
            }
        }
        private Bank? Mybank { get; set; }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (Mybank == null || Mybank.IsDisposed)
            {
                Mybank = new Bank()
                {

                };

            }
            Mybank.ShowDialog();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Mybank == null || Mybank.IsDisposed)
            {
                Mybank = new Bank()
                {

                };

            }
            Mybank.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Mybank == null || Mybank.IsDisposed)
            {
                Mybank = new Bank()
                {

                };

            }
            Mybank.ShowDialog();
        }
    }
}