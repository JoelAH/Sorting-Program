namespace Sorting_Program
{
    partial class frmMain
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
            this.lblSorting = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtGenerate = new System.Windows.Forms.TextBox();
            this.lblFF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBubble = new System.Windows.Forms.TextBox();
            this.txtShell = new System.Windows.Forms.TextBox();
            this.txtInsertion = new System.Windows.Forms.TextBox();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSorting
            // 
            this.lblSorting.AutoSize = true;
            this.lblSorting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSorting.Location = new System.Drawing.Point(275, 9);
            this.lblSorting.Name = "lblSorting";
            this.lblSorting.Size = new System.Drawing.Size(176, 24);
            this.lblSorting.TabIndex = 0;
            this.lblSorting.Text = "Sorting Program";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(47, 72);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(186, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate Random Numbers";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtGenerate
            // 
            this.txtGenerate.Enabled = false;
            this.txtGenerate.Location = new System.Drawing.Point(568, 69);
            this.txtGenerate.Name = "txtGenerate";
            this.txtGenerate.Size = new System.Drawing.Size(236, 20);
            this.txtGenerate.TabIndex = 2;
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Location = new System.Drawing.Point(465, 69);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(97, 13);
            this.lblFF.TabIndex = 3;
            this.lblFF.Text = "First Five Numbers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Five Numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Five Numbers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Five Numbers:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBubble);
            this.groupBox1.Controls.Add(this.txtShell);
            this.groupBox1.Controls.Add(this.txtInsertion);
            this.groupBox1.Controls.Add(this.btnBubble);
            this.groupBox1.Controls.Add(this.btnShell);
            this.groupBox1.Controls.Add(this.btnInsertion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 211);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorting Algorithms";
            // 
            // txtBubble
            // 
            this.txtBubble.Enabled = false;
            this.txtBubble.Location = new System.Drawing.Point(556, 153);
            this.txtBubble.Name = "txtBubble";
            this.txtBubble.Size = new System.Drawing.Size(236, 20);
            this.txtBubble.TabIndex = 12;
            // 
            // txtShell
            // 
            this.txtShell.Enabled = false;
            this.txtShell.Location = new System.Drawing.Point(557, 89);
            this.txtShell.Name = "txtShell";
            this.txtShell.Size = new System.Drawing.Size(235, 20);
            this.txtShell.TabIndex = 11;
            // 
            // txtInsertion
            // 
            this.txtInsertion.Enabled = false;
            this.txtInsertion.Location = new System.Drawing.Point(557, 12);
            this.txtInsertion.Name = "txtInsertion";
            this.txtInsertion.Size = new System.Drawing.Size(235, 20);
            this.txtInsertion.TabIndex = 10;
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(35, 160);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(186, 23);
            this.btnBubble.TabIndex = 9;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnShell
            // 
            this.btnShell.Location = new System.Drawing.Point(35, 89);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(186, 23);
            this.btnShell.TabIndex = 8;
            this.btnShell.Text = "Shell Sort";
            this.btnShell.UseVisualStyleBackColor = true;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(35, 19);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(186, 23);
            this.btnInsertion.TabIndex = 7;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 396);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFF);
            this.Controls.Add(this.txtGenerate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblSorting);
            this.Name = "frmMain";
            this.Text = "Sorting Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSorting;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGenerate;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBubble;
        private System.Windows.Forms.TextBox txtShell;
        private System.Windows.Forms.TextBox txtInsertion;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnExit;
    }
}

