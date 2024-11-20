using DevExpress.XtraCharts;
using SinemaSistemiv1.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormAdmin
{
    public partial class FrmCalisanSatislar : Form
    {
        public FrmCalisanSatislar(int userID)
        {
            InitializeComponent();
        }

        private void FrmCalisanSatislar_Load(object sender, EventArgs e)
        {
            using (var context = new SinemaSistemiContext())
            {
                
                var salesByEmployee = context.Biletler
                    .GroupBy(s => s.Kullanici.kullanici_adi)
                    .Select(g => new
                    {
                        KullaniciAdi = g.Key,
                        SatisSayisi = g.Count()
                    })
                    .ToList();

                Series series1 = new Series("Çalışan Bilet Satış Sayıları", ViewType.Bar);

                foreach (var item in salesByEmployee)
                {
                    series1.Points.Add(new SeriesPoint(item.KullaniciAdi, item.SatisSayisi));
                }

                chartControl1.Series.Add(series1);

                chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)chartControl1.Diagram).AxisX.Title.Text = "Çalışan Adı";
                ((XYDiagram)chartControl1.Diagram).AxisY.Title.Text = "Satış Sayısı";

                
                var revenueByEmployee = context.Biletler
                    .GroupBy(s => s.Kullanici.kullanici_adi)
                    .Select(g => new
                    {
                        KullaniciAdi = g.Key,
                        ToplamFiyat = g.Sum(s => s.fiyat)
                    })
                    .ToList();

                Series series2 = new Series("Çalışan Bilet Satış Gelirleri", ViewType.Bar);

                foreach (var item in revenueByEmployee)
                {
                    series2.Points.Add(new SeriesPoint(item.KullaniciAdi, item.ToplamFiyat));
                }

                chartControl2.Series.Add(series2);

                chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
                ((XYDiagram)chartControl2.Diagram).AxisX.Title.Text = "Çalışan Adı";
                ((XYDiagram)chartControl2.Diagram).AxisY.Title.Text = "Toplam Fiyat";

                
                var monthlySalesByEmployee = context.Biletler
                    .GroupBy(s => new { s.Kullanici.kullanici_adi, Ay = s.satin_alma_tarihi.Month })
                    .Select(g => new
                    {
                        KullaniciAdi = g.Key.kullanici_adi,
                        Ay = g.Key.Ay,
                        SatisSayisi = g.Count()
                    })
                    .ToList();
                
                var totalSales = salesByEmployee.Sum(s => s.SatisSayisi);
                var salesPercentageByEmployee = salesByEmployee
                    .Select(s => new
                    {
                        KullaniciAdi = s.KullaniciAdi,
                        Yuzde = (double)s.SatisSayisi / totalSales * 100
                    })
                    .ToList();

                Series series4 = new Series("Çalışanların Satış Yüzdeleri", ViewType.Pie);

                foreach (var item in salesPercentageByEmployee)
                {
                    series4.Points.Add(new SeriesPoint(item.KullaniciAdi, item.Yuzde));
                }

                chartControl4.Series.Add(series4);
                chartControl4.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
                chartControl4.Titles.Add(new ChartTitle { Text = "Çalışanların Satış Katkısı" });
            }
        }
    }
}
