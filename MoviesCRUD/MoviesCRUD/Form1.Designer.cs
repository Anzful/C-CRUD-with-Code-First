namespace MoviesCRUD
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.year = new System.Windows.Forms.TextBox();
            this.duration = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.reviewdate = new System.Windows.Forms.DateTimePicker();
            this.nationality = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.score = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.remove);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.reviewdate);
            this.panel1.Controls.Add(this.nationality);
            this.panel1.Controls.Add(this.lastname);
            this.panel1.Controls.Add(this.firstname);
            this.panel1.Controls.Add(this.comment);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Controls.Add(this.search);
            this.panel1.Location = new System.Drawing.Point(412, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 426);
            this.panel1.TabIndex = 0;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(103, 96);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 22);
            this.year.TabIndex = 30;
            this.year.TextChanged += new System.EventHandler(this.year_TextChanged);
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(103, 62);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(100, 22);
            this.duration.TabIndex = 29;
            this.duration.TextChanged += new System.EventHandler(this.duration_TextChanged);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(103, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 22);
            this.title.TabIndex = 28;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(258, 358);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 40);
            this.edit.TabIndex = 27;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(258, 302);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(86, 40);
            this.remove.TabIndex = 26;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(258, 112);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 40);
            this.add.TabIndex = 25;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // reviewdate
            // 
            this.reviewdate.Location = new System.Drawing.Point(103, 234);
            this.reviewdate.Name = "reviewdate";
            this.reviewdate.Size = new System.Drawing.Size(200, 22);
            this.reviewdate.TabIndex = 23;
            this.reviewdate.ValueChanged += new System.EventHandler(this.reviewdate_ValueChanged);
            // 
            // nationality
            // 
            this.nationality.Location = new System.Drawing.Point(103, 376);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(100, 22);
            this.nationality.TabIndex = 22;
            this.nationality.TextChanged += new System.EventHandler(this.nationality_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(103, 349);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(100, 22);
            this.lastname.TabIndex = 21;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(103, 320);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 22);
            this.firstname.TabIndex = 20;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(103, 262);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(100, 22);
            this.comment.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(20, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Director";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(20, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Review";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Movie";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(103, 147);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(100, 22);
            this.category.TabIndex = 15;
            this.category.TextChanged += new System.EventHandler(this.category_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nationality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "LastName";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "FirstName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Comment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "ReviewDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Duration";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(20, 35);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(33, 16);
            this.lable1.TabIndex = 4;
            this.lable1.Text = "Title";
            this.lable1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(258, 51);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(86, 40);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowTemplate.Height = 24;
            this.dataGridViewMovies.Size = new System.Drawing.Size(376, 426);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(103, 206);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(120, 22);
            this.score.TabIndex = 1;
            this.score.ValueChanged += new System.EventHandler(this.score_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.DateTimePicker reviewdate;
        private System.Windows.Forms.TextBox nationality;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.NumericUpDown score;
    }
}

