namespace Dictionary2
{
    partial class DictEnVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictEnVi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguồnFileTừĐiểnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starDictToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starDictViToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbDictInfo = new System.Windows.Forms.Label();
            this.lbSearchResult = new System.Windows.Forms.Label();
            this.lbListWords = new System.Windows.Forms.ListBox();
            this.lbMeaning = new System.Windows.Forms.Label();
            this.rtbMeaning = new System.Windows.Forms.RichTextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbBackground = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitHubToolStripMenuItem,
            this.danhSáchNhómToolStripMenuItem,
            this.nguồnFileTừĐiểnToolStripMenuItem});
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // danhSáchNhómToolStripMenuItem
            // 
            this.danhSáchNhómToolStripMenuItem.Name = "danhSáchNhómToolStripMenuItem";
            this.danhSáchNhómToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchNhómToolStripMenuItem.Text = "Danh sách Nhóm";
            this.danhSáchNhómToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhómToolStripMenuItem_Click);
            // 
            // nguồnFileTừĐiểnToolStripMenuItem
            // 
            this.nguồnFileTừĐiểnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starDictToolStripMenuItem,
            this.starDictViToolStripMenuItem});
            this.nguồnFileTừĐiểnToolStripMenuItem.Name = "nguồnFileTừĐiểnToolStripMenuItem";
            this.nguồnFileTừĐiểnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nguồnFileTừĐiểnToolStripMenuItem.Text = "Nguồn File Từ điển";
            // 
            // starDictToolStripMenuItem
            // 
            this.starDictToolStripMenuItem.Name = "starDictToolStripMenuItem";
            this.starDictToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.starDictToolStripMenuItem.Text = "StarDict";
            // 
            // starDictViToolStripMenuItem
            // 
            this.starDictViToolStripMenuItem.Name = "starDictViToolStripMenuItem";
            this.starDictViToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.starDictViToolStripMenuItem.Text = "StarDict Vi - Cre: dynamotn";
            this.starDictViToolStripMenuItem.Click += new System.EventHandler(this.starDictViToolStripMenuItem_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(12, 64);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(122, 15);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Nhập từ cần tìm kiếm";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(15, 82);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(160, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // lbDictInfo
            // 
            this.lbDictInfo.AutoSize = true;
            this.lbDictInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDictInfo.Location = new System.Drawing.Point(15, 28);
            this.lbDictInfo.Name = "lbDictInfo";
            this.lbDictInfo.Size = new System.Drawing.Size(129, 15);
            this.lbDictInfo.TabIndex = 3;
            this.lbDictInfo.Text = "Đồ Án Từ Điển Nhóm 4";
            // 
            // lbSearchResult
            // 
            this.lbSearchResult.AutoSize = true;
            this.lbSearchResult.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbSearchResult.Location = new System.Drawing.Point(15, 109);
            this.lbSearchResult.Name = "lbSearchResult";
            this.lbSearchResult.Size = new System.Drawing.Size(97, 15);
            this.lbSearchResult.TabIndex = 4;
            this.lbSearchResult.Text = "Kết quả tìm kiếm";
            // 
            // lbListWords
            // 
            this.lbListWords.FormattingEnabled = true;
            this.lbListWords.Location = new System.Drawing.Point(15, 127);
            this.lbListWords.Name = "lbListWords";
            this.lbListWords.Size = new System.Drawing.Size(241, 290);
            this.lbListWords.TabIndex = 5;
            this.lbListWords.Click += new System.EventHandler(this.lbListWords_Click);
            // 
            // lbMeaning
            // 
            this.lbMeaning.AutoSize = true;
            this.lbMeaning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbMeaning.Location = new System.Drawing.Point(279, 64);
            this.lbMeaning.Name = "lbMeaning";
            this.lbMeaning.Size = new System.Drawing.Size(47, 15);
            this.lbMeaning.TabIndex = 6;
            this.lbMeaning.Text = "Ý nghĩa";
            // 
            // rtbMeaning
            // 
            this.rtbMeaning.Location = new System.Drawing.Point(282, 82);
            this.rtbMeaning.Name = "rtbMeaning";
            this.rtbMeaning.Size = new System.Drawing.Size(506, 335);
            this.rtbMeaning.TabIndex = 7;
            this.rtbMeaning.Text = "";
            this.rtbMeaning.ZoomFactor = 2F;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSearch.Location = new System.Drawing.Point(181, 82);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Tìm";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbBackground
            // 
            this.lbBackground.AutoSize = true;
            this.lbBackground.Location = new System.Drawing.Point(621, 428);
            this.lbBackground.Name = "lbBackground";
            this.lbBackground.Size = new System.Drawing.Size(169, 13);
            this.lbBackground.TabIndex = 9;
            this.lbBackground.Text = "Từ điển nhóm 4 môn CTDL và GT";
            // 
            // DictEnVi
            // 
            this.AcceptButton = this.btSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBackground);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.rtbMeaning);
            this.Controls.Add(this.lbMeaning);
            this.Controls.Add(this.lbListWords);
            this.Controls.Add(this.lbSearchResult);
            this.Controls.Add(this.lbDictInfo);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DictEnVi";
            this.Text = "Từ điển Anh Việt - Đồ án cuối kỳ nhóm 4";
            this.Load += new System.EventHandler(this.DictEnVi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbDictInfo;
        private System.Windows.Forms.Label lbSearchResult;
        private System.Windows.Forms.ListBox lbListWords;
        private System.Windows.Forms.Label lbMeaning;
        private System.Windows.Forms.RichTextBox rtbMeaning;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhómToolStripMenuItem;
        private System.Windows.Forms.Label lbBackground;
        private System.Windows.Forms.ToolStripMenuItem nguồnFileTừĐiểnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starDictToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starDictViToolStripMenuItem;
    }
}

