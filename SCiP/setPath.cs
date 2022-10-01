using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace SCiP
{
    public partial class setPath : Form
    {
        public setPath()
        {
            InitializeComponent();
        }

        private void setPath_Load(object sender, EventArgs e)
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
            tb_path.Text = "Путь сервенной BD/";
            l_menuName.Text = "Меню изменения";
            l_note.Text = "Изменить путь к базе данных.";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            string PATH_SERVER_DB_VAR;
            if (File.Exists(Var.LOCAL_PATH + Var.LDBPATH))
            {
                File.Delete(Var.LOCAL_PATH + Var.LDBPATH);

                PATH_SERVER_DB_VAR = tb_path.Text;

                while (PATH_SERVER_DB_VAR.IndexOf('\\') != -1)
                {

                    PATH_SERVER_DB_VAR = PATH_SERVER_DB_VAR.Substring(0, PATH_SERVER_DB_VAR.IndexOf('\\')) +
                        "/" + PATH_SERVER_DB_VAR.Substring(PATH_SERVER_DB_VAR.IndexOf('\\') +
                        1, PATH_SERVER_DB_VAR.Length - 1 - PATH_SERVER_DB_VAR.IndexOf('\\'));

                }

                if (PATH_SERVER_DB_VAR.Substring(PATH_SERVER_DB_VAR.Count() - 1, 1) != "/")
                {

                    PATH_SERVER_DB_VAR += "/";

                }


                StreamWriter file = new StreamWriter(Var.LOCAL_PATH + Var.LDBPATH, true);
                if (PATH_SERVER_DB_VAR != "Путь сервенной BD/")
                {
                    file.Write(PATH_SERVER_DB_VAR);
                }
                else file.Write("SERVER_DB/");

                file.Close();

            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tb_path_Click(object sender, EventArgs e)
        {
            tb_path.Clear();
        }
    }
}
