Imports Infragistics.Win.UltraWinLiveTileView
Imports System.Environment
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Drawing.Graphics
Imports Infragistics.Win.UltraWinGrid.UltraGridAction
Imports System.Math
Imports Infragistics.Win.Misc
Imports System.Text.RegularExpressions
Public Class frmMain
    Dim mlista_Artigos As List(Of ClsArtigos)
    Dim mlista_Sub_Categorias As List(Of ClsSub_Categorias)
    Dim mTileGrupo As TileGroup
    Dim mLista_Categorias As List(Of ClsCategorias)
    Dim mLista_Pagamentos As List(Of ClsTipos_Pagamento)
    Dim mLista As List(Of ClsEntidades)
    Dim mlista_Mesas As List(Of ClsMesas)
    Dim mbEstouArtigos As Boolean = False
    Dim mContadorLinhas As Integer = 1
    Dim mVerificarArtigo As String
    Dim mArtigos As ClsArtigos
    Dim mIndex_Cat As Integer
    Dim Valor As Integer = 0
    Dim mListaDoc As New List(Of ClsDocumentos)
    Dim mClsMesaAtual As ClsMesas
    Dim mClsTipo_Pedido As ClsTipos_Doc
    Dim mClsTipo_Fatura As ClsTipos_Doc
    Dim mClsPedidoAtual As ClsDocumentos
    Dim mClsFatura As ClsTipos_Doc
    Dim mClsCliente As ClsEntidades
    Dim mTab_IVA As List(Of ClsTab_IVA)
    Dim mCS As String 'Categorias Selecionadas
    Dim mSCS As String ' SubCategorias Selecionadas
    Dim mArtSel As String 'Artigo selecionado
    Dim mM As String ' Mesa selecionada
    Dim mNum_Doc As String = ""
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim appdata As String = GetFolderPath(SpecialFolder.ApplicationData)
        If Not System.IO.Directory.Exists(appdata & "\Galena\Imagens") Then
            MsgBox("O BackOffice ainda não foi configurado. 

Por Favor execute o BackOffice primeiro.")
            End
        End If


        mListaDoc = ClsDocumentos.GetDocumentos

        Load_Mesas()

    End Sub
    Private Sub UT_TileClick(sender As Object, e As TileClickEventArgs) Handles UT.TileClick
        Dim mCategoria As Integer



        Select Case mTileGrupo.Text

            Case "Mesas"
                Init_Labels()
                utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(0)
                mTileGrupo.Tiles.Clear()
                UT.Groups.Clear()
                mNum_Doc = ""
                Dim mClsMesa As ClsMesas
                Dim mNum_Mesa = e.Tile.Key
                mM = e.Tile.Key
                mClsMesa = ClsMesas.GetMesasByNum(mNum_Mesa)
                If VerificaMesa(mNum_Mesa) = False Then
                    mNum_Doc = GerarInfoMesa(mNum_Mesa)
                    ADMesa(mNum_Mesa, True, mNum_Doc)
                Else
                    Dim mMesa As ClsMesas_Detalhes = ClsMesas_Detalhes.GetMesas_DetalhesByNum(mNum_Mesa)
                    mTab_IVA = ClsTab_IVA.GetTab_IVAByNum(mNum_Doc)
                    mNum_Doc = mMesa.Num_Doc
                End If
                mClsPedidoAtual = ClsDocumentos.GetDocumentosByCod(mNum_Mesa)
                utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
                mTileGrupo.Tiles.Clear()
                Load_ugDetalhes(mNum_Mesa, mNum_Doc)
                ugDetalhes.PerformAction(FirstRowInBand)
                Calcula_Totais(False)

                Load_Categorias()

            Case "Categorias"
                mCS = e.Tile.Key              'grava o código da categoria na string
                mTileGrupo.Tiles.Clear()
                Load_Sub_Categorias(mCS)

            Case "Sub_Categorias"
                mSCS = e.Tile.Key             'grava o código da subCategoria na string
                mTileGrupo.Tiles.Clear()
                mCategoria = mlista_Sub_Categorias.FindIndex(Function(x) x.Cod_Sub_Categorias = mSCS)
                Load_Artigos(mSCS, mlista_Sub_Categorias(mCategoria).Cod_Categoria)

            Case "Artigos"
                mArtSel = e.Tile.Key
                Adiciona_Artigo(mNum_Doc)
                Load_ugDetalhes(mM, mNum_Doc)
                Calcula_Totais(True)

                ugDetalhes.PerformAction(BelowRow)


        End Select



    End Sub


    Private Sub LimpaTXT()
        txtNome.Text = ""
        txtEndereco.Text = ""
        txtCod_Postal.Text = ""
        txtLocalidade.Text = ""
        txtNIF.Text = ""
    End Sub
    Private Sub Calcula_Totais(mAtivar As Boolean)
        With mClsPedidoAtual
            Try
                .Nome = txtNome.Text
                .Endereco = txtEndereco.Text
                .Cod_Postal = txtCod_Postal.Text
                .Localidade = txtLocalidade.Text
                .Cod_Entidade = frmLogin.TxtUser.Text
                .NIF = txtNIF.Text
                .Tipo_Pagamento = ucTP.SelectedRow.Cells("Designacao").Value

            Catch ex As Exception
            End Try




            .Total_Iliquido = 0D
            .Total_Desconto = 0D
            .Total_IVA = 0D
            .Total_Doc = 0D
            .Acertos = 0D
            .Total_A_Pagar = 0D
            '---------
            .Lista_Quadro_IVA = Nothing

            Dim mLista_Quadro_IVA As New List(Of ClsTab_IVA)

            mLista_Quadro_IVA = ClsTab_IVA.Init_Tab_IVA(.Num_Doc)

            Dim mIndex As Integer = 0

            For Each mRow As UltraGridRow In ugDetalhes.Rows
                .Total_Iliquido += CDec(mRow.Cells("Valor_Iliquido").Value)
                .Total_Desconto += CDec(mRow.Cells("Valor_Desconto").Value)
                .Total_IVA = CDec(mRow.Cells("Valor_IVA").Value)
                .Total_Doc = (.Total_Iliquido - .Total_Desconto) + .Total_IVA

                mIndex = mLista_Quadro_IVA.FindIndex(Function(x) x.Tipo_IVA = ClsArtigos.GetArtigosByCod(mRow.Cells("Cod_Artigo").Value).Tipo_IVA)

                mLista_Quadro_IVA(mIndex).S_IVA += CDec(mRow.Cells("Valor_Iliquido").Value) - CDec(mRow.Cells("Valor_Desconto").Value)
                mLista_Quadro_IVA(mIndex).V_IVA += CDec(mRow.Cells("Valor_IVA").Value)



            Next

            .Lista_Quadro_IVA = mLista_Quadro_IVA

            mIndex = .Lista_Quadro_IVA.FindIndex(Function(x) x.Tipo_IVA = "R")
            txtValorSujReduzido.Text = FormatCurrency(.Lista_Quadro_IVA(mIndex).S_IVA)
            txtValorIVAReduzido.Text = FormatCurrency(.Lista_Quadro_IVA(mIndex).V_IVA)

            mIndex = .Lista_Quadro_IVA.FindIndex(Function(x) x.Tipo_IVA = "I")
            txtValorSujIntermedio.Text = FormatCurrency(.Lista_Quadro_IVA(mIndex).S_IVA)
            txtValorIVAIntermedio.Text = FormatCurrency(.Lista_Quadro_IVA(mIndex).V_IVA)

            mIndex = .Lista_Quadro_IVA.FindIndex(Function(x) x.Tipo_IVA = "N")
            txtValorSujNormal.Text = FormatCurrency(.Lista_Quadro_IVA(mIndex).S_IVA)
            txtValorIVANormal.Text = FormatCurrency(.Lista_Quadro_IVA(mIndex).V_IVA)

            txtValorSujTotais.Text = FormatCurrency(.Lista_Quadro_IVA.Sum(Function(x) x.S_IVA))
            txtValorIVATotais.Text = FormatCurrency(.Lista_Quadro_IVA.Sum(Function(x) x.V_IVA))

            txtValorIliquido.Text = FormatCurrency(.Total_Iliquido)

            txtTotalIVA.Text = FormatCurrency(.Total_IVA)
            txtTotalDoc.Text = FormatCurrency(.Total_Doc)

            If .Total_Doc <> 0D Then
                .Acertos = CalculaAcertos(.Total_Doc, 0.1)
            End If
            .Total_A_Pagar = .Total_Doc + .Acertos

            txtAcertos.Text = FormatCurrency(.Acertos)
            txtTotalAPagar.Text = FormatCurrency(.Total_A_Pagar)
            ClsDocumentos.ModificaDocumentos(mClsPedidoAtual)
            If mAtivar = True Then
                Dim mClsTab_IVA As New ClsTab_IVA
                With mClsTab_IVA
                    .Num_Doc = mNum_Doc
                    .Tipo_IVA = ClsArtigos.GetArtigosByCod(mArtSel).Tipo_IVA
                    .S_IVA = mClsPedidoAtual.Lista_Quadro_IVA(mIndex).S_IVA
                    .V_IVA = mClsPedidoAtual.Lista_Quadro_IVA(mIndex).V_IVA
                End With

                Dim mContaTAB As List(Of ClsTab_IVA)
                mContaTAB = ClsTab_IVA.GetTab_IVAByNum(mNum_Doc)
                For i = 0 To mContaTAB.Count - 1
                    If mContaTAB(i).Tipo_IVA = mClsTab_IVA.Tipo_IVA Then
                        ClsTab_IVA.ModificaTab_IVA(mClsTab_IVA)
                        Exit Sub
                    End If
                Next
                mClsTab_IVA.ID_Tab_IVA = ClsTab_IVA.GetNovoID()
                ClsTab_IVA.GravaTab_IVA(mClsTab_IVA)
            End If

        End With
    End Sub



    Private Function CalculaAcertos(ByVal mPar As Decimal, ByVal mPar1 As Single) As Decimal
        Dim mTemp As Decimal

        mTemp = mPar
        mPar = Round(mPar / mPar1, 0) * mPar1
        CalculaAcertos = IIf(((mPar - mTemp) + mTemp) = 0, mPar1 - mTemp, mPar - mTemp)
    End Function
    Private Function AlterarInfoMesa(mNum_Mesa As String)
        Dim mReturn As String = ""
        mReturn = ClsMesas_Detalhes.GetMesas_DetalhesByNum(mNum_Mesa).Num_Doc
        For i = 0 To mListaDoc.Count - 1
            If mListaDoc(i).Num_Doc = mReturn Then
                LoadTxtPedido(mListaDoc(i).Num_Doc, mNum_Mesa)
            End If
        Next
        mClsPedidoAtual = ClsDocumentos.GetDocumentosByCod(mReturn)
        Return mReturn
    End Function

    Private Function GerarInfoMesa(ByVal mNum_Mesa As String)
        Dim mReturn As String = ""
        Dim mDoc As ClsDocumentos
        Dim mIVA As ClsTab_IVA
        mDoc = New ClsDocumentos
        mIVA = New ClsTab_IVA

        With mDoc
            .Num_Doc = ClsDocumentos.GetNovoCod()
            .FLG_Tipo_Doc = "PD"
            .Designacao = "N/Pedido"
            .Data_Doc = Date.Today.ToString
            .Cod_Entidade = frmLogin.TxtUser.Text
            .Nome = ""
            .Endereco = ""
            .Cod_Postal = ""
            .Localidade = ""
            .NIF = ""
            .Taxa_Desconto = 0
            .Total_Iliquido = 0
            .Total_Desconto = 0
            .Total_IVA = 0
            .Total_Doc = 0
            .FLG_Pago = False
            .Acertos = 0
            .Total_A_Pagar = 0
            .Tipo_Pagamento = ""
            .Data_Pagamento = Date.Now
            .FLG_Ativo = True
            mListaDoc.Add(mDoc)
        End With
        LoadTxtPedido(mDoc.Num_Doc, mNum_Mesa)
        ClsDocumentos.GravaDocumentos(mDoc)
        mReturn = mDoc.Num_Doc
        mClsPedidoAtual = ClsDocumentos.GetDocumentosByCod(mDoc.Num_Doc)
        Return mReturn
    End Function

    Private Sub LoadTxtPedido(ByVal mNum_Doc As String, ByVal mNum_Mesa As String)
        txtPedido.Text = mNum_Doc
        txtEmpregado.Text = frmLogin.TxtUser.Text
        txtMesa.Text = mNum_Mesa

        Dim mClsTP As List(Of ClsTipos_Pagamento)
        mClsTP = ClsTipos_Pagamento.GetTipos_Pagamento
        ucTP.DataSource = mClsTP

        For i = 0 To ucTP.Rows.Band.Columns.Count - 1
            ucTP.Rows.Band.Columns(i).Hidden = True
        Next
        ucTP.Rows.Band.Columns("Designacao").Hidden = False
        ucTP.ValueMember = "Cod_Tipo_Pagamento"
        ucTP.DisplayMember = "Designacao"
        ucTP.Rows.Band.Columns("Designacao").Header.Caption = "Tipo de Pagamento"

        pbTP.Image = Image.FromFile(My.Settings.User & "TiposPagamento\" & mClsTP(0).Cod_Imagem)
        ucTP.SelectedRow = ucTP.Rows(0)
    End Sub

    Private Sub ADMesa(mNum_Mesa As String, ByVal mAD As Boolean, ByVal mNum_Doc As String)
        If mAD = True Then
            ClsMesas_Detalhes.AtivaMesa(mNum_Mesa, mNum_Doc)
        Else
            ClsMesas_Detalhes.DesativaMesa(mNum_Mesa)
            mClsPedidoAtual.FLG_Pago = True
            ClsDocumentos.ModificaDocumentos(mClsPedidoAtual)
        End If
    End Sub

    Private Function VerificaMesa(mNum_Mesa As String)
        Dim mReturn As Boolean

        Dim mListaMesasAtivadas As List(Of ClsMesas_Detalhes)

        mListaMesasAtivadas = ClsMesas_Detalhes.GetMesas_DetalhesTrue

        If mListaMesasAtivadas.Count = 0 Then

            mReturn = False

        Else

            For i = 0 To mListaMesasAtivadas.Count - 1

                If mListaMesasAtivadas(i).Num_Mesa = mNum_Mesa Then

                    mReturn = True
                    GoTo Fim

                Else

                    mReturn = False

                End If

            Next

        End If
Fim:
        Return mReturn
    End Function

    Private Sub LoadUgMesas()
        Dim mMesasAtivas As List(Of ClsMesas_Detalhes)
        Dim mListaMesas As New List(Of ClsMesas)
        mMesasAtivas = ClsMesas_Detalhes.GetMesas_DetalhesTrue()
        For i = 0 To mMesasAtivas.Count - 1
            Dim mMesas As New ClsMesas
            mMesas = ClsMesas.GetMesasByNum(mMesasAtivas(i).Num_Mesa)
            mListaMesas.Add(mMesas)
        Next
        For i = 0 To mListaMesas.Count - 1
            mListaMesas(i).Valor = ClsDocumentos.GetDocumentosByCod(mMesasAtivas(i).Num_Doc).Total_A_Pagar
        Next
        ugMesas.DataSource = mListaMesas
        For i As Integer = 0 To ugMesas.Rows.Band.Columns.Count - 1
            ugMesas.Rows.Band.Columns(i).Hidden = True
        Next
        ugMesas.Rows.Band.Columns("Num_Mesa").Hidden = False
        ugMesas.Rows.Band.Columns("N_Lugares").Hidden = False
        ugMesas.Rows.Band.Columns("Valor").Hidden = False

    End Sub
    Sub Init_Labels()

        Me.txtValorIliquido.Text = "0,00 €"
        ' Me.lblTotal_Desconto.Text = "0,00 €"
        Me.txtTotalIVA.Text = "0,00 €"
        Me.txtTotalDoc.Text = "0,00 €"
        Me.txtAcertos.Text = "0,00 €"
        Me.txtTotalAPagar.Text = "0,00 €"

        ' Me.lblSIVA0.Text = "0,00 €"
        Me.txtValorSujReduzido.Text = "0,00 €"
        Me.txtValorSujNormal.Text = "0,00 €"
        Me.txtValorSujIntermedio.Text = "0,00 €"
        '  Me.lblVIVA0.Text = "0,00 €"
        Me.txtValorIVAReduzido.Text = "0,00 €"
        Me.txtValorIVANormal.Text = "0,00 €"
        Me.txtValorIVAIntermedio.Text = "0,00 €"

        Me.txtValorSujTotais.Text = "0,00 €"
        Me.txtValorIVATotais.Text = "0,00 €"
    End Sub
    Sub Adiciona_Artigo(ByVal mNum_Doc As String)
        Dim mLinhas As New ClsLinhas
        Dim mClsArtigos As ClsArtigos
        Dim mLista_Linhas As List(Of ClsLinhas)
        mClsArtigos = ClsArtigos.GetArtigosByCod(mArtSel)
        mLista_Linhas = ClsLinhas.GetLinhasByNum(mNum_Doc)
        If mLista_Linhas.Count = 0 Then GoTo Prox

        For i = 0 To mLista_Linhas.Count - 1
            If mLista_Linhas(i).Cod_Artigo = mArtSel Then
                With mLista_Linhas(i)
                    .Quantidade += 1
                    .Valor_Iliquido = .Quantidade * .P_Unitario
                    .Valor_IVA = .Valor_Iliquido * (.Taxa_IVA / 100)
                    ClsLinhas.ModificaLinhas(mLista_Linhas(i))
                End With
                GoTo fim
            End If
        Next
Prox:
        With mLinhas
            .ID_Linhas = ClsLinhas.GetNovoID()
            .Num_Doc = mNum_Doc
            .Num_Linha = If(mLista_Linhas.Count = 0, 1, mLista_Linhas.Count + 1)
            .Cod_Artigo = mArtSel
            .Designacao = mClsArtigos.Designacao
            .FLG_Preferencia = False
            .Quantidade = 1
            .P_Unitario = mClsArtigos.Preco_Compra
            .Taxa_Desconto = 0
            .Taxa_IVA = ClsIVA.GetIVAByTipo(mClsArtigos.Tipo_IVA).Taxa_IVA
            .Valor_IVA = mClsArtigos.Preco_Compra * (.Taxa_IVA / 100)
            .Valor_Iliquido = mClsArtigos.Preco_Compra
            .Valor_Desconto = 0
            .Tipo_IVA = mClsArtigos.Tipo_IVA
            .FLG_Ativo = True
        End With
        Dim mIVA As ClsTab_IVA = New ClsTab_IVA
        With mIVA
            .ID_Tab_IVA = ClsTab_IVA.GetNovoID()
            .Num_Doc = ClsIVA.GetIVAByTipo(mLinhas.Tipo_IVA).Cod_IVA
            .Tipo_IVA = mLinhas.Tipo_IVA
            .S_IVA = Nothing
            .V_IVA = 0D
        End With
        Dim mLista As ClsDocumentos
        mLista = ClsDocumentos.GetDocumentosByCod(mNum_Doc)
        ClsLinhas.GravaLinhas(mLinhas)
        ClsDocumentos.ModificaDocumentos(mLista)
fim:
    End Sub
    Private Sub Load_Mesas()
        LimpaTXT()
        LoadUgMesas()
        utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(0)
        lblMesaselect.Text = "Selecione Uma Mesa"
        UT.Groups.Clear()

        mlista_Mesas = ClsMesas.GetMesas

        mTileGrupo = UT.Groups.Add("Mesa")
        mSCS = ""
        mCS = ""

        Dim mpath As String = Application.StartupPath + "\..\..\Imagens\Mesas\"

        For Each mMesa As ClsMesas In mlista_Mesas
            Dim mCaminho As String = ""
            With mMesa

                mTileGrupo.Text = "Mesas"

                Dim mTile As StaticTile

                mTile = mTileGrupo.Tiles.AddStaticTile(.Num_Mesa)
                mTile.Appearance.Normal.TextHAlign = HAlign.Center
                mTile.DefaultView.Image.Scaling = ImageScaling.ScaleToFit
                mTile.DefaultView.Text = "Mesa " & .Num_Mesa


                Dim mStrImagem = ""
                If .N_Lugares >= 9 Then
                    mStrImagem = "More.png"
                Else
                    mStrImagem = "M" & .N_Lugares & ".png"
                End If

                'Select Case mMesa.N_Lugares

                '    Case Is = 1
                '        mStrImagem = "M1.png"

                '    Case Is = 2
                '        mStrImagem = "M2.png"

                '    Case Is = 4
                '        mStrImagem = "M4.png"

                '    Case Is = 6
                '        mStrImagem = "M6.png"

                '    Case Is = 8
                '        mStrImagem = "M8.png"

                '    Case Else
                '        mStrImagem = "More.png"

                'End Select

                mCaminho = mpath + mStrImagem

                Try
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mCaminho)
                Catch ex As Exception
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mpath + "Default.jpg")
                End Try

            End With
        Next
    End Sub
    Private Sub Load_Categorias()
        lblMesa()
        UT.Groups.Clear()
        Try
            mTileGrupo = UT.Groups.Add("Categorias")
        Catch ex As Exception

        End Try
        utcDetalhes.TabIndex = 2
        mLista_Categorias = ClsCategorias.GetCategorias
        Dim mpath As String = Application.StartupPath + "\..\..\Imagens\Categorias\"

        For Each mCategorias As ClsCategorias In mLista_Categorias
            Dim mCaminho As String = ""
            With mCategorias
                mTileGrupo.Text = "Categorias"
                Dim mTile As StaticTile
                mTile = mTileGrupo.Tiles.AddStaticTile(.Cod_Categoria)

                mTile.DefaultView.Text = (mCategorias.Descricao)

                mCaminho = mpath + mCategorias.Cod_Imagem

                mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mCaminho)

            End With
        Next
    End Sub

    Private Sub Load_ugDetalhes(ByVal mNum_Mesa As String, ByVal mNum_Doc As String)
        mNum_Doc = AlterarInfoMesa(mNum_Mesa)
        ugDetalhes.DataSource = ClsLinhas.GetLinhasByNum(mNum_Doc)
        For i As Integer = 0 To ugDetalhes.Rows.Band.Columns.Count - 1
            ugDetalhes.Rows.Band.Columns(i).Hidden = True
        Next
        If ugDetalhes.Rows.Count > 0 Then
            ugDetalhes.Enabled = True
        Else

            ugDetalhes.Enabled = False
        End If
        ugDetalhes.Rows.Band.Columns("Designacao").Hidden = False
        ugDetalhes.Rows.Band.Columns("Quantidade").Hidden = False
        ugDetalhes.Rows.Band.Columns("Valor_Iliquido").Hidden = False
        ugDetalhes.Rows.Band.Columns("P_Unitario").Hidden = False

        If ugDetalhes.Rows.Count > 0 Then
            ugDetalhes.ActiveRow = ugDetalhes.Rows(0)
            mArtSel = ugDetalhes.ActiveRow.Cells("Cod_Artigo").Value
        End If
    End Sub

    Private Sub Load_Sub_Categorias(ByVal pCod_Categoria As String)
        UT.Groups.Clear()

        mlista_Sub_Categorias = ClsSub_Categorias.GetLista_Sub_Categorias_By_Categoria(pCod_Categoria)
        Try
            mTileGrupo = UT.Groups.Add("Sub_Categorias")
        Catch ex As Exception

        End Try

        Dim mpath As String = Application.StartupPath + "\..\..\Imagens\SubCategorias\"

        For Each mSub_Categorias As ClsSub_Categorias In mlista_Sub_Categorias
            Dim mCaminho As String = ""
            With mSub_Categorias
                mTileGrupo.Text = "Sub_Categorias"
                Dim mTile As StaticTile
                mTile = mTileGrupo.Tiles.AddStaticTile(.Cod_Sub_Categorias)


                mTile.DefaultView.Text = (mSub_Categorias.Descricao)

                mCaminho = mpath + mSub_Categorias.Cod_Imagem

                mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mCaminho)

            End With
        Next
    End Sub
    Private Sub Load_Artigos(ByVal pCod_Sub_Categoria As String, ByVal pCod_Categoria As String)
        UT.Groups.Clear()

        mlista_Artigos = ClsArtigos.GetArtigosBySub_Categoria(pCod_Sub_Categoria, pCod_Categoria)

        Try
            mTileGrupo = UT.Groups.Add("Artigos")
        Catch ex As Exception

        End Try

        Dim mpath As String = "M:\AA-grupoi191\02-Imagens\ImagensPrograma\Artigos\"                                                                                 'temp

        For Each mArtigo As ClsArtigos In mlista_Artigos
            Dim mCaminho As String = ""
            With mArtigo
                mTileGrupo.Text = "Artigos"
                Dim mTile As StaticTile
                mTile = mTileGrupo.Tiles.AddStaticTile(.Cod_Artigo)

                mTile.DefaultView.Text = (mArtigo.Designacao)

                mCaminho = mpath + mArtigo.Imagem
                Try
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mCaminho)
                Catch ex As Exception
                    mTile.DefaultView.Image.AllResolutions.Image = Image.FromFile(mpath + "Default.jpg")
                End Try

                mTile.Tag = mArtigo.Cod_Artigo
            End With
        Next
    End Sub
    Private Sub lblSair_Click(sender As Object, e As EventArgs) Handles lblSair.Click
        Application.Exit()
    End Sub
    Private Sub lblSair_MouseEnter(sender As Object, e As EventArgs) Handles lblSair.MouseEnter
        lblSair.BackColor = Color.Red
        lblSair.ForeColor = Color.White
    End Sub
    Private Sub lblSair_MouseLeave(sender As Object, e As EventArgs) Handles lblSair.MouseLeave
        lblSair.BackColor = Color.WhiteSmoke
        lblSair.ForeColor = Color.Red
    End Sub
    Private Sub btnVolta_Click(sender As Object, e As EventArgs) Handles btnVolta.Click
        If utcDetalhes.SelectedTab Is utcDetalhes.Tabs.Item(2) Then
            Select Case mTileGrupo.Text
                Case "Categorias"
                    utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
                Case "Sub_Categorias"
                    utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
                Case "Artigos"
                    utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
                Case "Mesas"
                    utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(0)
            End Select
            GoTo sair
        End If

        Select Case mTileGrupo.Text
            Case "Categorias"
                utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(0)
                mTileGrupo.Tiles.Clear()
                mSCS = ""
                mCS = ""
                Load_Mesas()
            Case "Sub_Categorias"
                utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
                mTileGrupo.Tiles.Clear()
                mCS = ""
                Load_Categorias()
            Case "Artigos"
                utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
                mTileGrupo.Tiles.Clear()
                Load_Sub_Categorias(mCS)
        End Select
sair:
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(0)
        mTileGrupo.Tiles.Clear()
        UT.Groups.Clear()
        Load_Mesas()
    End Sub



    Private Sub btnPagamento_Click(sender As Object, e As EventArgs) Handles btnPagamento.Click
        If mTileGrupo.Text = "Mesas" Then
            Exit Sub
        End If
        utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(2)
    End Sub

    Private Sub btnSairInfo_Click(sender As Object, e As EventArgs) Handles btnSairInfo.Click
        utcDetalhes.SelectedTab = utcDetalhes.Tabs.Item(1)
    End Sub
    Sub lblMesa()
        lblMesaselect.Text = "Mesa " & mM
    End Sub
    Private Sub ucTP_AfterCloseUp(sender As Object, e As EventArgs) Handles ucTP.AfterCloseUp
        pbTP.Image = Image.FromFile(My.Settings.User & "TiposPagamento\" & ucTP.ActiveRow.Cells("Cod_Imagem").Text)
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If ugDetalhes.Rows.Count = 0 Then
            MsgBox("Não selecionou nenhum artigo!")
            Exit Sub
        End If
        'Gravar registos/ Fechar mesa
        ADMesa(mM, False, mNum_Doc)
        'REPORT
        Init_Report()
        Load_Mesas()
    End Sub
    Private Sub pbAdd_Click(sender As Object, e As EventArgs) Handles pbAdd.Click
        If ugDetalhes.ActiveRow Is Nothing Then
            Exit Sub
        End If

        mArtSel = ugDetalhes.ActiveRow.Cells.Item("Cod_Artigo").Text

        Dim mLinhas As List(Of ClsLinhas)
                mLinhas = ClsLinhas.GetLinhasByNum(mNum_Doc)

        Dim mIndex As Integer
        mIndex = mLinhas.FindIndex(Function(x) x.Cod_Artigo = mArtSel)

        With mLinhas(mIndex)
            .Quantidade += 1
            .Valor_Iliquido = .Quantidade * .P_Unitario
            .Valor_IVA = .Valor_Iliquido * (.Taxa_IVA / 100)
            ClsLinhas.ModificaLinhas(mLinhas(mIndex))
        End With

        Load_ugDetalhes(mM, mNum_Doc)
        Calcula_Totais(True)
        ugDetalhes.ActiveRow = ugDetalhes.Rows(Index_ugDetalhes)
    End Sub
    Private Sub pbDel_Click(sender As Object, e As EventArgs) Handles pbDel.Click
        If ugDetalhes.ActiveRow Is Nothing Then
            Exit Sub
        End If

        Dim mLinhas As List(Of ClsLinhas)
        mLinhas = ClsLinhas.GetLinhasByNum(mNum_Doc)

        mArtSel = ugDetalhes.ActiveRow.Cells.Item("Cod_Artigo").Text


        Dim mIndex As Integer
        mIndex = mLinhas.FindIndex(Function(x) x.Cod_Artigo = mArtSel)

        DelLinha(mLinhas(mIndex))
    End Sub
    Private Sub pbRemove_Click(sender As Object, e As EventArgs) Handles pbRemove.Click
        If ugDetalhes.ActiveRow Is Nothing Then
            Exit Sub
        End If

        mArtSel = ugDetalhes.ActiveRow.Cells.Item("Cod_Artigo").Text

        Dim mLinhas As List(Of ClsLinhas)
        mLinhas = ClsLinhas.GetLinhasByNum(mNum_Doc)

        Dim mIndex As Integer
        mIndex = mLinhas.FindIndex(Function(x) x.Cod_Artigo = mArtSel)

        With mLinhas(mIndex)
            If .Quantidade = 1 Then
                DelLinha(mLinhas(mIndex))
                Exit Sub
            Else
                .Quantidade -= 1
            End If
            .Valor_Iliquido = .Quantidade * .P_Unitario
            .Valor_IVA = .Valor_Iliquido * (.Taxa_IVA / 100)
            ClsLinhas.ModificaLinhas(mLinhas(mIndex))
        End With

        Calcula_Totais(True)
        Load_ugDetalhes(mM, mNum_Doc)
        ugDetalhes.ActiveRow = ugDetalhes.Rows(Index_ugDetalhes)
    End Sub

    Private Sub DelLinha(mLinhas As ClsLinhas)
        If MsgBox("Deseja apagar o Artigo " & mLinhas.Designacao & "?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim mNDoc As String = ""
            mNDoc = mLinhas.Num_Doc
            ClsLinhas.ApagaLinhas(mNDoc, mLinhas.Cod_Artigo)
            Load_ugDetalhes(mM, mNum_Doc)
            Calcula_Totais(True)

        Else
            Exit Sub
        End If
    End Sub

    Private Function Index_ugDetalhes()
        Dim mReturn As Integer
        For Each mRow As UltraGridRow In ugDetalhes.Rows
            If mRow.Cells("Cod_Artigo").Value = mArtSel Then
                mReturn = mRow.Index
            End If
        Next

        Return mReturn
    End Function

    Private Sub btnImprime_Click(sender As Object, e As EventArgs) Handles btnImprime.Click
        If mTileGrupo.Text = "Mesas" Or ugDetalhes.Rows.Count = 0 Then
            Exit Sub
        Else
            Init_Report()

        End If

    End Sub
    Private Sub Init_Report()
        Dim mrptFatura As New rptFatura
        Dim mrptTab_IVA As New rptTab_IVA

        mrptFatura.ObjectDataSource1.Parameters(0).Value = mNum_Doc
        mrptTab_IVA.ObjectDataSource1.Parameters(0).Value = mNum_Doc
        frmReports.DocumentViewer1.DocumentSource = mrptFatura
        frmReports.ShowDialog()
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class

