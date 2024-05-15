using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    partial class AddAnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.textBoxMovement = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.labelMovement = new System.Windows.Forms.Label();
            this.labelFoodType = new System.Windows.Forms.Label();
            this.labelHabitatType = new System.Windows.Forms.Label();
            this.labelAnimalType = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label(); // Added label for Animal Species
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(12, 80);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(204, 20);
            this.numericUpDownAge.TabIndex = 1;
            // 
            // textBoxSound
            // 
            this.textBoxSound.Location = new System.Drawing.Point(12, 126);
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.Size = new System.Drawing.Size(205, 20);
            this.textBoxSound.TabIndex = 2;
            // 
            // textBoxMovement
            // 
            this.textBoxMovement.Location = new System.Drawing.Point(12, 172);
            this.textBoxMovement.Name = "textBoxMovement";
            this.textBoxMovement.Size = new System.Drawing.Size(205, 20);
            this.textBoxMovement.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 64);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 5;
            this.labelAge.Text = "Age";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(12, 110);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(38, 13);
            this.labelSound.TabIndex = 6;
            this.labelSound.Text = "Sound";
            // 
            // labelMovement
            // 
            this.labelMovement.AutoSize = true;
            this.labelMovement.Location = new System.Drawing.Point(12, 156);
            this.labelMovement.Name = "labelMovement";
            this.labelMovement.Size = new System.Drawing.Size(57, 13);
            this.labelMovement.TabIndex = 7;
            this.labelMovement.Text = "Movement";
            // 
            // labelFoodType
            // 
            this.labelFoodType.AutoSize = true;
            this.labelFoodType.Location = new System.Drawing.Point(225, 18);
            this.labelFoodType.Name = "labelFoodType";
            this.labelFoodType.Size = new System.Drawing.Size(57, 13);
            this.labelFoodType.TabIndex = 8;
            this.labelFoodType.Text = "Food Type";
            // 
            // labelHabitatType
            // 
            this.labelHabitatType.AutoSize = true;
            this.labelHabitatType.Location = new System.Drawing.Point(225, 64);
            this.labelHabitatType.Name = "labelHabitatType";
            this.labelHabitatType.Size = new System.Drawing.Size(67, 13);
            this.labelHabitatType.TabIndex = 9;
            this.labelHabitatType.Text = "Habitat Type";
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(225, 110);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(66, 13);
            this.labelAnimalType.TabIndex = 10;
            this.labelAnimalType.Text = "Animal Type";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Location = new System.Drawing.Point(225, 156);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(45, 13);
            this.labelSpecies.TabIndex = 11;
            this.labelSpecies.Text = "Species";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(363, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 251); // Adjusted width and height
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelAnimalType);
            this.Controls.Add(this.labelHabitatType);
            this.Controls.Add(this.labelFoodType);
            this.Controls.Add(this.labelMovement);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxMovement);
            this.Controls.Add(this.textBoxSound);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // Prevent resizing
            this.Name = "AddAnimalForm";
            this.Text = "Add Animal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.TextBox textBoxMovement;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Label labelMovement;
        private System.Windows.Forms.Label labelFoodType;
        private System.Windows.Forms.Label labelHabitatType;
        private System.Windows.Forms.Label labelAnimalType;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Button btnAdd;
    }
}
