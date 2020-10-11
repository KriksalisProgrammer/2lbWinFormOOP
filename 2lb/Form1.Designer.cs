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
            this.AddPerson = new System.Windows.Forms.Button();
            this.buttonDell = new System.Windows.Forms.Button();
            this.numericAddDelPerson = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.слиятьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMerge = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAddDelPerson)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFabricaMenu
            // 
            this.AddFabricaMenu.BackColor = System.Drawing.Color.White;
            this.AddFabricaMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddFabricaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddFabricaMenu.Location = new System.Drawing.Point(383, 297);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(974, 311);
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
            // AddPerson
            // 
            this.AddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddPerson.Location = new System.Drawing.Point(12, 408);
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
            this.buttonDell.Location = new System.Drawing.Point(180, 408);
            this.buttonDell.Name = "buttonDell";
            this.buttonDell.Size = new System.Drawing.Size(162, 45);
            this.buttonDell.TabIndex = 10;
            this.buttonDell.Text = "Уволить работников";
            this.buttonDell.UseVisualStyleBackColor = true;
            this.buttonDell.Visible = false;
            this.buttonDell.Click += new System.EventHandler(this.buttonDell_Click);
            // 
            // numericAddDelPerson
            // 
            this.numericAddDelPerson.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericAddDelPerson.Location = new System.Drawing.Point(89, 382);
            this.numericAddDelPerson.Name = "numericAddDelPerson";
            this.numericAddDelPerson.Size = new System.Drawing.Size(162, 20);
            this.numericAddDelPerson.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.слиятьToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // слиятьToolStripMenuItem
            // 
            this.слиятьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuAdd,
            this.ToolStripMenuItemSort,
            this.ToolStripMenuItemMerge,
            this.toolStripSeparator1,
            this.ToolStripMenuItemExit});
            this.слиятьToolStripMenuItem.Name = "слиятьToolStripMenuItem";
            this.слиятьToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.слиятьToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuAdd
            // 
            this.toolStripMenuAdd.Name = "toolStripMenuAdd";
            this.toolStripMenuAdd.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuAdd.Text = "Добавить";
            this.toolStripMenuAdd.Click += new System.EventHandler(this.toolStripMenuAdd_Click);
            // 
            // ToolStripMenuItemSort
            // 
            this.ToolStripMenuItemSort.Name = "ToolStripMenuItemSort";
            this.ToolStripMenuItemSort.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSort.Text = "Отсортировать";
            this.ToolStripMenuItemSort.Click += new System.EventHandler(this.ToolStripMenuItemSort_Click);
            // 
            // ToolStripMenuItemMerge
            // 
            this.ToolStripMenuItemMerge.Name = "ToolStripMenuItemMerge";
            this.ToolStripMenuItemMerge.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemMerge.Text = "Слиять";
            this.ToolStripMenuItemMerge.Click += new System.EventHandler(this.ToolStripMenuItemMerge_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemExit.Text = "Выход";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInfo});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // ToolStripMenuItemInfo
            // 
            this.ToolStripMenuItemInfo.Name = "ToolStripMenuItemInfo";
            this.ToolStripMenuItemInfo.Size = new System.Drawing.Size(148, 22);
            this.ToolStripMenuItemInfo.Text = "Информация";
            this.ToolStripMenuItemInfo.Click += new System.EventHandler(this.ToolStripMenuItemInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(60, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Найм и увольнение:";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::_2lb.Properties.Resources.factory1;
            this.ClientSize = new System.Drawing.Size(974, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericAddDelPerson);
            this.Controls.Add(this.buttonDell);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button buttonDell;
        private System.Windows.Forms.NumericUpDown numericAddDelPerson;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem слиятьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMerge;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}

