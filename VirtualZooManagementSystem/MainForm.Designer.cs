namespace VirtualZooManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listBoxZoo = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAnimalType = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.labelMovement = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(16, 15);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(141, 28);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(165, 17);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(176, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(351, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(459, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listBoxZoo
            // 
            this.listBoxZoo.FormattingEnabled = true;
            this.listBoxZoo.ItemHeight = 16;
            this.listBoxZoo.Location = new System.Drawing.Point(16, 50);
            this.listBoxZoo.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxZoo.Name = "listBoxZoo";
            this.listBoxZoo.Size = new System.Drawing.Size(541, 180);
            this.listBoxZoo.TabIndex = 4;
            this.listBoxZoo.SelectedIndexChanged += new System.EventHandler(this.listBoxZoo_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 246);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 17);
            this.labelName.TabIndex = 5;
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(16, 270);
            this.labelAnimalType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(0, 17);
            this.labelAnimalType.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(16, 293);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 17);
            this.labelAge.TabIndex = 7;
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(16, 316);
            this.labelSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(0, 17);
            this.labelSound.TabIndex = 8;
            // 
            // labelMovement
            // 
            this.labelMovement.AutoSize = true;
            this.labelMovement.Location = new System.Drawing.Point(16, 340);
            this.labelMovement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMovement.Name = "labelMovement";
            this.labelMovement.Size = new System.Drawing.Size(0, 17);
            this.labelMovement.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 336);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 28);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 380);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelMovement);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAnimalType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxZoo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnAddAnimal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Virtual Zoo Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox listBoxZoo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAnimalType;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Label labelMovement;
        private System.Windows.Forms.Button btnClear;
    }
}
