
namespace mishaninprjc
{
    partial class statForm
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
            this.pointsumLabel = new System.Windows.Forms.Label();
            this.achsumLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pointsumLabel
            // 
            this.pointsumLabel.AutoSize = true;
            this.pointsumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointsumLabel.Location = new System.Drawing.Point(61, 19);
            this.pointsumLabel.Name = "pointsumLabel";
            this.pointsumLabel.Size = new System.Drawing.Size(239, 20);
            this.pointsumLabel.TabIndex = 0;
            this.pointsumLabel.Text = "Суммарное количество очков:";
            this.pointsumLabel.Click += new System.EventHandler(this.pointsumLabel_Click);
            // 
            // achsumLabel
            // 
            this.achsumLabel.AutoSize = true;
            this.achsumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.achsumLabel.Location = new System.Drawing.Point(12, 66);
            this.achsumLabel.Name = "achsumLabel";
            this.achsumLabel.Size = new System.Drawing.Size(288, 20);
            this.achsumLabel.TabIndex = 0;
            this.achsumLabel.Text = "Суммарное количество достижений:";
            this.achsumLabel.Click += new System.EventHandler(this.achsumLabel_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 148);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(354, 37);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // statForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 197);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.achsumLabel);
            this.Controls.Add(this.pointsumLabel);
            this.Name = "statForm";
            this.Text = "Статистика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsumLabel;
        private System.Windows.Forms.Label achsumLabel;
        private System.Windows.Forms.Button backButton;
    }
}