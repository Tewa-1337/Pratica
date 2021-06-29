
namespace mishaninprjc
{
    partial class mainform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeofachievement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofachievement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionofachievement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointforachievement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofachievenment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addachButton = new System.Windows.Forms.Button();
            this.delachButton = new System.Windows.Forms.Button();
            this.statButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeofachievement,
            this.nameofachievement,
            this.descriptionofachievement,
            this.pointforachievement,
            this.numberofachievenment});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // typeofachievement
            // 
            this.typeofachievement.HeaderText = "Тип достижения";
            this.typeofachievement.Name = "typeofachievement";
            // 
            // nameofachievement
            // 
            this.nameofachievement.HeaderText = "Название";
            this.nameofachievement.Name = "nameofachievement";
            this.nameofachievement.Width = 169;
            // 
            // descriptionofachievement
            // 
            this.descriptionofachievement.HeaderText = "Описание";
            this.descriptionofachievement.Name = "descriptionofachievement";
            this.descriptionofachievement.Width = 222;
            // 
            // pointforachievement
            // 
            this.pointforachievement.HeaderText = "Очки";
            this.pointforachievement.Name = "pointforachievement";
            this.pointforachievement.Width = 50;
            // 
            // numberofachievenment
            // 
            this.numberofachievenment.HeaderText = "Номер";
            this.numberofachievenment.Name = "numberofachievenment";
            this.numberofachievenment.Width = 75;
            // 
            // addachButton
            // 
            this.addachButton.Location = new System.Drawing.Point(488, 192);
            this.addachButton.Name = "addachButton";
            this.addachButton.Size = new System.Drawing.Size(188, 33);
            this.addachButton.TabIndex = 1;
            this.addachButton.Text = "Добавить достижение";
            this.addachButton.UseVisualStyleBackColor = true;
            this.addachButton.Click += new System.EventHandler(this.addachButton_Click);
            // 
            // delachButton
            // 
            this.delachButton.Location = new System.Drawing.Point(296, 192);
            this.delachButton.Name = "delachButton";
            this.delachButton.Size = new System.Drawing.Size(186, 33);
            this.delachButton.TabIndex = 1;
            this.delachButton.Text = "Удалить достижение";
            this.delachButton.UseVisualStyleBackColor = true;
            this.delachButton.Click += new System.EventHandler(this.delachButton_Click);
            // 
            // statButton
            // 
            this.statButton.Location = new System.Drawing.Point(139, 191);
            this.statButton.Name = "statButton";
            this.statButton.Size = new System.Drawing.Size(151, 34);
            this.statButton.TabIndex = 2;
            this.statButton.Text = "Статистика";
            this.statButton.UseVisualStyleBackColor = true;
            this.statButton.Click += new System.EventHandler(this.statButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 192);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(121, 32);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 236);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.statButton);
            this.Controls.Add(this.delachButton);
            this.Controls.Add(this.addachButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "mainform";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeofachievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofachievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionofachievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointforachievement;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofachievenment;
        private System.Windows.Forms.Button addachButton;
        private System.Windows.Forms.Button delachButton;
        private System.Windows.Forms.Button statButton;
        private System.Windows.Forms.Button backButton;
    }
}