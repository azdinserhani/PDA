namespace PDA
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.button2 = new System.Windows.Forms.Button();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.nomInput = new System.Windows.Forms.TextBox();
            this.prenomInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(617, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ageInput
            // 
            this.ageInput.BackColor = System.Drawing.Color.BurlyWood;
            this.ageInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageInput.ForeColor = System.Drawing.Color.White;
            this.ageInput.Location = new System.Drawing.Point(319, 298);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(130, 22);
            this.ageInput.TabIndex = 19;
            this.ageInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ageInput_KeyDown);
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.BurlyWood;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.ForeColor = System.Drawing.Color.White;
            this.passwordInput.Location = new System.Drawing.Point(319, 333);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(130, 22);
            this.passwordInput.TabIndex = 16;
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            // 
            // nomInput
            // 
            this.nomInput.BackColor = System.Drawing.Color.BurlyWood;
            this.nomInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomInput.ForeColor = System.Drawing.Color.White;
            this.nomInput.Location = new System.Drawing.Point(320, 256);
            this.nomInput.Name = "nomInput";
            this.nomInput.Size = new System.Drawing.Size(129, 22);
            this.nomInput.TabIndex = 4;
            this.nomInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nomInput_KeyDown);
            // 
            // prenomInput
            // 
            this.prenomInput.BackColor = System.Drawing.Color.BurlyWood;
            this.prenomInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenomInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenomInput.ForeColor = System.Drawing.Color.White;
            this.prenomInput.Location = new System.Drawing.Point(319, 215);
            this.prenomInput.Name = "prenomInput";
            this.prenomInput.Size = new System.Drawing.Size(130, 22);
            this.prenomInput.TabIndex = 3;
            this.prenomInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.prenomInput_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(239, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 38);
            this.panel1.TabIndex = 20;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.nomInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.prenomInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nomInput;
        private System.Windows.Forms.TextBox prenomInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Panel panel1;
    }
}