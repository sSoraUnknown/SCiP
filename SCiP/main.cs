using System;
using System.Drawing;
using System.Windows.Forms;

namespace SCiP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            b_add.Text = "Сбор"; // кнопка сбора ПК
            b_check.Text = "Просмотр"; // кнопка просмотра ПК
            b_changeDB.Text = "Изменить путь БД"; // изменить путь для "БД" (чтобы можно было просматривать и изменять информацию с разных ПК) >> необходим local_db
            l_mainName.Text = "SCiP v1.2"; // название программы (слева сверху конструктора)
            l_exit.Text = "X"; // если уж так приспичет поменять крестик на другой символ
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            Hide();
            addPC ap = new addPC();
            ap.ShowDialog();
            Show();
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            Hide();
            openPC op = new openPC();
            op.ShowDialog();
            Show();
        }

        private void b_changeDB_Click(object sender, EventArgs e)
        {
            Hide();
            MessageBox.Show("После изменения пути к базе данных, приложение будет закрыто, во избежании критических ошибок, возникающих после смены пути базы данных.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            setPath sp = new setPath();
            sp.ShowDialog();
            if (sp.DialogResult == DialogResult.OK) Close();
            try { Show(); } catch { }
        }
    }
}
