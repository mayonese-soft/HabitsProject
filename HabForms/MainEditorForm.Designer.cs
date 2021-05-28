
namespace HabForms
{
    partial class MainEditorForm
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
            this.pictureBoxQuest = new System.Windows.Forms.PictureBox();
            this.addPicture = new System.Windows.Forms.Button();
            this.edMainText = new System.Windows.Forms.TextBox();
            this.edFirstVar = new System.Windows.Forms.TextBox();
            this.edSecondVar = new System.Windows.Forms.TextBox();
            this.edThirdVar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.firstVarLink = new System.Windows.Forms.Label();
            this.secondVarLink = new System.Windows.Forms.Label();
            this.thirdVarLink = new System.Windows.Forms.Label();
            this.edExit = new System.Windows.Forms.Button();
            this.previousPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQuest
            // 
            this.pictureBoxQuest.Location = new System.Drawing.Point(147, 94);
            this.pictureBoxQuest.Name = "pictureBoxQuest";
            this.pictureBoxQuest.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxQuest.TabIndex = 0;
            this.pictureBoxQuest.TabStop = false;
            // 
            // addPicture
            // 
            this.addPicture.Location = new System.Drawing.Point(12, 109);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(114, 23);
            this.addPicture.TabIndex = 1;
            this.addPicture.Text = "Добавить картинку";
            this.addPicture.UseVisualStyleBackColor = true;
            // 
            // edMainText
            // 
            this.edMainText.Location = new System.Drawing.Point(147, 196);
            this.edMainText.Name = "edMainText";
            this.edMainText.Size = new System.Drawing.Size(100, 20);
            this.edMainText.TabIndex = 2;
            // 
            // edFirstVar
            // 
            this.edFirstVar.Location = new System.Drawing.Point(147, 232);
            this.edFirstVar.Name = "edFirstVar";
            this.edFirstVar.Size = new System.Drawing.Size(100, 20);
            this.edFirstVar.TabIndex = 3;
            // 
            // edSecondVar
            // 
            this.edSecondVar.Location = new System.Drawing.Point(147, 269);
            this.edSecondVar.Name = "edSecondVar";
            this.edSecondVar.Size = new System.Drawing.Size(100, 20);
            this.edSecondVar.TabIndex = 4;
            // 
            // edThirdVar
            // 
            this.edThirdVar.Location = new System.Drawing.Point(147, 308);
            this.edThirdVar.Name = "edThirdVar";
            this.edThirdVar.Size = new System.Drawing.Size(100, 20);
            this.edThirdVar.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить ссылку";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(451, 397);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(129, 23);
            this.nextPage.TabIndex = 8;
            this.nextPage.Text = "Следующая страница";
            this.nextPage.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(462, 196);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(118, 134);
            this.listBox1.TabIndex = 9;
            // 
            // firstVarLink
            // 
            this.firstVarLink.AutoSize = true;
            this.firstVarLink.Location = new System.Drawing.Point(278, 238);
            this.firstVarLink.Name = "firstVarLink";
            this.firstVarLink.Size = new System.Drawing.Size(13, 13);
            this.firstVarLink.TabIndex = 10;
            this.firstVarLink.Text = "0";
            // 
            // secondVarLink
            // 
            this.secondVarLink.AutoSize = true;
            this.secondVarLink.Location = new System.Drawing.Point(278, 276);
            this.secondVarLink.Name = "secondVarLink";
            this.secondVarLink.Size = new System.Drawing.Size(13, 13);
            this.secondVarLink.TabIndex = 11;
            this.secondVarLink.Text = "0";
            // 
            // thirdVarLink
            // 
            this.thirdVarLink.AutoSize = true;
            this.thirdVarLink.Location = new System.Drawing.Point(278, 315);
            this.thirdVarLink.Name = "thirdVarLink";
            this.thirdVarLink.Size = new System.Drawing.Size(13, 13);
            this.thirdVarLink.TabIndex = 12;
            this.thirdVarLink.Text = "0";
            // 
            // edExit
            // 
            this.edExit.Location = new System.Drawing.Point(713, 397);
            this.edExit.Name = "edExit";
            this.edExit.Size = new System.Drawing.Size(75, 23);
            this.edExit.TabIndex = 14;
            this.edExit.Text = "Выход";
            this.edExit.UseVisualStyleBackColor = true;
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(147, 397);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(144, 23);
            this.previousPage.TabIndex = 15;
            this.previousPage.Text = "Предыдущая страница";
            this.previousPage.UseVisualStyleBackColor = true;
            // 
            // MainEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.edExit);
            this.Controls.Add(this.thirdVarLink);
            this.Controls.Add(this.secondVarLink);
            this.Controls.Add(this.firstVarLink);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.edThirdVar);
            this.Controls.Add(this.edSecondVar);
            this.Controls.Add(this.edFirstVar);
            this.Controls.Add(this.edMainText);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.pictureBoxQuest);
            this.Name = "MainEditorForm";
            this.Text = "MainEditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQuest;
        private System.Windows.Forms.Button addPicture;
        private System.Windows.Forms.TextBox edMainText;
        private System.Windows.Forms.TextBox edFirstVar;
        private System.Windows.Forms.TextBox edSecondVar;
        private System.Windows.Forms.TextBox edThirdVar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label firstVarLink;
        private System.Windows.Forms.Label secondVarLink;
        private System.Windows.Forms.Label thirdVarLink;
        private System.Windows.Forms.Button edExit;
        private System.Windows.Forms.Button previousPage;
    }
}