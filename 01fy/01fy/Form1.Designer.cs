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
            this.colSaleUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSaleSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSpcz = new System.Windows.Forms.DataGridView();
            this.colSpczTitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSpczSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpczPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpczTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpczSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvXZLCZ = new System.Windows.Forms.DataGridView();
            this.colXZLCZTitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colXZLCZSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXZLCZPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXZLCZTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XZLCZSource = new System.Windows.Forms.BindingSource(this.components);
            this.tm_Sale = new System.Windows.Forms.Timer(this.components);
            this.tm_Spcz = new System.Windows.Forms.Timer(this.components);
            this.tm_XZLCZ = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpcz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpczSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXZLCZ)).BeginInit();
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
            this.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSale.Location = new System.Drawing.Point(3, 3);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowTemplate.Height = 23;
            this.dgvSale.Size = new System.Drawing.Size(755, 685);
            this.dgvSale.TabIndex = 0;
            this.dgvSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellContentClick);
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
            this.colSaleTitle.HeaderText = "标题";
            this.colSaleTitle.Name = "colSaleTitle";
            this.colSaleTitle.ReadOnly = true;
            this.colSaleTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSaleTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSaleTitle.Width = 300;
            // 
            // colSaleSize
            // 
            this.colSaleSize.DataPropertyName = "Size";
            this.colSaleSize.HeaderText = "面积";
            this.colSaleSize.Name = "colSaleSize";
            this.colSaleSize.ReadOnly = true;
            this.colSaleSize.Width = 90;
            // 
            // colSalePrice
            // 
            this.colSalePrice.DataPropertyName = "Price";
            this.colSalePrice.HeaderText = "价格";
            this.colSalePrice.Name = "colSalePrice";
            this.colSalePrice.ReadOnly = true;
            this.colSalePrice.Width = 90;
            // 
            // colSaleTime
            // 
            this.colSaleTime.DataPropertyName = "Time";
            this.colSaleTime.HeaderText = "发布时间";
            this.colSaleTime.Name = "colSaleTime";
            this.colSaleTime.ReadOnly = true;
            // 
            // SaleSource
            // 
            this.SaleSource.DataSource = typeof(_01fy.FYData);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 717);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSale);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 691);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "个人二手房";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSpcz);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 691);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "个人商铺";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSpcz
            // 
            this.dgvSpcz.AllowUserToAddRows = false;
            this.dgvSpcz.AllowUserToDeleteRows = false;
            this.dgvSpcz.AutoGenerateColumns = false;
            this.dgvSpcz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpcz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpczTitle,
            this.colSpczSize,
            this.colSpczPrice,
            this.colSpczTime});
            this.dgvSpcz.DataSource = this.SpczSource;
            this.dgvSpcz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSpcz.Location = new System.Drawing.Point(3, 3);
            this.dgvSpcz.Name = "dgvSpcz";
            this.dgvSpcz.ReadOnly = true;
            this.dgvSpcz.RowTemplate.Height = 23;
            this.dgvSpcz.Size = new System.Drawing.Size(755, 685);
            this.dgvSpcz.TabIndex = 2;
            this.dgvSpcz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpcz_CellContentClick);
            // 
            // colSpczTitle
            // 
            this.colSpczTitle.DataPropertyName = "Title";
            this.colSpczTitle.HeaderText = "标题";
            this.colSpczTitle.Name = "colSpczTitle";
            this.colSpczTitle.ReadOnly = true;
            this.colSpczTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSpczTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSpczTitle.Width = 300;
            // 
            // colSpczSize
            // 
            this.colSpczSize.DataPropertyName = "Size";
            this.colSpczSize.HeaderText = "面积";
            this.colSpczSize.Name = "colSpczSize";
            this.colSpczSize.ReadOnly = true;
            this.colSpczSize.Width = 90;
            // 
            // colSpczPrice
            // 
            this.colSpczPrice.DataPropertyName = "Price";
            this.colSpczPrice.HeaderText = "价格";
            this.colSpczPrice.Name = "colSpczPrice";
            this.colSpczPrice.ReadOnly = true;
            this.colSpczPrice.Width = 90;
            // 
            // colSpczTime
            // 
            this.colSpczTime.DataPropertyName = "Time";
            this.colSpczTime.HeaderText = "发布时间";
            this.colSpczTime.Name = "colSpczTime";
            this.colSpczTime.ReadOnly = true;
            // 
            // SpczSource
            // 
            this.SpczSource.DataSource = typeof(_01fy.FYData);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvXZLCZ);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 691);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "个人写字楼";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvXZLCZ
            // 
            this.dgvXZLCZ.AllowUserToAddRows = false;
            this.dgvXZLCZ.AllowUserToDeleteRows = false;
            this.dgvXZLCZ.AutoGenerateColumns = false;
            this.dgvXZLCZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXZLCZ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colXZLCZTitle,
            this.colXZLCZSize,
            this.colXZLCZPrice,
            this.colXZLCZTime});
            this.dgvXZLCZ.DataSource = this.XZLCZSource;
            this.dgvXZLCZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXZLCZ.Location = new System.Drawing.Point(3, 3);
            this.dgvXZLCZ.Name = "dgvXZLCZ";
            this.dgvXZLCZ.ReadOnly = true;
            this.dgvXZLCZ.RowTemplate.Height = 23;
            this.dgvXZLCZ.Size = new System.Drawing.Size(755, 685);
            this.dgvXZLCZ.TabIndex = 2;
            this.dgvXZLCZ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXZLCZ_CellContentClick);
            // 
            // colXZLCZTitle
            // 
            this.colXZLCZTitle.DataPropertyName = "Title";
            this.colXZLCZTitle.HeaderText = "标题";
            this.colXZLCZTitle.Name = "colXZLCZTitle";
            this.colXZLCZTitle.ReadOnly = true;
            this.colXZLCZTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colXZLCZTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colXZLCZTitle.Width = 300;
            // 
            // colXZLCZSize
            // 
            this.colXZLCZSize.DataPropertyName = "Size";
            this.colXZLCZSize.HeaderText = "面积";
            this.colXZLCZSize.Name = "colXZLCZSize";
            this.colXZLCZSize.ReadOnly = true;
            this.colXZLCZSize.Width = 90;
            // 
            // colXZLCZPrice
            // 
            this.colXZLCZPrice.DataPropertyName = "Price";
            this.colXZLCZPrice.HeaderText = "价格";
            this.colXZLCZPrice.Name = "colXZLCZPrice";
            this.colXZLCZPrice.ReadOnly = true;
            this.colXZLCZPrice.Width = 90;
            // 
            // colXZLCZTime
            // 
            this.colXZLCZTime.DataPropertyName = "Time";
            this.colXZLCZTime.HeaderText = "发布时间";
            this.colXZLCZTime.Name = "colXZLCZTime";
            this.colXZLCZTime.ReadOnly = true;
            // 
            // XZLCZSource
            // 
            this.XZLCZSource.DataSource = typeof(_01fy.FYData);
            // 
            // tm_Sale
            // 
            this.tm_Sale.Tick += new System.EventHandler(this.tm_Sale_Tick);
            // 
            // tm_Spcz
            // 
            this.tm_Spcz.Tick += new System.EventHandler(this.tm_Spcz_Tick);
            // 
            // tm_XZLCZ
            // 
            this.tm_XZLCZ.Tick += new System.EventHandler(this.tm_XZLCZ_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 717);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "第一时间房源信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpcz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpczSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXZLCZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XZLCZSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.BindingSource SaleSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSpcz;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvXZLCZ;
        private System.Windows.Forms.BindingSource SpczSource;
        private System.Windows.Forms.BindingSource XZLCZSource;
        private System.Windows.Forms.Timer tm_Sale;
        private System.Windows.Forms.Timer tm_Spcz;
        private System.Windows.Forms.Timer tm_XZLCZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleUrl;
        private System.Windows.Forms.DataGridViewLinkColumn colSaleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTime;
        private System.Windows.Forms.DataGridViewLinkColumn colXZLCZTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXZLCZTime;
        private System.Windows.Forms.DataGridViewLinkColumn colSpczTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpczSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpczPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpczTime;
    }
}

