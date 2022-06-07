Imports System.Data.Odbc
Public Class FormJenisSurat
    
    Public Sub refreshfjs()
        dgvFjs.Rows.Clear()

        Try
            Koneksi()
            Da = New OdbcDataAdapter("select * from tbl_jenissurat order by panjang asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            dgvFjs.ColumnCount = 2
            dgvFjs.Columns(0).Name = "Jenis Surat"
            dgvFjs.Columns(1).Name = "Kode"
            dgvFjs.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvFjs.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            For Each row In Dt.Rows
                dgvFjs.Rows.Add(row(0), row(1))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub FormJenisSurat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call refreshfjs()

    End Sub

    Private Sub btnFjstambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFjstambah.Click
        FormTambah.labelFtjudul.Text = "Tambah Jenis Surat"
        FormTambah.Label1.Text = "Jenis Surat"
        FormTambah.ShowDialog()
    End Sub

    Private Sub btnFjskembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFjskembali.Click
        Me.Close()
    End Sub
End Class