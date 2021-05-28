
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
            this.pictureBoxEditor = new System.Windows.Forms.PictureBox();
            this.addPicture = new System.Windows.Forms.Button();
            this.firstLinkList = new System.Windows.Forms.ComboBox();
            this.mainTextED = new System.Windows.Forms.TextBox();
            this.edFirstVar = new System.Windows.Forms.TextBox();
            this.edSecondVar = new System.Windows.Forms.TextBox();
            this.edThirdVar = new System.Windows.Forms.TextBox();
            this.secondLinkList = new System.Windows.Forms.ComboBox();
            this.thirdLinkList = new System.Windows.Forms.ComboBox();
            this.exitEditor = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.previousPage = new System.Windows.Forms.Button();
            this.deletePage = new System.Windows.Forms.Button();
            this.pageNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEditor
            // 
            this.pictureBoxEditor.Location = new System.Drawing.Point(353, 64);
            this.pictureBoxEditor.Name = "pictureBoxEditor";
            this.pictureBoxEditor.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEditor.TabIndex = 0;
            this.pictureBoxEditor.TabStop = false;
            // 
            // addPicture
            // 
            this.addPicture.Location = new System.Drawing.Point(366, 137);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(75, 23);
            this.addPicture.TabIndex = 1;
            this.addPicture.Text = "addPicture";
            this.addPicture.UseVisualStyleBackColor = true;
            this.addPicture.Click += new System.EventHandler(this.addPicture_Click);
            // 
            // firstLinkList
            // 
            this.firstLinkList.FormattingEnabled = true;
            this.firstLinkList.Location = new System.Drawing.Point(409, 245);
            this.firstLinkList.Name = "firstLinkList";
            this.firstLinkList.Size = new System.Drawing.Size(121, 21);
            this.firstLinkList.TabIndex = 2;
            // 
            // mainTextED
            // 
            this.mainTextED.Location = new System.Drawing.Point(283, 201);
            this.mainTextED.Name = "mainTextED";
            this.mainTextED.Size = new System.Drawing.Size(247, 20);
            this.mainTextED.TabIndex = 3;
            this.mainTextED.TextChanged += new System.EventHandler(this.mainTextED_TextChanged);
            // 
            // edFirstVar
            // 
            this.edFirstVar.Location = new System.Drawing.Point(283, 246);
            this.edFirstVar.Name = "edFirstVar";
            this.edFirstVar.Size = new System.Drawing.Size(100, 20);
            this.edFirstVar.TabIndex = 4;
            // 
            // edSecondVar
            // 
            this.edSecondVar.Location = new System.Drawing.Point(283, 287);
            this.edSecondVar.Name = "edSecondVar";
            this.edSecondVar.Size = new System.Drawing.Size(100, 20);
            this.edSecondVar.TabIndex = 5;
            // 
            // edThirdVar
            // 
            this.edThirdVar.Location = new System.Drawing.Point(283, 332);
            this.edThirdVar.Name = "edThirdVar";
            this.edThirdVar.Size = new System.Drawing.Size(100, 20);
            this.edThirdVar.TabIndex = 6;
            // 
            // secondLinkList
            // 
            this.secondLinkList.FormattingEnabled = true;
            this.secondLinkList.Location = new System.Drawing.Point(409, 286);
            this.secondLinkList.Name = "secondLinkList";
            this.secondLinkList.Size = new System.Drawing.Size(121, 21);
            this.secondLinkList.TabIndex = 7;
            // 
            // thirdLinkList
            // 
            this.thirdLinkList.FormattingEnabled = true;
            this.thirdLinkList.Location = new System.Drawing.Point(409, 331);
            this.thirdLinkList.Name = "thirdLinkList";
            this.thirdLinkList.Size = new System.Drawing.Size(121, 21);
            this.thirdLinkList.TabIndex = 8;
            // 
            // exitEditor
            // 
            this.exitEditor.Location = new System.Drawing.Point(676, 406);
            this.exitEditor.Name = "exitEditor";
            this.exitEditor.Size = new System.Drawing.Size(75, 23);
            this.exitEditor.TabIndex = 9;
            this.exitEditor.Text = "exitEditor";
            this.exitEditor.UseVisualStyleBackColor = true;
            this.exitEditor.Click += new System.EventHandler(this.exitEditor_Click);
            // 
            // nextPage
            // 
            this.nextPage.Location = new System.Drawing.Point(455, 406);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(75, 23);
            this.nextPage.TabIndex = 10;
            this.nextPage.Text = "nextPage";
            this.nextPage.UseVisualStyleBackColor = true;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // previousPage
            // 
            this.previousPage.Location = new System.Drawing.Point(283, 406);
            this.previousPage.Name = "previousPage";
            this.previousPage.Size = new System.Drawing.Size(133, 23);
            this.previousPage.TabIndex = 11;
            this.previousPage.Text = "Предыдущая страница";
            this.previousPage.UseVisualStyleBackColor = true;
            this.previousPage.Click += new System.EventHandler(this.previousPage_Click);
            // 
            // deletePage
            // 
            this.deletePage.Location = new System.Drawing.Point(28, 406);
            this.deletePage.Name = "deletePage";
            this.deletePage.Size = new System.Drawing.Size(108, 23);
            this.deletePage.TabIndex = 12;
            this.deletePage.Text = "Удалить страницу";
            this.deletePage.UseVisualStyleBackColor = true;
            this.deletePage.Click += new System.EventHandler(this.deletePage_Click);
            // 
            // pageNumber
            // 
            this.pageNumber.AutoSize = true;
            this.pageNumber.Location = new System.Drawing.Point(25, 24);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(35, 13);
            this.pageNumber.TabIndex = 13;
            this.pageNumber.Text = "label1";
            // 
            // MainEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pageNumber);
            this.Controls.Add(this.deletePage);
            this.Controls.Add(this.previousPage);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.exitEditor);
            this.Controls.Add(this.thirdLinkList);
            this.Controls.Add(this.secondLinkList);
            this.Controls.Add(this.edThirdVar);
            this.Controls.Add(this.edSecondVar);
            this.Controls.Add(this.edFirstVar);
            this.Controls.Add(this.mainTextED);
            this.Controls.Add(this.firstLinkList);
            this.Controls.Add(this.addPicture);
            this.Controls.Add(this.pictureBoxEditor);
            this.Name = "MainEditorForm";
            this.Text = "Редактор квестов";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEditor;
        private System.Windows.Forms.Button addPicture;
        private System.Windows.Forms.ComboBox firstLinkList;
        private System.Windows.Forms.TextBox mainTextED;
        private System.Windows.Forms.TextBox edFirstVar;
        private System.Windows.Forms.TextBox edSecondVar;
        private System.Windows.Forms.TextBox edThirdVar;
        private System.Windows.Forms.ComboBox secondLinkList;
        private System.Windows.Forms.ComboBox thirdLinkList;
        private System.Windows.Forms.Button exitEditor;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button previousPage;
        private System.Windows.Forms.Button deletePage;
        private System.Windows.Forms.Label pageNumber;
    }
}