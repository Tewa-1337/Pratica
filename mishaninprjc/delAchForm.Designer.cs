
namespace mishaninprjc
{
    partial class delAchForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.numberToDelTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 120);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(302, 29);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numberToDelTB
            // 
            this.numberToDelTB.Location = new System.Drawing.Point(54, 56);
            this.numberToDelTB.Name = "numberToDelTB";
            this.numberToDelTB.Size = new System.Drawing.Size(216, 20);
            this.numberToDelTB.TabIndex = 1;
            this.numberToDelTB.TextChanged += new System.EventHandler(this.numberToDelTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите номер достижения:";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(12, 85);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(302, 29);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Удалить";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // delAchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 161);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberToDelTB);
            this.Controls.Add(this.backButton);
            this.Name = "delAchForm";
            this.Text = "Удалить достижение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox numberToDelTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delButton;
    }
}