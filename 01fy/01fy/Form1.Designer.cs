namespace _01fy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvSpcz = new System.Windows.Forms.DataGridView();
            this.dgvXZLCZ = new System.Windows.Forms.DataGridView();
            this.colSaleUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSaleSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleSource = new System.Windows.Forms.BindingSource(this.components);
            this.pe_Sale = new _01fy.UcPagerEx();
            this.colSpczUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpczTitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSpczSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpczTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpczSource = new System.Windows.Forms.BindingSource(this.components);
            this.pe_Spcz = new _01fy.UcPagerEx();
            this.colXZLCZUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXZLCZTitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colXZLCZSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXZLCZPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXZLCZTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XZLCZSource = new System.Windows.Forms.BindingSource(this.components);
            this.pe_XZLCZ = new _01fy.UcPagerEx();
            this.tm_Sale = new System.Windows.Forms.Timer(this.components);
            this.tm_Spcz = new System.Windows.Forms.Timer(this.components);
            this.tm_XZLCZ = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpcz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXZLCZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpczSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XZLCZSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AutoGenerateColumns = false;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSaleUrl,
            this.colSaleTitle,
            this.colSaleSize,
            this.colSalePrice,
            this.colSaleTime});
            this.dgvSale.DataSource = this.SaleSource;
            this.dgvSale.Location = new System.Drawing.Point(54, 16);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowTemplate.Height = 23;
            this.dgvSale.Size = new System.Drawing.Size(452, 260);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 420);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSale);
            this.tabPage1.Controls.Add(this.pe_Sale);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSpcz);
            this.tabPage2.Controls.Add(this.pe_Spcz);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvXZLCZ);
            this.tabPage3.Controls.Add(this.pe_XZLCZ);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(696, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvSpcz
            // 
            this.dgvSpcz.AllowUserToAddRows = false;
            this.dgvSpcz.AllowUserToDeleteRows = false;
            this.dgvSpcz.AutoGenerateColumns = false;
            this.dgvSpcz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpcz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpczUrl,
            this.colSpczTitle,
            this.colSpczSize,
            this.colPrice,
            this.colSpczTime});
            this.dgvSpcz.DataSource = this.SpczSource;
            this.dgvSpcz.Location = new System.Drawing.Point(122, 45);
            this.dgvSpcz.Name = "dgvSpcz";
            this.dgvSpcz.ReadOnly = true;
            this.dgvSpcz.RowTemplate.Height = 23;
            this.dgvSpcz.Size = new System.Drawing.Size(452, 260);
            this.dgvSpcz.TabIndex = 2;
            this.dgvSpcz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpcz_CellContentClick);
            // 
            // dgvXZLCZ
            // 
            this.dgvXZLCZ.AllowUserToAddRows = false;
            this.dgvXZLCZ.AllowUserToDeleteRows = false;
            this.dgvXZLCZ.AutoGenerateColumns = false;
            this.dgvXZLCZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXZLCZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colXZLCZUrl,
            this.colXZLCZTitle,
            this.colXZLCZSize,
            this.colXZLCZPrice,
            this.colXZLCZTime});
            this.dgvXZLCZ.DataSource = this.XZLCZSource;
            this.dgvXZLCZ.Location = new System.Drawing.Point(122, 45);
            this.dgvXZLCZ.Name = "dgvXZLCZ";
            this.dgvXZLCZ.ReadOnly = true;
            this.dgvXZLCZ.RowTemplate.Height = 23;
            this.dgvXZLCZ.Size = new System.Drawing.Size(452, 260);
            this.dgvXZLCZ.TabIndex = 2;
            this.dgvXZLCZ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXZLCZ_CellContentClick);
            // 
            // colSaleUrl
            // 
            this.colSaleUrl.DataPropertyName = "URL";
            this.colSaleUrl.HeaderText = "URL";
            this.colSaleUrl.Name = "colSaleUrl";
            this.colSaleUrl.ReadOnly = true;
            this.colSaleUrl.Visible = false;
            // 
            // colSaleTitle
            // 
            this.colSaleTitle.DataPropertyName = "Title";
            this.colSaleTitle.HeaderText = "Title";
            this.colSaleTitle.Name = "colSaleTitle";
            this.colSaleTitle.ReadOnly = true;
            this.colSaleTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSaleTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSaleSize
            // 
            this.colSaleSize.DataPropertyName = "Size";
            this.colSaleSize.HeaderText = "Size";
            this.colSaleSize.Name = "colSaleSize";
            this.colSaleSize.ReadOnly = true;
            // 
            // colSalePrice
            // 
            this.colSalePrice.DataPropertyName = "Price";
            this.colSalePrice.HeaderText = "Price";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            // 
            // colSaleTime
            // 
            this.colSaleTime.DataPropertyName = "Time";
            this.colSaleTime.HeaderText = "Time";
            this.colSaleTime.Name = "colSaleTime";
            this.colSaleTime.ReadOnly = true;
            // 
            // SaleSource
            // 
            this.SaleSource.DataSource = typeof(_01fy.FYData);
            // 
            // pe_Sale
            // 
            this.pe_Sale.Location = new System.Drawing.Point(64, 282);
            this.pe_Sale.Name = "pe_Sale";
            this.pe_Sale.PageIndex = 1;
            this.pe_Sale.PageSize = 15;
            this.pe_Sale.PreviousPage = 0;
            this.pe_Sale.RecordCount = 0;
            this.pe_Sale.Size = new System.Drawing.Size(417, 38);
            this.pe_Sale.TabIndex = 1;
            // 
            // colSpczUrl
            // 
            this.colSpczUrl.DataPropertyName = "URL";
            this.colSpczUrl.HeaderText = "URL";
            this.colSpczUrl.Name = "colSpczUrl";
            this.colSpczUrl.ReadOnly = true;
            this.colSpczUrl.Visible = false;
            // 
            // colSpczTitle
            // 
            this.colSpczTitle.DataPropertyName = "Title";
            this.colSpczTitle.HeaderText = "Title";
            this.colSpczTitle.Name = "colSpczTitle";
            this.colSpczTitle.ReadOnly = true;
            this.colSpczTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSpczTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSpczSize
            // 
            this.colSpczSize.DataPropertyName = "Size";
            this.colSpczSize.HeaderText = "Size";
            this.colSpczSize.Name = "colSpczSize";
            this.colSpczSize.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colSpczTime
            // 
            this.colSpczTime.DataPropertyName = "Time";
            this.colSpczTime.HeaderText = "Time";
            this.colSpczTime.Name = "colSpczTime";
            this.colSpczTime.ReadOnly = true;
            // 
            // SpczSource
            // 
            this.SpczSource.DataSource = typeof(_01fy.FYData);
            // 
            // pe_Spcz
            // 
            this.pe_Spcz.Location = new System.Drawing.Point(132, 311);
            this.pe_Spcz.Name = "pe_Spcz";
            this.pe_Spcz.PageIndex = 1;
            this.pe_Spcz.PageSize = 15;
            this.pe_Spcz.PreviousPage = 0;
            this.pe_Spcz.RecordCount = 0;
            this.pe_Spcz.Size = new System.Drawing.Size(417, 38);
            this.pe_Spcz.TabIndex = 3;
            // 
            // colXZLCZUrl
            // 
            this.colXZLCZUrl.DataPropertyName = "URL";
            this.colXZLCZUrl.HeaderText = "URL";
            this.colXZLCZUrl.Name = "colXZLCZUrl";
            this.colXZLCZUrl.ReadOnly = true;
            this.colXZLCZUrl.Visible = false;
            // 
            // colXZLCZTitle
            // 
            this.colXZLCZTitle.DataPropertyName = "Title";
            this.colXZLCZTitle.HeaderText = "Title";
            this.colXZLCZTitle.Name = "colXZLCZTitle";
            this.colXZLCZTitle.ReadOnly = true;
            this.colXZLCZTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXZLCZTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colXZLCZSize
            // 
            this.colXZLCZSize.DataPropertyName = "Size";
            this.colXZLCZSize.HeaderText = "Size";
            this.colXZLCZSize.Name = "colXZLCZSize";
            this.colXZLCZSize.ReadOnly = true;
            // 
            // colXZLCZPrice
            // 
            this.colXZLCZPrice.DataPropertyName = "Price";
            this.colXZLCZPrice.HeaderText = "Price";
            this.colXZLCZPrice.Name = "colXZLCZPrice";
            this.colXZLCZPrice.ReadOnly = true;
            // 
            // colXZLCZTime
            // 
            this.colXZLCZTime.DataPropertyName = "Time";
            this.colXZLCZTime.HeaderText = "Time";
            this.colXZLCZTime.Name = "colXZLCZTime";
            this.colXZLCZTime.ReadOnly = true;
            // 
            // XZLCZSource
            // 
            this.XZLCZSource.DataSource = typeof(_01fy.FYData);
            // 
            // pe_XZLCZ
            // 
            this.pe_XZLCZ.Location = new System.Drawing.Point(132, 311);
            this.pe_XZLCZ.Name = "pe_XZLCZ";
            this.pe_XZLCZ.PageIndex = 1;
            this.pe_XZLCZ.PageSize = 15;
            this.pe_XZLCZ.PreviousPage = 0;
            this.pe_XZLCZ.RecordCount = 0;
            this.pe_XZLCZ.Size = new System.Drawing.Size(417, 38);
            this.pe_XZLCZ.TabIndex = 3;
            // 
            // tm_Sale
            // 
            this.tm_Sale.Interval = 700;
            this.tm_Sale.Tick += new System.EventHandler(this.tm_Sale_Tick);
            // 
            // tm_Spcz
            // 
            this.tm_Spcz.Interval = 700;
            this.tm_Spcz.Tick += new System.EventHandler(this.tm_Spcz_Tick);
            // 
            // tm_XZLCZ
            // 
            this.tm_XZLCZ.Interval = 700;
            this.tm_XZLCZ.Tick += new System.EventHandler(this.tm_XZLCZ_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpcz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXZLCZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpczSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XZLCZSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.BindingSource SaleSource;
        private UcPagerEx pe_Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleUrl;
        private System.Windows.Forms.DataGridViewLinkColumn colSaleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSpcz;
        private UcPagerEx pe_Spcz;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvXZLCZ;
        private UcPagerEx pe_XZLCZ;
        private System.Windows.Forms.BindingSource SpczSource;
        private System.Windows.Forms.BindingSource XZLCZSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZUrl;
        private System.Windows.Forms.DataGridViewLinkColumn colXZLCZTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpczUrl;
        private System.Windows.Forms.DataGridViewLinkColumn colSpczTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpczSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpczTime;
        private System.Windows.Forms.Timer tm_Sale;
        private System.Windows.Forms.Timer tm_Spcz;
        private System.Windows.Forms.Timer tm_XZLCZ;
    }
}

