using System.Windows.Forms;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelFoodType = new System.Windows.Forms.Label();
            this.labelHabitatType = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(106, 23);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(124, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(133, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(263, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(344, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listBoxZoo
            // 
            this.listBoxZoo.FormattingEnabled = true;
            this.listBoxZoo.Location = new System.Drawing.Point(12, 41);
            this.listBoxZoo.Name = "listBoxZoo";
            this.listBoxZoo.Size = new System.Drawing.Size(407, 147);
            this.listBoxZoo.TabIndex = 4;
            this.listBoxZoo.SelectedIndexChanged += new System.EventHandler(this.listBoxZoo_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 200);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 5;
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(12, 219);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(0, 13);
            this.labelAnimalType.TabIndex = 6;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 238);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(0, 13);
            this.labelAge.TabIndex = 7;
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(12, 257);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(0, 13);
            this.labelSound.TabIndex = 8;
            // 
            // labelMovement
            // 
            this.labelMovement.AutoSize = true;
            this.labelMovement.Location = new System.Drawing.Point(12, 276);
            this.labelMovement.Name = "labelMovement";
            this.labelMovement.Size = new System.Drawing.Size(0, 13);
            this.labelMovement.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(344, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(150, 200);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(0, 13);
            this.labelSpecies.TabIndex = 11;
            // 
            // labelFoodType
            // 
            this.labelFoodType.AutoSize = true;
            this.labelFoodType.Location = new System.Drawing.Point(150, 219);
            this.labelFoodType.Name = "labelFoodType";
            this.labelFoodType.Size = new System.Drawing.Size(0, 13);
            this.labelFoodType.TabIndex = 12;
            // 
            // labelHabitatType
            // 
            this.labelHabitatType.AutoSize = true;
            this.labelHabitatType.Location = new System.Drawing.Point(150, 238);
            this.labelHabitatType.Name = "labelHabitatType";
            this.labelHabitatType.Size = new System.Drawing.Size(0, 13);
            this.labelHabitatType.TabIndex = 13;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(344, 224);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMainMenu.TabIndex = 14;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 297);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.labelHabitatType);
            this.Controls.Add(this.labelFoodType);
            this.Controls.Add(this.labelSpecies);
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
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelFoodType;
        private System.Windows.Forms.Label labelHabitatType;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnClose;
    }
}
