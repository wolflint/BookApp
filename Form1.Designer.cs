namespace BookApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblBookSubject = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.inpTitle = new System.Windows.Forms.TextBox();
            this.inpAuthor = new System.Windows.Forms.TextBox();
            this.inptSubject = new System.Windows.Forms.TextBox();
            this.inpId = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(341, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Input Book Specification:";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(12, 61);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 25);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Title:";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(12, 106);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(76, 25);
            this.lblBookAuthor.TabIndex = 2;
            this.lblBookAuthor.Text = "Author:";
            this.lblBookAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookSubject
            // 
            this.lblBookSubject.AutoSize = true;
            this.lblBookSubject.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookSubject.Location = new System.Drawing.Point(12, 151);
            this.lblBookSubject.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblBookSubject.Name = "lblBookSubject";
            this.lblBookSubject.Size = new System.Drawing.Size(81, 25);
            this.lblBookSubject.TabIndex = 3;
            this.lblBookSubject.Text = "Subject:";
            this.lblBookSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(12, 196);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(82, 25);
            this.lblBookId.TabIndex = 4;
            this.lblBookId.Text = "Book ID:";
            this.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inpTitle
            // 
            this.inpTitle.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTitle.Location = new System.Drawing.Point(100, 58);
            this.inpTitle.Name = "inpTitle";
            this.inpTitle.Size = new System.Drawing.Size(688, 33);
            this.inpTitle.TabIndex = 5;
            // 
            // inpAuthor
            // 
            this.inpAuthor.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAuthor.Location = new System.Drawing.Point(100, 105);
            this.inpAuthor.Name = "inpAuthor";
            this.inpAuthor.Size = new System.Drawing.Size(688, 33);
            this.inpAuthor.TabIndex = 6;
            // 
            // inptSubject
            // 
            this.inptSubject.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inptSubject.Location = new System.Drawing.Point(100, 148);
            this.inptSubject.Name = "inptSubject";
            this.inptSubject.Size = new System.Drawing.Size(688, 33);
            this.inptSubject.TabIndex = 7;
            // 
            // inpId
            // 
            this.inpId.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpId.Location = new System.Drawing.Point(100, 189);
            this.inpId.Name = "inpId";
            this.inpId.Size = new System.Drawing.Size(688, 33);
            this.inpId.TabIndex = 8;
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(17, 277);
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(771, 161);
            this.txtTest.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Source Sans Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(652, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SavePressed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.inpId);
            this.Controls.Add(this.inptSubject);
            this.Controls.Add(this.inpAuthor);
            this.Controls.Add(this.inpTitle);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblBookSubject);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.Label lblBookSubject;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox inpTitle;
        private System.Windows.Forms.TextBox inpAuthor;
        private System.Windows.Forms.TextBox inptSubject;
        private System.Windows.Forms.TextBox inpId;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnSave;
    }
}

