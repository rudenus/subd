namespace WinFormsApp1
{
    partial class FormLessons
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdSubject = new System.Windows.Forms.TextBox();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.textBoxEstimation = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxIdDelete = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIdUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSubjectIdUpdate = new System.Windows.Forms.TextBox();
            this.textBoxUserIdUpdate = new System.Windows.Forms.TextBox();
            this.textBoxEstimationUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiltred = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(22, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 50);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(22, 304);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(143, 50);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Получить список уроков";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxIdSubject);
            this.groupBox1.Controls.Add(this.textBoxIdUser);
            this.groupBox1.Controls.Add(this.textBoxEstimation);
            this.groupBox1.Location = new System.Drawing.Point(22, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Предмет";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Оценка";
            // 
            // textBoxIdSubject
            // 
            this.textBoxIdSubject.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdSubject.Location = new System.Drawing.Point(113, 107);
            this.textBoxIdSubject.Name = "textBoxIdSubject";
            this.textBoxIdSubject.Size = new System.Drawing.Size(42, 25);
            this.textBoxIdSubject.TabIndex = 8;
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdUser.Location = new System.Drawing.Point(113, 67);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.Size = new System.Drawing.Size(42, 25);
            this.textBoxIdUser.TabIndex = 7;
            // 
            // textBoxEstimation
            // 
            this.textBoxEstimation.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEstimation.Location = new System.Drawing.Point(113, 24);
            this.textBoxEstimation.Name = "textBoxEstimation";
            this.textBoxEstimation.Size = new System.Drawing.Size(42, 25);
            this.textBoxEstimation.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(590, 12);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(147, 50);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Обновить значение";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(590, 291);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 43);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxIdDelete
            // 
            this.textBoxIdDelete.Location = new System.Drawing.Point(92, 35);
            this.textBoxIdDelete.Name = "textBoxIdDelete";
            this.textBoxIdDelete.Size = new System.Drawing.Size(73, 27);
            this.textBoxIdDelete.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(17, 38);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(22, 20);
            this.Id.TabIndex = 9;
            this.Id.Text = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Id);
            this.groupBox3.Controls.Add(this.textBoxIdDelete);
            this.groupBox3.Location = new System.Drawing.Point(562, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 89);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.number,
            this.Letter});
            this.dataGridView.Location = new System.Drawing.Point(200, 68);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(356, 364);
            this.dataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.HeaderText = "Номер класса";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            // 
            // Letter
            // 
            this.Letter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Letter.HeaderText = "Литера";
            this.Letter.MinimumWidth = 6;
            this.Letter.Name = "Letter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIdUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxSubjectIdUpdate);
            this.groupBox2.Controls.Add(this.textBoxUserIdUpdate);
            this.groupBox2.Controls.Add(this.textBoxEstimationUpdate);
            this.groupBox2.Location = new System.Drawing.Point(590, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 192);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // textBoxIdUpdate
            // 
            this.textBoxIdUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIdUpdate.Location = new System.Drawing.Point(113, 32);
            this.textBoxIdUpdate.Name = "textBoxIdUpdate";
            this.textBoxIdUpdate.Size = new System.Drawing.Size(42, 25);
            this.textBoxIdUpdate.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Предмет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пользователь";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Оценка";
            // 
            // textBoxSubjectIdUpdate
            // 
            this.textBoxSubjectIdUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubjectIdUpdate.Location = new System.Drawing.Point(113, 154);
            this.textBoxSubjectIdUpdate.Name = "textBoxSubjectIdUpdate";
            this.textBoxSubjectIdUpdate.Size = new System.Drawing.Size(42, 25);
            this.textBoxSubjectIdUpdate.TabIndex = 8;
            // 
            // textBoxUserIdUpdate
            // 
            this.textBoxUserIdUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserIdUpdate.Location = new System.Drawing.Point(113, 112);
            this.textBoxUserIdUpdate.Name = "textBoxUserIdUpdate";
            this.textBoxUserIdUpdate.Size = new System.Drawing.Size(42, 25);
            this.textBoxUserIdUpdate.TabIndex = 7;
            // 
            // textBoxEstimationUpdate
            // 
            this.textBoxEstimationUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEstimationUpdate.Location = new System.Drawing.Point(113, 71);
            this.textBoxEstimationUpdate.Name = "textBoxEstimationUpdate";
            this.textBoxEstimationUpdate.Size = new System.Drawing.Size(42, 25);
            this.textBoxEstimationUpdate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фильтрация по оценке";
            // 
            // textBoxFiltred
            // 
            this.textBoxFiltred.Location = new System.Drawing.Point(24, 408);
            this.textBoxFiltred.Name = "textBoxFiltred";
            this.textBoxFiltred.Size = new System.Drawing.Size(125, 27);
            this.textBoxFiltred.TabIndex = 14;
            // 
            // FormLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFiltred);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormLessons";
            this.Text = "FormClasses";
            this.Load += new System.EventHandler(this.FormClasses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private Button buttonRefresh;
        private GroupBox groupBox1;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBoxIdDelete;
        private Label Id;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn Letter;
        private Label label9;
        private Label label8;
        private Label label2;
        private TextBox textBoxIdSubject;
        private TextBox textBoxIdUser;
        private TextBox textBoxEstimation;
        private GroupBox groupBox2;
        private TextBox textBoxIdUpdate;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxSubjectIdUpdate;
        private TextBox textBoxUserIdUpdate;
        private TextBox textBoxEstimationUpdate;
        private Label label1;
        private TextBox textBoxFiltred;
    }
}