namespace PFC___StandBy_CSharp.Impressao
{
    public partial class ReportDesigner : DevExpress.XtraEditors.XtraForm
    {
        public ReportDesigner()
        {
            InitializeComponent();
            report_OrdemServicoEntrada report = new report_OrdemServicoEntrada();
            report.Parameters["pIDServico"].Value = 34000;
            report.Parameters["pIDServico"].Visible = false;
            report.PrintingSystem.ShowPrintStatusDialog = false;
            documentViewer1.DocumentSource = report;

            using (var printTool = new DevExpress.XtraReports.UI.ReportPrintTool(report))
            {
                //   printTool.Print(sPrinterDeliveryTkt);
                printTool.Report.CreateDocument(false); // <- ADD THIS LINE
                printTool.PrintingSystem.ExportToPdf(@"teste.pdf");
            }
            //report.CreateDocument();
        }
    }
}