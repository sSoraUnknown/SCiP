using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SCiP
{
    public partial class addPC : Form
    {
        public addPC()
        {
            InitializeComponent();
        }

        private void addPC_Load(object sender, EventArgs e)
        {
            SetSettings();
            CheckLastPage();
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

        public void CheckLastPage()
        {
            if (Var.LASTPAGE)
            {
                tb_id.Text = Var.ID;
                tb_id.Enabled = false;

                tb_mp.Text = Var.MP;
                tb_cp.Text = Var.CP;
                tb_op.Text = Var.OP;
                tb_bp.Text = Var.BP;
                tb_hdd.Text = Var.HDD;
                tb_com.Text = Var.COM;

                cb_repeat.Enabled = false;
                cb_repeat.Visible = false;

                Size = new Size(200,320);
                Text = "SCiP - Меню редактирования";
            }
        }

        public void SetSettings()
        {
            l_menuName.Text = "Меню добавления";
            l_exit.Text = "X";
            l_id.Text = "ID компьютера";
            l_mp.Text = "Материнская плата";
            l_cp.Text = "Центральный процессор";
            l_op.Text = "Оперативная память";
            l_bp.Text = "Блок питания";
            l_hdd.Text = "Жёсткий диск(HDD/SSD)";
            l_com.Text = "Комментарий";
            cb_repeat.Text = "Запомнить значения";
            Size = new Size(200,340);
        }

        private void l_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            Var.Init();
            Save();
            if (Var.LASTPAGE) Close();
            
        }

        public void Save()
        {
            try
            {
                if (tb_id.Text != "")
                {
                    string PATH = Var.SERVER_PATH + tb_id.Text;
                    Directory.CreateDirectory(PATH);
                    PATH += "/";

                    StreamWriter file1 = new StreamWriter(PATH + "MP.abc");
                    file1.Write(tb_mp.Text);
                    file1.Close();

                    StreamWriter file2 = new StreamWriter(PATH + "CP.abc");
                    file2.Write(tb_cp.Text);
                    file2.Close();

                    StreamWriter file3 = new StreamWriter(PATH + "OP.abc");
                    file3.Write(tb_op.Text);
                    file3.Close();

                    StreamWriter file4 = new StreamWriter(PATH + "BP.abc");
                    file4.Write(tb_bp.Text);
                    file4.Close();

                    StreamWriter file5 = new StreamWriter(PATH + "HDD.abc");
                    file5.Write(tb_hdd.Text);
                    file5.Close();

                    StreamWriter file6 = new StreamWriter(PATH + "COM.abc");
                    file6.Write(tb_com.Text);
                    file6.Close();

                }

                if(!cb_repeat.Checked)
                    TBClear();
            }
            catch { }
        }

        public void TBClear()
        {
            tb_id.Clear();
            tb_mp.Clear();
            tb_cp.Clear();
            tb_op.Clear();
            tb_bp.Clear();
            tb_hdd.Clear();
            tb_com.Clear();
        }
    }
}
