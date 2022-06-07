Imports System.Data.Odbc
Module Module1
    Public Conn As OdbcConnection
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Dt As DataTable
    Public CMd As OdbcCommand
    Public Rd As OdbcDataReader
    Public MyDB As String

    Public TimeNow As String

    Public no1 As String
    Public no2 As String
    Public Sub Koneksi()
        Try
            MyDB = "Driver={Mysql odbc 3.51 driver};database=dbnomorsurat;server=localhost;uid=root;pwd="
            Conn = New OdbcConnection(MyDB)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            Else
                MsgBox("Koneksi error")
            End If
        Catch ex As Exception
            MsgBox("Error Database")
        End Try
    End Sub

    
End Module
Module Tanggal
    'ubah hari ke bahasa indonesia
    Public Function RubahHari(ByVal hari As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(hari, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function
    Public Function RubahBulan(ByVal bulan As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(Replace(bulan, "January", "Januari"), "Febuary", "Febuari"), "March", "Maret"), "May", "Mei"), "June", "Juni"), "July", "Juli"), "August", "Agustus"), "October", "Oktober"), "November", "NOOOVEEMBER")
    End Function
End Module
