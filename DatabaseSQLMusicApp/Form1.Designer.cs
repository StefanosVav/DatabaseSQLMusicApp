namespace DatabaseSQLMusicApp
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            Add = new Button();
            txt_Description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_Year = new TextBox();
            txt_ArtistName = new TextBox();
            txt_AlbumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button3 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(263, 6);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(263, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(640, 206);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(468, 5);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(561, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(909, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Add);
            groupBox1.Controls.Add(txt_Description);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_Year);
            groupBox1.Controls.Add(txt_ArtistName);
            groupBox1.Controls.Add(txt_AlbumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 177);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // Add
            // 
            Add.Location = new Point(60, 148);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 14;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(90, 114);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(100, 23);
            txt_Description.TabIndex = 13;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(90, 92);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(100, 23);
            txt_ImageURL.TabIndex = 12;
            // 
            // txt_Year
            // 
            txt_Year.Location = new Point(90, 70);
            txt_Year.Name = "txt_Year";
            txt_Year.Size = new Size(100, 23);
            txt_Year.TabIndex = 11;
            // 
            // txt_ArtistName
            // 
            txt_ArtistName.Location = new Point(90, 48);
            txt_ArtistName.Name = "txt_ArtistName";
            txt_ArtistName.Size = new Size(100, 23);
            txt_ArtistName.TabIndex = 10;
            // 
            // txt_AlbumName
            // 
            txt_AlbumName.Location = new Point(90, 26);
            txt_AlbumName.Name = "txt_AlbumName";
            txt_AlbumName.Size = new Size(100, 23);
            txt_AlbumName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 117);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 95);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 73);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 257);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(468, 284);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(640, 190);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(468, 490);
            button3.Name = "button3";
            button3.Size = new Size(119, 23);
            button3.TabIndex = 8;
            button3.Text = "Delete Selected";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 284);
            webView21.Name = "webView21";
            webView21.Size = new Size(450, 295);
            webView21.TabIndex = 9;
            webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 591);
            Controls.Add(webView21);
            Controls.Add(button3);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Description;
        private TextBox txt_ImageURL;
        private TextBox txt_Year;
        private TextBox txt_ArtistName;
        private TextBox txt_AlbumName;
        private Label label5;
        private Label label4;
        private Button Add;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button3;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}