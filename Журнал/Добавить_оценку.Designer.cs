
namespace Журнал
{
    partial class Добавить_оценку
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
            this.label2 = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.ComboBox();
            this.discip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(91, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "Ученик";
            // 
            // kod
            // 
            this.kod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kod.FormattingEnabled = true;
            this.kod.Items.AddRange(new object[] {
            "Купли",
            "Продажи"});
            this.kod.Location = new System.Drawing.Point(181, 24);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(314, 25);
            this.kod.TabIndex = 111;
            // 
            // discip
            // 
            this.discip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discip.FormattingEnabled = true;
            this.discip.Items.AddRange(new object[] {
            "Купли",
            "Продажи"});
            this.discip.Location = new System.Drawing.Point(181, 78);
            this.discip.Name = "discip";
            this.discip.Size = new System.Drawing.Size(314, 25);
            this.discip.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 112;
            this.label1.Text = "Дисциплина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(89, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 114;
            this.label3.Text = "Оценка";
            // 
            // grade
            // 
            this.grade.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.grade.Location = new System.Drawing.Point(181, 138);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(314, 23);
            this.grade.TabIndex = 115;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.DarkRed;
            this.backbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.backbtn.Location = new System.Drawing.Point(330, 206);
            this.backbtn.Margin = new System.Windows.Forms.Padding(10);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(145, 30);
            this.backbtn.TabIndex = 117;
            this.backbtn.Text = "Отменить";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Green;
            this.Addbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Addbtn.Location = new System.Drawing.Point(156, 206);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(10);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(145, 30);
            this.Addbtn.TabIndex = 116;
            this.Addbtn.Text = "Добавить";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Добавить_оценку
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 277);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.label2);
            this.Name = "Добавить_оценку";
            this.Text = "Добавить оценку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox kod;
        public System.Windows.Forms.ComboBox discip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox grade;
        public System.Windows.Forms.Button backbtn;
        public System.Windows.Forms.Button Addbtn;
    }
}