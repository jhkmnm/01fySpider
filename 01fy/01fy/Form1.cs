using System;
using System.Collections.Generic;
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
        string Url_Spcz = "http://bj.01fy.cn/spcs/";
        /// <summary>
        /// 字字楼
        /// </summary>
        string Url_XZLCZ = "http://bj.01fy.cn/xzlcs/";

        string Url_list = "list_2_0_0_0-0_0_0-0_0_2_0_{0}_.html";//最后一个是页码

        public Form1()
        {
            InitializeComponent();
            tm_Sale.Enabled = true;
            tm_Spcz.Enabled = true;
            tm_XZLCZ.Enabled = true;
        }

        private List<FYData> GetHtml(string url)
        {
            HAP.HtmlDocument doc = new HAP.HtmlDocument();
            HAP.HtmlWeb web = new HAP.HtmlWeb();
            doc = web.Load(url);
            var list = doc.GetElementbyId("list").SelectNodes(".//ul/li");
            var data = new List<FYData>();
            
            foreach(HAP.HtmlNode node in list)
            {
                FYData fy = new FYData();
                var title = node.SelectSingleNode(".//div[@class='div01']/a");
                fy.URL = title.GetAttributeValue("href", "");
                fy.Title = title.InnerText;
                var size = node.SelectSingleNode(".//div[@class='div02']");
                if(size == null)
                    size = node.SelectSingleNode(".//div[@class='div07']");
                fy.Size = size.InnerText.Trim();
                var price = node.SelectSingleNode(".//div[@class='div03']");
                fy.Price = price.InnerText.Trim();
                var time = node.SelectSingleNode(".//div[@class='div04']");
                fy.Time = time.InnerText.Trim();
                int hour = 0;
                int.TryParse(fy.Time.Replace("小时前", ""), out hour);
                if (fy.Time.Contains("天") || fy.Time.Contains("月"))
                    break;
                else if (hour > DateTime.Now.Hour)
                    break;
                else
                    data.Add(fy);
            }

            return data;
        }

        #region Sale
        private void LoadSale()
        {
            this.Cursor = Cursors.WaitCursor;
            int index = 1;
            var source = new List<FYData>();
            var data = GetHtml(Url_Sale + string.Format(Url_list, index));
            source.AddRange(data);
            while (data.Count == 60)
            {
                data = GetHtml(Url_Sale + string.Format(Url_list, ++index));
                source.AddRange(data);
            }

            SaleList = source;
            this.Cursor = Cursors.Default;
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
            tm_Sale.Interval = 18000;
            tm_Sale.Enabled = false;
            LoadSale();
            tm_Sale.Enabled = true;
        }
        #endregion

        #region Spcz
        private void LoadSpcz()
        {
            this.Cursor = Cursors.WaitCursor;
            int index = 1;
            var source = new List<FYData>();
            var data = GetHtml(Url_Spcz + string.Format(Url_list, index));
            source.AddRange(data);
            while (data.Count == 60)
            {
                data = GetHtml(Url_Spcz + string.Format(Url_list, ++index));
                source.AddRange(data);
            }

            SpczList = source;
            this.Cursor = Cursors.Default;
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
            tm_Spcz.Interval = 18000;
            tm_Spcz.Enabled = false;
            LoadSpcz();
            tm_Spcz.Enabled = true;
        }
        #endregion

        #region XZLCZ
        private void LoadXZLCZ()
        {
            this.Cursor = Cursors.WaitCursor;
            int index = 1;
            var source = new List<FYData>();
            var data = GetHtml(Url_XZLCZ + string.Format(Url_list, index));
            source.AddRange(data);
            while(data.Count == 60)
            {
                data = GetHtml(Url_XZLCZ + string.Format(Url_list, ++index));
                source.AddRange(data);
            }

            XZLCZList = source;
            this.Cursor = Cursors.Default;
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
            tm_XZLCZ.Interval = 18000;
            tm_XZLCZ.Enabled = false;
            LoadXZLCZ();
            tm_XZLCZ.Enabled = true;
        }
        #endregion        
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
