namespace Tea_Factory_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ceylon Tea Factory";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.LimeGreen;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.Desktop;
            this.register.Location = new System.Drawing.Point(291, 125);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(240, 30);
            this.register.TabIndex = 1;
            this.register.Text = "Customer Registration";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LimeGreen;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.add.Location = new System.Drawing.Point(291, 212);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(240, 30);
            this.add.TabIndex = 2;
            this.add.Text = "Add Tea Record";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.LimeGreen;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.Desktop;
            this.view.Location = new System.Drawing.Point(291, 286);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(240, 30);
            this.view.TabIndex = 3;
            this.view.Text = "View Records";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.Color.LimeGreen;
            this.bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bill.Location = new System.Drawing.Point(291, 362);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(240, 30);
            this.bill.TabIndex = 4;
            this.bill.Text = "Generate Monthly Bill";
            this.bill.UseVisualStyleBackColor = false;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.view);
            this.Controls.Add(this.add);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button bill;
    }
}

