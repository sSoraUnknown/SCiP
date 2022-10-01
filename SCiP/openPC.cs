using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SCiP
{
    public partial class openPC : Form
    {
        public openPC()
        {
            InitializeComponent();
        }

        private void addPC_Load(object sender, EventArgs e)
        {
            SetSettings(); 
            Var.Init();
            try
            {
                Var.SetConfig();
                SetConfig();
            }
            catch { }
        }

        List<string> items = new List<string>();
        public void SetConfig()
        {
            for (int i = 0; i < Var.dir.Length; i++)
            {
                lb_ids.Items.Add(Var.dir[i].Name);
                items.Add(Var.dir[i].Name);
            }
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
            l_menuName.Text = "Меню просмотра";
            l_exit.Text = "X";
            b_delete.Text = "Удалить";
            b_edit.Text = "Заменить";
            b_open.Text = "Открыть";
            tb_search.Text = "[Поиск по ID]";
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Clear();
        }

        private void l_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string PATH = Var.SERVER_PATH + lb_ids.SelectedItem.ToString();
                string[] files = Directory.GetFiles(PATH);

                for (int i = 0; i < files.Length; i++)
                    File.Delete(files[i]);
                Directory.Delete(PATH);

                lb_ids.Items.Remove(lb_ids.SelectedItem);
            }
            catch {  }
        }

        public void GetStats()
        {
            GetDB();
            Var.LASTPAGE = true;
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                GetStats();
                addPC ad = new addPC();
                ad.ShowDialog();
                Var.LASTPAGE = false;
                Show();
            }
            catch { Show(); }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            lb_ids.Items.Clear();
            foreach(string str in items)
            {
                if(str.Contains(tb_search.Text))
                {
                    lb_ids.Items.Add(str);
                }
            }
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            if (lb_ids.SelectedItem != null)
            {
                Hide();
                GetDis();
                openDis od = new openDis();
                od.ShowDialog();
                Show();
            }
        }

        public void GetDB()
        {
            Var.ID = lb_ids.SelectedItem.ToString();
            Var.MP = File.ReadAllText(Var.SERVER_PATH + Var.ID + "/MP.abc");
            Var.CP = File.ReadAllText(Var.SERVER_PATH + Var.ID + "/CP.abc");
            Var.OP = File.ReadAllText(Var.SERVER_PATH + Var.ID + "/OP.abc");
            Var.BP = File.ReadAllText(Var.SERVER_PATH + Var.ID + "/BP.abc");
            Var.HDD = File.ReadAllText(Var.SERVER_PATH + Var.ID + "/HDD.abc");
            Var.COM = File.ReadAllText(Var.SERVER_PATH + Var.ID + "/COM.abc");
        }

        public void GetDis()
        {
            GetDB();
        }

        private void lb_ids_DoubleClick(object sender, EventArgs e)
        {
            b_open_Click(sender, e);
        }
    }
}
