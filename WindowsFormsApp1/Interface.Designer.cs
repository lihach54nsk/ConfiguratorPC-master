namespace WindowsFormsApp1
{
    partial class Interface
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.CPUTabPage = new System.Windows.Forms.TabPage();
            this.GPUTabPage = new System.Windows.Forms.TabPage();
            this.HardTabPage = new System.Windows.Forms.TabPage();
            this.MotherTabPage = new System.Windows.Forms.TabPage();
            this.PowerTabPage = new System.Windows.Forms.TabPage();
            this.MemoryTabPage = new System.Windows.Forms.TabPage();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MainPage);
            this.tabControl.Controls.Add(this.CPUTabPage);
            this.tabControl.Controls.Add(this.GPUTabPage);
            this.tabControl.Controls.Add(this.HardTabPage);
            this.tabControl.Controls.Add(this.MotherTabPage);
            this.tabControl.Controls.Add(this.PowerTabPage);
            this.tabControl.Controls.Add(this.MemoryTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(983, 290);
            this.tabControl.TabIndex = 2;
            // 
            // MainPage
            // 
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(975, 264);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Главная страница";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // CPUTabPage
            // 
            this.CPUTabPage.Location = new System.Drawing.Point(4, 22);
            this.CPUTabPage.Name = "CPUTabPage";
            this.CPUTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CPUTabPage.Size = new System.Drawing.Size(974, 264);
            this.CPUTabPage.TabIndex = 1;
            this.CPUTabPage.Text = "Процессоры";
            this.CPUTabPage.UseVisualStyleBackColor = true;
            // 
            // GPUTabPage
            // 
            this.GPUTabPage.Location = new System.Drawing.Point(4, 22);
            this.GPUTabPage.Name = "GPUTabPage";
            this.GPUTabPage.Size = new System.Drawing.Size(974, 264);
            this.GPUTabPage.TabIndex = 2;
            this.GPUTabPage.Text = "Видеокарты";
            this.GPUTabPage.UseVisualStyleBackColor = true;
            // 
            // HardTabPage
            // 
            this.HardTabPage.Location = new System.Drawing.Point(4, 22);
            this.HardTabPage.Name = "HardTabPage";
            this.HardTabPage.Size = new System.Drawing.Size(974, 264);
            this.HardTabPage.TabIndex = 3;
            this.HardTabPage.Text = "Жёсткие диски";
            this.HardTabPage.UseVisualStyleBackColor = true;
            // 
            // MotherTabPage
            // 
            this.MotherTabPage.Location = new System.Drawing.Point(4, 22);
            this.MotherTabPage.Name = "MotherTabPage";
            this.MotherTabPage.Size = new System.Drawing.Size(974, 264);
            this.MotherTabPage.TabIndex = 4;
            this.MotherTabPage.Text = "Материнская плата";
            this.MotherTabPage.UseVisualStyleBackColor = true;
            // 
            // PowerTabPage
            // 
            this.PowerTabPage.Location = new System.Drawing.Point(4, 22);
            this.PowerTabPage.Name = "PowerTabPage";
            this.PowerTabPage.Size = new System.Drawing.Size(974, 264);
            this.PowerTabPage.TabIndex = 5;
            this.PowerTabPage.Text = "Блоки питания";
            this.PowerTabPage.UseVisualStyleBackColor = true;
            // 
            // MemoryTabPage
            // 
            this.MemoryTabPage.Location = new System.Drawing.Point(4, 22);
            this.MemoryTabPage.Name = "MemoryTabPage";
            this.MemoryTabPage.Size = new System.Drawing.Size(974, 264);
            this.MemoryTabPage.TabIndex = 6;
            this.MemoryTabPage.Text = "Оперативная память";
            this.MemoryTabPage.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 308);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить в сборку";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 337);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить из сборки";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(860, 308);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(135, 23);
            this.RandomButton.TabIndex = 5;
            this.RandomButton.Text = "Сборка имени рандома";
            this.RandomButton.UseVisualStyleBackColor = true;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 366);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.tabControl);
            this.Name = "Interface";
            this.Text = "Interface";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage CPUTabPage;
        private System.Windows.Forms.TabPage GPUTabPage;
        private System.Windows.Forms.TabPage HardTabPage;
        private System.Windows.Forms.TabPage MotherTabPage;
        private System.Windows.Forms.TabPage PowerTabPage;
        private System.Windows.Forms.TabPage MemoryTabPage;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RandomButton;
    }
}