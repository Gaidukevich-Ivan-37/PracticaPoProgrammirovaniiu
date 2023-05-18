namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.турыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.туристыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сезоныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путевкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОТуристахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.турыToolStripMenuItem,
            this.туристыToolStripMenuItem,
            this.сезоныToolStripMenuItem,
            this.путевкиToolStripMenuItem,
            this.оплатаToolStripMenuItem,
            this.информацияОТуристахToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // турыToolStripMenuItem
            // 
            this.турыToolStripMenuItem.Name = "турыToolStripMenuItem";
            this.турыToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.турыToolStripMenuItem.Text = "Туры";
            this.турыToolStripMenuItem.Click += new System.EventHandler(this.турыToolStripMenuItem_Click);
            // 
            // туристыToolStripMenuItem
            // 
            this.туристыToolStripMenuItem.Name = "туристыToolStripMenuItem";
            this.туристыToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.туристыToolStripMenuItem.Text = "Туристы";
            this.туристыToolStripMenuItem.Click += new System.EventHandler(this.туристыToolStripMenuItem_Click);
            // 
            // сезоныToolStripMenuItem
            // 
            this.сезоныToolStripMenuItem.Name = "сезоныToolStripMenuItem";
            this.сезоныToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.сезоныToolStripMenuItem.Text = "Сезоны";
            this.сезоныToolStripMenuItem.Click += new System.EventHandler(this.сезоныToolStripMenuItem_Click);
            // 
            // путевкиToolStripMenuItem
            // 
            this.путевкиToolStripMenuItem.Name = "путевкиToolStripMenuItem";
            this.путевкиToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.путевкиToolStripMenuItem.Text = "Путевки";
            this.путевкиToolStripMenuItem.Click += new System.EventHandler(this.путевкиToolStripMenuItem_Click);
            // 
            // оплатаToolStripMenuItem
            // 
            this.оплатаToolStripMenuItem.Name = "оплатаToolStripMenuItem";
            this.оплатаToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.оплатаToolStripMenuItem.Text = "Оплата";
            this.оплатаToolStripMenuItem.Click += new System.EventHandler(this.оплатаToolStripMenuItem_Click);
            // 
            // информацияОТуристахToolStripMenuItem
            // 
            this.информацияОТуристахToolStripMenuItem.Name = "информацияОТуристахToolStripMenuItem";
            this.информацияОТуристахToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.информацияОТуристахToolStripMenuItem.Text = "Информация о туристах";
            this.информацияОТуристахToolStripMenuItem.Click += new System.EventHandler(this.информацияОТуристахToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 385);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Все таблицы";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem турыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem туристыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сезоныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путевкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОТуристахToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}