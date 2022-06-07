<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrganisasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrganisasi))
        Me.dgvFo = New System.Windows.Forms.DataGridView()
        Me.btnFotambah = New System.Windows.Forms.Button()
        Me.btnFokembali = New System.Windows.Forms.Button()
        CType(Me.dgvFo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFo
        '
        Me.dgvFo.AllowUserToAddRows = False
        Me.dgvFo.AllowUserToDeleteRows = False
        Me.dgvFo.BackgroundColor = System.Drawing.Color.White
        Me.dgvFo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFo.Location = New System.Drawing.Point(12, 26)
        Me.dgvFo.Name = "dgvFo"
        Me.dgvFo.RowHeadersVisible = False
        Me.dgvFo.Size = New System.Drawing.Size(290, 150)
        Me.dgvFo.TabIndex = 0
        '
        'btnFotambah
        '
        Me.btnFotambah.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttontambah
        Me.btnFotambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFotambah.Location = New System.Drawing.Point(325, 26)
        Me.btnFotambah.Name = "btnFotambah"
        Me.btnFotambah.Size = New System.Drawing.Size(83, 35)
        Me.btnFotambah.TabIndex = 1
        Me.btnFotambah.Tag = "Tambah"
        Me.btnFotambah.UseVisualStyleBackColor = True
        '
        'btnFokembali
        '
        Me.btnFokembali.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttonkembali
        Me.btnFokembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFokembali.Location = New System.Drawing.Point(325, 141)
        Me.btnFokembali.Name = "btnFokembali"
        Me.btnFokembali.Size = New System.Drawing.Size(83, 35)
        Me.btnFokembali.TabIndex = 2
        Me.btnFokembali.Tag = "Kembali"
        Me.btnFokembali.UseVisualStyleBackColor = True
        '
        'FormOrganisasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.form_js_org
        Me.ClientSize = New System.Drawing.Size(415, 205)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFokembali)
        Me.Controls.Add(Me.btnFotambah)
        Me.Controls.Add(Me.dgvFo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormOrganisasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organisasi"
        CType(Me.dgvFo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvFo As System.Windows.Forms.DataGridView
    Friend WithEvents btnFotambah As System.Windows.Forms.Button
    Friend WithEvents btnFokembali As System.Windows.Forms.Button
End Class
