
namespace Circustrein
{
    partial class Circustrein
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnimalAdd = new System.Windows.Forms.Panel();
            this.AnimalAddSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SizeLarge = new System.Windows.Forms.RadioButton();
            this.SizeSmall = new System.Windows.Forms.RadioButton();
            this.SizeMedium = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DietMeat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DietPlants = new System.Windows.Forms.RadioButton();
            this.AnimailAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnimalAddTitle = new System.Windows.Forms.Label();
            this.ListViewAnimal = new System.Windows.Forms.ListView();
            this.OrderAnimals = new System.Windows.Forms.Button();
            this.TrainList = new System.Windows.Forms.RichTextBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.AnimalAdd.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalAdd
            // 
            this.AnimalAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AnimalAdd.Controls.Add(this.AnimalAddSubmit);
            this.AnimalAdd.Controls.Add(this.groupBox2);
            this.AnimalAdd.Controls.Add(this.groupBox1);
            this.AnimalAdd.Controls.Add(this.AnimailAddName);
            this.AnimalAdd.Controls.Add(this.label1);
            this.AnimalAdd.Controls.Add(this.AnimalAddTitle);
            this.AnimalAdd.Location = new System.Drawing.Point(898, 12);
            this.AnimalAdd.Name = "AnimalAdd";
            this.AnimalAdd.Size = new System.Drawing.Size(350, 653);
            this.AnimalAdd.TabIndex = 0;
            // 
            // AnimalAddSubmit
            // 
            this.AnimalAddSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.AnimalAddSubmit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimalAddSubmit.Location = new System.Drawing.Point(0, 602);
            this.AnimalAddSubmit.Name = "AnimalAddSubmit";
            this.AnimalAddSubmit.Size = new System.Drawing.Size(350, 51);
            this.AnimalAddSubmit.TabIndex = 9;
            this.AnimalAddSubmit.Text = "Add Animal";
            this.AnimalAddSubmit.UseVisualStyleBackColor = false;
            this.AnimalAddSubmit.Click += new System.EventHandler(this.AnimalAddSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SizeLarge);
            this.groupBox2.Controls.Add(this.SizeSmall);
            this.groupBox2.Controls.Add(this.SizeMedium);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // SizeLarge
            // 
            this.SizeLarge.AutoSize = true;
            this.SizeLarge.BackColor = System.Drawing.SystemColors.Control;
            this.SizeLarge.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeLarge.Location = new System.Drawing.Point(213, 39);
            this.SizeLarge.Name = "SizeLarge";
            this.SizeLarge.Size = new System.Drawing.Size(85, 34);
            this.SizeLarge.TabIndex = 9;
            this.SizeLarge.TabStop = true;
            this.SizeLarge.Text = "Large";
            this.SizeLarge.UseVisualStyleBackColor = false;
            // 
            // SizeSmall
            // 
            this.SizeSmall.AutoSize = true;
            this.SizeSmall.BackColor = System.Drawing.SystemColors.Control;
            this.SizeSmall.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeSmall.Location = new System.Drawing.Point(6, 39);
            this.SizeSmall.Name = "SizeSmall";
            this.SizeSmall.Size = new System.Drawing.Size(83, 34);
            this.SizeSmall.TabIndex = 7;
            this.SizeSmall.TabStop = true;
            this.SizeSmall.Text = "Small";
            this.SizeSmall.UseVisualStyleBackColor = false;
            // 
            // SizeMedium
            // 
            this.SizeMedium.AutoSize = true;
            this.SizeMedium.BackColor = System.Drawing.SystemColors.Control;
            this.SizeMedium.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeMedium.Location = new System.Drawing.Point(95, 39);
            this.SizeMedium.Name = "SizeMedium";
            this.SizeMedium.Size = new System.Drawing.Size(112, 34);
            this.SizeMedium.TabIndex = 8;
            this.SizeMedium.TabStop = true;
            this.SizeMedium.Text = "Medium";
            this.SizeMedium.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Animal size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DietMeat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DietPlants);
            this.groupBox1.Location = new System.Drawing.Point(0, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 101);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DietMeat
            // 
            this.DietMeat.AutoSize = true;
            this.DietMeat.BackColor = System.Drawing.SystemColors.Control;
            this.DietMeat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DietMeat.Location = new System.Drawing.Point(6, 38);
            this.DietMeat.Name = "DietMeat";
            this.DietMeat.Size = new System.Drawing.Size(81, 34);
            this.DietMeat.TabIndex = 5;
            this.DietMeat.TabStop = true;
            this.DietMeat.Text = "Meat";
            this.DietMeat.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Animal diet";
            // 
            // DietPlants
            // 
            this.DietPlants.AutoSize = true;
            this.DietPlants.BackColor = System.Drawing.SystemColors.Control;
            this.DietPlants.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DietPlants.Location = new System.Drawing.Point(93, 38);
            this.DietPlants.Name = "DietPlants";
            this.DietPlants.Size = new System.Drawing.Size(87, 34);
            this.DietPlants.TabIndex = 6;
            this.DietPlants.TabStop = true;
            this.DietPlants.Text = "Plants";
            this.DietPlants.UseVisualStyleBackColor = false;
            // 
            // AnimailAddName
            // 
            this.AnimailAddName.BackColor = System.Drawing.SystemColors.Control;
            this.AnimailAddName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimailAddName.Location = new System.Drawing.Point(0, 122);
            this.AnimailAddName.MaxLength = 16;
            this.AnimailAddName.Name = "AnimailAddName";
            this.AnimailAddName.Size = new System.Drawing.Size(350, 36);
            this.AnimailAddName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Animal name";
            // 
            // AnimalAddTitle
            // 
            this.AnimalAddTitle.AutoSize = true;
            this.AnimalAddTitle.BackColor = System.Drawing.SystemColors.Control;
            this.AnimalAddTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimalAddTitle.Location = new System.Drawing.Point(-11, 9);
            this.AnimalAddTitle.Name = "AnimalAddTitle";
            this.AnimalAddTitle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AnimalAddTitle.Size = new System.Drawing.Size(381, 65);
            this.AnimalAddTitle.TabIndex = 0;
            this.AnimalAddTitle.Text = "ADD A ANIMAL\r\n";
            this.AnimalAddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListViewAnimal
            // 
            this.ListViewAnimal.BackColor = System.Drawing.SystemColors.Control;
            this.ListViewAnimal.HideSelection = false;
            this.ListViewAnimal.Location = new System.Drawing.Point(12, 12);
            this.ListViewAnimal.Name = "ListViewAnimal";
            this.ListViewAnimal.Size = new System.Drawing.Size(275, 653);
            this.ListViewAnimal.TabIndex = 1;
            this.ListViewAnimal.UseCompatibleStateImageBehavior = false;
            // 
            // OrderAnimals
            // 
            this.OrderAnimals.BackColor = System.Drawing.SystemColors.Control;
            this.OrderAnimals.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderAnimals.Location = new System.Drawing.Point(293, 614);
            this.OrderAnimals.Name = "OrderAnimals";
            this.OrderAnimals.Size = new System.Drawing.Size(169, 51);
            this.OrderAnimals.TabIndex = 2;
            this.OrderAnimals.Text = "Order to train";
            this.OrderAnimals.UseVisualStyleBackColor = false;
            this.OrderAnimals.Click += new System.EventHandler(this.OrderAnimals_Click);
            // 
            // TrainList
            // 
            this.TrainList.BackColor = System.Drawing.SystemColors.Control;
            this.TrainList.Location = new System.Drawing.Point(293, 12);
            this.TrainList.Name = "TrainList";
            this.TrainList.ReadOnly = true;
            this.TrainList.Size = new System.Drawing.Size(599, 596);
            this.TrainList.TabIndex = 3;
            this.TrainList.Text = "";
            // 
            // ClearAll
            // 
            this.ClearAll.BackColor = System.Drawing.SystemColors.Control;
            this.ClearAll.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearAll.Location = new System.Drawing.Point(723, 614);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(169, 51);
            this.ClearAll.TabIndex = 4;
            this.ClearAll.Text = "Clear all";
            this.ClearAll.UseVisualStyleBackColor = false;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Circustrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(10, 0);
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.TrainList);
            this.Controls.Add(this.OrderAnimals);
            this.Controls.Add(this.ListViewAnimal);
            this.Controls.Add(this.AnimalAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Circustrein";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circustrein";
            this.AnimalAdd.ResumeLayout(false);
            this.AnimalAdd.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnimalAdd;
        private System.Windows.Forms.Label AnimalAddTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnimailAddName;
        private System.Windows.Forms.RadioButton DietPlants;
        private System.Windows.Forms.RadioButton DietMeat;
        private System.Windows.Forms.Button AnimalAddSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SizeLarge;
        private System.Windows.Forms.RadioButton SizeSmall;
        private System.Windows.Forms.RadioButton SizeMedium;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListViewAnimal;
        private System.Windows.Forms.Button OrderAnimals;
        private System.Windows.Forms.RichTextBox TrainList;
        private System.Windows.Forms.Button ClearAll;
    }
}

