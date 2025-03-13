namespace SimpleFormsAppWithCheckedListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkedListBox = new CheckedListBox();
            listBox = new ListBox();
            label1 = new Label();
            addBtn = new Button();
            dltBtn = new Button();
            clrBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.BackColor = Color.Black;
            checkedListBox.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox.ForeColor = Color.FromArgb(192, 0, 0);
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(56, 101);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(278, 256);
            checkedListBox.TabIndex = 0;
            // 
            // listBox
            // 
            listBox.BackColor = Color.Black;
            listBox.Font = new Font("Constantia", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox.ForeColor = Color.Green;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(474, 101);
            listBox.Name = "listBox";
            listBox.Size = new Size(258, 259);
            listBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 31);
            label1.TabIndex = 2;
            label1.Text = "Simple";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.Black;
            addBtn.BackgroundImageLayout = ImageLayout.None;
            addBtn.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.FromArgb(192, 0, 0);
            addBtn.Location = new Point(56, 393);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(105, 31);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // dltBtn
            // 
            dltBtn.BackColor = Color.Black;
            dltBtn.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dltBtn.ForeColor = Color.FromArgb(192, 0, 0);
            dltBtn.Location = new Point(474, 396);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(105, 31);
            dltBtn.TabIndex = 4;
            dltBtn.Text = "Delete";
            dltBtn.UseVisualStyleBackColor = false;
            dltBtn.Click += dltBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = Color.Black;
            clrBtn.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.ForeColor = Color.FromArgb(192, 0, 0);
            clrBtn.Location = new Point(627, 396);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(105, 31);
            clrBtn.TabIndex = 5;
            clrBtn.Text = "Clear";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(56, 79);
            label2.Name = "label2";
            label2.Size = new Size(207, 19);
            label2.TabIndex = 6;
            label2.Text = "Horror Movies / Series List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Constantia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(474, 79);
            label3.Name = "label3";
            label3.Size = new Size(213, 19);
            label3.TabIndex = 7;
            label3.Text = "My Favorite Horror Movies ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(378, 9);
            label4.Name = "label4";
            label4.Size = new Size(87, 31);
            label4.TabIndex = 8;
            label4.Text = "Movie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(464, 9);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 9;
            label5.Text = "Picker";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(264, 9);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 10;
            label6.Text = "Favorite";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(549, 9);
            label7.Name = "label7";
            label7.Size = new Size(63, 31);
            label7.TabIndex = 11;
            label7.Text = "App";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 448);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clrBtn);
            Controls.Add(dltBtn);
            Controls.Add(addBtn);
            Controls.Add(label1);
            Controls.Add(listBox);
            Controls.Add(checkedListBox);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox;
        private ListBox listBox;
        private Label label1;
        private Button addBtn;
        private Button dltBtn;
        private Button clrBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
