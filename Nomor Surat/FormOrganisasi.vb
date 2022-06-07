Public Class FormOrganisasi
    Public Sub refreshfo()
        dgvFo.Rows.Clear()

        Try
            Koneksi()
            Da = New OdbcDataAdapter("select * from tbl_organisasi order by panjang asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            dgvFo.ColumnCount = 2
            dgvFo.Columns(0).Name = "Organisasi"
            dgvFo.Columns(1).Name = "Kode"
            dgvFo.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvFo.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            For Each row In Dt.Rows
                dgvFo.Rows.Add(row(0), row(1))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub btnFotambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFotambah.Click
        FormTambah.labelFtjudul.Text = "Tambah Organisasi"
        FormTambah.Label1.Text = "Organisasi"
        FormTambah.ShowDialog()
    End Sub

    Private Sub FormOrganisasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call refreshfo()

    End Sub

    Private Sub btnFokembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFokembali.Click
        Me.Close()
    End Sub
End Class