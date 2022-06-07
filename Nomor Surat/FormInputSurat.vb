Public Class FormInputSurat
    Public Sub clearfis()
        dtpFis.Value = Now
        txtFis1.Text = ""
        cbFisjs.Items.Clear()
        cbFisorg.Items.Clear()
        txtFisnosurat.Text = ""
        txtFisinstansi.Text = ""
        txtFisketerangan.Text = ""
    End Sub
    Public Sub cbloadjs()
        cbFisjs.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select panjang from tbl_jenissurat order by panjang", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFisjs.Items.Add(Rd("panjang"))
            End While
        Catch ex As Exception
        End Try
        Dim ar(cbFisjs.Items.Count - 1) As Object

        cbFisjs.Items.CopyTo(ar, 0)
        cbFisjs.Items.Clear()

        Dim i As Integer
        For i = 0 To UBound(ar)
            If Not cbFisjs.Items.Contains(ar(i)) Then
                cbFisjs.Items.Add(ar(i))
            End If
        Next
    End Sub
    Public Sub cbloadorg()
        cbFisorg.Items.Clear()
        Koneksi()
        Try
            CMd = New OdbcCommand("select panjang from tbl_organisasi order by panjang", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                cbFisorg.Items.Add(Rd("panjang"))
            End While
        Catch ex As Exception
        End Try
        Dim ar(cbFisjs.Items.Count - 1) As Object

        cbFisjs.Items.CopyTo(ar, 0)
        cbFisjs.Items.Clear()

        Dim i As Integer
        For i = 0 To UBound(ar)
            If Not cbFisjs.Items.Contains(ar(i)) Then
                cbFisjs.Items.Add(ar(i))
            End If
        Next
    End Sub
    Private Sub btnFisbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFisbatal.Click
        Call clearfis()

        Me.Close()

    End Sub

    Private Sub btnFistambahjs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFistambahjs.Click
        FormTambah.labelFtjudul.Text = "Menambah Jenis Surat"
        FormTambah.Label1.Text = "Jenis Surat"
        FormTambah.ShowDialog()
    End Sub

    Private Sub btnFistambahorg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFistambahorg.Click
        FormTambah.labelFtjudul.Text = "Menambah Organisasi"
        FormTambah.Label1.Text = "Organisasi"
        FormTambah.ShowDialog()
    End Sub
    Private Sub autonumber()
        '001/SEKDIR/JS/ORG/BULAN/TAHUN
        Dim bln As String
        Dim thn As String
        Dim roma As String
        Dim js As String
        Dim org As String
        bln = Format(Now, "MM")
        thn = Format(Now, "yyyy")
        Select Case Val(bln)
            Case Is = "1"
                roma = "I"
            Case Is = "2"
                roma = "II"
            Case Is = "3"
                roma = "III"
            Case Is = "4"
                roma = "IV"
            Case Is = "5"
                roma = "V"
            Case Is = "6"
                roma = "VI"
            Case Is = "7"
                roma = "VII"
            Case Is = "8"
                roma = "VIII"
            Case Is = "9"
                roma = "IX"
            Case Is = "10"
                roma = "X"
            Case Is = "11"
                roma = "XI"
            Case Is = "12"
                roma = "XII"
        End Select
        'Dim no2 As String
        Koneksi()
        Try
            CMd = New OdbcCommand("select * from tbl_jenissurat", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                If cbFisjs.SelectedItem = Rd("panjang") Then
                    js = Rd("singkat")
                End If
            End While
        Catch ex As Exception
        End Try
        Koneksi()
        Try
            CMd = New OdbcCommand("select * from tbl_organisasi", Conn)
            Rd = CMd.ExecuteReader
            While Rd.Read
                If cbFisorg.SelectedItem = Rd("panjang") Then
                    org = Rd("singkat")
                End If
            End While
        Catch ex As Exception
        End Try
        Try
            Call Koneksi()
            CMd = New OdbcCommand("select * from tbl_nosurat where nosurat like '%-" & js & "%' order by no desc", Conn)
            Rd = CMd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                no1 = "001"
            Else
                no1 = Val(Microsoft.VisualBasic.Mid(Rd.Item("no").ToString, 3)) + 1
                If Len(no1) = 1 Then
                    no1 = "00" & no1 & ""
                ElseIf Len(no1) = 2 Then
                    no1 = "0" & no1 & ""
                End If
            End If
        Catch ex As Exception

        End Try
        Try
            Call Koneksi()
            CMd = New OdbcCommand("select * from tbl_nosurat" & thn & " where nosurat like '%-" & js & "%' order by no desc", Conn)
            Rd = CMd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                no2 = "001"
            Else
                no2 = Val(Microsoft.VisualBasic.Mid(Rd.Item("no").ToString, 3)) + 1
                If Len(no2) = 1 Then
                    no2 = "00" & no2 & ""
                ElseIf Len(no2) = 2 Then
                    no2 = "0" & no2 & ""
                End If
            End If
        Catch ex As Exception

        End Try
        
        labelsurat.Text = "Urutan Surat : " & no1
        labelthn.Text = "Nomor Tahun : " & no2
        txtFisnosurat.Text = "" & no2 & "/" & txtFis1.Text & "-" & js & "-" & org & "/" & roma & "/" & thn & ""
    End Sub
    Private Sub FormInputSurat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFis.Value = Now
        txtFis1.Text = "SEKDIR"
        Call cbloadjs()
        Call cbloadorg()
        txtFisinstansi.Select()
    End Sub


    Private Sub cbFisorg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFisorg.SelectedIndexChanged
        If cbFisorg.Text = "" Or cbFisjs.Text = "" Or txtFis1.Text = "" Then

        Else
            Call autonumber()
            txtFisinstansi.Select()
        End If
    End Sub

    Private Sub cbFisjs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFisjs.SelectedIndexChanged
        If cbFisorg.Text = "" Or cbFisjs.Text = "" Or txtFis1.Text = "" Then

        Else
            Call autonumber()
            txtFisinstansi.Select()
        End If
    End Sub

    Private Sub btnFissimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFissimpan.Click
        If txtFis1.Text = "" Or cbFisjs.Text = "" Or cbFisorg.Text = "" Or txtFisnosurat.Text = "" Or txtFisinstansi.Text = "" Or txtFisketerangan.Text = "" Then
            MsgBox("Isi semua kolom!")
        Else
            Dim tgl As String
            tgl = dtpFis.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim thn As String
            thn = Format(Now, "yyyy")
            Call Koneksi()
            Dim InputData01 As String = "Insert into tbl_nosurat values('" & no1 & "','" & tgl & "','" & txtFisnosurat.Text & "','" & txtFisinstansi.Text & "','" & txtFisketerangan.Text & "')"
            CMd = New OdbcCommand(InputData01, Conn)
            CMd.ExecuteNonQuery()
            Conn.Close()
            Call Koneksi()
            Dim InputData02 As String = "Insert into tbl_nosurat" & thn & " values('" & no2 & "','" & tgl & "','" & txtFisnosurat.Text & "','" & txtFisinstansi.Text & "','" & txtFisketerangan.Text & "')"
            CMd = New OdbcCommand(InputData02, Conn)
            CMd.ExecuteNonQuery()
            MessageBox.Show("Input data nomor surat baru berhasil!", "Input Nomor Surat")
            Call clearfis()
            Me.Close()
            Call FormMenuUtama.refreshfmu()

        End If
    End Sub

    Public Sub ambilnomor()
        Dim no1 As String
        'Dim no2 As String
        Call Koneksi()
        CMd = New OdbcCommand("select * from tbl_nosurat order by no desc", Conn)
        Rd = CMd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            no1 = "001"
        Else
            no1 = Val(Microsoft.VisualBasic.Mid(Rd.Item("no").ToString, 3)) + 1
            If Len(no1) = 1 Then
                no1 = "00" & no1 & ""
            ElseIf Len(no1) = 2 Then
                no1 = "0" & no1 & ""
            End If
        End If
    End Sub
End Class