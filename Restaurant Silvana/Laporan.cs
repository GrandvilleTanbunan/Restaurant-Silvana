using Microsoft.Reporting.WinForms;
using Restaurant_Silvana.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Silvana
{
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        int pilihReport;
        string tanggal;
        DateTime tmp_dari;
        string dari;
        DateTime tmp_sampai;
        string sampai;
        string tahun;
        string bulan;
        private void Laporan_Load(object sender, EventArgs e)
        {
            CB_Periode.SelectedIndex = 0;
            DTP_DariReport.CustomFormat = "dd-MM-yyyy";
            DTP_SampaiReport.CustomFormat = "dd-MM-yyyy";
            RB_Penjualan.Checked = true;
            this.reportViewer1.RefreshReport();
        }



        
        private void Btn_Load_Click(object sender, EventArgs e)
        {
            if (pilihReport == 0 || pilihReport == 1 || pilihReport == 2) // penjualan
            {
                executeDatabase(CB_Periode.SelectedIndex);
            }
            //else if(pilihReport == 1) // pembelian
            //{

            //    reportViewer1.LocalReport.DataSources.Clear();
            //    reportViewer1.RefreshReport();
            //}

        }

        private void executeDatabase(int periode)
        {
            ClassDAL objDAL = new ClassDAL();

            DateTime theDate = DateTime.Now;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("id");
            tanggal = theDate.ToString("yyyy-MM-dd");
            tmp_dari = Convert.ToDateTime(DTP_DariReport.Text);
            tmp_sampai = Convert.ToDateTime(DTP_SampaiReport.Text);

            dari = tmp_dari.ToString("yyyy-MM-dd") + " 00:00:00";
            sampai = tmp_sampai.ToString("yyyy-MM-dd") + " 23:59:00";
            Microsoft.Reporting.WinForms.ReportParameter rParams2 = new Microsoft.Reporting.WinForms.ReportParameter();

            Microsoft.Reporting.WinForms.ReportParameter[] ParameterTanggal = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("Dari", tmp_dari.ToString("dd-MM-yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("Sampai", tmp_sampai.ToString("dd-MM-yyyy")),
            };


            //MessageBox.Show(dari);
            //MessageBox.Show(sampai);

            if (periode == 4) // tahun saja
            {
                tahun = DTP_TahunSaja.Text;
                Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("Periode", tahun),
                        new Microsoft.Reporting.WinForms.ReportParameter("ColumnVisible", "False")
                    };

                if(pilihReport == 0)
                {
                    DataTable dt = objDAL.ReadHtransWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                    ReportDataSource rds = new ReportDataSource("DataSetHtrans", dt);
                    reportViewer1.LocalReport.ReportPath = "LaporanPenjualanTahunIni.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.DisplayName = "Laporan Penjualan Tahun " + tahun;
                    reportViewer1.LocalReport.SetParameters(rParams);
                    reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                }
                else if(pilihReport == 1)
                {
                    DataTable dt = objDAL.ReadHPengeluaranWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                    ReportDataSource rds = new ReportDataSource("DataSetHPembelian", dt);
                    reportViewer1.LocalReport.ReportPath = "LaporanPembelianRangkumanTahunIni.rdlc";
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.LocalReport.DisplayName = "Laporan Penjualan Tahun " + tahun;
                    reportViewer1.LocalReport.SetParameters(rParams);
                    reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                }
               
            }
            else
            {
                tahun = theDate.ToString("yyyy");
                if (periode == 0) //hari ini
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("Periode", theDate.ToString("dd-MM-yyyy")),
                        new Microsoft.Reporting.WinForms.ReportParameter("ColumnVisible", "False")
                    };
                    
                    if(pilihReport == 0)
                    {
                        DataTable dt = objDAL.ReadHtransWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHtrans", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPenjualan.rdlc";
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        tanggal = theDate.ToString("dd-MM-yyyy");
                        reportViewer1.LocalReport.DisplayName = "Laporan Penjualan " + tanggal;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    else if(pilihReport == 1)
                    {
                        
                        DataTable dt = objDAL.ReadHPengeluaranWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHPembelian", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPembelianRangkuman.rdlc";
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        tanggal = theDate.ToString("dd-MM-yyyy");
                        reportViewer1.LocalReport.DisplayName = "Laporan Pembelian " + tanggal;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }

                    else if(pilihReport == 2)
                    {
                        DataTable dt = objDAL.ReadSumHPengeluaran(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);
                        DataTable dt2 = objDAL.ReadSumHtrans(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHPembelian", dt);
                        ReportDataSource rds2 = new ReportDataSource("DataSetHtrans", dt2);

                        reportViewer1.LocalReport.ReportPath = "LaporanPenjualandanPembelian.rdlc";
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.LocalReport.DataSources.Add(rds2);
                        tanggal = theDate.ToString("dd-MM-yyyy");
                        reportViewer1.LocalReport.DisplayName = "Laporan Pembelian " + tanggal;
                        //reportViewer1.LocalReport.SetParameters(rParams);
                        //reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    

                }
                else if (periode == 1) //bulan ini
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("Periode", theDate.ToString("MMMM yyyy", culture)),
                        new Microsoft.Reporting.WinForms.ReportParameter("ColumnVisible", "False"),
                        new Microsoft.Reporting.WinForms.ReportParameter("TanggalBulan", "Tanggal")
                    };

                    bulan = theDate.ToString("MM");
                    if(pilihReport == 0)
                    {
                        DataTable dt = objDAL.ReadHtransWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHtrans", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPenjualanBulanIni.rdlc";

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        bulan = theDate.ToString("MMMM", culture);
                        reportViewer1.LocalReport.DisplayName = "Laporan Penjualan Bulan " + bulan + " " + tahun;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    else if(pilihReport == 1)
                    {
                        DataTable dt = objDAL.ReadHPengeluaranWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHPembelian", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPembelianRangkumanBulanIni.rdlc";

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        bulan = theDate.ToString("MMMM", culture);
                        reportViewer1.LocalReport.DisplayName = "Laporan Pembelian Bulan " + bulan + " " + tahun;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    


                }
                else if (periode == 2)//tahun ini
                {

                    Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("Periode", theDate.ToString("yyyy")),
                        new Microsoft.Reporting.WinForms.ReportParameter("ColumnVisible", "False")
                    };

                    if(pilihReport == 0)
                    {
                        DataTable dt = objDAL.ReadHtransWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHtrans", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPenjualanTahunIni.rdlc";

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.LocalReport.DisplayName = "Laporan Penjualan Tahun " + tahun;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    else if(pilihReport == 1)
                    {
                        DataTable dt = objDAL.ReadHPengeluaranWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHPembelian", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPembelianRangkumanTahunIni.rdlc";

                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.LocalReport.DisplayName = "Laporan Pembelian Tahun " + tahun;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    


                }
                else if (periode == 3) // dari sampai
                {
                    
                    bulan = theDate.ToString("MM");

                    

                    if(pilihReport == 0)
                    {
                        DataTable dt = objDAL.ReadHtransWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHtrans", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPenjualanBulanIni.rdlc";
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        dari = tmp_dari.ToString("dd-MM-yyyy");
                        sampai = tmp_sampai.ToString("dd-MM-yyyy");

                        Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                        {

                            new Microsoft.Reporting.WinForms.ReportParameter("Periode", dari + " s/d " + sampai),
                            new Microsoft.Reporting.WinForms.ReportParameter("ColumnVisible", "False"),
                            new Microsoft.Reporting.WinForms.ReportParameter("TanggalBulan", "Tanggal")
                        };

                        reportViewer1.LocalReport.DisplayName = "Laporan Penjualan dari " + dari + " sampai " + sampai;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }
                    else if(pilihReport == 1)
                    {
                        DataTable dt = objDAL.ReadHPengeluaranWithCondition(CB_Periode.SelectedIndex, tanggal, bulan, dari, sampai, tahun);

                        ReportDataSource rds = new ReportDataSource("DataSetHPembelian", dt);
                        reportViewer1.LocalReport.ReportPath = "LaporanPembelianRangkumanBulanIni.rdlc";
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        dari = tmp_dari.ToString("dd-MM-yyyy");
                        sampai = tmp_sampai.ToString("dd-MM-yyyy");

                        Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
                        {

                            new Microsoft.Reporting.WinForms.ReportParameter("Periode", dari + " s/d " + sampai),
                            new Microsoft.Reporting.WinForms.ReportParameter("ColumnVisible", "False"),
                            new Microsoft.Reporting.WinForms.ReportParameter("TanggalBulan", "Tanggal")
                        };

                        reportViewer1.LocalReport.DisplayName = "Laporan pembelian dari " + dari + " sampai " + sampai;
                        reportViewer1.LocalReport.SetParameters(rParams);
                        reportViewer1.LocalReport.SetParameters(ParameterTanggal);
                    }

                    
                }
            }

            reportViewer1.RefreshReport();
        }



        private void Btn_Dtrans_Click(object sender, EventArgs e)
        {
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CB_Periode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(CB_Periode.SelectedIndex == 3)
            {
                DTP_DariReport.Visible = true;
                DTP_SampaiReport.Visible = true;
                DTP_TahunSaja.Visible = false;

            }
            else if(CB_Periode.SelectedIndex == 4)
            {
                DTP_DariReport.Visible = false;
                DTP_SampaiReport.Visible = false;
                DTP_TahunSaja.Visible = true;
            }

            else
            {
                DTP_DariReport.Visible = false;
                DTP_SampaiReport.Visible = false;
                DTP_TahunSaja.Visible = false;
            }
        }

        private void RB_Penjualan_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 0; //Rangkuman penjualan
        }

        private void RB_Pembelian_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 1; //Rangkuman pembelian
        }

        private void RB_PenjualanPembelian_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 2; //Rangkuman penjualan+pembelian
        }

        private void RB_RangkumanBerdasarkanPesanan_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 3; //Detail Penjualan

        }

        private void RB_DetailPenjualan_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 4; //Detail Penjualan
        }

        private void RB_DetailPembelian_CheckedChanged(object sender, EventArgs e)
        {
            pilihReport = 5; //Detail pembelian
        }


        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
