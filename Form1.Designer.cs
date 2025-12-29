namespace LibraryTrackingSystem
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnWindowControl = new System.Windows.Forms.Button();
            this.btnIconState = new System.Windows.Forms.Button();
            this.btnCrossMark = new System.Windows.Forms.Button();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.lblPublicationYear = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.tbxPublicationYear = new System.Windows.Forms.TextBox();
            this.tbxPageCount = new System.Windows.Forms.TextBox();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.tbxLanguage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(15, 57);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.Size = new System.Drawing.Size(714, 765);
            this.dgwBooks.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleBar.BackColor = System.Drawing.Color.Gray;
            this.pnlTitleBar.Controls.Add(this.btnWindowControl);
            this.pnlTitleBar.Controls.Add(this.btnIconState);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1253, 35);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnWindowControl
            // 
            this.btnWindowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWindowControl.BackColor = System.Drawing.Color.Gray;
            this.btnWindowControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWindowControl.BackgroundImage")));
            this.btnWindowControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWindowControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWindowControl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWindowControl.FlatAppearance.BorderSize = 0;
            this.btnWindowControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnWindowControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWindowControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowControl.Location = new System.Drawing.Point(1183, 0);
            this.btnWindowControl.Name = "btnWindowControl";
            this.btnWindowControl.Size = new System.Drawing.Size(35, 35);
            this.btnWindowControl.TabIndex = 5;
            this.btnWindowControl.UseVisualStyleBackColor = false;
            this.btnWindowControl.Click += new System.EventHandler(this.btnWindowControl_Click);
            // 
            // btnIconState
            // 
            this.btnIconState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIconState.BackColor = System.Drawing.Color.Gray;
            this.btnIconState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIconState.BackgroundImage")));
            this.btnIconState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIconState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIconState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIconState.FlatAppearance.BorderSize = 0;
            this.btnIconState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIconState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIconState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIconState.Location = new System.Drawing.Point(1148, 0);
            this.btnIconState.Name = "btnIconState";
            this.btnIconState.Size = new System.Drawing.Size(35, 35);
            this.btnIconState.TabIndex = 4;
            this.btnIconState.UseVisualStyleBackColor = false;
            this.btnIconState.Click += new System.EventHandler(this.btnIconState_Click);
            // 
            // btnCrossMark
            // 
            this.btnCrossMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrossMark.BackColor = System.Drawing.Color.Gray;
            this.btnCrossMark.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrossMark.BackgroundImage")));
            this.btnCrossMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrossMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrossMark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrossMark.FlatAppearance.BorderSize = 0;
            this.btnCrossMark.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrossMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCrossMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrossMark.Location = new System.Drawing.Point(1218, 0);
            this.btnCrossMark.Name = "btnCrossMark";
            this.btnCrossMark.Size = new System.Drawing.Size(35, 35);
            this.btnCrossMark.TabIndex = 2;
            this.btnCrossMark.UseVisualStyleBackColor = false;
            this.btnCrossMark.Click += new System.EventHandler(this.btnCrossMark_Click);
            // 
            // pnlOperation
            // 
            this.pnlOperation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.pnlOperation.Controls.Add(this.tbxPublicationYear);
            this.pnlOperation.Controls.Add(this.tbxPageCount);
            this.pnlOperation.Controls.Add(this.tbxPublisher);
            this.pnlOperation.Controls.Add(this.tbxLanguage);
            this.pnlOperation.Controls.Add(this.lblPublicationYear);
            this.pnlOperation.Controls.Add(this.lblPageCount);
            this.pnlOperation.Controls.Add(this.lblPublisher);
            this.pnlOperation.Controls.Add(this.lblLanguage);
            this.pnlOperation.Controls.Add(this.lbl);
            this.pnlOperation.Controls.Add(this.tbxGenre);
            this.pnlOperation.Controls.Add(this.lblAuthor);
            this.pnlOperation.Controls.Add(this.tbxAuthor);
            this.pnlOperation.Controls.Add(this.lblTitle);
            this.pnlOperation.Controls.Add(this.tbxTitle);
            this.pnlOperation.Controls.Add(this.lblId);
            this.pnlOperation.Controls.Add(this.tbxId);
            this.pnlOperation.Location = new System.Drawing.Point(746, 57);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(487, 765);
            this.pnlOperation.TabIndex = 4;
            // 
            // tbxId
            // 
            this.tbxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxId.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxId.Location = new System.Drawing.Point(186, 34);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(278, 26);
            this.tbxId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.Location = new System.Drawing.Point(136, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 26);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.Location = new System.Drawing.Point(117, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 26);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            this.tbxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTitle.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTitle.Location = new System.Drawing.Point(186, 94);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(278, 26);
            this.tbxTitle.TabIndex = 2;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(95, 148);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 26);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAuthor.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAuthor.Location = new System.Drawing.Point(186, 147);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(278, 26);
            this.tbxAuthor.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(102, 205);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 26);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Genre";
            // 
            // tbxGenre
            // 
            this.tbxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGenre.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGenre.Location = new System.Drawing.Point(186, 205);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(278, 26);
            this.tbxGenre.TabIndex = 6;
            // 
            // lblPublicationYear
            // 
            this.lblPublicationYear.AutoSize = true;
            this.lblPublicationYear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublicationYear.Location = new System.Drawing.Point(17, 433);
            this.lblPublicationYear.Name = "lblPublicationYear";
            this.lblPublicationYear.Size = new System.Drawing.Size(150, 26);
            this.lblPublicationYear.TabIndex = 11;
            this.lblPublicationYear.Text = "Publication Year";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageCount.Location = new System.Drawing.Point(57, 376);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(110, 26);
            this.lblPageCount.TabIndex = 10;
            this.lblPageCount.Text = "Page Count";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublisher.Location = new System.Drawing.Point(75, 319);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(92, 26);
            this.lblPublisher.TabIndex = 9;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLanguage.Location = new System.Drawing.Point(73, 262);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(94, 26);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "Language";
            // 
            // tbxPublicationYear
            // 
            this.tbxPublicationYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPublicationYear.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPublicationYear.Location = new System.Drawing.Point(186, 433);
            this.tbxPublicationYear.Name = "tbxPublicationYear";
            this.tbxPublicationYear.Size = new System.Drawing.Size(278, 26);
            this.tbxPublicationYear.TabIndex = 15;
            // 
            // tbxPageCount
            // 
            this.tbxPageCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPageCount.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPageCount.Location = new System.Drawing.Point(186, 375);
            this.tbxPageCount.Name = "tbxPageCount";
            this.tbxPageCount.Size = new System.Drawing.Size(278, 26);
            this.tbxPageCount.TabIndex = 14;
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPublisher.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPublisher.Location = new System.Drawing.Point(186, 322);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.Size = new System.Drawing.Size(278, 26);
            this.tbxPublisher.TabIndex = 13;
            // 
            // tbxLanguage
            // 
            this.tbxLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLanguage.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxLanguage.Location = new System.Drawing.Point(186, 262);
            this.tbxLanguage.Name = "tbxLanguage";
            this.tbxLanguage.Size = new System.Drawing.Size(278, 26);
            this.tbxLanguage.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(1253, 848);
            this.Controls.Add(this.pnlOperation);
            this.Controls.Add(this.btnCrossMark);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.dgwBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Tracking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnCrossMark;
        private System.Windows.Forms.Button btnIconState;
        private System.Windows.Forms.Button btnWindowControl;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxPublicationYear;
        private System.Windows.Forms.TextBox tbxPageCount;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.TextBox tbxLanguage;
        private System.Windows.Forms.Label lblPublicationYear;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
    }
}

