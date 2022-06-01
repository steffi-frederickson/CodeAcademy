namespace Tip_Tax_Total
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.tipLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.tipBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "foodCostLbl";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price: ";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(24, 68);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(37, 15);
            this.taxLbl.TabIndex = 1;
            this.taxLbl.Text = "Tax %";
            // 
            // tipLbl
            // 
            this.tipLbl.AutoSize = true;
            this.tipLbl.Location = new System.Drawing.Point(24, 106);
            this.tipLbl.Name = "tipLbl";
            this.tipLbl.Size = new System.Drawing.Size(76, 15);
            this.tipLbl.TabIndex = 2;
            this.tipLbl.Text = "Tip Amount: ";
            // 
            // totalLbl
            // 
            this.totalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLbl.Location = new System.Drawing.Point(24, 151);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(64, 23);
            this.totalLbl.TabIndex = 3;
            this.totalLbl.Text = "Total:";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(24, 198);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(193, 39);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(60, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(117, 27);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 23);
            this.priceBox.TabIndex = 6;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(117, 68);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(100, 23);
            this.taxBox.TabIndex = 7;
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(117, 106);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(100, 23);
            this.tipBox.TabIndex = 8;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(108, 151);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(149, 23);
            this.totalBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 353);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.tipBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.tipLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meal Cost Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label taxLbl;
        private Label tipLbl;
        private Label totalLbl;
        private Button calculateButton;
        private Button exitButton;
        private TextBox priceBox;
        private TextBox taxBox;
        private TextBox tipBox;
        private TextBox totalBox;
    }
}