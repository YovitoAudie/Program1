using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program1
{
    public partial class frmPrint : Form
    {

        List<Setter> list;
        Getter _getter;
        private Getter getter;

        public frmPrint(Getter _getter, List<Setter> _list)
        {
            InitializeComponent();
            _getter = getter;
            _list = list;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            printform1.SetDataSource(list);
            printform1.SetParameterValue("pTanggalMasuk", _getter.tanggal);
            printform1.SetParameterValue("pNama",_getter.namaKonsumen);
            printform1.SetParameterValue("pBiayaServis",_getter.biayaService);
            printform1.SetParameterValue("pHargaSparepart",_getter.hargaSparepart);
            printform1.SetParameterValue("pTotal", _getter.total);
            crystalReportViewer1.ReportSource = printform1;
            crystalReportViewer1.Refresh();
        }

    }
}
