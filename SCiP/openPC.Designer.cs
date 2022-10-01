namespace SCiP
{
    partial class openPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openPC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_open = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_ids = new System.Windows.Forms.ListBox();
            this.l_exit = new System.Windows.Forms.Label();
            this.l_menuName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.l_menuName);
            this.panel1.Controls.Add(this.l_exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // b_edit
            // 
            this.b_edit.Location = new System.Drawing.Point(100, 20);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(100, 20);
            this.b_edit.TabIndex = 2;
            this.b_edit.Text = "[EDIT]";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(0, 20);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(100, 20);
            this.b_delete.TabIndex = 1;
            this.b_delete.Text = "[DELETE]";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_open
            // 
            this.b_open.Location = new System.Drawing.Point(0, 230);
            this.b_open.Name = "b_open";
            this.b_open.Size = new System.Drawing.Size(200, 40);
            this.b_open.TabIndex = 3;
            this.b_open.Text = "[OPEN <THIS>]";
            this.b_open.UseVisualStyleBackColor = true;
            this.b_open.Click += new System.EventHandler(this.b_open_Click);
            // 
            // tb_search
            // 
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.Location = new System.Drawing.Point(0, 210);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(200, 20);
            this.tb_search.TabIndex = 4;
            this.tb_search.Text = "[SEARCH]";
            this.tb_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_search.WordWrap = false;
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // lb_ids
            // 
            this.lb_ids.FormattingEnabled = true;
            this.lb_ids.Location = new System.Drawing.Point(0, 40);
            this.lb_ids.Name = "lb_ids";
            this.lb_ids.Size = new System.Drawing.Size(200, 173);
            this.lb_ids.TabIndex = 5;
            this.lb_ids.DoubleClick += new System.EventHandler(this.lb_ids_DoubleClick);
            // 
            // l_exit
            // 
            this.l_exit.AutoSize = true;
            this.l_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_exit.Location = new System.Drawing.Point(180, 0);
            this.l_exit.Name = "l_exit";
            this.l_exit.Size = new System.Drawing.Size(20, 20);
            this.l_exit.TabIndex = 6;
            this.l_exit.Text = "X";
            this.l_exit.Click += new System.EventHandler(this.l_exit_Click);
            // 
            // l_menuName
            // 
            this.l_menuName.AutoSize = true;
            this.l_menuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_menuName.Location = new System.Drawing.Point(3, 0);
            this.l_menuName.Name = "l_menuName";
            this.l_menuName.Size = new System.Drawing.Size(114, 20);
            this.l_menuName.TabIndex = 7;
            this.l_menuName.Text = "[MENU NAME]";
            this.l_menuName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.l_menuName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // openPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 265);
            this.Controls.Add(this.lb_ids);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.b_open);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "openPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCiP - Меню просмотра";
            this.Load += new System.EventHandler(this.addPC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_open;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ListBox lb_ids;
        private System.Windows.Forms.Label l_exit;
        private System.Windows.Forms.Label l_menuName;
    }
}