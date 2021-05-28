
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTextLable
            // 
            this.mainTextLable.AutoSize = true;
            this.mainTextLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextLable.Location = new System.Drawing.Point(133, 256);
            this.mainTextLable.Name = "mainTextLable";
            this.mainTextLable.Size = new System.Drawing.Size(51, 20);
            this.mainTextLable.TabIndex = 0;
            this.mainTextLable.Text = "label1";
            this.mainTextLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerButton1
            // 
            this.answerButton1.Location = new System.Drawing.Point(137, 333);
            this.answerButton1.Name = "answerButton1";
            this.answerButton1.Size = new System.Drawing.Size(278, 23);
            this.answerButton1.TabIndex = 1;
            this.answerButton1.Text = "button1";
            this.answerButton1.UseVisualStyleBackColor = true;
            this.answerButton1.Click += new System.EventHandler(this.answerButton1_Click);
            // 
            // answerButton2
            // 
            this.answerButton2.Location = new System.Drawing.Point(137, 362);
            this.answerButton2.Name = "answerButton2";
            this.answerButton2.Size = new System.Drawing.Size(278, 23);
            this.answerButton2.TabIndex = 2;
            this.answerButton2.Text = "button2";
            this.answerButton2.UseVisualStyleBackColor = true;
            this.answerButton2.Click += new System.EventHandler(this.answerButton2_Click);
            // 
            // answerButton3
            // 
            this.answerButton3.Location = new System.Drawing.Point(137, 391);
            this.answerButton3.Name = "answerButton3";
            this.answerButton3.Size = new System.Drawing.Size(278, 23);
            this.answerButton3.TabIndex = 3;
            this.answerButton3.Text = "button3";
            this.answerButton3.UseVisualStyleBackColor = true;
            this.answerButton3.Click += new System.EventHandler(this.answerButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(13, 333);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(13, 362);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 6;
            this.newGameButton.Text = "Новая игра";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 391);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 304);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answerButton3);
            this.Controls.Add(this.answerButton2);
            this.Controls.Add(this.answerButton1);
            this.Controls.Add(this.mainTextLable);
            this.Name = "MainQuestForm";
            this.Text = "MainQuestForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTextLable;
        private System.Windows.Forms.Button answerButton1;
        private System.Windows.Forms.Button answerButton2;
        private System.Windows.Forms.Button answerButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button saveButton;
    }
}