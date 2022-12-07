Public Class frmLogin
    Dim mLista As New ClsEntidades
    Public Nome As String
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        mLista = ClsEntidades.GetEntidadesByCod(TxtUser.Text)
        If mLista.Cod_Entidade Is Nothing Then
            MsgBox("O Código de Empregado " + TxtUser.Text + " não existe", MsgBoxStyle.Exclamation, "Galena")
            GoTo Username
        Else
            If mLista.Password = TxtPassword.Text Then
                Nome = mLista.Nome
                frmMain.Show()
                Me.Hide()
            Else
                MsgBox("Palavra-Passe Incorreta!", MsgBoxStyle.Exclamation, "Galena")
                GoTo Password
            End If

        End If

Username:
        TxtUser.Text = ""
        TxtPassword.Text = ""
        TxtUser.Focus()
        Exit Sub
Password:
        TxtPassword.Text = ""
        TxtPassword.Focus()
    End Sub
End Class