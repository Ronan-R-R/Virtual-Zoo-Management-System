namespace VirtualZooManagementSystem
{
    partial class AddAnimalForm
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

        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelSound = new System.Windows.Forms.Label();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.labelMovement = new System.Windows.Forms.Label();
            this.textBoxMovement = new System.Windows.Forms.TextBox();
            this.labelAnimalType = new System.Windows.Forms.Label();
            this.textBoxAnimalType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(29, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(29, 65);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 2;
            this.labelAge.Text = "Age";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(102, 63);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAge.TabIndex = 3;
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point(29, 101);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(37, 13);
            this.labelSound.TabIndex = 4;
            this.labelSound.Text = "Sound";
            // 
            // textBoxSound
            // 
            this.textBoxSound.Location = new System.Drawing.Point(102, 98);
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.Size = new System.Drawing.Size(120, 20);
            this.textBoxSound.TabIndex = 5;
            // 
            // labelMovement
            // 
            this.labelMovement.AutoSize = true;
            this.labelMovement.Location = new System.Drawing.Point(29, 137);
            this.labelMovement.Name = "labelMovement";
            this.labelMovement.Size = new System.Drawing.Size(56, 13);
            this.labelMovement.TabIndex = 6;
            this.labelMovement.Text = "Movement";
            // 
            // textBoxMovement
            // 
            this.textBoxMovement.Location = new System.Drawing.Point(102, 134);
            this.textBoxMovement.Name = "textBoxMovement";
            this.textBoxMovement.Size = new System.Drawing.Size(120, 20);
            this.textBoxMovement.TabIndex = 7;
            // 
            // labelAnimalType
            // 
            this.labelAnimalType.AutoSize = true;
            this.labelAnimalType.Location = new System.Drawing.Point(29, 173);
            this.labelAnimalType.Name = "labelAnimalType";
            this.labelAnimalType.Size = new System.Drawing.Size(64, 13);
            this.labelAnimalType.TabIndex = 8;
            this.labelAnimalType.Text = "Animal Type";
            // 
            // textBoxAnimalType
            // 
            this.textBoxAnimalType.Location = new System.Drawing.Point(102, 170);
            this.textBoxAnimalType.Name = "textBoxAnimalType";
            this.textBoxAnimalType.Size = new System.Drawing.Size(120, 20);
            this.textBoxAnimalType.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddAnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 257);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxAnimalType);
            this.Controls.Add(this.labelAnimalType);
            this.Controls.Add(this.textBoxMovement);
            this.Controls.Add(this.labelMovement);
            this.Controls.Add(this.textBoxSound);
            this.Controls.Add(this.labelSound);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddAnimalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Animal";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.Label labelMovement;
        private System.Windows.Forms.TextBox textBoxMovement;
        private System.Windows.Forms.Label labelAnimalType;
        private System.Windows.Forms.TextBox textBoxAnimalType;
        private System.Windows.Forms.Button btnAdd;
    }
}
