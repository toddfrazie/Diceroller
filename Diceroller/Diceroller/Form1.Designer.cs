namespace Diceroller
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
            this.d6 = new System.Windows.Forms.Button();
            this.d8 = new System.Windows.Forms.Button();
            this.d10 = new System.Windows.Forms.Button();
            this.d12 = new System.Windows.Forms.Button();
            this.d20 = new System.Windows.Forms.Button();
            this.numericD6 = new System.Windows.Forms.NumericUpDown();
            this.numericD8 = new System.Windows.Forms.NumericUpDown();
            this.numericD10 = new System.Windows.Forms.NumericUpDown();
            this.numericD12 = new System.Windows.Forms.NumericUpDown();
            this.numericD20 = new System.Windows.Forms.NumericUpDown();
            this.resultD6 = new System.Windows.Forms.TextBox();
            this.resultD8 = new System.Windows.Forms.TextBox();
            this.resultD10 = new System.Windows.Forms.TextBox();
            this.resultD12 = new System.Windows.Forms.TextBox();
            this.resultD20 = new System.Windows.Forms.TextBox();
            this.totalD6 = new System.Windows.Forms.TextBox();
            this.totalD8 = new System.Windows.Forms.TextBox();
            this.totalD10 = new System.Windows.Forms.TextBox();
            this.totalD12 = new System.Windows.Forms.TextBox();
            this.totalD20 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericD6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD20)).BeginInit();
            this.SuspendLayout();
            // 
            // d6
            // 
            this.d6.Location = new System.Drawing.Point(220, 88);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(75, 26);
            this.d6.TabIndex = 0;
            this.d6.Text = "D6";
            this.d6.UseVisualStyleBackColor = true;
            this.d6.Click += new System.EventHandler(this.d6_Click);
            // 
            // d8
            // 
            this.d8.Location = new System.Drawing.Point(220, 120);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(75, 23);
            this.d8.TabIndex = 1;
            this.d8.Text = "D8";
            this.d8.UseVisualStyleBackColor = true;
            this.d8.Click += new System.EventHandler(this.d8_Click);
            // 
            // d10
            // 
            this.d10.Location = new System.Drawing.Point(220, 149);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(75, 23);
            this.d10.TabIndex = 2;
            this.d10.Text = "D10";
            this.d10.UseVisualStyleBackColor = true;
            this.d10.Click += new System.EventHandler(this.d10_Click);
            // 
            // d12
            // 
            this.d12.Location = new System.Drawing.Point(220, 178);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(75, 23);
            this.d12.TabIndex = 3;
            this.d12.Text = "D12";
            this.d12.UseVisualStyleBackColor = true;
            this.d12.Click += new System.EventHandler(this.d12_Click);
            // 
            // d20
            // 
            this.d20.Location = new System.Drawing.Point(220, 207);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(75, 23);
            this.d20.TabIndex = 4;
            this.d20.Text = "D20";
            this.d20.UseVisualStyleBackColor = true;
            this.d20.Click += new System.EventHandler(this.d20_Click);
            // 
            // numericD6
            // 
            this.numericD6.Location = new System.Drawing.Point(301, 93);
            this.numericD6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericD6.Name = "numericD6";
            this.numericD6.Size = new System.Drawing.Size(40, 20);
            this.numericD6.TabIndex = 5;
            this.numericD6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericD8
            // 
            this.numericD8.Location = new System.Drawing.Point(301, 123);
            this.numericD8.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericD8.Name = "numericD8";
            this.numericD8.Size = new System.Drawing.Size(40, 20);
            this.numericD8.TabIndex = 6;
            this.numericD8.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericD10
            // 
            this.numericD10.Location = new System.Drawing.Point(302, 151);
            this.numericD10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericD10.Name = "numericD10";
            this.numericD10.Size = new System.Drawing.Size(39, 20);
            this.numericD10.TabIndex = 7;
            this.numericD10.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericD12
            // 
            this.numericD12.Location = new System.Drawing.Point(302, 180);
            this.numericD12.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericD12.Name = "numericD12";
            this.numericD12.Size = new System.Drawing.Size(40, 20);
            this.numericD12.TabIndex = 8;
            this.numericD12.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericD20
            // 
            this.numericD20.Location = new System.Drawing.Point(302, 209);
            this.numericD20.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericD20.Name = "numericD20";
            this.numericD20.Size = new System.Drawing.Size(39, 20);
            this.numericD20.TabIndex = 9;
            this.numericD20.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resultD6
            // 
            this.resultD6.Location = new System.Drawing.Point(47, 93);
            this.resultD6.Name = "resultD6";
            this.resultD6.Size = new System.Drawing.Size(100, 20);
            this.resultD6.TabIndex = 10;
            // 
            // resultD8
            // 
            this.resultD8.Location = new System.Drawing.Point(47, 123);
            this.resultD8.Name = "resultD8";
            this.resultD8.Size = new System.Drawing.Size(100, 20);
            this.resultD8.TabIndex = 11;
            // 
            // resultD10
            // 
            this.resultD10.Location = new System.Drawing.Point(47, 152);
            this.resultD10.Name = "resultD10";
            this.resultD10.Size = new System.Drawing.Size(100, 20);
            this.resultD10.TabIndex = 12;
            // 
            // resultD12
            // 
            this.resultD12.Location = new System.Drawing.Point(47, 181);
            this.resultD12.Name = "resultD12";
            this.resultD12.Size = new System.Drawing.Size(100, 20);
            this.resultD12.TabIndex = 13;
            // 
            // resultD20
            // 
            this.resultD20.Location = new System.Drawing.Point(47, 210);
            this.resultD20.Name = "resultD20";
            this.resultD20.Size = new System.Drawing.Size(100, 20);
            this.resultD20.TabIndex = 14;
            // 
            // totalD6
            // 
            this.totalD6.Location = new System.Drawing.Point(154, 92);
            this.totalD6.Name = "totalD6";
            this.totalD6.Size = new System.Drawing.Size(60, 20);
            this.totalD6.TabIndex = 15;
            // 
            // totalD8
            // 
            this.totalD8.Location = new System.Drawing.Point(154, 123);
            this.totalD8.Name = "totalD8";
            this.totalD8.Size = new System.Drawing.Size(60, 20);
            this.totalD8.TabIndex = 16;
            // 
            // totalD10
            // 
            this.totalD10.Location = new System.Drawing.Point(154, 152);
            this.totalD10.Name = "totalD10";
            this.totalD10.Size = new System.Drawing.Size(60, 20);
            this.totalD10.TabIndex = 17;
            // 
            // totalD12
            // 
            this.totalD12.Location = new System.Drawing.Point(153, 181);
            this.totalD12.Name = "totalD12";
            this.totalD12.Size = new System.Drawing.Size(60, 20);
            this.totalD12.TabIndex = 18;
            // 
            // totalD20
            // 
            this.totalD20.Location = new System.Drawing.Point(154, 210);
            this.totalD20.Name = "totalD20";
            this.totalD20.Size = new System.Drawing.Size(60, 20);
            this.totalD20.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 454);
            this.Controls.Add(this.totalD20);
            this.Controls.Add(this.totalD12);
            this.Controls.Add(this.totalD10);
            this.Controls.Add(this.totalD8);
            this.Controls.Add(this.totalD6);
            this.Controls.Add(this.resultD20);
            this.Controls.Add(this.resultD12);
            this.Controls.Add(this.resultD10);
            this.Controls.Add(this.resultD8);
            this.Controls.Add(this.resultD6);
            this.Controls.Add(this.numericD20);
            this.Controls.Add(this.numericD12);
            this.Controls.Add(this.numericD10);
            this.Controls.Add(this.numericD8);
            this.Controls.Add(this.numericD6);
            this.Controls.Add(this.d20);
            this.Controls.Add(this.d12);
            this.Controls.Add(this.d10);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.d6);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            ((System.ComponentModel.ISupportInitialize)(this.numericD6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericD20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button d6;
        private System.Windows.Forms.Button d8;
        private System.Windows.Forms.Button d10;
        private System.Windows.Forms.Button d12;
        private System.Windows.Forms.Button d20;
        private System.Windows.Forms.NumericUpDown numericD6;
        private System.Windows.Forms.NumericUpDown numericD8;
        private System.Windows.Forms.NumericUpDown numericD10;
        private System.Windows.Forms.NumericUpDown numericD12;
        private System.Windows.Forms.NumericUpDown numericD20;
        private System.Windows.Forms.TextBox resultD6;
        private System.Windows.Forms.TextBox resultD8;
        private System.Windows.Forms.TextBox resultD10;
        private System.Windows.Forms.TextBox resultD12;
        private System.Windows.Forms.TextBox resultD20;
        private System.Windows.Forms.TextBox totalD6;
        private System.Windows.Forms.TextBox totalD8;
        private System.Windows.Forms.TextBox totalD10;
        private System.Windows.Forms.TextBox totalD12;
        private System.Windows.Forms.TextBox totalD20;
    }
}

