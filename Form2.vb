Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("test")
    End Sub

    Private Sub tKeyup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tKeyup.TextChanged
        tKeyup.Text = tMasteraction.Text
    End Sub

    Private Sub tChange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tChange.TextChanged
        tChange.Text = tMasteraction.Text
    End Sub

    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'MsgBox(tMasteraction.Text)
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tLoad.Text = "On Load"
    End Sub
End Class