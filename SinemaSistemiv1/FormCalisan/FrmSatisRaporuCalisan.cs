using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace SinemaSistemiv1.FormCalisan
{
    public partial class FrmSatisRaporuCalisan : Form
    {
        private readonly int _userId;
        private readonly SinemaSistemiContext _context;

        public FrmSatisRaporuCalisan(int userId)
        {
            InitializeComponent();
            _userId = userId;

            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;", new MySqlServerVersion(new Version(8, 0, 21)))
                .Options;
            _context = new SinemaSistemiContext(options);
        }

        private void FrmSatisRaporuCalisan_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void LoadChartData()
        {
            var salesData = _context.Biletler
                .Where(b => b.Kullanici_id == _userId)
                .GroupBy(b => b.Seans.Film.baslik)
                .Select(g => new
                {
                    Film = g.Key,
                    SatisSayisi = g.Count()
                })
                .ToList();

            Series salesSeries = new Series("Filme Göre Satılan Bilet Sayısı", ViewType.Bar);

            foreach (var item in salesData)
            {
                salesSeries.Points.Add(new SeriesPoint(item.Film, item.SatisSayisi));
            }

            chartControl1.Series.Clear();
            chartControl1.Series.Add(salesSeries);

            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            ((XYDiagram)chartControl1.Diagram).AxisX.Title.Text = "Filmler";
            ((XYDiagram)chartControl1.Diagram).AxisY.Title.Text = "Satış Sayısı";

            var cancelledSalesCount = _context.Biletler
                .Where(b => b.Kullanici_id == _userId && b.durum == "İptal")
                .Count();

            lblCancelledSales.Text = $"İptal Edilen Satışlar: {cancelledSalesCount}";

            var paymentMethods = _context.Biletler
                .Where(b => b.Kullanici_id == _userId)
                .GroupBy(b => b.odeme_turu)
                .Select(g => new
                {
                    OdemeYontemi = g.Key,
                    SatisSayisi = g.Count()
                })
                .ToList();

            Series paymentSeries = new Series("Ödeme Yöntemleri", ViewType.Pie);

            foreach (var item in paymentMethods)
            {
                paymentSeries.Points.Add(new SeriesPoint(item.OdemeYontemi, item.SatisSayisi));
            }

            chartControl3.Titles.Clear();
            chartControl3.Titles.Add(new ChartTitle { Text = "Ödeme Yöntemleri" });

            PieSeriesLabel label = (PieSeriesLabel)paymentSeries.Label;
            label.TextPattern = "{A}: {VP}%"; 
            label.ResolveOverlappingMode = ResolveOverlappingMode.Default;

            chartControl3.Series.Clear();
            chartControl3.Series.Add(paymentSeries);

            var monthlySales = _context.Biletler
                .Where(b => b.Kullanici_id == _userId)
                .GroupBy(b => b.satin_alma_tarihi.Month)
                .Select(g => new
                {
                    Ay = g.Key,
                    SatisSayisi = g.Count()
                })
                .ToList();

            Series monthlySalesSeries = new Series("Aylık Bilet Satışların", ViewType.Line);

            foreach (var item in monthlySales)
            {
                monthlySalesSeries.Points.Add(new SeriesPoint(item.Ay, item.SatisSayisi));
            }

            chartControl2.Series.Clear();
            chartControl2.Series.Add(monthlySalesSeries);

            var topSellingFilm = _context.Biletler
                .Where(b => b.Kullanici_id == _userId)
                .GroupBy(b => b.Seans.Film.baslik)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            lblTopSellingFilm.Text = $"En Çok Satılan Film: {topSellingFilm}";

            var totalSalesAmount = _context.Biletler
                .Where(b => b.Kullanici_id == _userId)
                .Sum(b => b.fiyat);

            lblTotalSalesAmount.Text = $"Toplam Satış Tutarı: {totalSalesAmount:C}";
        }

    }
}
