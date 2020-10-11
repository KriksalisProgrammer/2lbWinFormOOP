namespace _2lb.View
{
    partial class AddFabricaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFabricaView));
            this.OkButton = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelQWorking = new System.Windows.Forms.Label();
            this.labelQWorkShop = new System.Windows.Forms.Label();
            this.labelSalaryWorking = new System.Windows.Forms.Label();
            this.labelSalarymaster = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxQWorking = new System.Windows.Forms.TextBox();
            this.textBoxQWorkShop = new System.Windows.Forms.TextBox();
            this.textBoxSWorking = new System.Windows.Forms.TextBox();
            this.textBoxSMaster = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OkButton.Location = new System.Drawing.Point(16, 196);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(105, 37);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Сохранить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(171, 24);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название завода:";
            // 
            // labelQWorking
            // 
            this.labelQWorking.AutoSize = true;
            this.labelQWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelQWorking.Location = new System.Drawing.Point(12, 48);
            this.labelQWorking.Name = "labelQWorking";
            this.labelQWorking.Size = new System.Drawing.Size(201, 24);
            this.labelQWorking.TabIndex = 2;
            this.labelQWorking.Text = "Количество рабочих:";
            // 
            // labelQWorkShop
            // 
            this.labelQWorkShop.AutoSize = true;
            this.labelQWorkShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelQWorkShop.Location = new System.Drawing.Point(12, 84);
            this.labelQWorkShop.Name = "labelQWorkShop";
            this.labelQWorkShop.Size = new System.Drawing.Size(181, 24);
            this.labelQWorkShop.TabIndex = 3;
            this.labelQWorkShop.Text = "Количество цехов:";
            // 
            // labelSalaryWorking
            // 
            this.labelSalaryWorking.AutoSize = true;
            this.labelSalaryWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSalaryWorking.Location = new System.Drawing.Point(12, 119);
            this.labelSalaryWorking.Name = "labelSalaryWorking";
            this.labelSalaryWorking.Size = new System.Drawing.Size(189, 24);
            this.labelSalaryWorking.TabIndex = 4;
            this.labelSalaryWorking.Text = "Зарплата рабочего:";
            // 
            // labelSalarymaster
            // 
            this.labelSalarymaster.AutoSize = true;
            this.labelSalarymaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSalarymaster.Location = new System.Drawing.Point(12, 153);
            this.labelSalarymaster.Name = "labelSalarymaster";
            this.labelSalarymaster.Size = new System.Drawing.Size(180, 24);
            this.labelSalarymaster.TabIndex = 5;
            this.labelSalarymaster.Text = "Зарплата мастера:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(227, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxQWorking
            // 
            this.textBoxQWorking.Location = new System.Drawing.Point(227, 52);
            this.textBoxQWorking.Name = "textBoxQWorking";
            this.textBoxQWorking.Size = new System.Drawing.Size(142, 20);
            this.textBoxQWorking.TabIndex = 7;
            this.textBoxQWorking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQWorking_KeyPress);
            // 
            // textBoxQWorkShop
            // 
            this.textBoxQWorkShop.Location = new System.Drawing.Point(227, 89);
            this.textBoxQWorkShop.Name = "textBoxQWorkShop";
            this.textBoxQWorkShop.Size = new System.Drawing.Size(142, 20);
            this.textBoxQWorkShop.TabIndex = 8;
            this.textBoxQWorkShop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQWorkShop_KeyPress);
            // 
            // textBoxSWorking
            // 
            this.textBoxSWorking.Location = new System.Drawing.Point(227, 124);
            this.textBoxSWorking.Name = "textBoxSWorking";
            this.textBoxSWorking.Size = new System.Drawing.Size(142, 20);
            this.textBoxSWorking.TabIndex = 9;
            this.textBoxSWorking.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSWorking_KeyPress);
            // 
            // textBoxSMaster
            // 
            this.textBoxSMaster.Location = new System.Drawing.Point(227, 158);
            this.textBoxSMaster.Name = "textBoxSMaster";
            this.textBoxSMaster.Size = new System.Drawing.Size(142, 20);
            this.textBoxSMaster.TabIndex = 10;
            this.textBoxSMaster.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSMaster_KeyPress);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CancelButton.Location = new System.Drawing.Point(258, 196);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 37);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddFabricaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 245);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBoxSMaster);
            this.Controls.Add(this.textBoxSWorking);
            this.Controls.Add(this.textBoxQWorkShop);
            this.Controls.Add(this.textBoxQWorking);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSalarymaster);
            this.Controls.Add(this.labelSalaryWorking);
            this.Controls.Add(this.labelQWorkShop);
            this.Controls.Add(this.labelQWorking);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.OkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFabricaView";
            this.Text = "Добавление завода";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelQWorking;
        private System.Windows.Forms.Label labelQWorkShop;
        private System.Windows.Forms.Label labelSalaryWorking;
        private System.Windows.Forms.Label labelSalarymaster;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxQWorking;
        private System.Windows.Forms.TextBox textBoxQWorkShop;
        private System.Windows.Forms.TextBox textBoxSWorking;
        private System.Windows.Forms.TextBox textBoxSMaster;
        private System.Windows.Forms.Button CancelButton;
    }
}