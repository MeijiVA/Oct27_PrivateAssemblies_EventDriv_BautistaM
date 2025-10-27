namespace Oct27_ClassLib_EventDriv_BautistaM
{
    partial class BasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cbxOperation = new System.Windows.Forms.ComboBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnCompute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCompute = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(23, 73);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(364, 38);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(23, 197);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(364, 38);
            this.txtNum2.TabIndex = 3;

            // 
            // cbxOperation
            // 
            this.cbxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOperation.FormattingEnabled = true;
            this.cbxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbxOperation.Location = new System.Drawing.Point(156, 133);
            this.cbxOperation.Name = "cbxOperation";
            this.cbxOperation.Size = new System.Drawing.Size(100, 39);
            this.cbxOperation.TabIndex = 4;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Black;
            this.pnl.Controls.Add(this.lblCompute);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Location = new System.Drawing.Point(23, 261);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(364, 143);
            this.pnl.TabIndex = 5;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(141, 429);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(126, 67);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total:";
            // 
            // lblCompute
            // 
            this.lblCompute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompute.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompute.ForeColor = System.Drawing.Color.Green;
            this.lblCompute.Location = new System.Drawing.Point(0, 27);
            this.lblCompute.Name = "lblCompute";
            this.lblCompute.Size = new System.Drawing.Size(364, 116);
            this.lblCompute.TabIndex = 1;
            this.lblCompute.Text = "000000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 540);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.cbxOperation);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cbxOperation;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblCompute;
        private System.Windows.Forms.Label label2;
    }
}