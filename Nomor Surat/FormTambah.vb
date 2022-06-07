Imports System.Data.Odbc

Public Class FormTambah
    Private Sub clearisi()
        txtFtpanjang.Text = ""
        txtFtsingkat.Text = ""
    End Sub
    Private Sub btnFtsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFtsimpan.Click
        If txtFtpanjang.Text = "" Or txtFtsingkat.Text = "" Then
            MsgBox("Isi semua kolom!")
        Else
            If labelFtjudul.Text = "Tambah Jenis Surat" Then
                Try
                    Call Koneksi()
                    Dim InputData01 As String = "Insert into tbl_jenissurat values('" & txtFtpanjang.Text & "','" & txtFtsingkat.Text & "')"
                    CMd = New OdbcCommand(InputData01, Conn)
                    CMd.ExecuteNonQuery()
                    MessageBox.Show("Input data jenis surat baru berhasil!", "Input Jenis Surat")
                    Call FormJenisSurat.refreshfjs()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
                FormJenisSurat.refreshfjs()

            ElseIf labelFtjudul.Text = "Tambah Organisasi" Then
                Try
                    Call Koneksi()
                    Dim InputData01 As String = "Insert into tbl_organisasi values('" & txtFtpanjang.Text & "','" & txtFtsingkat.Text & "')"
                    CMd = New OdbcCommand(InputData01, Conn)
                    CMd.ExecuteNonQuery()
                    MessageBox.Show("Input data Organisasi baru berhasil!", "Input Organisasi")
                    Call FormJenisSurat.refreshfjs()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
                FormOrganisasi.refreshfo()
            ElseIf labelFtjudul.Text = "Menambah Jenis Surat" Then
                Try
                    Call Koneksi()
                    Dim InputData01 As String = "Insert into tbl_jenissurat values('" & txtFtpanjang.Text & "','" & txtFtsingkat.Text & "')"
                    CMd = New OdbcCommand(InputData01, Conn)
                    CMd.ExecuteNonQuery()
                    MessageBox.Show("Input data jenis surat baru berhasil!", "Input Jenis Surat")
                    Call FormJenisSurat.refreshfjs()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
                Call FormInputSurat.cbloadjs()
                FormInputSurat.txtFisnosurat.Text = ""


            ElseIf labelFtjudul.Text = "Menambah Organisasi" Then

                Try
                    Call Koneksi()
                    Dim InputData01 As String = "Insert into tbl_organisasi values('" & txtFtpanjang.Text & "','" & txtFtsingkat.Text & "')"
                    CMd = New OdbcCommand(InputData01, Conn)
                    CMd.ExecuteNonQuery()
                    MessageBox.Show("Input data Organisasi baru berhasil!", "Input Organisasi")
                    Call FormJenisSurat.refreshfjs()
                    Me.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
                Call FormInputSurat.cbloadorg()
                FormInputSurat.txtFisnosurat.Text = ""

            End If
            Call clearisi()
            Me.Close()
        End If
        

    End Sub

    Private Sub btnFtbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFtbatal.Click
        Call clearisi()
        Me.Close()
    End Sub

    Private Sub FormTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtFtpanjang.Select()
    End Sub
End Class