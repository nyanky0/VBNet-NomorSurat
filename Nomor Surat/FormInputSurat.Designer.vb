<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputSurat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputSurat))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFisnosurat = New System.Windows.Forms.TextBox()
        Me.txtFisinstansi = New System.Windows.Forms.TextBox()
        Me.txtFisketerangan = New System.Windows.Forms.TextBox()
        Me.cbFisjs = New System.Windows.Forms.ComboBox()
        Me.cbFisorg = New System.Windows.Forms.ComboBox()
        Me.dtpFis = New System.Windows.Forms.DateTimePicker()
        Me.btnFissimpan = New System.Windows.Forms.Button()
        Me.btnFisbatal = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFistambahjs = New System.Windows.Forms.Button()
        Me.btnFistambahorg = New System.Windows.Forms.Button()
        Me.txtFis1 = New System.Windows.Forms.TextBox()
        Me.labelthn = New System.Windows.Forms.Label()
        Me.labelsurat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Surat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Instansi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Surat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Organisasi"
        '
        'txtFisnosurat
        '
        Me.txtFisnosurat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFisnosurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFisnosurat.Location = New System.Drawing.Point(137, 196)
        Me.txtFisnosurat.Name = "txtFisnosurat"
        Me.txtFisnosurat.ReadOnly = True
        Me.txtFisnosurat.Size = New System.Drawing.Size(312, 23)
        Me.txtFisnosurat.TabIndex = 7
        '
        'txtFisinstansi
        '
        Me.txtFisinstansi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFisinstansi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFisinstansi.Location = New System.Drawing.Point(137, 225)
        Me.txtFisinstansi.Name = "txtFisinstansi"
        Me.txtFisinstansi.Size = New System.Drawing.Size(200, 23)
        Me.txtFisinstansi.TabIndex = 8
        '
        'txtFisketerangan
        '
        Me.txtFisketerangan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFisketerangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFisketerangan.Location = New System.Drawing.Point(137, 257)
        Me.txtFisketerangan.Multiline = True
        Me.txtFisketerangan.Name = "txtFisketerangan"
        Me.txtFisketerangan.Size = New System.Drawing.Size(312, 116)
        Me.txtFisketerangan.TabIndex = 9
        '
        'cbFisjs
        '
        Me.cbFisjs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFisjs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFisjs.FormattingEnabled = True
        Me.cbFisjs.Location = New System.Drawing.Point(137, 133)
        Me.cbFisjs.Name = "cbFisjs"
        Me.cbFisjs.Size = New System.Drawing.Size(229, 24)
        Me.cbFisjs.TabIndex = 10
        '
        'cbFisorg
        '
        Me.cbFisorg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFisorg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFisorg.FormattingEnabled = True
        Me.cbFisorg.Location = New System.Drawing.Point(137, 166)
        Me.cbFisorg.Name = "cbFisorg"
        Me.cbFisorg.Size = New System.Drawing.Size(229, 24)
        Me.cbFisorg.TabIndex = 11
        '
        'dtpFis
        '
        Me.dtpFis.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFis.Location = New System.Drawing.Point(137, 73)
        Me.dtpFis.Name = "dtpFis"
        Me.dtpFis.Size = New System.Drawing.Size(211, 23)
        Me.dtpFis.TabIndex = 12
        '
        'btnFissimpan
        '
        Me.btnFissimpan.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttonsimpan
        Me.btnFissimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFissimpan.Location = New System.Drawing.Point(265, 395)
        Me.btnFissimpan.Name = "btnFissimpan"
        Me.btnFissimpan.Size = New System.Drawing.Size(83, 35)
        Me.btnFissimpan.TabIndex = 13
        Me.btnFissimpan.Tag = "Simpan"
        Me.btnFissimpan.UseVisualStyleBackColor = True
        '
        'btnFisbatal
        '
        Me.btnFisbatal.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttonbatal
        Me.btnFisbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFisbatal.Location = New System.Drawing.Point(366, 395)
        Me.btnFisbatal.Name = "btnFisbatal"
        Me.btnFisbatal.Size = New System.Drawing.Size(83, 35)
        Me.btnFisbatal.TabIndex = 14
        Me.btnFisbatal.Tag = "Batal"
        Me.btnFisbatal.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 26)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Input Surat Baru"
        '
        'btnFistambahjs
        '
        Me.btnFistambahjs.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.logoplus
        Me.btnFistambahjs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFistambahjs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFistambahjs.Location = New System.Drawing.Point(400, 129)
        Me.btnFistambahjs.Name = "btnFistambahjs"
        Me.btnFistambahjs.Size = New System.Drawing.Size(28, 28)
        Me.btnFistambahjs.TabIndex = 16
        Me.btnFistambahjs.Tag = "+"
        Me.btnFistambahjs.UseVisualStyleBackColor = True
        '
        'btnFistambahorg
        '
        Me.btnFistambahorg.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.logoplus
        Me.btnFistambahorg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFistambahorg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFistambahorg.Location = New System.Drawing.Point(400, 162)
        Me.btnFistambahorg.Name = "btnFistambahorg"
        Me.btnFistambahorg.Size = New System.Drawing.Size(28, 28)
        Me.btnFistambahorg.TabIndex = 17
        Me.btnFistambahorg.Tag = "+"
        Me.btnFistambahorg.UseVisualStyleBackColor = True
        '
        'txtFis1
        '
        Me.txtFis1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFis1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFis1.Location = New System.Drawing.Point(137, 102)
        Me.txtFis1.Name = "txtFis1"
        Me.txtFis1.Size = New System.Drawing.Size(141, 23)
        Me.txtFis1.TabIndex = 18
        '
        'labelthn
        '
        Me.labelthn.AutoSize = True
        Me.labelthn.BackColor = System.Drawing.Color.Transparent
        Me.labelthn.Location = New System.Drawing.Point(342, 22)
        Me.labelthn.Name = "labelthn"
        Me.labelthn.Size = New System.Drawing.Size(78, 13)
        Me.labelthn.TabIndex = 19
        Me.labelthn.Text = "Nomor Tahun :"
        '
        'labelsurat
        '
        Me.labelsurat.AutoSize = True
        Me.labelsurat.BackColor = System.Drawing.Color.Transparent
        Me.labelsurat.Location = New System.Drawing.Point(347, 9)
        Me.labelsurat.Name = "labelsurat"
        Me.labelsurat.Size = New System.Drawing.Size(73, 13)
        Me.labelsurat.TabIndex = 20
        Me.labelsurat.Text = "Urutan Surat :"
        '
        'FormInputSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.forminputsurat
        Me.ClientSize = New System.Drawing.Size(481, 435)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelsurat)
        Me.Controls.Add(Me.labelthn)
        Me.Controls.Add(Me.txtFis1)
        Me.Controls.Add(Me.btnFistambahorg)
        Me.Controls.Add(Me.btnFistambahjs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnFisbatal)
        Me.Controls.Add(Me.btnFissimpan)
        Me.Controls.Add(Me.dtpFis)
        Me.Controls.Add(Me.cbFisorg)
        Me.Controls.Add(Me.cbFisjs)
        Me.Controls.Add(Me.txtFisketerangan)
        Me.Controls.Add(Me.txtFisinstansi)
        Me.Controls.Add(Me.txtFisnosurat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(487, 464)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(487, 464)
        Me.Name = "FormInputSurat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Surat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFisnosurat As System.Windows.Forms.TextBox
    Friend WithEvents txtFisinstansi As System.Windows.Forms.TextBox
    Friend WithEvents txtFisketerangan As System.Windows.Forms.TextBox
    Friend WithEvents cbFisjs As System.Windows.Forms.ComboBox
    Friend WithEvents cbFisorg As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFis As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFissimpan As System.Windows.Forms.Button
    Friend WithEvents btnFisbatal As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnFistambahjs As System.Windows.Forms.Button
    Friend WithEvents btnFistambahorg As System.Windows.Forms.Button
    Friend WithEvents txtFis1 As System.Windows.Forms.TextBox
    Friend WithEvents labelthn As System.Windows.Forms.Label
    Friend WithEvents labelsurat As System.Windows.Forms.Label
End Class
