
namespace mishaninprjc
{
    partial class addAchForm
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
            this.typeTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.descTB = new System.Windows.Forms.TextBox();
            this.pointTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 224);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(265, 35);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(44, 32);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(195, 20);
            this.typeTB.TabIndex = 1;
            this.typeTB.Text = "Тип";
            this.typeTB.TextChanged += new System.EventHandler(this.typeTB_TextChanged);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(44, 71);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(195, 20);
            this.nameTB.TabIndex = 1;
            this.nameTB.Text = "Название";
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // descTB
            // 
            this.descTB.Location = new System.Drawing.Point(44, 109);
            this.descTB.Name = "descTB";
            this.descTB.Size = new System.Drawing.Size(195, 20);
            this.descTB.TabIndex = 1;
            this.descTB.Text = "Описание";
            this.descTB.TextChanged += new System.EventHandler(this.descTB_TextChanged);
            // 
            // pointTB
            // 
            this.pointTB.Location = new System.Drawing.Point(44, 151);
            this.pointTB.Name = "pointTB";
            this.pointTB.Size = new System.Drawing.Size(195, 20);
            this.pointTB.TabIndex = 1;
            this.pointTB.Text = "Очки";
            this.pointTB.TextChanged += new System.EventHandler(this.pointTB_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 183);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(265, 35);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addAchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 271);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pointTB);
            this.Controls.Add(this.descTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.backButton);
            this.Name = "addAchForm";
            this.Text = "Добавить достижение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox descTB;
        private System.Windows.Forms.TextBox pointTB;
        private System.Windows.Forms.Button addButton;
    }
}