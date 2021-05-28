
namespace HabForms
{
    partial class EditorEntry
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
            this.questLoadED = new System.Windows.Forms.Button();
            this.questList = new System.Windows.Forms.ListBox();
            this.newQuestED = new System.Windows.Forms.Button();
            this.goBackED = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questLoadED
            // 
            this.questLoadED.Location = new System.Drawing.Point(113, 168);
            this.questLoadED.Name = "questLoadED";
            this.questLoadED.Size = new System.Drawing.Size(102, 23);
            this.questLoadED.TabIndex = 0;
            this.questLoadED.Text = "Загрузить";
            this.questLoadED.UseVisualStyleBackColor = true;
            // 
            // questList
            // 
            this.questList.FormattingEnabled = true;
            this.questList.Location = new System.Drawing.Point(95, 44);
            this.questList.Name = "questList";
            this.questList.Size = new System.Drawing.Size(120, 95);
            this.questList.TabIndex = 2;
            // 
            // newQuestED
            // 
            this.newQuestED.Location = new System.Drawing.Point(113, 230);
            this.newQuestED.Name = "newQuestED";
            this.newQuestED.Size = new System.Drawing.Size(102, 23);
            this.newQuestED.TabIndex = 3;
            this.newQuestED.Text = "Новый квест";
            this.newQuestED.UseVisualStyleBackColor = true;
            // 
            // goBackED
            // 
            this.goBackED.Location = new System.Drawing.Point(113, 395);
            this.goBackED.Name = "goBackED";
            this.goBackED.Size = new System.Drawing.Size(75, 23);
            this.goBackED.TabIndex = 4;
            this.goBackED.Text = "Назад";
            this.goBackED.UseVisualStyleBackColor = true;
            this.goBackED.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditorEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.goBackED);
            this.Controls.Add(this.newQuestED);
            this.Controls.Add(this.questList);
            this.Controls.Add(this.questLoadED);
            this.Name = "EditorEntry";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.EditorEntry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button questLoadED;
        private System.Windows.Forms.ListBox questList;
        private System.Windows.Forms.Button newQuestED;
        private System.Windows.Forms.Button goBackED;
    }
}