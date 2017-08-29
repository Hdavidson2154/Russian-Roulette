namespace Russian_Roulette
{
    partial class HighScores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGScore = new System.Windows.Forms.DataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGScore)).BeginInit();
            this.SuspendLayout();
            // 
            // DGScore
            // 
            this.DGScore.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.Score1,
            this.Date1});
            this.DGScore.Location = new System.Drawing.Point(1, 1);
            this.DGScore.Name = "DGScore";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.DGScore.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGScore.Size = new System.Drawing.Size(494, 444);
            this.DGScore.TabIndex = 0;
            this.DGScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGScore_CellContentClick);
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 250;
            // 
            // Score1
            // 
            this.Score1.HeaderText = "Score";
            this.Score1.Name = "Score1";
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Date/Time";
            this.Date1.Name = "Date1";
            // 
            // BtnScores
            // 
            this.BtnScores.Location = new System.Drawing.Point(412, 413);
            this.BtnScores.Name = "BtnScores";
            this.BtnScores.Size = new System.Drawing.Size(83, 32);
            this.BtnScores.TabIndex = 1;
            this.BtnScores.Text = "Show Scores";
            this.BtnScores.UseVisualStyleBackColor = true;
            this.BtnScores.Click += new System.EventHandler(this.BtnScores_Click);
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 445);
            this.Controls.Add(this.BtnScores);
            this.Controls.Add(this.DGScore);
            this.Name = "HighScores";
            this.Text = "HighScores";
            ((System.ComponentModel.ISupportInitialize)(this.DGScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.Button BtnScores;
    }
}