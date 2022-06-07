Imports System.Data.Odbc
Imports System.Globalization

Public Class FormMenuUtama

    Private Sub JenisSuratToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisSuratToolStripMenuItem.Click
        FormJenisSurat.Show()
    End Sub

    Private Sub OrganisasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganisasiToolStripMenuItem.Click
        FormOrganisasi.Show()
    End Sub

    Private Sub InputSuratBaruToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputSuratBaruToolStripMenuItem.Click
        FormInputSurat.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Application.Exit()
    End Sub

    Public Sub FormMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timerwaktu.Enabled = True
        Call Koneksi()
        Call refreshfmu()
        Call checktbl()
        Call refreshcbfmu()
        btnFmucari.Visible = False
        dtpFmu.Visible = False
        txtFmubox.Visible = False
        nudFmu.Visible = False
        cbFmu.Visible = False
    End Sub

    Public Sub refreshfmu()
        dgvFmu.Rows.Clear()
        Try
            Koneksi()
            Da = New OdbcDataAdapter("select * from tbl_nosurat order by no asc", Conn)
            Dt = New DataTable
            Da.Fill(Dt)
            dgvFmu.ColumnCount = 5
            dgvFmu.Columns(0).Name = "No"
            dgvFmu.Columns(1).Name = "Tanggal"
            dgvFmu.Columns(2).Name = "Nomor Surat"
            dgvFmu.Columns(3).Name = "Instansi"
            dgvFmu.Columns(4).Name = "Keterangan"
            dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
            dgvFmu.Columns(3).Width = 100
            dgvFmu.Columns(4).Width = 250
            For Each row In Dt.Rows
                dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
            Next
            Dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Public Sub refreshcbfmu()
        cbFmufilter.Items.Clear()
        Dim columns() As String = {"Semua", "Tanggal", "No. Surat", "Jenis Surat", "Organisasi", "Bulan", "Tahun"}
        cbFmufilter.MaxDropDownItems = columns.Length
        For Each column As String In columns
            cbFmufilter.Items.Add(column)
        Next
        cbFmufilter.SelectedItem = "Semua"
    End Sub
    Public Sub checktbl()
        Dim thn As String
        thn = Format(Now, "yyyy")
        Call Koneksi()
        Dim queryString As String = "select * from tbl_nosurat" & thn & ""
        CMd = New OdbcCommand(queryString, Conn)
        Try
            CMd.ExecuteNonQuery()
            'MessageBox.Show("query successfully!")
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            If MsgBox("TIDAK DITEMUKAN TABEL DATABASE UNTUK TAHUN INI, BUAT?", MsgBoxStyle.Information Or MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
                'MsgBox("acc")
                Call Koneksi()
                Dim createtbl As String = "create table tbl_nosurat" & thn & " like tbl_nosurat"
                CMd = New OdbcCommand(createtbl, Conn)
                CMd.ExecuteNonQuery()
            End If
        End Try
    End Sub


    Private Sub cbFmufilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFmufilter.SelectedIndexChanged
        If cbFmufilter.SelectedItem = "Semua" Then
            dtpFmu.Visible = False
            txtFmubox.Visible = False
            cbFmu.Visible = False
            nudFmu.Visible = False
            btnFmucari.Visible = False
            Call refreshfmu()
        ElseIf cbFmufilter.SelectedItem = "Tanggal" Then
            dtpFmu.Visible = True
            txtFmubox.Visible = False
            cbFmu.Visible = False
            nudFmu.Visible = False
            btnFmucari.Visible = True
        ElseIf cbFmufilter.SelectedItem = "No. Surat" Then
            dtpFmu.Visible = False
            txtFmubox.Visible = True
            cbFmu.Visible = False
            nudFmu.Visible = False
            txtFmubox.Text = ""
            btnFmucari.Visible = True
        ElseIf cbFmufilter.SelectedItem = "Jenis Surat" Then
            dtpFmu.Visible = False
            txtFmubox.Visible = False
            cbFmu.Visible = True
            nudFmu.Visible = False
            btnFmucari.Visible = True
            cbFmu.Width = 215
            cbFmu.Items.Clear()
            Try
                Koneksi()
                CMd = New OdbcCommand("select panjang from tbl_jenissurat order by panjang", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    cbFmu.Items.Add(Rd("panjang"))
                End While
            Catch ex As Exception
            End Try
        ElseIf cbFmufilter.SelectedItem = "Organisasi" Then
            dtpFmu.Visible = False
            txtFmubox.Visible = False
            cbFmu.Visible = True
            nudFmu.Visible = False
            btnFmucari.Visible = True
            cbFmu.Width = 215
            cbFmu.Items.Clear()
            Try
                Koneksi()
                CMd = New OdbcCommand("select panjang from tbl_organisasi order by panjang", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    cbFmu.Items.Add(Rd("panjang"))
                End While
            Catch ex As Exception
            End Try
        ElseIf cbFmufilter.SelectedItem = "Bulan" Then

            dtpFmu.Visible = False
            txtFmubox.Visible = False
            cbFmu.Visible = True
            nudFmu.Visible = True
            btnFmucari.Visible = True
            cbFmu.Width = 90
            cbFmu.Items.Clear()
            For a As Integer = 0 To 11
                Dim b As DateTime
                cbFmu.Items.Add(Format(b.AddMonths(a), "MMMM"))
            Next
            cbFmu.SelectedIndex = DateTime.Now.Month - 1
            nudFmu.Text = DateTime.Now.Year
            nudFmu.Location = New Point(240, 18)
        ElseIf cbFmufilter.SelectedItem = "Tahun" Then
            dtpFmu.Visible = False
            txtFmubox.Visible = False
            cbFmu.Visible = False
            nudFmu.Visible = True
            nudFmu.Text = DateTime.Now.Year
            nudFmu.Location = New Point(133, 18)
            btnFmucari.Visible = True
        End If
    End Sub

    Private Sub btnFmucari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmucari.Click
        If cbFmufilter.SelectedItem = "Tanggal" Then
            Dim tgl1 As String
            tgl1 = dtpFmu.Value.ToString("yyyy-MM-dd")
            dgvFmu.Rows.Clear()
            Try
                Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_nosurat where tanggal like '%" & tgl1 & "%' order by no asc", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                dgvFmu.ColumnCount = 5
                dgvFmu.Columns(0).Name = "No"
                dgvFmu.Columns(1).Name = "Tanggal"
                dgvFmu.Columns(2).Name = "Nomor Surat"
                dgvFmu.Columns(3).Name = "Instansi"
                dgvFmu.Columns(4).Name = "Keterangan"
                dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
                dgvFmu.Columns(3).Width = 100
                dgvFmu.Columns(4).Width = 250
                For Each row In Dt.Rows
                    dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
                Next
                Dt.Rows.Clear()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        ElseIf cbFmufilter.SelectedItem = "No. Surat" Then
            If txtFmubox.Text = "" Then
                MsgBox("Isi kotak pencarian!")
            Else
                dgvFmu.Rows.Clear()
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%" & txtFmubox.Text & "%' order by no asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    dgvFmu.ColumnCount = 5
                    dgvFmu.Columns(0).Name = "No"
                    dgvFmu.Columns(1).Name = "Tanggal"
                    dgvFmu.Columns(2).Name = "Nomor Surat"
                    dgvFmu.Columns(3).Name = "Instansi"
                    dgvFmu.Columns(4).Name = "Keterangan"
                    dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
                    dgvFmu.Columns(3).Width = 100
                    dgvFmu.Columns(4).Width = 250
                    For Each row In Dt.Rows
                        dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        ElseIf cbFmufilter.SelectedItem = "Jenis Surat" Then
            If cbFmu.Text = "" Then
                MsgBox("Pilih jenis surat!")
            Else
                Dim js1 As String
                Try
                    Koneksi()
                    CMd = New OdbcCommand("select * from tbl_jenissurat", Conn)
                    Rd = CMd.ExecuteReader
                    While Rd.Read
                        If cbFmu.SelectedItem = Rd("panjang") Then
                            js1 = Rd("singkat")
                        End If
                    End While
                Catch ex As Exception
                End Try
                dgvFmu.Rows.Clear()
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%-" & js1 & "-%' order by no asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    dgvFmu.ColumnCount = 5
                    dgvFmu.Columns(0).Name = "No"
                    dgvFmu.Columns(1).Name = "Tanggal"
                    dgvFmu.Columns(2).Name = "Nomor Surat"
                    dgvFmu.Columns(3).Name = "Instansi"
                    dgvFmu.Columns(4).Name = "Keterangan"
                    dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
                    dgvFmu.Columns(3).Width = 100
                    dgvFmu.Columns(4).Width = 250
                    For Each row In Dt.Rows
                        dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
            
        ElseIf cbFmufilter.SelectedItem = "Organisasi" Then
            If cbFmu.Text = "" Then
                MsgBox("Pilih organisasi!")
            Else
                Dim org1 As String
                Try
                    Koneksi()
                    CMd = New OdbcCommand("select * from tbl_organisasi", Conn)
                    Rd = CMd.ExecuteReader
                    While Rd.Read
                        If cbFmu.SelectedItem = Rd("panjang") Then
                            org1 = Rd("singkat")
                        End If
                    End While
                Catch ex As Exception
                End Try
                dgvFmu.Rows.Clear()
                Try
                    Koneksi()
                    Da = New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%-" & org1 & "/%' order by no asc", Conn)
                    Dt = New DataTable
                    Da.Fill(Dt)
                    dgvFmu.ColumnCount = 5
                    dgvFmu.Columns(0).Name = "No"
                    dgvFmu.Columns(1).Name = "Tanggal"
                    dgvFmu.Columns(2).Name = "Nomor Surat"
                    dgvFmu.Columns(3).Name = "Instansi"
                    dgvFmu.Columns(4).Name = "Keterangan"
                    dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
                    dgvFmu.Columns(3).Width = 100
                    dgvFmu.Columns(4).Width = 250
                    For Each row In Dt.Rows
                        dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
                    Next
                    Dt.Rows.Clear()
                Catch ex As Exception
                    MsgBox("Error")
                End Try
            End If
        ElseIf cbFmufilter.SelectedItem = "Bulan" Then
            Dim blnrow As String
            Dim blnthn As String
            Dim blncb As String
            blncb = cbFmu.Text
            Try
                Dim monthNumber = DateTime.ParseExact(blncb, "MMMM", CultureInfo.CurrentCulture).Month
                Select Case Val(monthNumber)
                    Case Is = "1"
                        blnrow = "I"
                    Case Is = "2"
                        blnrow = "II"
                    Case Is = "3"
                        blnrow = "III"
                    Case Is = "4"
                        blnrow = "IV"
                    Case Is = "5"
                        blnrow = "V"
                    Case Is = "6"
                        blnrow = "VI"
                    Case Is = "7"
                        blnrow = "VII"
                    Case Is = "8"
                        blnrow = "VIII"
                    Case Is = "9"
                        blnrow = "IX"
                    Case Is = "10"
                        blnrow = "X"
                    Case Is = "11"
                        blnrow = "XI"
                    Case Is = "12"
                        blnrow = "XII"
                End Select
            Catch ex As Exception
                MsgBox("Tidak Ada Data")
            End Try
            blnthn = "/" & blnrow & "/" & nudFmu.Text & ""
            dgvFmu.Rows.Clear()
            Try
                Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%" & blnthn & "%' order by no asc", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                dgvFmu.ColumnCount = 5
                dgvFmu.Columns(0).Name = "No"
                dgvFmu.Columns(1).Name = "Tanggal"
                dgvFmu.Columns(2).Name = "Nomor Surat"
                dgvFmu.Columns(3).Name = "Instansi"
                dgvFmu.Columns(4).Name = "Keterangan"
                dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
                dgvFmu.Columns(3).Width = 100
                dgvFmu.Columns(4).Width = 250
                For Each row In Dt.Rows
                    dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
                Next
                Dt.Rows.Clear()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        ElseIf cbFmufilter.SelectedItem = "Tahun" Then
            dgvFmu.Rows.Clear()
            Try
                Koneksi()
                Da = New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%/" & nudFmu.Text & "%' order by no asc", Conn)
                Dt = New DataTable
                Da.Fill(Dt)
                dgvFmu.ColumnCount = 5
                dgvFmu.Columns(0).Name = "No"
                dgvFmu.Columns(1).Name = "Tanggal"
                dgvFmu.Columns(2).Name = "Nomor Surat"
                dgvFmu.Columns(3).Name = "Instansi"
                dgvFmu.Columns(4).Name = "Keterangan"
                dgvFmu.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgvFmu.Columns(1).DefaultCellStyle.Format = "dddd, dd MMMM yyyy HH:mm"
                dgvFmu.Columns(3).Width = 100
                dgvFmu.Columns(4).Width = 250
                For Each row In Dt.Rows
                    dgvFmu.Rows.Add(row(0), row(1), row(2), row(3), row(4))
                Next
                Dt.Rows.Clear()
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
    End Sub

    Private Sub LaporanNomorSuratToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanNomorSuratToolStripMenuItem.Click
        FormReport.Show()
    End Sub

    Private Sub Timerwaktu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerwaktu.Tick
        labeljam.Text = Date.Now.ToString("hh:mm:ss tt")
        labeltgl.Text = Format(Now, "dddd, dd MMMM yyyy")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
