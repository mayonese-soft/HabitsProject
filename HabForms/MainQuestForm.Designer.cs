
namespace HabForms
{
    partial class MainQuestForm
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
            this.mainTextLable = new System.Windows.Forms.Label();
            this.answerButton1 = new System.Windows.Forms.Button();
            this.answerButton2 = new System.Windows.Forms.Button();
            this.answerButton3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextLable
            // 
            this.mainTextLable.AutoSize = true;
            this.mainTextLable.Location = new System.Drawing.Point(199, 92);
            this.mainTextLable.Name = "mainTextLable";
            this.mainTextLable.Size = new System.Drawing.Size(35, 13);
            this.mainTextLable.TabIndex = 0;
            this.mainTextLable.Text = "label1";
            this.mainTextLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainTextLable.Click += new System.EventHandler(this.mainTextLable_Click);
            // 
            // answerButton1
            // 
            this.answerButton1.BackColor = System.Drawing.SystemColors.Control;
            this.answerButton1.FlatAppearance.BorderSize = 0;
            this.answerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton1.Location = new System.Drawing.Point(42, 19);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(245, 43);
            this.answerButton1.TabIndex = 1;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = false;
            this.answerButton1.Click += new System.EventHandler(this.answerButton1_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.BackColor = System.Drawing.SystemColors.Control;
            this.answerButton2.FlatAppearance.BorderSize = 0;
            this.answerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton2.Location = new System.Drawing.Point(42, 68);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(245, 45);
            this.answerButton2.TabIndex = 2;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = false;
            this.answerButton2.Click += new System.EventHandler(this.answerButton2_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.FlatAppearance.BorderSize = 0;
            this.answerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton3.Location = new System.Drawing.Point(42, 119);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(245, 49);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.Text = "button3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.answerButton1);
            this.groupBox1.Controls.Add(this.answerButton3);
            this.groupBox1.Controls.Add(this.answerButton2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(150, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите варианты ответа";
            // 
            // MainQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainTextLable);
            this.Name = "MainQuestForm";
            this.Text = "MainQuestForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTextLable;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}