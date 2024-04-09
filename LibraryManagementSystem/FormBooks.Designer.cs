namespace LibraryManagementSystem
{
    partial class FormBooks
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
            groupBox1 = new GroupBox();
            buttonDelete = new Button();
            buttonShowAll = new Button();
            buttonClear = new Button();
            buttonSearch = new Button();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            labelID = new Label();
            textBoxGenreCode = new TextBox();
            textBoxISBN = new TextBox();
            textBoxWriterSur = new TextBox();
            textBoxWriterName = new TextBox();
            textBoxBookName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBoxCustomer = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            labelDelayFee = new Label();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSalmon;
            groupBox1.Controls.Add(buttonDelete);
            groupBox1.Controls.Add(buttonShowAll);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(buttonUpdate);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(textBoxGenreCode);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxWriterSur);
            groupBox1.Controls.Add(textBoxWriterName);
            groupBox1.Controls.Add(textBoxBookName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 436);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Updating and Adding";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(570, 333);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(105, 53);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(459, 333);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(105, 53);
            buttonShowAll.TabIndex = 16;
            buttonShowAll.Text = "Show All Books";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(348, 333);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(105, 53);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(237, 333);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(105, 53);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(126, 333);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 53);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add Book";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(15, 333);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(105, 53);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Update Book";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Book Antiqua", 10.8F);
            labelID.Location = new Point(191, 35);
            labelID.Name = "labelID";
            labelID.Size = new Size(16, 22);
            labelID.TabIndex = 11;
            labelID.Text = "-";
            // 
            // textBoxGenreCode
            // 
            textBoxGenreCode.Location = new Point(191, 241);
            textBoxGenreCode.Name = "textBoxGenreCode";
            textBoxGenreCode.Size = new Size(344, 27);
            textBoxGenreCode.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(191, 198);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(344, 27);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxWriterSur
            // 
            textBoxWriterSur.Location = new Point(191, 161);
            textBoxWriterSur.Name = "textBoxWriterSur";
            textBoxWriterSur.Size = new Size(344, 27);
            textBoxWriterSur.TabIndex = 8;
            // 
            // textBoxWriterName
            // 
            textBoxWriterName.Location = new Point(191, 119);
            textBoxWriterName.Name = "textBoxWriterName";
            textBoxWriterName.Size = new Size(344, 27);
            textBoxWriterName.TabIndex = 7;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(191, 77);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(344, 27);
            textBoxBookName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Book Antiqua", 10.8F);
            label6.Location = new Point(6, 241);
            label6.Name = "label6";
            label6.Size = new Size(158, 22);
            label6.TabIndex = 5;
            label6.Text = "Book Genre Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 10.8F);
            label5.Location = new Point(6, 198);
            label5.Name = "label5";
            label5.Size = new Size(56, 22);
            label5.TabIndex = 4;
            label5.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 10.8F);
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(143, 22);
            label4.TabIndex = 3;
            label4.Text = "Writer Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 10.8F);
            label3.Location = new Point(6, 119);
            label3.Name = "label3";
            label3.Size = new Size(121, 22);
            label3.TabIndex = 2;
            label3.Text = "Writer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 10.8F);
            label2.Location = new Point(6, 77);
            label2.Name = "label2";
            label2.Size = new Size(110, 22);
            label2.TabIndex = 1;
            label2.Text = "Book Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 10.8F);
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 0;
            label1.Text = "Book ID:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Salmon;
            groupBox2.Controls.Add(buttonSave);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBoxCustomer);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(703, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 210);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Book Renting";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(158, 142);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(158, 46);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(108, 35);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(266, 27);
            textBoxCustomer.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 10.8F);
            label8.Location = new Point(7, 101);
            label8.Name = "label8";
            label8.Size = new Size(53, 22);
            label8.TabIndex = 2;
            label8.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Book Antiqua", 10.8F);
            label7.Location = new Point(7, 35);
            label7.Name = "label7";
            label7.Size = new Size(95, 22);
            label7.TabIndex = 1;
            label7.Text = "Customer:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Coral;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(labelDelayFee);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(703, 228);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(426, 220);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Book Returning";
            // 
            // button2
            // 
            button2.Location = new Point(233, 117);
            button2.Name = "button2";
            button2.Size = new Size(131, 53);
            button2.TabIndex = 15;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(96, 117);
            button1.Name = "button1";
            button1.Size = new Size(131, 53);
            button1.TabIndex = 14;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelDelayFee
            // 
            labelDelayFee.AutoSize = true;
            labelDelayFee.Font = new Font("Book Antiqua", 10.8F);
            labelDelayFee.Location = new Point(202, 53);
            labelDelayFee.Name = "labelDelayFee";
            labelDelayFee.Size = new Size(19, 22);
            labelDelayFee.TabIndex = 2;
            labelDelayFee.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Book Antiqua", 10.8F);
            label10.Location = new Point(12, 53);
            label10.Name = "label10";
            label10.Size = new Size(175, 22);
            label10.TabIndex = 1;
            label10.Text = "Calculate Delay Fee:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 454);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1117, 242);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Books List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1111, 216);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1141, 708);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormBooks";
            Text = "FormBooks";
            FormClosed += FormBooks_FormClosed;
            Load += FormBooks_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Label labelID;
        private TextBox textBoxGenreCode;
        private TextBox textBoxISBN;
        private TextBox textBoxWriterSur;
        private TextBox textBoxWriterName;
        private TextBox textBoxBookName;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private Button buttonSave;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxCustomer;
        private Label label8;
        private Label label7;
        private Button button2;
        private Button button1;
        private Label labelDelayFee;
        private Label label10;
        private Button buttonShowAll;
        private Button buttonClear;
        private Button buttonSearch;
        private Button buttonDelete;
    }
}