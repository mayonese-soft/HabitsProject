
namespace HabForms
{
    partial class EdtiorQuestCreation
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
            this.textBoxQuestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.questCreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestName
            // 
            this.textBoxQuestName.Location = new System.Drawing.Point(28, 50);
            this.textBoxQuestName.Name = "textBoxQuestName";
            this.textBoxQuestName.Size = new System.Drawing.Size(166, 20);
            this.textBoxQuestName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите название квеста";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(28, 86);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Закрыть";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // questCreateButton
            // 
            this.questCreateButton.Location = new System.Drawing.Point(119, 86);
            this.questCreateButton.Name = "questCreateButton";
            this.questCreateButton.Size = new System.Drawing.Size(75, 23);
            this.questCreateButton.TabIndex = 3;
            this.questCreateButton.Text = "Создать";
            this.questCreateButton.UseVisualStyleBackColor = true;
            this.questCreateButton.Click += new System.EventHandler(this.questCreateButton_Click);
            // 
            // EdtiorQuestCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 124);
            this.Controls.Add(this.questCreateButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuestName);
            this.Name = "EdtiorQuestCreation";
            this.Text = "EdtiorQuestCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button questCreateButton;
    }
}