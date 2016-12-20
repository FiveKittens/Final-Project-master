using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin.View
{
    public partial class FrmRekap : Form
    {
        private DataSet data;
        private Interface.IntSuara suaraDao;
        public FrmRekap()
        {
            suaraDao = Factory.FactLogin.GetInterfaceSuara();
            InitializeComponent();
            TampilDataRekap();
            TampilDataCalon();
        }
        public void TampilDataRekap()
        {
            data = new DataSet();
            data = suaraDao.rekapSuara();
            dgvRekap.DataSource = data.Tables["tb_rekap"];
            this.dgvRekap.Sort(this.dgvRekap.Columns["waktu_suara"], ListSortDirection.Ascending);
        }
        public void TampilDataCalon()
        {
            data = new DataSet();
            data = suaraDao.SelectCalon();
            dgvCalon.DataSource = data;
            dgvCalon.DataMember = "tb_calon";
            dgvCalon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCalon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Rekap Suara";
            printer.SubTitle = string.Format("tanggal: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            printer.CellAlignment = StringAlignment.Center;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "KPUD Yogyakarta";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintPreviewDataGridView(dgvRekap);
            printer.PrintDataGridView(dgvRekap);
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            View.FrmInputSuara f5 = new View.FrmInputSuara();
            f5.ShowDialog(this);
            TampilDataRekap();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            View.FrmCabutSuara f8 = new View.FrmCabutSuara();
            f8.ShowDialog(this);
            TampilDataRekap();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmDashboard f4 = new FrmDashboard();
            f4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLogin f1 = new FrmLogin();
            f1.Show();
            this.Close();
        }
    }
}
