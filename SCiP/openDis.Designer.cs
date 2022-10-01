namespace SCiP
{
    partial class openDis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openDis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_exit = new System.Windows.Forms.Label();
            this.l_mainName = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.l_mptext = new System.Windows.Forms.Label();
            this.l_mpname = new System.Windows.Forms.Label();
            this.l_optext = new System.Windows.Forms.Label();
            this.l_cpname = new System.Windows.Forms.Label();
            this.l_cptext = new System.Windows.Forms.Label();
            this.l_bptext = new System.Windows.Forms.Label();
            this.l_opname = new System.Windows.Forms.Label();
            this.l_hddname = new System.Windows.Forms.Label();
            this.l_hddtext = new System.Windows.Forms.Label();
            this.l_bpname = new System.Windows.Forms.Label();
            this.l_comtext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.l_exit);
            this.panel1.Controls.Add(this.l_mainName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 1;
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
            this.l_exit.TabIndex = 2;
            this.l_exit.Text = "X";
            this.l_exit.Click += new System.EventHandler(this.l_exit_Click);
            // 
            // l_mainName
            // 
            this.l_mainName.AutoSize = true;
            this.l_mainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_mainName.Location = new System.Drawing.Point(3, 0);
            this.l_mainName.Name = "l_mainName";
            this.l_mainName.Size = new System.Drawing.Size(123, 20);
            this.l_mainName.TabIndex = 1;
            this.l_mainName.Text = "[Program Name]";
            this.l_mainName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.l_mainName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(12, 23);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(55, 13);
            this.l_id.TabIndex = 2;
            this.l_id.Text = "[ID TEXT]";
            // 
            // l_mptext
            // 
            this.l_mptext.AutoSize = true;
            this.l_mptext.Location = new System.Drawing.Point(12, 49);
            this.l_mptext.Name = "l_mptext";
            this.l_mptext.Size = new System.Drawing.Size(60, 13);
            this.l_mptext.TabIndex = 3;
            this.l_mptext.Text = "[MP TEXT]";
            // 
            // l_mpname
            // 
            this.l_mpname.AutoSize = true;
            this.l_mpname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_mpname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l_mpname.Location = new System.Drawing.Point(12, 62);
            this.l_mpname.Name = "l_mpname";
            this.l_mpname.Size = new System.Drawing.Size(63, 13);
            this.l_mpname.TabIndex = 5;
            this.l_mpname.Text = "[MP NAME]";
            this.l_mpname.Click += new System.EventHandler(this.l_mpname_Click);
            // 
            // l_optext
            // 
            this.l_optext.AutoSize = true;
            this.l_optext.Location = new System.Drawing.Point(12, 127);
            this.l_optext.Name = "l_optext";
            this.l_optext.Size = new System.Drawing.Size(59, 13);
            this.l_optext.TabIndex = 9;
            this.l_optext.Text = "[OP TEXT]";
            // 
            // l_cpname
            // 
            this.l_cpname.AutoSize = true;
            this.l_cpname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_cpname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l_cpname.Location = new System.Drawing.Point(12, 101);
            this.l_cpname.Name = "l_cpname";
            this.l_cpname.Size = new System.Drawing.Size(61, 13);
            this.l_cpname.TabIndex = 8;
            this.l_cpname.Text = "[CP NAME]";
            this.l_cpname.Click += new System.EventHandler(this.l_cpname_Click);
            // 
            // l_cptext
            // 
            this.l_cptext.AutoSize = true;
            this.l_cptext.Location = new System.Drawing.Point(12, 88);
            this.l_cptext.Name = "l_cptext";
            this.l_cptext.Size = new System.Drawing.Size(58, 13);
            this.l_cptext.TabIndex = 6;
            this.l_cptext.Text = "[CP TEXT]";
            // 
            // l_bptext
            // 
            this.l_bptext.AutoSize = true;
            this.l_bptext.Location = new System.Drawing.Point(12, 166);
            this.l_bptext.Name = "l_bptext";
            this.l_bptext.Size = new System.Drawing.Size(58, 13);
            this.l_bptext.TabIndex = 12;
            this.l_bptext.Text = "[BP TEXT]";
            // 
            // l_opname
            // 
            this.l_opname.AutoSize = true;
            this.l_opname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_opname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l_opname.Location = new System.Drawing.Point(12, 140);
            this.l_opname.Name = "l_opname";
            this.l_opname.Size = new System.Drawing.Size(62, 13);
            this.l_opname.TabIndex = 11;
            this.l_opname.Text = "[OP NAME]";
            this.l_opname.Click += new System.EventHandler(this.l_opname_Click);
            // 
            // l_hddname
            // 
            this.l_hddname.AutoSize = true;
            this.l_hddname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_hddname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l_hddname.Location = new System.Drawing.Point(12, 218);
            this.l_hddname.Name = "l_hddname";
            this.l_hddname.Size = new System.Drawing.Size(71, 13);
            this.l_hddname.TabIndex = 17;
            this.l_hddname.Text = "[HDD NAME]";
            this.l_hddname.Click += new System.EventHandler(this.l_hddname_Click);
            // 
            // l_hddtext
            // 
            this.l_hddtext.AutoSize = true;
            this.l_hddtext.Location = new System.Drawing.Point(12, 205);
            this.l_hddtext.Name = "l_hddtext";
            this.l_hddtext.Size = new System.Drawing.Size(68, 13);
            this.l_hddtext.TabIndex = 15;
            this.l_hddtext.Text = "[HDD TEXT]";
            // 
            // l_bpname
            // 
            this.l_bpname.AutoSize = true;
            this.l_bpname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_bpname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l_bpname.Location = new System.Drawing.Point(12, 179);
            this.l_bpname.Name = "l_bpname";
            this.l_bpname.Size = new System.Drawing.Size(61, 13);
            this.l_bpname.TabIndex = 14;
            this.l_bpname.Text = "[BP NAME]";
            this.l_bpname.Click += new System.EventHandler(this.l_bpname_Click);
            // 
            // l_comtext
            // 
            this.l_comtext.AutoSize = true;
            this.l_comtext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_comtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.l_comtext.Location = new System.Drawing.Point(12, 244);
            this.l_comtext.Name = "l_comtext";
            this.l_comtext.Size = new System.Drawing.Size(121, 13);
            this.l_comtext.TabIndex = 18;
            this.l_comtext.Text = "[COM TEXT AND LINK]";
            this.l_comtext.Click += new System.EventHandler(this.l_comtext_Click);
            // 
            // openDis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 260);
            this.Controls.Add(this.l_comtext);
            this.Controls.Add(this.l_hddname);
            this.Controls.Add(this.l_hddtext);
            this.Controls.Add(this.l_bpname);
            this.Controls.Add(this.l_bptext);
            this.Controls.Add(this.l_opname);
            this.Controls.Add(this.l_optext);
            this.Controls.Add(this.l_cpname);
            this.Controls.Add(this.l_cptext);
            this.Controls.Add(this.l_mpname);
            this.Controls.Add(this.l_mptext);
            this.Controls.Add(this.l_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "openDis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCiP - Просмотр ПК";
            this.Load += new System.EventHandler(this.openDis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_exit;
        private System.Windows.Forms.Label l_mainName;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_mptext;
        private System.Windows.Forms.Label l_mpname;
        private System.Windows.Forms.Label l_optext;
        private System.Windows.Forms.Label l_cpname;
        private System.Windows.Forms.Label l_cptext;
        private System.Windows.Forms.Label l_bptext;
        private System.Windows.Forms.Label l_opname;
        private System.Windows.Forms.Label l_hddname;
        private System.Windows.Forms.Label l_hddtext;
        private System.Windows.Forms.Label l_bpname;
        private System.Windows.Forms.Label l_comtext;
    }
}