namespace SCiP
{
    partial class setPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setPath));
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_exit = new System.Windows.Forms.Label();
            this.l_menuName = new System.Windows.Forms.Label();
            this.l_note = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.b_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.l_exit);
            this.panel1.Controls.Add(this.l_menuName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // l_exit
            // 
            this.l_exit.AutoSize = true;
            this.l_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_exit.Location = new System.Drawing.Point(180, 0);
            this.l_exit.Name = "l_exit";
            this.l_exit.Size = new System.Drawing.Size(20, 20);
            this.l_exit.TabIndex = 1;
            this.l_exit.Text = "X";
            this.l_exit.Click += new System.EventHandler(this.label2_Click);
            // 
            // l_menuName
            // 
            this.l_menuName.AutoSize = true;
            this.l_menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_menuName.Location = new System.Drawing.Point(3, 0);
            this.l_menuName.Name = "l_menuName";
            this.l_menuName.Size = new System.Drawing.Size(114, 20);
            this.l_menuName.TabIndex = 0;
            this.l_menuName.Text = "[MENU NAME]";
            this.l_menuName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.l_menuName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // l_note
            // 
            this.l_note.AutoSize = true;
            this.l_note.Location = new System.Drawing.Point(-1, 23);
            this.l_note.Name = "l_note";
            this.l_note.Size = new System.Drawing.Size(43, 13);
            this.l_note.TabIndex = 1;
            this.l_note.Text = "[NOTE]";
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(0, 40);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(200, 20);
            this.tb_path.TabIndex = 2;
            this.tb_path.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_path.Click += new System.EventHandler(this.tb_path_Click);
            // 
            // b_save
            // 
            this.b_save.Location = new System.Drawing.Point(0, 66);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(200, 23);
            this.b_save.TabIndex = 3;
            this.b_save.Text = "[SAVE]";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // setPath
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(200, 95);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.l_note);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setPath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCiP - Меню БД";
            this.Load += new System.EventHandler(this.setPath_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_exit;
        private System.Windows.Forms.Label l_menuName;
        private System.Windows.Forms.Label l_note;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button b_save;
    }
}