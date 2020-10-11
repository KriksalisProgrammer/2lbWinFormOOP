namespace _2lb
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddFabricaMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.AddFactor = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.numericAddDelPerson = new System.Windows.Forms.NumericUpDown();
            this.buttonSl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddDelPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFabricaMenu
            // 
            this.AddFabricaMenu.BackColor = System.Drawing.Color.White;
            this.AddFabricaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFabricaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddFabricaMenu.Location = new System.Drawing.Point(370, 297);
            this.AddFabricaMenu.Name = "AddFabricaMenu";
            this.AddFabricaMenu.Size = new System.Drawing.Size(188, 60);
            this.AddFabricaMenu.TabIndex = 0;
            this.AddFabricaMenu.Text = "Показать заводы";
            this.AddFabricaMenu.UseVisualStyleBackColor = false;
            this.AddFabricaMenu.Click += new System.EventHandler(this.AddFabrica_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(80, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(823, 221);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро Пожаловать в программу о заводах. Нажмите кнопку \"Показать заводы\", что бы " +
    "увидеть табличку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(974, 284);
            this.dataGridView1.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
         
            // 
            // AddFactor
            // 
            this.AddFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddFactor.Location = new System.Drawing.Point(39, 297);
            this.AddFactor.Name = "AddFactor";
            this.AddFactor.Size = new System.Drawing.Size(162, 45);
            this.AddFactor.TabIndex = 8;
            this.AddFactor.Text = "Добавить Завод";
            this.AddFactor.UseVisualStyleBackColor = true;
            this.AddFactor.Visible = false;
            this.AddFactor.Click += new System.EventHandler(this.AddFactor_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddPerson.Location = new System.Drawing.Point(777, 297);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(162, 45);
            this.AddPerson.TabIndex = 9;
            this.AddPerson.Text = "Принять работников";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Visible = false;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // buttonDell
            // 
            this.buttonDell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDell.Location = new System.Drawing.Point(777, 393);
            this.buttonDell.Name = "buttonDell";
            this.buttonDell.Size = new System.Drawing.Size(162, 45);
            this.buttonDell.TabIndex = 10;
            this.buttonDell.Text = "Уволить работников";
            this.buttonDell.UseVisualStyleBackColor = true;
            this.buttonDell.Visible = false;
            this.buttonDell.Click += new System.EventHandler(this.buttonDell_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSort.Location = new System.Drawing.Point(352, 379);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(219, 45);
            this.buttonSort.TabIndex = 11;
            this.buttonSort.Text = "Сортировка по количеству работникуров";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Visible = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // numericAddDelPerson
            // 
            this.numericAddDelPerson.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericAddDelPerson.Location = new System.Drawing.Point(777, 361);
            this.numericAddDelPerson.Name = "numericAddDelPerson";
            this.numericAddDelPerson.Size = new System.Drawing.Size(162, 20);
            this.numericAddDelPerson.TabIndex = 13;
            // 
            // buttonSl
            // 
            this.buttonSl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSl.Location = new System.Drawing.Point(39, 379);
            this.buttonSl.Name = "buttonSl";
            this.buttonSl.Size = new System.Drawing.Size(162, 45);
            this.buttonSl.TabIndex = 14;
            this.buttonSl.Text = "Слияние";
            this.buttonSl.UseVisualStyleBackColor = true;
            this.buttonSl.Visible = false;
            this.buttonSl.Click += new System.EventHandler(this.buttonSl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::_2lb.Properties.Resources.factory1;
            this.ClientSize = new System.Drawing.Size(974, 478);
            this.Controls.Add(this.buttonSl);
            this.Controls.Add(this.numericAddDelPerson);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonDell);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.AddFactor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFabricaMenu);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Завод";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddDelPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddFabricaMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button AddFactor;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button buttonDell;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.NumericUpDown numericAddDelPerson;
        private System.Windows.Forms.Button buttonSl;
    }
}

