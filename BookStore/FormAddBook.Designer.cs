namespace BookStore
{
    partial class FormAddBook
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
            txtName = new TextBox();
            label1 = new Label();
            txtYear = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(60, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 47);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 60);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(450, 110);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(250, 47);
            txtYear.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 60);
            label2.Name = "label2";
            label2.Size = new Size(73, 41);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(255, 315);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 47);
            txtPrice.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 265);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 1;
            label3.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 645);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 58);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(512, 645);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 58);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAddBook
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 747);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtName);
            Name = "FormAddBook";
            Text = "FormAddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtYear;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
    }
}