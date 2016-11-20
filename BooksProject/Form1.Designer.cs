namespace BooksProject
{
    public partial class Books
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
            this.addButton = new System.Windows.Forms.Button();
            this.authorBox = new System.Windows.Forms.TextBox();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.publishDateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 266);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(104, 36);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton);
            // 
            // authorBox
            // 
            this.authorBox.Location = new System.Drawing.Point(312, 12);
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(161, 22);
            this.authorBox.TabIndex = 2;
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Location = new System.Drawing.Point(12, 311);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.Size = new System.Drawing.Size(544, 203);
            this.bookDataGridView.TabIndex = 3;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(312, 41);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(161, 22);
            this.titleBox.TabIndex = 4;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(312, 70);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(161, 22);
            this.genreBox.TabIndex = 5;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(312, 98);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(161, 22);
            this.priceBox.TabIndex = 6;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(123, 38);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load XML";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton);
            // 
            // publishDateBox
            // 
            this.publishDateBox.Location = new System.Drawing.Point(312, 127);
            this.publishDateBox.Name = "publishDateBox";
            this.publishDateBox.Size = new System.Drawing.Size(161, 22);
            this.publishDateBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Publish date:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 62);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 38);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save XML";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(380, 266);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 36);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(228, 266);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(98, 36);
            this.editButton.TabIndex = 13;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(312, 166);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(161, 22);
            this.descriptionBox.TabIndex = 14;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(312, 204);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(161, 22);
            this.idBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Id:";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 526);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishDateBox);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.bookDataGridView);
            this.Controls.Add(this.authorBox);
            this.Controls.Add(this.addButton);
            this.Name = "Books";
            this.Text = "Books";
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox authorBox;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox publishDateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

