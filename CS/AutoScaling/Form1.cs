using System;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
// ...

namespace AutoScaling {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ReportPrintTool printTool = new ReportPrintTool(new XtraReport1());
            printTool.Report.CreateDocument(false);
            printTool.PreviewForm.Load += new EventHandler(PreviewForm_Load);
            printTool.ShowPreviewDialog();
        }

        void PreviewForm_Load(object sender, EventArgs e) {
            PrintPreviewFormEx frm = (PrintPreviewFormEx)sender;
            frm.PrintingSystem.ExecCommand(PrintingSystemCommand.Scale, new object[] { 0.7f });
        }

    }
}

