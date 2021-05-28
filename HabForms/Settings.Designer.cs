
namespace HabForms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.closeButton = new System.Windows.Forms.Button();
            this.isAutosaveOn = new System.Windows.Forms.CheckBox();
            this.isTextWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(363, 344);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // isAutosaveOn
            // 
            this.isAutosaveOn.AutoSize = true;
            this.isAutosaveOn.BackColor = System.Drawing.Color.Transparent;
            this.isAutosaveOn.Checked = true;
            this.isAutosaveOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAutosaveOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isAutosaveOn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.isAutosaveOn.ForeColor = System.Drawing.Color.Black;
            this.isAutosaveOn.Location = new System.Drawing.Point(347, 176);
            this.isAutosaveOn.Name = "isAutosaveOn";
            this.isAutosaveOn.Size = new System.Drawing.Size(160, 17);
            this.isAutosaveOn.TabIndex = 1;
            this.isAutosaveOn.Text = "Включить автосохранения";
            this.isAutosaveOn.UseVisualStyleBackColor = false;
            // 
            // isTextWhite
            // 
            this.isTextWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isTextWhite.Location = new System.Drawing.Point(363, 373);
            this.isTextWhite.Name = "isTextWhite";
            this.isTextWhite.Size = new System.Drawing.Size(75, 37);
            this.isTextWhite.TabIndex = 2;
            this.isTextWhite.Text = "Включить фонарик";
            this.isTextWhite.UseVisualStyleBackColor = true;
            this.isTextWhite.Click += new System.EventHandler(this.isTextWhite_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isTextWhite);
            this.Controls.Add(this.isAutosaveOn);
            this.Controls.Add(this.closeButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox isAutosaveOn;
        private System.Windows.Forms.Button isTextWhite;
    }
}