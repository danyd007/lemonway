namespace WSWinformClient
{
    partial class MyForm
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
            this.btn_compute = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.lblXML = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_compute
            // 
            this.btn_compute.Location = new System.Drawing.Point(69, 67);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(95, 66);
            this.btn_compute.TabIndex = 0;
            this.btn_compute.Text = "Compute Fibonacci(N)";
            this.btn_compute.UseVisualStyleBackColor = true;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(32, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(24, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "N =";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(69, 27);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(95, 20);
            this.txtNumber.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_compute);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fibonacci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConvert);
            this.groupBox2.Controls.Add(this.txtXML);
            this.groupBox2.Controls.Add(this.lblXML);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XML to JSON Converter";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(69, 179);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(95, 25);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(69, 40);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(156, 133);
            this.txtXML.TabIndex = 5;
            // 
            // lblXML
            // 
            this.lblXML.AutoSize = true;
            this.lblXML.Location = new System.Drawing.Point(14, 43);
            this.lblXML.Name = "lblXML";
            this.lblXML.Size = new System.Drawing.Size(49, 13);
            this.lblXML.TabIndex = 4;
            this.lblXML.Text = "XML text";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblXML;
        private System.Windows.Forms.TextBox txtXML;
    }
}