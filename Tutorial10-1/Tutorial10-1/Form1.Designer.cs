namespace Tutorial10_1
{
    partial class Form1
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.createObjBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.matDateLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.intRateLbl = new System.Windows.Forms.Label();
            this.accNumberLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.matDateTB = new System.Windows.Forms.TextBox();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.intRateTB = new System.Windows.Forms.TextBox();
            this.accNumberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(138, 330);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 38);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // createObjBtn
            // 
            this.createObjBtn.Location = new System.Drawing.Point(43, 330);
            this.createObjBtn.Name = "createObjBtn";
            this.createObjBtn.Size = new System.Drawing.Size(75, 38);
            this.createObjBtn.TabIndex = 6;
            this.createObjBtn.Text = "Create Object";
            this.createObjBtn.UseVisualStyleBackColor = true;
            this.createObjBtn.Click += new System.EventHandler(this.createObjBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.matDateLbl);
            this.groupBox2.Controls.Add(this.balanceLbl);
            this.groupBox2.Controls.Add(this.intRateLbl);
            this.groupBox2.Controls.Add(this.accNumberLbl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(13, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object Properties";
            // 
            // matDateLbl
            // 
            this.matDateLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matDateLbl.Location = new System.Drawing.Point(111, 104);
            this.matDateLbl.Name = "matDateLbl";
            this.matDateLbl.Size = new System.Drawing.Size(100, 23);
            this.matDateLbl.TabIndex = 10;
            // 
            // balanceLbl
            // 
            this.balanceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balanceLbl.Location = new System.Drawing.Point(111, 77);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(100, 23);
            this.balanceLbl.TabIndex = 9;
            // 
            // intRateLbl
            // 
            this.intRateLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intRateLbl.Location = new System.Drawing.Point(111, 51);
            this.intRateLbl.Name = "intRateLbl";
            this.intRateLbl.Size = new System.Drawing.Size(100, 23);
            this.intRateLbl.TabIndex = 8;
            // 
            // accNumberLbl
            // 
            this.accNumberLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accNumberLbl.Location = new System.Drawing.Point(111, 25);
            this.accNumberLbl.Name = "accNumberLbl";
            this.accNumberLbl.Size = new System.Drawing.Size(100, 23);
            this.accNumberLbl.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Maturity Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Account Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Interest Rate:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matDateTB);
            this.groupBox1.Controls.Add(this.balanceTB);
            this.groupBox1.Controls.Add(this.intRateTB);
            this.groupBox1.Controls.Add(this.accNumberTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter CD Account Data";
            // 
            // matDateTB
            // 
            this.matDateTB.Location = new System.Drawing.Point(111, 97);
            this.matDateTB.Name = "matDateTB";
            this.matDateTB.Size = new System.Drawing.Size(100, 20);
            this.matDateTB.TabIndex = 10;
            // 
            // balanceTB
            // 
            this.balanceTB.Location = new System.Drawing.Point(111, 72);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.Size = new System.Drawing.Size(100, 20);
            this.balanceTB.TabIndex = 9;
            // 
            // intRateTB
            // 
            this.intRateTB.Location = new System.Drawing.Point(111, 48);
            this.intRateTB.Name = "intRateTB";
            this.intRateTB.Size = new System.Drawing.Size(100, 20);
            this.intRateTB.TabIndex = 8;
            // 
            // accNumberTB
            // 
            this.accNumberTB.Location = new System.Drawing.Point(111, 23);
            this.accNumberTB.Name = "accNumberTB";
            this.accNumberTB.Size = new System.Drawing.Size(100, 20);
            this.accNumberTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maturity Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interest Rate:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 380);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.createObjBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button createObjBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label matDateLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label intRateLbl;
        private System.Windows.Forms.Label accNumberLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox matDateTB;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.TextBox intRateTB;
        private System.Windows.Forms.TextBox accNumberTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

