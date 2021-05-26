
namespace HabForms
{
    partial class MainTrackerForm
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
            this.ChooseActivities = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseActivities
            // 
            this.ChooseActivities.Location = new System.Drawing.Point(488, 25);
            this.ChooseActivities.Name = "ChooseActivities";
            this.ChooseActivities.Size = new System.Drawing.Size(138, 53);
            this.ChooseActivities.TabIndex = 0;
            this.ChooseActivities.Text = "Изменить отслеживаемые активности";
            this.ChooseActivities.UseVisualStyleBackColor = true;
            // 
            // StatsButton
            // 
            this.StatsButton.Location = new System.Drawing.Point(488, 169);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(138, 53);
            this.StatsButton.TabIndex = 1;
            this.StatsButton.Text = "Ваша статистика";
            this.StatsButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityName,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(47, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // ActivityName
            // 
            this.ActivityName.HeaderText = "Привычка";
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(242, 209);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(49, 13);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "Question";
            // 
            // MainTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.ChooseActivities);
            this.Name = "MainTrackerForm";
            this.Text = "MainTrackerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseActivities;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Label questionLabel;
    }
}