using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCiP
{
    public partial class openDis : Form
    {
        public openDis()
        {
            InitializeComponent();
        }

        private void l_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openDis_Load(object sender, EventArgs e)
        {
            SetSettings();
        }

        Point lastPoint;
        private new void MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        public void SetSettings()
        {
            // OTHER
            l_mainName.Text = "Просмотр";
            l_exit.Text = "X";
            l_id.Text = "ID компьютера: " + Var.ID;
            // TEXT
            l_mptext.Text = "Материнская плата";
            l_cptext.Text = "Центральный процессор";
            l_optext.Text = "Оперативная память";
            l_bptext.Text = "Блок питания";
            l_hddtext.Text = "Жёсткий диск";
            l_comtext.Text = "Комментарий";
            // NAME
            l_mpname.Text = Var.MP;
            l_cpname.Text = Var.CP;
            l_opname.Text = Var.OP;
            l_bpname.Text = Var.BP;
            l_hddname.Text = Var.HDD;
        }

        public void OpenURL(string str)
        {

            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + str);
        }

        private void l_mpname_Click(object sender, EventArgs e)
        {
            OpenURL(l_mpname.Text);
        }

        private void l_cpname_Click(object sender, EventArgs e)
        {

            OpenURL(l_cpname.Text);
        }

        private void l_opname_Click(object sender, EventArgs e)
        {

            OpenURL(l_opname.Text);
        }

        private void l_bpname_Click(object sender, EventArgs e)
        {

            OpenURL(l_bpname.Text);
        }

        private void l_hddname_Click(object sender, EventArgs e)
        {

            OpenURL(l_hddname.Text);
        }

        private void l_comtext_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Var.COM, "Комментарий");
        }
    }
}
