Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LVbiodata.View = View.Details
        LVbiodata.Columns.Add("NO", 50)
        LVbiodata.Columns.Add("NAMA", 100)
        LVbiodata.Columns.Add("ALAMAT", 300)
    End Sub

    Private Sub LVbiodata_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVbiodata.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim no As Integer

        no = LVbiodata.Items.Count() + 1
        Dim newitem As New ListViewItem(no)
        newitem.SubItems.Add(Tnama.Text)
        newitem.SubItems.Add(Talamat.Text)
        LVbiodata.Items.Add(newitem)
    End Sub
End Class