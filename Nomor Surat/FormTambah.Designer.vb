<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambah))
        Me.txtFtpanjang = New System.Windows.Forms.TextBox()
        Me.txtFtsingkat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelFtjudul = New System.Windows.Forms.Label()
        Me.btnFtsimpan = New System.Windows.Forms.Button()
        Me.btnFtbatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFtpanjang
        '
        Me.txtFtpanjang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFtpanjang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFtpanjang.Location = New System.Drawing.Point(119, 83)
        Me.txtFtpanjang.Name = "txtFtpanjang"
        Me.txtFtpanjang.Size = New System.Drawing.Size(291, 29)
        Me.txtFtpanjang.TabIndex = 0
        '
        'txtFtsingkat
        '
        Me.txtFtsingkat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFtsingkat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFtsingkat.Location = New System.Drawing.Point(119, 131)
        Me.txtFtsingkat.Name = "txtFtsingkat"
        Me.txtFtsingkat.Size = New System.Drawing.Size(113, 29)
        Me.txtFtsingkat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kode"
        '
        'labelFtjudul
        '
        Me.labelFtjudul.AutoSize = True
        Me.labelFtjudul.BackColor = System.Drawing.Color.Transparent
        Me.labelFtjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFtjudul.Location = New System.Drawing.Point(12, 20)
        Me.labelFtjudul.Name = "labelFtjudul"
        Me.labelFtjudul.Size = New System.Drawing.Size(144, 31)
        Me.labelFtjudul.TabIndex = 4
        Me.labelFtjudul.Text = "Tambah ..."
        '
        'btnFtsimpan
        '
        Me.btnFtsimpan.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttonsimpan
        Me.btnFtsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFtsimpan.Location = New System.Drawing.Point(226, 180)
        Me.btnFtsimpan.Name = "btnFtsimpan"
        Me.btnFtsimpan.Size = New System.Drawing.Size(83, 35)
        Me.btnFtsimpan.TabIndex = 5
        Me.btnFtsimpan.Tag = "Simpan"
        Me.btnFtsimpan.UseVisualStyleBackColor = True
        '
        'btnFtbatal
        '
        Me.btnFtbatal.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttonbatal
        Me.btnFtbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFtbatal.Location = New System.Drawing.Point(327, 180)
        Me.btnFtbatal.Name = "btnFtbatal"
        Me.btnFtbatal.Size = New System.Drawing.Size(83, 35)
        Me.btnFtbatal.TabIndex = 6
        Me.btnFtbatal.Tag = "Batal"
        Me.btnFtbatal.UseVisualStyleBackColor = True
        '
        'FormTambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.formtambah
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(422, 241)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFtbatal)
        Me.Controls.Add(Me.btnFtsimpan)
        Me.Controls.Add(Me.labelFtjudul)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFtsingkat)
        Me.Controls.Add(Me.txtFtpanjang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTambah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tambah Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFtpanjang As System.Windows.Forms.TextBox
    Friend WithEvents txtFtsingkat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labelFtjudul As System.Windows.Forms.Label
    Friend WithEvents btnFtsimpan As System.Windows.Forms.Button
    Friend WithEvents btnFtbatal As System.Windows.Forms.Button
End Class
