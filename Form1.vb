Public Class Form1

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Badditem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badditem.Click
        CBkendaraan.Items.Add("Mobil")
        CBkendaraan.Items.Add("Motor")
        CBkendaraan.Items.Add("Pesawat")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBjeniskendaraan.Items.Add("Roda Dua")
        CBjeniskendaraan.Items.Add("Roda Empat")
    End Sub

    Private Sub CBjeniskendaraan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBjeniskendaraan.SelectedIndexChanged
        Dim tselect As String = CBjeniskendaraan.SelectedItem
        CBmodelkendaraan.Items.Clear()
        If tselect = "Roda Dua" Then
            CBmodelkendaraan.Items.Add("Honda")
            CBmodelkendaraan.Items.Add("Yamaha")
        Else
            CBmodelkendaraan.Items.Add("Avanza")
            CBmodelkendaraan.Items.Add("Xenia")
        End If
    End Sub
End Class
