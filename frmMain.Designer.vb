<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("ClsMesas", -1)
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Mesa")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Num_Mesa")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cod_Imagem")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("N_Lugares", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FLG_Ativo")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Valor")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mesa_Detalhes")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim TileGroup1 As Infragistics.Win.UltraWinLiveTileView.TileGroup = New Infragistics.Win.UltraWinLiveTileView.TileGroup()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugMesas = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ugDetalhes = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.UltraGroupBox4 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.txtTotalAPagar = New DevExpress.XtraEditors.TextEdit()
        Me.txtAcertos = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalDoc = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalIVA = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorIliquido = New DevExpress.XtraEditors.TextEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.UltraGroupBox3 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMesa = New System.Windows.Forms.TextBox()
        Me.UltraGroupBox2 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEmpregado = New System.Windows.Forms.TextBox()
        Me.UltraGroupBox5 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorIVATotais = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorIVANormal = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorIVAIntermedio = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorIVAReduzido = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorSujTotais = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorSujNormal = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorSujIntermedio = New DevExpress.XtraEditors.TextEdit()
        Me.txtValorSujReduzido = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UltraGroupBox1 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPedido = New System.Windows.Forms.TextBox()
        Me.UltraGroupBox6 = New Infragistics.Win.Misc.UltraGroupBox()
        Me.pbRemove = New System.Windows.Forms.PictureBox()
        Me.pbAdd = New System.Windows.Forms.PictureBox()
        Me.pbDel = New System.Windows.Forms.PictureBox()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.ucTP = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.pbTP = New System.Windows.Forms.PictureBox()
        Me.btnSairInfo = New System.Windows.Forms.PictureBox()
        Me.BtnPrint = New Infragistics.Win.Misc.UltraButton()
        Me.txtLocalidade = New DevExpress.XtraEditors.TextEdit()
        Me.txtEndereco = New DevExpress.XtraEditors.TextEdit()
        Me.txtCod_Postal = New DevExpress.XtraEditors.TextEdit()
        Me.txtNIF = New DevExpress.XtraEditors.TextEdit()
        Me.txtNome = New DevExpress.XtraEditors.TextEdit()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMesaselect = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.btnPagamento = New System.Windows.Forms.PictureBox()
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.btnImprime = New System.Windows.Forms.PictureBox()
        Me.btnVolta = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSair = New System.Windows.Forms.Label()
        Me.utcDetalhes = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.UT = New Infragistics.Win.UltraWinLiveTileView.UltraLiveTileView()
        Me.ClsMesasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClsLinhasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.ugMesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.ugDetalhes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox4.SuspendLayout()
        CType(Me.txtTotalAPagar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAcertos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorIliquido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox3.SuspendLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox2.SuspendLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox5.SuspendLayout()
        CType(Me.txtValorIVATotais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorIVANormal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorIVAIntermedio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorIVAReduzido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorSujTotais.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorSujNormal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorSujIntermedio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValorSujReduzido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox1.SuspendLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraGroupBox6.SuspendLayout()
        CType(Me.pbRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.ucTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSairInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLocalidade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEndereco.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCod_Postal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPagamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnImprime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utcDetalhes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.utcDetalhes.SuspendLayout()
        CType(Me.UT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsMesasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsLinhasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.ugMesas)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(380, 651)
        '
        'ugMesas
        '
        Me.ugMesas.DataSource = Me.ClsMesasBindingSource
        Me.ugMesas.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn16.Header.VisiblePosition = 0
        UltraGridColumn16.Width = 46
        UltraGridColumn17.Header.VisiblePosition = 1
        UltraGridColumn17.Width = 52
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn18.Width = 56
        UltraGridColumn19.Header.VisiblePosition = 3
        UltraGridColumn19.Width = 51
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.Width = 50
        UltraGridColumn21.Header.VisiblePosition = 5
        UltraGridColumn21.Width = 43
        UltraGridColumn22.Header.VisiblePosition = 6
        UltraGridColumn22.Width = 61
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22})
        Me.ugMesas.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugMesas.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.ugMesas.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugMesas.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugMesas.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugMesas.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[False]
        Me.ugMesas.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugMesas.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Hidden
        Me.ugMesas.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugMesas.DisplayLayout.Override.RowFilterAction = Infragistics.Win.UltraWinGrid.RowFilterAction.DisableFilteredOutRows
        Me.ugMesas.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugMesas.Dock = System.Windows.Forms.DockStyle.Left
        Me.ugMesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugMesas.Location = New System.Drawing.Point(0, 0)
        Me.ugMesas.Name = "ugMesas"
        Me.ugMesas.Size = New System.Drawing.Size(380, 651)
        Me.ugMesas.TabIndex = 0
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.ugDetalhes)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox4)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox3)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox2)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox5)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox1)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGroupBox6)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(380, 651)
        '
        'ugDetalhes
        '
        Me.ugDetalhes.DataSource = Me.ClsLinhasBindingSource
        Me.ugDetalhes.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.ugDetalhes.DisplayLayout.EmptyRowSettings.ShowEmptyRows = True
        Me.ugDetalhes.DisplayLayout.InterBandSpacing = 18
        Me.ugDetalhes.DisplayLayout.MaxColScrollRegions = 1
        Me.ugDetalhes.DisplayLayout.MaxRowScrollRegions = 1
        Me.ugDetalhes.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugDetalhes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugDetalhes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugDetalhes.DisplayLayout.Override.RowSpacingAfter = 4
        Me.ugDetalhes.DisplayLayout.Override.RowSpacingBefore = 2
        Me.ugDetalhes.DisplayLayout.RowConnectorColor = System.Drawing.Color.Black
        Me.ugDetalhes.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid
        Me.ugDetalhes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugDetalhes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugDetalhes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugDetalhes.Location = New System.Drawing.Point(0, 118)
        Me.ugDetalhes.Name = "ugDetalhes"
        Me.ugDetalhes.Size = New System.Drawing.Size(357, 224)
        Me.ugDetalhes.TabIndex = 3
        '
        'UltraGroupBox4
        '
        Me.UltraGroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.UltraGroupBox4.Controls.Add(Me.txtTotalAPagar)
        Me.UltraGroupBox4.Controls.Add(Me.txtAcertos)
        Me.UltraGroupBox4.Controls.Add(Me.txtTotalDoc)
        Me.UltraGroupBox4.Controls.Add(Me.txtTotalIVA)
        Me.UltraGroupBox4.Controls.Add(Me.txtValorIliquido)
        Me.UltraGroupBox4.Controls.Add(Me.Label13)
        Me.UltraGroupBox4.Controls.Add(Me.Label9)
        Me.UltraGroupBox4.Controls.Add(Me.Label10)
        Me.UltraGroupBox4.Controls.Add(Me.Label11)
        Me.UltraGroupBox4.Controls.Add(Me.Label12)
        Me.UltraGroupBox4.Location = New System.Drawing.Point(0, 500)
        Me.UltraGroupBox4.Name = "UltraGroupBox4"
        Me.UltraGroupBox4.Size = New System.Drawing.Size(354, 151)
        Me.UltraGroupBox4.TabIndex = 4
        Me.UltraGroupBox4.Text = "Totais"
        '
        'txtTotalAPagar
        '
        Me.txtTotalAPagar.Location = New System.Drawing.Point(112, 121)
        Me.txtTotalAPagar.Name = "txtTotalAPagar"
        Me.txtTotalAPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalAPagar.TabIndex = 40
        '
        'txtAcertos
        '
        Me.txtAcertos.Location = New System.Drawing.Point(112, 96)
        Me.txtAcertos.Name = "txtAcertos"
        Me.txtAcertos.Size = New System.Drawing.Size(100, 20)
        Me.txtAcertos.TabIndex = 39
        '
        'txtTotalDoc
        '
        Me.txtTotalDoc.Location = New System.Drawing.Point(112, 71)
        Me.txtTotalDoc.Name = "txtTotalDoc"
        Me.txtTotalDoc.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalDoc.TabIndex = 38
        '
        'txtTotalIVA
        '
        Me.txtTotalIVA.Location = New System.Drawing.Point(112, 46)
        Me.txtTotalIVA.Name = "txtTotalIVA"
        Me.txtTotalIVA.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalIVA.TabIndex = 37
        '
        'txtValorIliquido
        '
        Me.txtValorIliquido.Location = New System.Drawing.Point(112, 21)
        Me.txtValorIliquido.Name = "txtValorIliquido"
        Me.txtValorIliquido.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIliquido.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Navy
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(24, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 20)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Total A Pagar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Navy
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(24, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Total Doc"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Navy
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(24, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Acertos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Navy
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(24, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Total IVA"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Navy
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(24, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Valor Iliquido"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UltraGroupBox3
        '
        Me.UltraGroupBox3.Controls.Add(Me.Label3)
        Me.UltraGroupBox3.Controls.Add(Me.txtMesa)
        Me.UltraGroupBox3.Location = New System.Drawing.Point(0, 78)
        Me.UltraGroupBox3.Name = "UltraGroupBox3"
        Me.UltraGroupBox3.Size = New System.Drawing.Size(357, 40)
        Me.UltraGroupBox3.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mesa:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMesa
        '
        Me.txtMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMesa.Location = New System.Drawing.Point(169, 9)
        Me.txtMesa.Name = "txtMesa"
        Me.txtMesa.Size = New System.Drawing.Size(111, 20)
        Me.txtMesa.TabIndex = 0
        '
        'UltraGroupBox2
        '
        Me.UltraGroupBox2.Controls.Add(Me.Label2)
        Me.UltraGroupBox2.Controls.Add(Me.txtEmpregado)
        Me.UltraGroupBox2.Location = New System.Drawing.Point(0, 40)
        Me.UltraGroupBox2.Name = "UltraGroupBox2"
        Me.UltraGroupBox2.Size = New System.Drawing.Size(357, 40)
        Me.UltraGroupBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empregado:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmpregado
        '
        Me.txtEmpregado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpregado.Location = New System.Drawing.Point(169, 11)
        Me.txtEmpregado.Name = "txtEmpregado"
        Me.txtEmpregado.Size = New System.Drawing.Size(111, 20)
        Me.txtEmpregado.TabIndex = 0
        '
        'UltraGroupBox5
        '
        Me.UltraGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.UltraGroupBox5.Controls.Add(Me.Label14)
        Me.UltraGroupBox5.Controls.Add(Me.Label7)
        Me.UltraGroupBox5.Controls.Add(Me.Label6)
        Me.UltraGroupBox5.Controls.Add(Me.Label5)
        Me.UltraGroupBox5.Controls.Add(Me.Label4)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorIVATotais)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorIVANormal)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorIVAIntermedio)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorIVAReduzido)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorSujTotais)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorSujNormal)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorSujIntermedio)
        Me.UltraGroupBox5.Controls.Add(Me.txtValorSujReduzido)
        Me.UltraGroupBox5.Controls.Add(Me.Label8)
        Me.UltraGroupBox5.Location = New System.Drawing.Point(0, 343)
        Me.UltraGroupBox5.Name = "UltraGroupBox5"
        Me.UltraGroupBox5.Size = New System.Drawing.Size(354, 158)
        Me.UltraGroupBox5.TabIndex = 5
        Me.UltraGroupBox5.Text = "IVA"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Navy
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(24, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 20)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Normal"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Navy
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(24, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Totais"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Navy
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(24, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Intermédio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Navy
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(24, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Reduzido"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(214, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Valor IVA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtValorIVATotais
        '
        Me.txtValorIVATotais.Location = New System.Drawing.Point(213, 119)
        Me.txtValorIVATotais.Name = "txtValorIVATotais"
        Me.txtValorIVATotais.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIVATotais.TabIndex = 22
        '
        'txtValorIVANormal
        '
        Me.txtValorIVANormal.Location = New System.Drawing.Point(213, 95)
        Me.txtValorIVANormal.Name = "txtValorIVANormal"
        Me.txtValorIVANormal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIVANormal.TabIndex = 21
        '
        'txtValorIVAIntermedio
        '
        Me.txtValorIVAIntermedio.Location = New System.Drawing.Point(213, 71)
        Me.txtValorIVAIntermedio.Name = "txtValorIVAIntermedio"
        Me.txtValorIVAIntermedio.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIVAIntermedio.TabIndex = 20
        '
        'txtValorIVAReduzido
        '
        Me.txtValorIVAReduzido.Location = New System.Drawing.Point(213, 47)
        Me.txtValorIVAReduzido.Name = "txtValorIVAReduzido"
        Me.txtValorIVAReduzido.Size = New System.Drawing.Size(100, 20)
        Me.txtValorIVAReduzido.TabIndex = 19
        '
        'txtValorSujTotais
        '
        Me.txtValorSujTotais.Location = New System.Drawing.Point(108, 119)
        Me.txtValorSujTotais.Name = "txtValorSujTotais"
        Me.txtValorSujTotais.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSujTotais.TabIndex = 18
        '
        'txtValorSujNormal
        '
        Me.txtValorSujNormal.Location = New System.Drawing.Point(108, 95)
        Me.txtValorSujNormal.Name = "txtValorSujNormal"
        Me.txtValorSujNormal.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSujNormal.TabIndex = 17
        '
        'txtValorSujIntermedio
        '
        Me.txtValorSujIntermedio.Location = New System.Drawing.Point(108, 71)
        Me.txtValorSujIntermedio.Name = "txtValorSujIntermedio"
        Me.txtValorSujIntermedio.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSujIntermedio.TabIndex = 16
        '
        'txtValorSujReduzido
        '
        Me.txtValorSujReduzido.Location = New System.Drawing.Point(108, 47)
        Me.txtValorSujReduzido.Name = "txtValorSujReduzido"
        Me.txtValorSujReduzido.Size = New System.Drawing.Size(100, 20)
        Me.txtValorSujReduzido.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(109, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Valor Sujeito"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UltraGroupBox1
        '
        Me.UltraGroupBox1.Controls.Add(Me.Label1)
        Me.UltraGroupBox1.Controls.Add(Me.txtPedido)
        Me.UltraGroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.UltraGroupBox1.Name = "UltraGroupBox1"
        Me.UltraGroupBox1.Size = New System.Drawing.Size(357, 40)
        Me.UltraGroupBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pedido:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPedido
        '
        Me.txtPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPedido.Location = New System.Drawing.Point(169, 11)
        Me.txtPedido.Name = "txtPedido"
        Me.txtPedido.Size = New System.Drawing.Size(111, 20)
        Me.txtPedido.TabIndex = 0
        '
        'UltraGroupBox6
        '
        Me.UltraGroupBox6.Controls.Add(Me.pbRemove)
        Me.UltraGroupBox6.Controls.Add(Me.pbAdd)
        Me.UltraGroupBox6.Controls.Add(Me.pbDel)
        Me.UltraGroupBox6.Location = New System.Drawing.Point(77, 348)
        Me.UltraGroupBox6.Name = "UltraGroupBox6"
        Me.UltraGroupBox6.Size = New System.Drawing.Size(190, 70)
        Me.UltraGroupBox6.TabIndex = 11
        '
        'pbRemove
        '
        Me.pbRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pbRemove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbRemove.Image = CType(resources.GetObject("pbRemove.Image"), System.Drawing.Image)
        Me.pbRemove.Location = New System.Drawing.Point(70, 10)
        Me.pbRemove.Name = "pbRemove"
        Me.pbRemove.Size = New System.Drawing.Size(50, 50)
        Me.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRemove.TabIndex = 9
        Me.pbRemove.TabStop = False
        '
        'pbAdd
        '
        Me.pbAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pbAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbAdd.Image = CType(resources.GetObject("pbAdd.Image"), System.Drawing.Image)
        Me.pbAdd.Location = New System.Drawing.Point(10, 10)
        Me.pbAdd.Name = "pbAdd"
        Me.pbAdd.Size = New System.Drawing.Size(50, 50)
        Me.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAdd.TabIndex = 8
        Me.pbAdd.TabStop = False
        '
        'pbDel
        '
        Me.pbDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pbDel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbDel.Image = CType(resources.GetObject("pbDel.Image"), System.Drawing.Image)
        Me.pbDel.Location = New System.Drawing.Point(130, 10)
        Me.pbDel.Name = "pbDel"
        Me.pbDel.Size = New System.Drawing.Size(50, 50)
        Me.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDel.TabIndex = 10
        Me.pbDel.TabStop = False
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.ucTP)
        Me.UltraTabPageControl3.Controls.Add(Me.pbTP)
        Me.UltraTabPageControl3.Controls.Add(Me.btnSairInfo)
        Me.UltraTabPageControl3.Controls.Add(Me.BtnPrint)
        Me.UltraTabPageControl3.Controls.Add(Me.txtLocalidade)
        Me.UltraTabPageControl3.Controls.Add(Me.txtEndereco)
        Me.UltraTabPageControl3.Controls.Add(Me.txtCod_Postal)
        Me.UltraTabPageControl3.Controls.Add(Me.txtNIF)
        Me.UltraTabPageControl3.Controls.Add(Me.txtNome)
        Me.UltraTabPageControl3.Controls.Add(Me.Label21)
        Me.UltraTabPageControl3.Controls.Add(Me.Label20)
        Me.UltraTabPageControl3.Controls.Add(Me.Label19)
        Me.UltraTabPageControl3.Controls.Add(Me.Label18)
        Me.UltraTabPageControl3.Controls.Add(Me.Label17)
        Me.UltraTabPageControl3.Controls.Add(Me.Label16)
        Me.UltraTabPageControl3.Controls.Add(Me.Label15)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(380, 651)
        '
        'ucTP
        '
        Me.ucTP.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucTP.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucTP.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucTP.DisplayLayout.MaxColScrollRegions = 1
        Me.ucTP.DisplayLayout.MaxRowScrollRegions = 1
        Me.ucTP.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucTP.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucTP.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucTP.DisplayLayout.Override.CellPadding = 0
        Me.ucTP.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucTP.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Me.ucTP.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucTP.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucTP.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucTP.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucTP.Location = New System.Drawing.Point(184, 302)
        Me.ucTP.Name = "ucTP"
        Me.ucTP.Size = New System.Drawing.Size(123, 22)
        Me.ucTP.TabIndex = 17
        '
        'pbTP
        '
        Me.pbTP.Location = New System.Drawing.Point(115, 368)
        Me.pbTP.Name = "pbTP"
        Me.pbTP.Size = New System.Drawing.Size(150, 150)
        Me.pbTP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTP.TabIndex = 16
        Me.pbTP.TabStop = False
        '
        'btnSairInfo
        '
        Me.btnSairInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnSairInfo.Image = CType(resources.GetObject("btnSairInfo.Image"), System.Drawing.Image)
        Me.btnSairInfo.Location = New System.Drawing.Point(317, 3)
        Me.btnSairInfo.Name = "btnSairInfo"
        Me.btnSairInfo.Size = New System.Drawing.Size(37, 26)
        Me.btnSairInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSairInfo.TabIndex = 15
        Me.btnSairInfo.TabStop = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnPrint.Location = New System.Drawing.Point(140, 524)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(100, 100)
        Me.BtnPrint.TabIndex = 14
        Me.BtnPrint.Text = "Print"
        '
        'txtLocalidade
        '
        Me.txtLocalidade.Location = New System.Drawing.Point(184, 200)
        Me.txtLocalidade.Name = "txtLocalidade"
        Me.txtLocalidade.Size = New System.Drawing.Size(123, 20)
        Me.txtLocalidade.TabIndex = 11
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(184, 234)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(123, 20)
        Me.txtEndereco.TabIndex = 10
        '
        'txtCod_Postal
        '
        Me.txtCod_Postal.Location = New System.Drawing.Point(184, 268)
        Me.txtCod_Postal.Name = "txtCod_Postal"
        Me.txtCod_Postal.Size = New System.Drawing.Size(123, 20)
        Me.txtCod_Postal.TabIndex = 9
        '
        'txtNIF
        '
        Me.txtNIF.Location = New System.Drawing.Point(184, 166)
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Size = New System.Drawing.Size(123, 20)
        Me.txtNIF.TabIndex = 8
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(184, 132)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(123, 20)
        Me.txtNome.TabIndex = 7
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(25, 298)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 26)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Tipo de Pagamento:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 264)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(150, 26)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Código Postal:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(28, 230)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(150, 26)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Endereço:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(28, 196)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(150, 26)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Localidade:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(28, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 26)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "NIF:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(28, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 26)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Nome/Código:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(0, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(380, 60)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Informação do Cliente"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblMesaselect)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblSair)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 94)
        Me.Panel1.TabIndex = 4
        '
        'lblMesaselect
        '
        Me.lblMesaselect.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblMesaselect.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblMesaselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblMesaselect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMesaselect.ForeColor = System.Drawing.Color.White
        Me.lblMesaselect.Location = New System.Drawing.Point(0, 0)
        Me.lblMesaselect.Name = "lblMesaselect"
        Me.lblMesaselect.Size = New System.Drawing.Size(127, 94)
        Me.lblMesaselect.TabIndex = 23
        Me.lblMesaselect.Text = "Selecione Uma Mesa"
        Me.lblMesaselect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.Controls.Add(Me.btnHome)
        Me.Panel2.Controls.Add(Me.btnPagamento)
        Me.Panel2.Controls.Add(Me.UltraStatusBar1)
        Me.Panel2.Controls.Add(Me.btnImprime)
        Me.Panel2.Controls.Add(Me.btnVolta)
        Me.Panel2.Location = New System.Drawing.Point(324, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(726, 91)
        Me.Panel2.TabIndex = 22
        '
        'btnHome
        '
        Me.btnHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(436, 6)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(80, 80)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 18
        Me.btnHome.TabStop = False
        '
        'btnPagamento
        '
        Me.btnPagamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnPagamento.Image = CType(resources.GetObject("btnPagamento.Image"), System.Drawing.Image)
        Me.btnPagamento.Location = New System.Drawing.Point(643, 6)
        Me.btnPagamento.Name = "btnPagamento"
        Me.btnPagamento.Size = New System.Drawing.Size(80, 80)
        Me.btnPagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPagamento.TabIndex = 19
        Me.btnPagamento.TabStop = False
        '
        'UltraStatusBar1
        '
        Me.UltraStatusBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.UltraStatusBar1.Location = New System.Drawing.Point(139, 18)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        UltraStatusPanel1.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.[Date]
        UltraStatusPanel2.Style = Infragistics.Win.UltraWinStatusBar.PanelStyle.Time
        Me.UltraStatusBar1.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2})
        Me.UltraStatusBar1.Size = New System.Drawing.Size(155, 56)
        Me.UltraStatusBar1.TabIndex = 13
        Me.UltraStatusBar1.Text = "UltraStatusBar1"
        Me.UltraStatusBar1.ViewStyle = Infragistics.Win.UltraWinStatusBar.ViewStyle.Office2007
        '
        'btnImprime
        '
        Me.btnImprime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.Location = New System.Drawing.Point(540, 6)
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(80, 80)
        Me.btnImprime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnImprime.TabIndex = 20
        Me.btnImprime.TabStop = False
        '
        'btnVolta
        '
        Me.btnVolta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnVolta.Image = CType(resources.GetObject("btnVolta.Image"), System.Drawing.Image)
        Me.btnVolta.Location = New System.Drawing.Point(330, 6)
        Me.btnVolta.Name = "btnVolta"
        Me.btnVolta.Size = New System.Drawing.Size(80, 80)
        Me.btnVolta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolta.TabIndex = 21
        Me.btnVolta.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLogin.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLogin.Font = New System.Drawing.Font("SansSerif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.Coral
        Me.lblLogin.Location = New System.Drawing.Point(1056, 0)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(76, 33)
        Me.lblLogin.TabIndex = 12
        Me.lblLogin.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(133, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 92)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblSair
        '
        Me.lblSair.AutoSize = True
        Me.lblSair.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblSair.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSair.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSair.ForeColor = System.Drawing.Color.Red
        Me.lblSair.Location = New System.Drawing.Point(1132, 0)
        Me.lblSair.Name = "lblSair"
        Me.lblSair.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSair.Size = New System.Drawing.Size(73, 35)
        Me.lblSair.TabIndex = 6
        Me.lblSair.Text = "Sair"
        Me.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'utcDetalhes
        '
        Me.utcDetalhes.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.utcDetalhes.Controls.Add(Me.UltraTabPageControl1)
        Me.utcDetalhes.Controls.Add(Me.UltraTabPageControl2)
        Me.utcDetalhes.Controls.Add(Me.UltraTabPageControl3)
        Me.utcDetalhes.Dock = System.Windows.Forms.DockStyle.Left
        Me.utcDetalhes.Location = New System.Drawing.Point(0, 94)
        Me.utcDetalhes.Name = "utcDetalhes"
        Me.utcDetalhes.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.utcDetalhes.Size = New System.Drawing.Size(380, 651)
        Me.utcDetalhes.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.Wizard
        Me.utcDetalhes.TabIndex = 6
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "tab1"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "tab2"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "tab3"
        Me.utcDetalhes.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(380, 651)
        '
        'UT
        '
        Me.UT.AutoHideScrollBar = False
        Me.UT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UT.ForeColor = System.Drawing.SystemColors.ControlText
        TileGroup1.Key = "Mesas"
        Me.UT.Groups.Add(TileGroup1)
        Me.UT.HighContrast = False
        Me.UT.Location = New System.Drawing.Point(380, 94)
        Me.UT.Name = "UT"
        Me.UT.Size = New System.Drawing.Size(825, 651)
        Me.UT.TabIndex = 5
        Me.UT.Text = "UltraLiveTileView1"
        '
        'ClsMesasBindingSource
        '
        Me.ClsMesasBindingSource.DataSource = GetType(FrontOffice_Paulino.ClsMesas)
        '
        'ClsLinhasBindingSource
        '
        Me.ClsLinhasBindingSource.DataSource = GetType(FrontOffice_Paulino.ClsLinhas)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1205, 745)
        Me.ControlBox = False
        Me.Controls.Add(Me.UT)
        Me.Controls.Add(Me.utcDetalhes)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "   "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.ugMesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.ugDetalhes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox4.ResumeLayout(False)
        CType(Me.txtTotalAPagar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAcertos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorIliquido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox3.ResumeLayout(False)
        Me.UltraGroupBox3.PerformLayout()
        CType(Me.UltraGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox2.ResumeLayout(False)
        Me.UltraGroupBox2.PerformLayout()
        CType(Me.UltraGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox5.ResumeLayout(False)
        CType(Me.txtValorIVATotais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorIVANormal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorIVAIntermedio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorIVAReduzido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorSujTotais.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorSujNormal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorSujIntermedio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValorSujReduzido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox1.ResumeLayout(False)
        Me.UltraGroupBox1.PerformLayout()
        CType(Me.UltraGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraGroupBox6.ResumeLayout(False)
        CType(Me.pbRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl3.ResumeLayout(False)
        Me.UltraTabPageControl3.PerformLayout()
        CType(Me.ucTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSairInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLocalidade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEndereco.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCod_Postal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPagamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnImprime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utcDetalhes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.utcDetalhes.ResumeLayout(False)
        CType(Me.UT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsMesasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsLinhasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSair As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents utcDetalhes As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGroupBox3 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMesa As TextBox
    Friend WithEvents UltraGroupBox2 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmpregado As TextBox
    Friend WithEvents UltraGroupBox5 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents txtValorSujTotais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorSujNormal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorSujIntermedio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorSujReduzido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents UltraGroupBox4 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents ugDetalhes As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGroupBox1 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPedido As TextBox
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorIVATotais As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorIVANormal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorIVAIntermedio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorIVAReduzido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtTotalAPagar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAcertos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalIVA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtValorIliquido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLocalidade As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEndereco As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCod_Postal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnPrint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnVolta As PictureBox
    Friend WithEvents btnImprime As PictureBox
    Friend WithEvents btnPagamento As PictureBox
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSairInfo As PictureBox
    Friend WithEvents UT As Infragistics.Win.UltraWinLiveTileView.UltraLiveTileView
    Friend WithEvents lblMesaselect As Label
    Friend WithEvents ugMesas As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents lblvalor As Label
    Friend WithEvents ClsMesasBindingSource As BindingSource
    Friend WithEvents ClsLinhasBindingSource As BindingSource
    Friend WithEvents pbDel As PictureBox
    Friend WithEvents pbRemove As PictureBox
    Friend WithEvents pbAdd As PictureBox
    Friend WithEvents UltraGroupBox6 As Infragistics.Win.Misc.UltraGroupBox
    Friend WithEvents pbTP As PictureBox
    Friend WithEvents ucTP As Infragistics.Win.UltraWinGrid.UltraCombo
End Class
