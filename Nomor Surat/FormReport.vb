Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization
Public Class FormReport

    Public Sub loadheader()
        Dim txtCr1 As TextObject
        Dim txtCr2 As TextObject
        Dim dtp As String
        txtCr1 = CrystalReport11.ReportDefinition.ReportObjects("txtCr1")
        txtCr2 = CrystalReport11.ReportDefinition.ReportObjects("txtCr2")
        If rbFrdtp.Checked = True Then
            txtCr1.Text = rbFrdtp.Text
            dtp = dtpFr.Value.ToString("dddd, dd MMMM yyyy")
            txtCr2.Text = dtp
        ElseIf rbFrjs.Checked = True Then
            txtCr1.Text = rbFrjs.Text
            txtCr2.Text = cbFr.SelectedItem
        ElseIf rbFrorg.Checked = True Then
            txtCr1.Text = rbFrorg.Text
            txtCr2.Text = cbFr.SelectedItem
        ElseIf rbFrbln.Checked = True Then
            txtCr1.Text = rbFrbln.Text
            txtCr2.Text = cbFrbln.SelectedItem & " " & nudFrthn.Text
        ElseIf rbFrthn.Checked = True Then
            txtCr1.Text = rbFrthn.Text
            txtCr2.Text = nudFrthn.Text
        ElseIf rbFrnosurat.Checked = True Then
            txtCr1.Text = rbFrnosurat.Text
            txtCr2.Text = cbFr.SelectedItem
        End If
    End Sub
    Private Sub btnFrcari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFrcari.Click
        Try
            If rbFrdtp.Checked = True Then
                Dim caridtp As String
                caridtp = dtpFr.Value.ToString("yyyy-MM-dd")
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_nosurat where tanggal like '%" & caridtp & "%' ", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                CrystalReport11.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = CrystalReport11
                Call loadheader()
                CrystalReportViewer1.RefreshReport()
            ElseIf rbFrjs.Checked = True Then
                Dim js As String
                Try
                    Koneksi()
                    CMd = New OdbcCommand("select * from tbl_jenissurat", Conn)
                    Rd = CMd.ExecuteReader
                    While Rd.Read
                        If cbFr.SelectedItem = Rd("panjang") Then
                            js = Rd("singkat")
                        End If
                    End While
                Catch ex As Exception
                End Try
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%" & js & "%' ", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                CrystalReport11.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = CrystalReport11
                Call loadheader()
                CrystalReportViewer1.RefreshReport()
            ElseIf rbFrorg.Checked = True Then
                Dim org As String
                Try
                    Koneksi()
                    CMd = New OdbcCommand("select * from tbl_organisasi", Conn)
                    Rd = CMd.ExecuteReader
                    While Rd.Read
                        If cbFr.SelectedItem = Rd("panjang") Then
                            org = Rd("singkat")
                        End If
                    End While
                Catch ex As Exception
                End Try
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_nosurat where nosurat like '%" & org & "%' ", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                CrystalReport11.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = CrystalReport11
                Call loadheader()
                CrystalReportViewer1.RefreshReport()
            ElseIf rbFrbln.Checked = True Then
                Dim tahun As String
                Dim bln1 As String
                Dim bulan = DateTime.ParseExact("" & cbFrbln.Text & "", "MMMM", CultureInfo.CurrentCulture).Month
                tahun = nudFrthn.Text
                If bulan >= 10 Then
                    bln1 = "" & tahun & "-" & bulan & ""
                Else
                    bln1 = "" & tahun & "-0" & bulan & ""
                End If
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_nosurat where tanggal like '%" & bln1 & "%' ", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                CrystalReport11.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = CrystalReport11
                Call loadheader()
                CrystalReportViewer1.RefreshReport()
            ElseIf rbFrthn.Checked = True Then
                Dim tahun As String
                tahun = nudFrthn.Text
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_nosurat where tanggal like '%" & tahun & "%' ", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                CrystalReport11.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = CrystalReport11
                Call loadheader()
                CrystalReportViewer1.RefreshReport()
            ElseIf rbFrnosurat.Checked = True Then
                Koneksi()
                Dim da As New OdbcDataAdapter("select * from tbl_nosurat where nosurat='" & cbFr.Text & "'", Conn)
                Dim dt As New DataTable
                da.Fill(dt)
                CrystalReport11.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = CrystalReport11
                Call loadheader()
                CrystalReportViewer1.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox("Filter Error")
        End Try
        
    End Sub

    Private Sub rbFrdtp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrdtp.CheckedChanged
        If rbFrdtp.Checked = True Then
            pnlFrcb.Visible = False
            pnlFrblnthn.Visible = False
            pnlFrtgl.Visible = True
            dtpFr.Value = Now
        End If
    End Sub

    Private Sub rbFrjs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrjs.CheckedChanged
        If rbFrjs.Checked = True Then
            pnlFrcb.Visible = True
            pnlFrblnthn.Visible = False
            pnlFrtgl.Visible = False
            cbFr.Items.Clear()
            Koneksi()
            Try
                CMd = New OdbcCommand("select panjang from tbl_jenissurat order by panjang", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    cbFr.Items.Add(Rd("panjang"))
                End While
            Catch ex As Exception
            End Try
            Dim ar(cbFr.Items.Count - 1) As Object
            cbFr.Items.CopyTo(ar, 0)
            cbFr.Items.Clear()
            Dim i As Integer
            For i = 0 To UBound(ar)
                If Not cbFr.Items.Contains(ar(i)) Then
                    cbFr.Items.Add(ar(i))
                End If
            Next
        End If
    End Sub

    Private Sub rbFrorg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrorg.CheckedChanged
        If rbFrorg.Checked = True Then
            pnlFrcb.Visible = True
            pnlFrblnthn.Visible = False
            pnlFrtgl.Visible = False
            cbFr.Items.Clear()
            Koneksi()
            Try
                CMd = New OdbcCommand("select panjang from tbl_organisasi order by panjang", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    cbFr.Items.Add(Rd("panjang"))
                End While
            Catch ex As Exception
            End Try
            Dim ar(cbFr.Items.Count - 1) As Object
            cbFr.Items.CopyTo(ar, 0)
            cbFr.Items.Clear()
            Dim i As Integer
            For i = 0 To UBound(ar)
                If Not cbFr.Items.Contains(ar(i)) Then
                    cbFr.Items.Add(ar(i))
                End If
            Next
        End If
    End Sub

    Private Sub rbFrbln_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrbln.CheckedChanged
        If rbFrbln.Checked = True Then
            pnlFrcb.Visible = False
            pnlFrblnthn.Visible = True
            pnlFrtgl.Visible = False
            Labelbln.Visible = True
            cbFrbln.Visible = True
            cbFrbln.Items.Clear()
            For a As Integer = 0 To 11
                Dim b As DateTime
                cbFrbln.Items.Add(Format(b.AddMonths(a), "MMMM").ToUpper())
            Next
            cbFrbln.SelectedIndex = DateTime.Now.Month - 1
            nudFrthn.Minimum = 2015
            nudFrthn.Maximum = DateTime.Now.Year + 2
            nudFrthn.Text = DateTime.Now.Year
            'MsgBox(cbFrbln.SelectedItem)
        End If
    End Sub

    Private Sub rbFrthn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrthn.CheckedChanged
        If rbFrthn.Checked = True Then
            pnlFrcb.Visible = False
            pnlFrblnthn.Visible = True
            pnlFrtgl.Visible = False
            Labelbln.Visible = False
            cbFrbln.Visible = False
            nudFrthn.Minimum = 2015
            nudFrthn.Maximum = DateTime.Now.Year + 2
            nudFrthn.Text = DateTime.Now.Year
        End If
    End Sub

    Private Sub rbFrnosurat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFrnosurat.CheckedChanged
        If rbFrnosurat.Checked = True Then
            pnlFrcb.Visible = True
            pnlFrblnthn.Visible = False
            pnlFrtgl.Visible = False
            cbFr.Items.Clear()
            Koneksi()
            Try
                CMd = New OdbcCommand("select nosurat from tbl_nosurat order by nosurat", Conn)
                Rd = CMd.ExecuteReader
                While Rd.Read
                    cbFr.Items.Add(Rd("nosurat"))
                End While
            Catch ex As Exception
            End Try
            Dim ar(cbFr.Items.Count - 1) As Object
            cbFr.Items.CopyTo(ar, 0)
            cbFr.Items.Clear()
            Dim i As Integer
            For i = 0 To UBound(ar)
                If Not cbFr.Items.Contains(ar(i)) Then
                    cbFr.Items.Add(ar(i))
                End If
            Next
        End If
    End Sub

    Private Sub checkFr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFr.CheckedChanged
        If checkFr.Checked = True Then
            Panel1.Visible = False
            pnlFrtgl.Visible = False
            pnlFrcb.Visible = False
            pnlFrblnthn.Visible = False
        Else
            Panel1.Visible = True
            rbFrdtp.Checked = False
            rbFrjs.Checked = False
            rbFrorg.Checked = False
            rbFrbln.Checked = False
            rbFrthn.Checked = False
            rbFrnosurat.Checked = False
        End If
    End Sub

    Private Sub FormReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        pnlFrtgl.Visible = False
        pnlFrcb.Visible = False
        pnlFrblnthn.Visible = False
    End Sub
End Class