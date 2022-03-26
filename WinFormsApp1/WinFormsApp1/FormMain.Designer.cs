namespace WinFormsApp1
{
    partial class FormMain
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
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonClasses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(26, 27);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(149, 44);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonClasses
            // 
            this.buttonClasses.Location = new System.Drawing.Point(26, 98);
            this.buttonClasses.Name = "buttonClasses";
            this.buttonClasses.Size = new System.Drawing.Size(149, 44);
            this.buttonClasses.TabIndex = 1;
            this.buttonClasses.Text = "Классы";
            this.buttonClasses.UseVisualStyleBackColor = true;
            this.buttonClasses.Click += new System.EventHandler(this.buttonClasses_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClasses);
            this.Controls.Add(this.buttonUsers);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonUsers;
        private Button buttonClasses;
    }
}