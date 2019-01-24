namespace u4_Proje2
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
            this.btnXMLdenGetir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXMLeCevir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXMLdenGetir
            // 
            this.btnXMLdenGetir.Location = new System.Drawing.Point(406, 361);
            this.btnXMLdenGetir.Name = "btnXMLdenGetir";
            this.btnXMLdenGetir.Size = new System.Drawing.Size(124, 47);
            this.btnXMLdenGetir.TabIndex = 5;
            this.btnXMLdenGetir.Text = "XML den Getir";
            this.btnXMLdenGetir.UseVisualStyleBackColor = true;
            this.btnXMLdenGetir.Click += new System.EventHandler(this.btnXMLdenGetir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 329);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnXMLeCevir
            // 
            this.btnXMLeCevir.Location = new System.Drawing.Point(14, 361);
            this.btnXMLeCevir.Name = "btnXMLeCevir";
            this.btnXMLeCevir.Size = new System.Drawing.Size(129, 47);
            this.btnXMLeCevir.TabIndex = 3;
            this.btnXMLeCevir.Text = "XML e Çevir";
            this.btnXMLeCevir.UseVisualStyleBackColor = true;
            this.btnXMLeCevir.Click += new System.EventHandler(this.btnXMLeCevir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 431);
            this.Controls.Add(this.btnXMLdenGetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXMLeCevir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXMLdenGetir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXMLeCevir;
    }
}

