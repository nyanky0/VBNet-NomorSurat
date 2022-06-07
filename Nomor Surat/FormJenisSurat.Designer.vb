<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisSurat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJenisSurat))
        Me.dgvFjs = New System.Windows.Forms.DataGridView()
        Me.btnFjstambah = New System.Windows.Forms.Button()
        Me.btnFjskembali = New System.Windows.Forms.Button()
        CType(Me.dgvFjs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvFjs
        '
        Me.dgvFjs.AllowUserToAddRows = False
        Me.dgvFjs.AllowUserToDeleteRows = False
        Me.dgvFjs.BackgroundColor = System.Drawing.Color.White
        Me.dgvFjs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFjs.Location = New System.Drawing.Point(12, 26)
        Me.dgvFjs.Name = "dgvFjs"
        Me.dgvFjs.RowHeadersVisible = False
        Me.dgvFjs.Size = New System.Drawing.Size(290, 150)
        Me.dgvFjs.TabIndex = 0
        '
        'btnFjstambah
        '
        Me.btnFjstambah.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttontambah
        Me.btnFjstambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFjstambah.Location = New System.Drawing.Point(325, 26)
        Me.btnFjstambah.Name = "btnFjstambah"
        Me.btnFjstambah.Size = New System.Drawing.Size(83, 35)
        Me.btnFjstambah.TabIndex = 1
        Me.btnFjstambah.Tag = "Tambah"
        Me.btnFjstambah.UseVisualStyleBackColor = True
        '
        'btnFjskembali
        '
        Me.btnFjskembali.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttonkembali
        Me.btnFjskembali.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFjskembali.Location = New System.Drawing.Point(325, 141)
        Me.btnFjskembali.Name = "btnFjskembali"
        Me.btnFjskembali.Size = New System.Drawing.Size(83, 35)
        Me.btnFjskembali.TabIndex = 2
        Me.btnFjskembali.Tag = "Kembali"
        Me.btnFjskembali.UseVisualStyleBackColor = True
        '
        'FormJenisSurat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.form_js_org
        Me.ClientSize = New System.Drawing.Size(415, 205)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFjskembali)
        Me.Controls.Add(Me.btnFjstambah)
        Me.Controls.Add(Me.dgvFjs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormJenisSurat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jenis Surat"
        CType(Me.dgvFjs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvFjs As System.Windows.Forms.DataGridView
    Friend WithEvents btnFjstambah As System.Windows.Forms.Button
    Friend WithEvents btnFjskembali As System.Windows.Forms.Button
End Class
