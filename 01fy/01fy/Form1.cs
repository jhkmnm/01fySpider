using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HAP = HtmlAgilityPack;

namespace _01fy
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 二手房
        /// </summary>
        string Url_Sale = "http://bj.01fy.cn/sale/";
        /// <summary>
        /// 商铺
        /// </summary>
        string Url_Spcz = "http://bj.01fy.cn/spcz/";
        /// <summary>
        /// 字字楼
        /// </summary>
        string Url_XZLCZ = "http://bj.01fy.cn/xzlcz/";

        string Url_list = "list_2_0_0_0-0_0_0-0_0_2_0_{0}_.html";//最后一个是页码

        public Form1()
        {
            InitializeComponent();
            //LoadSale();
            tm_Sale.Enabled = true;
            tm_Spcz.Enabled = true;
            tm_XZLCZ.Enabled = true;
        }

        private PageData GetHtml(string url)
        {
            HAP.HtmlDocument doc = new HAP.HtmlDocument();
            HAP.HtmlWeb web = new HAP.HtmlWeb();
            doc = web.Load(url);
            var list = doc.GetElementbyId("list").SelectNodes(".//ul/li");
            PageData pagedata = new PageData();
            pagedata.Data = new List<FYData>();
            foreach(HAP.HtmlNode node in list)
            {
                FYData fy = new FYData();
                var title = node.SelectSingleNode(".//div[@class='div01']/a");
                fy.URL = title.GetAttributeValue("href", "");
                fy.Title = title.InnerText;
                var size = node.SelectSingleNode(".//div[@class='div02']");
                if(size == null)
                    size = node.SelectSingleNode(".//div[@class='div07']");
                fy.Size = size.InnerText;
                var price = node.SelectSingleNode(".//div[@class='div03']");
                fy.Price = price.InnerText;
                var time = node.SelectSingleNode(".//div[@class='div04']");
                fy.Time = time.InnerText.Trim();
                pagedata.Data.Add(fy);
            }

            var pagelist = doc.DocumentNode.SelectNodes("//div[@class='pager']/ul/ul/li/a");
            var current = doc.DocumentNode.SelectSingleNode("//li[@class='thisclass']/a");
            pagedata.CurrentPage = Convert.ToInt32(current.InnerText);
            pagedata.MaxPage = Convert.ToInt32(pagelist[pagelist.Count - 2].InnerText);

            return pagedata;
        }

        #region Sale
        private void LoadSale()
        {
            GetSale(Url_Sale + string.Format(Url_list, "1"));
        }

        private void GetSale(string url)
        {
            var data = GetHtml(url);
            SaleList = data.Data;

            pe_Sale.RecordCount = data.MaxPage * 60;
            pe_Sale.PageIndex = data.CurrentPage;
            pe_Sale.InitPageInfo();
            pe_Sale.PageChanged -= pe_Sale_PageChanged;
            pe_Sale.PageChanged += pe_Sale_PageChanged;
        }

        void pe_Sale_PageChanged(object sender, EventArgs e)
        {
            GetSale(Url_Sale + string.Format(Url_list, pe_Sale.PageIndex.ToString()));
        }

        private List<FYData> SaleList
        {
            get { return SaleSource.DataSource as List<FYData>; }
            set
            {
                if (value == null)
                    SaleSource.Clear();
                else
                {
                    SaleSource.DataSource = value;
                    dgvSale.Refresh();
                }
            }
        }

        private FYData SaleCurrent
        {
            get {
                if (SaleSource == null || SaleSource.Current == null)
                    return null;
                return SaleSource.Current as FYData; 
            }
        }

        private void dgvSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if(e.ColumnIndex == colSaleTitle.Index)
            {
                var fy = SaleCurrent;

                if (fy != null)
                {
                    System.Diagnostics.Process.Start(Url_Sale + fy.URL);
                }
            }
        }

        private void tm_Sale_Tick(object sender, EventArgs e)
        {
            tm_Sale.Enabled = false;
            LoadSale();
            tm_Sale.Enabled = true;
        }
        #endregion

        #region Spcz
        private void LoadSpcz()
        {
            GetSpcz(Url_Spcz + string.Format(Url_list, "1"));
        }

        private void GetSpcz(string url)
        {
            var data = GetHtml(url);
            SpczList = data.Data;

            pe_Spcz.RecordCount = data.MaxPage * 60;
            pe_Spcz.PageIndex = data.CurrentPage;
            pe_Spcz.InitPageInfo();
            pe_Spcz.PageChanged -= pe_Spcz_PageChanged;
            pe_Spcz.PageChanged += pe_Spcz_PageChanged;
        }

        void pe_Spcz_PageChanged(object sender, EventArgs e)
        {
            GetSpcz(Url_Spcz + string.Format(Url_list, pe_Spcz.PageIndex.ToString()));
        }

        private List<FYData> SpczList
        {
            get { return SpczSource.DataSource as List<FYData>; }
            set
            {
                if (value == null)
                    SpczSource.Clear();
                else
                {
                    SpczSource.DataSource = value;
                    dgvSpcz.Refresh();
                }
            }
        }

        private FYData SpczCurrent
        {
            get
            {
                if (SpczSource == null || SpczSource.Current == null)
                    return null;
                return SpczSource.Current as FYData;
            }
        }

        private void dgvSpcz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == colSpczTitle.Index)
            {
                var fy = SpczCurrent;

                if (fy != null)
                {
                    System.Diagnostics.Process.Start(Url_Spcz + fy.URL);
                }
            }
        }

        private void tm_Spcz_Tick(object sender, EventArgs e)
        {
            tm_Spcz.Enabled = false;
            LoadSpcz();
            tm_Spcz.Enabled = true;
        }
        #endregion

        #region XZLCZ
        private void LoadXZLCZ()
        {
            GetXZLCZ(Url_XZLCZ + string.Format(Url_list, "1"));
        }

        private void GetXZLCZ(string url)
        {
            var data = GetHtml(url);
            XZLCZList = data.Data;

            pe_XZLCZ.RecordCount = data.MaxPage * 60;
            pe_XZLCZ.PageIndex = data.CurrentPage;
            pe_XZLCZ.InitPageInfo();
            pe_XZLCZ.PageChanged -= pe_XZLCZ_PageChanged;
            pe_XZLCZ.PageChanged += pe_XZLCZ_PageChanged;
        }

        void pe_XZLCZ_PageChanged(object sender, EventArgs e)
        {
            GetXZLCZ(Url_XZLCZ + string.Format(Url_list, pe_XZLCZ.PageIndex.ToString()));
        }

        private List<FYData> XZLCZList
        {
            get { return XZLCZSource.DataSource as List<FYData>; }
            set
            {
                if (value == null)
                    XZLCZSource.Clear();
                else
                {
                    XZLCZSource.DataSource = value;
                    dgvXZLCZ.Refresh();
                }
            }
        }

        private FYData XZLCZCurrent
        {
            get
            {
                if (XZLCZSource == null || XZLCZSource.Current == null)
                    return null;
                return XZLCZSource.Current as FYData;
            }
        }

        private void dgvXZLCZ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == colXZLCZTitle.Index)
            {
                var fy = XZLCZCurrent;

                if (fy != null)
                {
                    System.Diagnostics.Process.Start(Url_XZLCZ + fy.URL);
                }
            }
        }

        private void tm_XZLCZ_Tick(object sender, EventArgs e)
        {
            tm_XZLCZ.Enabled = false;
            LoadXZLCZ();
            tm_XZLCZ.Enabled = true;
        }
        #endregion        
    }

    public class PageData
    {
        public int CurrentPage { get; set; }
        public int MaxPage { get; set; }
        public List<FYData> Data { get; set; }
    }

    public class FYData
    {
        public string URL { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public string Price { get; set; }
        public string Time { get; set; }
    }
}
