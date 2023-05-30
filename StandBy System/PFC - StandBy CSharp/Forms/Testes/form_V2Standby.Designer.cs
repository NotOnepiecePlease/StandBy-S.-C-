namespace PFC___StandBy_CSharp.Forms.Testes
{
    partial class form_V2Standby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_V2Standby));
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel5 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer5 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView3 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle5 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraCharts.XYDiagram xyDiagram6 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView6 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel6 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer6 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView4 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle6 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram7 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel7 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer7 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.ChartTitle chartTitle7 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram8 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView8 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel8 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer8 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.ChartTitle chartTitle8 = new DevExpress.XtraCharts.ChartTitle();
            this.sourceServicosSemanais = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.graficoMensal = new DevExpress.XtraCharts.ChartControl();
            this.sourceServicosMensais = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.graficoSemanal = new DevExpress.XtraCharts.ChartControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.menuSuperior = new DevExpress.XtraBars.Bar();
            this.btnInicio = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lblStatusUpdate = new DevExpress.XtraBars.BarStaticItem();
            this.lblVersao = new DevExpress.XtraBars.BarStaticItem();
            this.btnAtualizarSistema = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.bindingServicosSemanais = new System.Windows.Forms.BindingSource(this.components);
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.queryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moverForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.progressMemoriaGeral = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.progressCPU = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.lblCpu = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfig = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnServicosPorMes = new DevExpress.XtraEditors.SimpleButton();
            this.workerVerificarVersao = new System.ComponentModel.BackgroundWorker();
            this.workerInicializarJuntoComForm = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.graficoMensal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingServicosSemanais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceServicosSemanais
            // 
            this.sourceServicosSemanais.ConnectionName = "standby_MainConn";
            this.sourceServicosSemanais.Name = "sourceServicosSemanais";
            storedProcQuery2.Name = "Query";
            storedProcQuery2.StoredProcName = "ServicosUltimos7DiasV2";
            this.sourceServicosSemanais.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sourceServicosSemanais.ResultSchemaSerializable = resources.GetString("sourceServicosSemanais.ResultSchemaSerializable");
            // 
            // graficoMensal
            // 
            this.graficoMensal.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.graficoMensal.AutoLayout = false;
            this.graficoMensal.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.graficoMensal.BorderOptions.Thickness = 2;
            this.graficoMensal.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1";
            this.graficoMensal.Diagram = xyDiagram5;
            this.graficoMensal.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.graficoMensal.Location = new System.Drawing.Point(12, 465);
            this.graficoMensal.Name = "graficoMensal";
            this.graficoMensal.SeriesDataMember = "NomeMes";
            series5.ArgumentDataMember = "NomeMes";
            series5.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series5.Name = "Series 4";
            series5.ValueDataMembersSerializable = "Quantidade";
            lineSeriesView5.Color = System.Drawing.SystemColors.ControlLightLight;
            lineSeriesView5.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lineSeriesView5.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Diamond;
            lineSeriesView5.LineMarkerOptions.Size = 5;
            lineSeriesView5.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series5.View = lineSeriesView5;
            this.graficoMensal.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series5};
            this.graficoMensal.SeriesTemplate.ArgumentDataMember = "NomeMes";
            sideBySideBarSeriesLabel5.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            this.graficoMensal.SeriesTemplate.Label = sideBySideBarSeriesLabel5;
            this.graficoMensal.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            seriesKeyColorColorizer5.PaletteName = "Violet II";
            this.graficoMensal.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer5;
            this.graficoMensal.SeriesTemplate.SeriesDataMember = "NomeMes";
            this.graficoMensal.SeriesTemplate.ShowInLegend = false;
            this.graficoMensal.SeriesTemplate.ValueDataMembersSerializable = "Quantidade";
            sideBySideBarSeriesView3.BarWidth = 1D;
            this.graficoMensal.SeriesTemplate.View = sideBySideBarSeriesView3;
            this.graficoMensal.Size = new System.Drawing.Size(1256, 222);
            this.graficoMensal.TabIndex = 24;
            chartTitle5.Text = "Serviços Mensais";
            this.graficoMensal.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle5});
            // 
            // sourceServicosMensais
            // 
            this.sourceServicosMensais.ConnectionName = "standby_MainConn";
            this.sourceServicosMensais.Name = "sourceServicosMensais";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sourceServicosMensais.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sourceServicosMensais.ResultSchemaSerializable = resources.GetString("sourceServicosMensais.ResultSchemaSerializable");
            // 
            // graficoSemanal
            // 
            this.graficoSemanal.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.graficoSemanal.AutoLayout = false;
            this.graficoSemanal.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.graficoSemanal.BorderOptions.Thickness = 2;
            this.graficoSemanal.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram6.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram6.AxisY.VisibleInPanesSerializable = "-1";
            this.graficoSemanal.Diagram = xyDiagram6;
            this.graficoSemanal.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.graficoSemanal.Location = new System.Drawing.Point(12, 44);
            this.graficoSemanal.Name = "graficoSemanal";
            this.graficoSemanal.SeriesDataMember = "day_of_week";
            series6.ArgumentDataMember = "day_of_week";
            series6.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series6.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.False;
            series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series6.Name = "Series 4";
            series6.ShowInLegend = false;
            series6.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.False;
            series6.ValueDataMembersSerializable = "count";
            lineSeriesView6.Color = System.Drawing.SystemColors.HighlightText;
            lineSeriesView6.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lineSeriesView6.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Diamond;
            lineSeriesView6.LineMarkerOptions.Size = 5;
            lineSeriesView6.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series6.View = lineSeriesView6;
            this.graficoSemanal.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series6};
            this.graficoSemanal.SeriesTemplate.ArgumentDataMember = "day_of_week";
            sideBySideBarSeriesLabel6.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            this.graficoSemanal.SeriesTemplate.Label = sideBySideBarSeriesLabel6;
            this.graficoSemanal.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            seriesKeyColorColorizer6.PaletteName = "Violet II";
            this.graficoSemanal.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer6;
            this.graficoSemanal.SeriesTemplate.SeriesDataMember = "day_of_week";
            this.graficoSemanal.SeriesTemplate.ShowInLegend = false;
            this.graficoSemanal.SeriesTemplate.ValueDataMembersSerializable = "count";
            sideBySideBarSeriesView4.BarWidth = 1D;
            this.graficoSemanal.SeriesTemplate.View = sideBySideBarSeriesView4;
            this.graficoSemanal.Size = new System.Drawing.Size(812, 222);
            this.graficoSemanal.TabIndex = 0;
            chartTitle6.Text = "Serviços Semanais";
            this.graficoSemanal.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle6});
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.menuSuperior,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barSubItem5,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barSubItem6,
            this.barButtonItem14,
            this.barStaticItem1,
            this.barButtonItem15,
            this.barHeaderItem1,
            this.barHeaderItem2,
            this.lblStatusUpdate,
            this.btnInicio,
            this.barButtonItem16,
            this.lblVersao,
            this.btnAtualizarSistema});
            this.barManager1.MainMenu = this.menuSuperior;
            this.barManager1.MaxItemId = 55;
            this.barManager1.StatusBar = this.bar3;
            // 
            // menuSuperior
            // 
            this.menuSuperior.BarName = "Main menu";
            this.menuSuperior.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.menuSuperior.DockCol = 0;
            this.menuSuperior.DockRow = 0;
            this.menuSuperior.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.menuSuperior.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInicio),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4)});
            this.menuSuperior.OptionsBar.DrawDragBorder = false;
            this.menuSuperior.OptionsBar.MultiLine = true;
            this.menuSuperior.OptionsBar.UseWholeRow = true;
            this.menuSuperior.Text = "Main menu";
            // 
            // btnInicio
            // 
            this.btnInicio.Caption = "INICIO";
            this.btnInicio.Id = 51;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInicio_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "SERVIÇOS";
            this.barSubItem2.Id = 1;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tela Principal";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Cadastrar Serviço";
            this.barSubItem5.Id = 6;
            this.barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5)});
            this.barSubItem5.Name = "barSubItem5";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Celular";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Notebook";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Computador";
            this.barButtonItem5.Id = 9;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Buscar Serviços";
            this.barButtonItem6.Id = 10;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "CLIENTES";
            this.barSubItem3.Id = 2;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem16),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Tela Principal";
            this.barButtonItem16.Id = 52;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Cadastrar Cliente";
            this.barButtonItem7.Id = 11;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Buscar Cliente";
            this.barButtonItem8.Id = 12;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "LUCROS";
            this.barSubItem4.Id = 3;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem10),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem11)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Tela Principal";
            this.barButtonItem9.Id = 13;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Ultimos 30 Dias";
            this.barButtonItem10.Id = 14;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Ano inteiro";
            this.barButtonItem11.Id = 15;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblStatusUpdate),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.lblVersao),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAtualizarSistema)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Desenvolvido por: voidEnterprise";
            this.barStaticItem1.Id = 46;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.Caption = "Atualizando...";
            this.lblStatusUpdate.Id = 50;
            this.lblStatusUpdate.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Lime;
            this.lblStatusUpdate.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            // 
            // lblVersao
            // 
            this.lblVersao.Caption = "v?.?.?";
            this.lblVersao.Id = 53;
            this.lblVersao.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Lime;
            this.lblVersao.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblVersao.Name = "lblVersao";
            // 
            // btnAtualizarSistema
            // 
            this.btnAtualizarSistema.Caption = "ATUALIZAR SISTEMA";
            this.btnAtualizarSistema.Id = 54;
            this.btnAtualizarSistema.ItemAppearance.Normal.BackColor = System.Drawing.Color.Green;
            this.btnAtualizarSistema.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarSistema.ItemAppearance.Normal.Options.UseBackColor = true;
            this.btnAtualizarSistema.ItemAppearance.Normal.Options.UseForeColor = true;
            this.btnAtualizarSistema.Name = "btnAtualizarSistema";
            this.btnAtualizarSistema.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnAtualizarSistema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAtualizarSistema_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 648);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 38);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "INICIO";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "barButtonItem12";
            this.barButtonItem12.Id = 16;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Mudar estilo gráfico";
            this.barButtonItem13.Id = 43;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barSubItem6
            // 
            this.barSubItem6.Caption = "Mudar estilo gráfico";
            this.barSubItem6.Id = 44;
            this.barSubItem6.ImageOptions.DisabledSvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem6.ImageOptions.DisabledSvgImage")));
            this.barSubItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem6.ImageOptions.SvgImage")));
            this.barSubItem6.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem14)});
            this.barSubItem6.Name = "barSubItem6";
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Tipo 1";
            this.barButtonItem14.Id = 45;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "barButtonItem15";
            this.barButtonItem15.Id = 47;
            this.barButtonItem15.Name = "barButtonItem15";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 48;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Caption = "barHeaderItem2";
            this.barHeaderItem2.Id = 49;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // chartControl1
            // 
            this.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chartControl1.DataSource = this.bindingServicosSemanais;
            xyDiagram7.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram7.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram7;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "day_of_week";
            series7.ArgumentDataMember = "day_of_week";
            series7.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series7.Name = "Semanal";
            series7.ShowInLegend = false;
            series7.ValueDataMembersSerializable = "count";
            lineSeriesView7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lineSeriesView7.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lineSeriesView7.LineMarkerOptions.Size = 4;
            lineSeriesView7.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series7.View = lineSeriesView7;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "day_of_week";
            sideBySideBarSeriesLabel7.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel7.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel7;
            this.chartControl1.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            seriesKeyColorColorizer7.PaletteName = "Violet II";
            this.chartControl1.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer7;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "day_of_week";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "count";
            this.chartControl1.Size = new System.Drawing.Size(930, 249);
            this.chartControl1.TabIndex = 4;
            chartTitle7.DXFont = new DevExpress.Drawing.DXFont("Segoe UI", 12F);
            chartTitle7.Indent = 1;
            chartTitle7.MaxLineCount = 1;
            chartTitle7.Text = "Serviços da Semana";
            chartTitle7.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle7});
            // 
            // bindingServicosSemanais
            // 
            this.bindingServicosSemanais.DataMember = "Query";
            this.bindingServicosSemanais.DataSource = this.sourceServicosSemanais;
            // 
            // chartControl2
            // 
            this.chartControl2.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chartControl2.DataSource = this.queryBindingSource;
            xyDiagram8.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram8.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram8;
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl2.Location = new System.Drawing.Point(0, 367);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesDataMember = "NomeMes";
            series8.ArgumentDataMember = "NomeMes";
            series8.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            series8.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series8.Name = "Mensal";
            series8.ShowInLegend = false;
            series8.ValueDataMembersSerializable = "Quantidade";
            lineSeriesView8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lineSeriesView8.LineMarkerOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            lineSeriesView8.LineMarkerOptions.Size = 4;
            lineSeriesView8.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True;
            series8.View = lineSeriesView8;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series8};
            this.chartControl2.SeriesTemplate.ArgumentDataMember = "NomeMes";
            sideBySideBarSeriesLabel8.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel8.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Top;
            this.chartControl2.SeriesTemplate.Label = sideBySideBarSeriesLabel8;
            this.chartControl2.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            seriesKeyColorColorizer8.PaletteName = "Violet II";
            this.chartControl2.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer8;
            this.chartControl2.SeriesTemplate.SeriesDataMember = "NomeMes";
            this.chartControl2.SeriesTemplate.ValueDataMembersSerializable = "Quantidade";
            this.chartControl2.Size = new System.Drawing.Size(1278, 244);
            this.chartControl2.TabIndex = 9;
            chartTitle8.DXFont = new DevExpress.Drawing.DXFont("Segoe UI", 12F);
            chartTitle8.Indent = 1;
            chartTitle8.MaxLineCount = 1;
            chartTitle8.Text = "Serviços por Mês";
            chartTitle8.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle8});
            // 
            // queryBindingSource
            // 
            this.queryBindingSource.DataMember = "Query";
            this.queryBindingSource.DataSource = this.sourceServicosMensais;
            // 
            // moverForm
            // 
            this.moverForm.Fixed = true;
            this.moverForm.Horizontal = true;
            this.moverForm.TargetControl = null;
            this.moverForm.Vertical = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.AutoSize = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.progressMemoriaGeral);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.progressCPU);
            this.panelControl1.Controls.Add(this.lblCpu);
            this.panelControl1.Controls.Add(this.chartControl1);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.chartControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1278, 610);
            this.panelControl1.TabIndex = 14;
            // 
            // progressMemoriaGeral
            // 
            this.progressMemoriaGeral.Animated = true;
            this.progressMemoriaGeral.AnimationInterval = 1;
            this.progressMemoriaGeral.AnimationSpeed = 1;
            this.progressMemoriaGeral.BackColor = System.Drawing.Color.Transparent;
            this.progressMemoriaGeral.CircleMargin = 10;
            this.progressMemoriaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.progressMemoriaGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressMemoriaGeral.IsPercentage = false;
            this.progressMemoriaGeral.LineProgressThickness = 5;
            this.progressMemoriaGeral.LineThickness = 10;
            this.progressMemoriaGeral.Location = new System.Drawing.Point(724, 278);
            this.progressMemoriaGeral.Name = "progressMemoriaGeral";
            this.progressMemoriaGeral.ProgressAnimationSpeed = 200;
            this.progressMemoriaGeral.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.progressMemoriaGeral.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.progressMemoriaGeral.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.progressMemoriaGeral.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressMemoriaGeral.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progressMemoriaGeral.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressMemoriaGeral.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressMemoriaGeral.Size = new System.Drawing.Size(75, 75);
            this.progressMemoriaGeral.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressMemoriaGeral.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progressMemoriaGeral.SubScriptText = "%";
            this.progressMemoriaGeral.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressMemoriaGeral.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.progressMemoriaGeral.SuperScriptText = "";
            this.progressMemoriaGeral.TabIndex = 18;
            this.progressMemoriaGeral.Text = "30";
            this.progressMemoriaGeral.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressMemoriaGeral.Value = 30;
            this.progressMemoriaGeral.ValueByTransition = 30;
            this.progressMemoriaGeral.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(678, 256);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(167, 25);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Uso Memoria Geral:";
            // 
            // progressCPU
            // 
            this.progressCPU.Animated = true;
            this.progressCPU.AnimationInterval = 1;
            this.progressCPU.AnimationSpeed = 1;
            this.progressCPU.BackColor = System.Drawing.Color.Transparent;
            this.progressCPU.CircleMargin = 10;
            this.progressCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.progressCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressCPU.IsPercentage = false;
            this.progressCPU.LineProgressThickness = 5;
            this.progressCPU.LineThickness = 10;
            this.progressCPU.Location = new System.Drawing.Point(490, 278);
            this.progressCPU.Name = "progressCPU";
            this.progressCPU.ProgressAnimationSpeed = 200;
            this.progressCPU.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(36)))));
            this.progressCPU.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.progressCPU.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.progressCPU.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressCPU.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progressCPU.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressCPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressCPU.Size = new System.Drawing.Size(75, 75);
            this.progressCPU.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressCPU.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progressCPU.SubScriptText = "%";
            this.progressCPU.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressCPU.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.progressCPU.SuperScriptText = "";
            this.progressCPU.TabIndex = 16;
            this.progressCPU.Text = "30";
            this.progressCPU.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressCPU.Value = 30;
            this.progressCPU.ValueByTransition = 30;
            this.progressCPU.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // lblCpu
            // 
            this.lblCpu.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpu.Appearance.Options.UseFont = true;
            this.lblCpu.Location = new System.Drawing.Point(489, 256);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(77, 25);
            this.lblCpu.TabIndex = 11;
            this.lblCpu.Text = "Uso CPU:";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.simpleButton10);
            this.groupControl1.Controls.Add(this.simpleButton11);
            this.groupControl1.Controls.Add(this.simpleButton12);
            this.groupControl1.Controls.Add(this.simpleButton7);
            this.groupControl1.Controls.Add(this.simpleButton8);
            this.groupControl1.Controls.Add(this.btnConfig);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton5);
            this.groupControl1.Controls.Add(this.simpleButton6);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnServicosPorMes);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupControl1.Location = new System.Drawing.Point(928, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(350, 249);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Menu de Ações Rápidas";
            // 
            // simpleButton10
            // 
            this.simpleButton10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton10.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton10.Appearance.Options.UseBackColor = true;
            this.simpleButton10.Appearance.Options.UseBorderColor = true;
            this.simpleButton10.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton10.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton10.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton10.Location = new System.Drawing.Point(262, 176);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(75, 66);
            this.simpleButton10.TabIndex = 11;
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton11.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton11.Appearance.Options.UseBackColor = true;
            this.simpleButton11.Appearance.Options.UseBorderColor = true;
            this.simpleButton11.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton11.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton11.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton11.Location = new System.Drawing.Point(262, 104);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(75, 66);
            this.simpleButton11.TabIndex = 10;
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton12.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton12.Appearance.Options.UseBackColor = true;
            this.simpleButton12.Appearance.Options.UseBorderColor = true;
            this.simpleButton12.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton12.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton12.ImageOptions.SvgImage")));
            this.simpleButton12.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton12.Location = new System.Drawing.Point(262, 32);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(75, 66);
            this.simpleButton12.TabIndex = 9;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton7.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton7.Appearance.Options.UseBackColor = true;
            this.simpleButton7.Appearance.Options.UseBorderColor = true;
            this.simpleButton7.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton7.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton7.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton7.Location = new System.Drawing.Point(178, 176);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(75, 66);
            this.simpleButton7.TabIndex = 8;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton8.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton8.Appearance.Options.UseBackColor = true;
            this.simpleButton8.Appearance.Options.UseBorderColor = true;
            this.simpleButton8.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton8.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton8.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton8.Location = new System.Drawing.Point(178, 104);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(75, 66);
            this.simpleButton8.TabIndex = 7;
            // 
            // btnConfig
            // 
            this.btnConfig.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnConfig.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnConfig.Appearance.Options.UseBackColor = true;
            this.btnConfig.Appearance.Options.UseBorderColor = true;
            this.btnConfig.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnConfig.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnConfig.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnConfig.ImageOptions.SvgImage")));
            this.btnConfig.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.btnConfig.Location = new System.Drawing.Point(178, 32);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 66);
            this.btnConfig.TabIndex = 6;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton4.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton4.Location = new System.Drawing.Point(94, 176);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 66);
            this.simpleButton4.TabIndex = 5;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton5.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseBorderColor = true;
            this.simpleButton5.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton5.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton5.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton5.Location = new System.Drawing.Point(94, 104);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 66);
            this.simpleButton5.TabIndex = 4;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton6.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseBorderColor = true;
            this.simpleButton6.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton6.ImageOptions.SvgImage")));
            this.simpleButton6.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton6.Location = new System.Drawing.Point(94, 32);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 66);
            this.simpleButton6.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton3.Location = new System.Drawing.Point(10, 176);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 66);
            this.simpleButton3.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.simpleButton2.Location = new System.Drawing.Point(10, 104);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 66);
            this.simpleButton2.TabIndex = 1;
            // 
            // btnServicosPorMes
            // 
            this.btnServicosPorMes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnServicosPorMes.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.btnServicosPorMes.Appearance.Options.UseBackColor = true;
            this.btnServicosPorMes.Appearance.Options.UseBorderColor = true;
            this.btnServicosPorMes.AppearanceHovered.BackColor = System.Drawing.Color.Black;
            this.btnServicosPorMes.AppearanceHovered.BorderColor = System.Drawing.Color.Black;
            this.btnServicosPorMes.AppearanceHovered.Options.UseBackColor = true;
            this.btnServicosPorMes.AppearanceHovered.Options.UseBorderColor = true;
            this.btnServicosPorMes.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnServicosPorMes.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnServicosPorMes.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnServicosPorMes.ImageOptions.SvgImage")));
            this.btnServicosPorMes.ImageOptions.SvgImageSize = new System.Drawing.Size(50, 50);
            this.btnServicosPorMes.Location = new System.Drawing.Point(10, 32);
            this.btnServicosPorMes.Name = "btnServicosPorMes";
            this.btnServicosPorMes.Size = new System.Drawing.Size(75, 66);
            this.btnServicosPorMes.TabIndex = 0;
            this.btnServicosPorMes.Click += new System.EventHandler(this.btnServicosPorMes_Click);
            // 
            // workerVerificarVersao
            // 
            this.workerVerificarVersao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerVerificarVersao_DoWork);
            this.workerVerificarVersao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerVerificarVersao_RunWorkerCompleted);
            // 
            // workerInicializarJuntoComForm
            // 
            this.workerInicializarJuntoComForm.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerInicializarJuntoComForm_DoWork);
            // 
            // form_V2Standby
            // 
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 686);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::PFC___StandBy_CSharp.Properties.Resources.icone;
            this.KeyPreview = true;
            this.Name = "form_V2Standby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StandBy System - Assistência Técnica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_V2Standby_FormClosing);
            this.Shown += new System.EventHandler(this.form_V2Standby_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_V2Standby_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_V2Standby_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoMensal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoSemanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingServicosSemanais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sourceServicosSemanais;
        private DevExpress.XtraCharts.ChartControl graficoSemanal;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarSubItem barSubItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.DataAccess.Sql.SqlDataSource sourceServicosMensais;
        private DevExpress.XtraCharts.ChartControl graficoMensal;
        public DevExpress.XtraBars.Bar menuSuperior;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource bindingServicosSemanais;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.BindingSource queryBindingSource;
        private Bunifu.Framework.UI.BunifuDragControl moverForm;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarStaticItem lblStatusUpdate;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnServicosPorMes;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton btnConfig;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraBars.BarButtonItem btnInicio;
        private DevExpress.XtraEditors.LabelControl lblCpu;
        private Bunifu.UI.WinForms.BunifuCircleProgress progressCPU;
        private Bunifu.UI.WinForms.BunifuCircleProgress progressMemoriaGeral;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private System.ComponentModel.BackgroundWorker workerVerificarVersao;
        private DevExpress.XtraBars.BarStaticItem lblVersao;
        private DevExpress.XtraBars.BarButtonItem btnAtualizarSistema;
        private System.ComponentModel.BackgroundWorker workerInicializarJuntoComForm;
    }
}