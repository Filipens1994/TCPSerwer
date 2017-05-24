namespace TCPklient
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
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.polacz = new System.Windows.Forms.Button();
            this.Adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(45, 53);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(679, 368);
            this.info_o_polaczeniu.TabIndex = 0;
            // 
            // polacz
            // 
            this.polacz.Location = new System.Drawing.Point(309, 427);
            this.polacz.Name = "polacz";
            this.polacz.Size = new System.Drawing.Size(142, 50);
            this.polacz.TabIndex = 1;
            this.polacz.Text = "polacz";
            this.polacz.UseVisualStyleBackColor = true;
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(45, 12);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(308, 20);
            this.Adres.TabIndex = 2;
            this.Adres.Text = "Adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(392, 12);
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(332, 20);
            this.my_port.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 489);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button polacz;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.NumericUpDown my_port;
    }
}

