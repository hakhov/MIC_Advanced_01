namespace _01_TicTac
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btA1 = new System.Windows.Forms.Button();
            this.btB1 = new System.Windows.Forms.Button();
            this.btC1 = new System.Windows.Forms.Button();
            this.btA2 = new System.Windows.Forms.Button();
            this.btB2 = new System.Windows.Forms.Button();
            this.btC2 = new System.Windows.Forms.Button();
            this.btA3 = new System.Windows.Forms.Button();
            this.btB3 = new System.Windows.Forms.Button();
            this.btC3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNoWinner = new System.Windows.Forms.Label();
            this.lbOWinner = new System.Windows.Forms.Label();
            this.lbXWinner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(252, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btA1
            // 
            this.btA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btA1.Location = new System.Drawing.Point(12, 27);
            this.btA1.Name = "btA1";
            this.btA1.Size = new System.Drawing.Size(70, 70);
            this.btA1.TabIndex = 1;
            this.btA1.UseVisualStyleBackColor = true;
            this.btA1.UseWaitCursor = true;
            this.btA1.Click += new System.EventHandler(this.bt_Click);
            this.btA1.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btA1.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btB1
            // 
            this.btB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btB1.Location = new System.Drawing.Point(94, 27);
            this.btB1.Name = "btB1";
            this.btB1.Size = new System.Drawing.Size(70, 70);
            this.btB1.TabIndex = 2;
            this.btB1.UseVisualStyleBackColor = true;
            this.btB1.UseWaitCursor = true;
            this.btB1.Click += new System.EventHandler(this.bt_Click);
            this.btB1.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btB1.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btC1
            // 
            this.btC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC1.Location = new System.Drawing.Point(176, 27);
            this.btC1.Name = "btC1";
            this.btC1.Size = new System.Drawing.Size(70, 70);
            this.btC1.TabIndex = 3;
            this.btC1.UseVisualStyleBackColor = true;
            this.btC1.UseWaitCursor = true;
            this.btC1.Click += new System.EventHandler(this.bt_Click);
            this.btC1.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btC1.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btA2
            // 
            this.btA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btA2.Location = new System.Drawing.Point(12, 103);
            this.btA2.Name = "btA2";
            this.btA2.Size = new System.Drawing.Size(70, 70);
            this.btA2.TabIndex = 4;
            this.btA2.UseVisualStyleBackColor = true;
            this.btA2.UseWaitCursor = true;
            this.btA2.Click += new System.EventHandler(this.bt_Click);
            this.btA2.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btA2.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btB2
            // 
            this.btB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btB2.Location = new System.Drawing.Point(94, 103);
            this.btB2.Name = "btB2";
            this.btB2.Size = new System.Drawing.Size(70, 70);
            this.btB2.TabIndex = 5;
            this.btB2.UseVisualStyleBackColor = true;
            this.btB2.UseWaitCursor = true;
            this.btB2.Click += new System.EventHandler(this.bt_Click);
            this.btB2.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btB2.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btC2
            // 
            this.btC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC2.Location = new System.Drawing.Point(176, 103);
            this.btC2.Name = "btC2";
            this.btC2.Size = new System.Drawing.Size(70, 70);
            this.btC2.TabIndex = 6;
            this.btC2.UseVisualStyleBackColor = true;
            this.btC2.UseWaitCursor = true;
            this.btC2.Click += new System.EventHandler(this.bt_Click);
            this.btC2.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btC2.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btA3
            // 
            this.btA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btA3.Location = new System.Drawing.Point(12, 179);
            this.btA3.Name = "btA3";
            this.btA3.Size = new System.Drawing.Size(70, 70);
            this.btA3.TabIndex = 7;
            this.btA3.UseVisualStyleBackColor = true;
            this.btA3.UseWaitCursor = true;
            this.btA3.Click += new System.EventHandler(this.bt_Click);
            this.btA3.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btA3.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btB3
            // 
            this.btB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btB3.Location = new System.Drawing.Point(94, 179);
            this.btB3.Name = "btB3";
            this.btB3.Size = new System.Drawing.Size(70, 70);
            this.btB3.TabIndex = 8;
            this.btB3.UseVisualStyleBackColor = true;
            this.btB3.UseWaitCursor = true;
            this.btB3.Click += new System.EventHandler(this.bt_Click);
            this.btB3.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btB3.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // btC3
            // 
            this.btC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC3.Location = new System.Drawing.Point(176, 179);
            this.btC3.Name = "btC3";
            this.btC3.Size = new System.Drawing.Size(70, 70);
            this.btC3.TabIndex = 9;
            this.btC3.UseVisualStyleBackColor = true;
            this.btC3.UseWaitCursor = true;
            this.btC3.Click += new System.EventHandler(this.bt_Click);
            this.btC3.MouseEnter += new System.EventHandler(this.bt_Enter);
            this.btC3.MouseLeave += new System.EventHandler(this.bt_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbNoWinner);
            this.groupBox1.Controls.Add(this.lbOWinner);
            this.groupBox1.Controls.Add(this.lbXWinner);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Winner Table";
            this.groupBox1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "No Winner";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "O Winner";
            this.label2.UseWaitCursor = true;
            // 
            // lbNoWinner
            // 
            this.lbNoWinner.AutoSize = true;
            this.lbNoWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoWinner.Location = new System.Drawing.Point(190, 77);
            this.lbNoWinner.Name = "lbNoWinner";
            this.lbNoWinner.Size = new System.Drawing.Size(18, 20);
            this.lbNoWinner.TabIndex = 0;
            this.lbNoWinner.Text = "0";
            this.lbNoWinner.UseWaitCursor = true;
            // 
            // lbOWinner
            // 
            this.lbOWinner.AutoSize = true;
            this.lbOWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOWinner.Location = new System.Drawing.Point(190, 52);
            this.lbOWinner.Name = "lbOWinner";
            this.lbOWinner.Size = new System.Drawing.Size(18, 20);
            this.lbOWinner.TabIndex = 0;
            this.lbOWinner.Text = "0";
            this.lbOWinner.UseWaitCursor = true;
            // 
            // lbXWinner
            // 
            this.lbXWinner.AutoSize = true;
            this.lbXWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXWinner.Location = new System.Drawing.Point(190, 24);
            this.lbXWinner.Name = "lbXWinner";
            this.lbXWinner.Size = new System.Drawing.Size(18, 20);
            this.lbXWinner.TabIndex = 0;
            this.lbXWinner.Text = "0";
            this.lbXWinner.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Winner";
            this.label1.UseWaitCursor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(325, 131);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(163, 118);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 392);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btC3);
            this.Controls.Add(this.btB3);
            this.Controls.Add(this.btC2);
            this.Controls.Add(this.btB2);
            this.Controls.Add(this.btA3);
            this.Controls.Add(this.btC1);
            this.Controls.Add(this.btA2);
            this.Controls.Add(this.btB1);
            this.Controls.Add(this.btA1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btA1;
        private System.Windows.Forms.Button btB1;
        private System.Windows.Forms.Button btC1;
        private System.Windows.Forms.Button btA2;
        private System.Windows.Forms.Button btB2;
        private System.Windows.Forms.Button btC2;
        private System.Windows.Forms.Button btA3;
        private System.Windows.Forms.Button btB3;
        private System.Windows.Forms.Button btC3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNoWinner;
        private System.Windows.Forms.Label lbOWinner;
        private System.Windows.Forms.Label lbXWinner;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}

