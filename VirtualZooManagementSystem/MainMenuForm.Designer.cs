namespace VirtualZooManagementSystem
{
    partial class MainMenuForm
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
            this.btnManageAnimals = new System.Windows.Forms.Button();
            this.btnInteractWithAnimal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageAnimals
            // 
            this.btnManageAnimals.Location = new System.Drawing.Point(52, 39);
            this.btnManageAnimals.Name = "btnManageAnimals";
            this.btnManageAnimals.Size = new System.Drawing.Size(145, 23);
            this.btnManageAnimals.TabIndex = 0;
            this.btnManageAnimals.Text = "Manage Animals";
            this.btnManageAnimals.UseVisualStyleBackColor = true;
            this.btnManageAnimals.Click += new System.EventHandler(this.btnManageAnimals_Click);
            // 
            // btnInteractWithAnimal
            // 
            this.btnInteractWithAnimal.Location = new System.Drawing.Point(52, 83);
            this.btnInteractWithAnimal.Name = "btnInteractWithAnimal";
            this.btnInteractWithAnimal.Size = new System.Drawing.Size(145, 23);
            this.btnInteractWithAnimal.TabIndex = 1;
            this.btnInteractWithAnimal.Text = "Interact with Animal";
            this.btnInteractWithAnimal.UseVisualStyleBackColor = true;
            this.btnInteractWithAnimal.Click += new System.EventHandler(this.btnInteractWithAnimal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 127);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 180);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInteractWithAnimal);
            this.Controls.Add(this.btnManageAnimals);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnManageAnimals;
        private System.Windows.Forms.Button btnInteractWithAnimal;
        private System.Windows.Forms.Button btnClose;
    }
}
