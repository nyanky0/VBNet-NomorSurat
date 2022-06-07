<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputSuratBaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenisSuratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganisasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanNomorSuratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvFmu = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFmucari = New System.Windows.Forms.Button()
        Me.nudFmu = New System.Windows.Forms.NumericUpDown()
        Me.cbFmu = New System.Windows.Forms.ComboBox()
        Me.txtFmubox = New System.Windows.Forms.TextBox()
        Me.dtpFmu = New System.Windows.Forms.DateTimePicker()
        Me.cbFmufilter = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.labeltgl = New System.Windows.Forms.Label()
        Me.Timerwaktu = New System.Windows.Forms.Timer(Me.components)
        Me.labeljam = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvFmu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudFmu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.DataToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(728, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputSuratBaruToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'InputSuratBaruToolStripMenuItem
        '
        Me.InputSuratBaruToolStripMenuItem.Name = "InputSuratBaruToolStripMenuItem"
        Me.InputSuratBaruToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.InputSuratBaruToolStripMenuItem.Text = "Input Surat Baru"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JenisSuratToolStripMenuItem, Me.OrganisasiToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'JenisSuratToolStripMenuItem
        '
        Me.JenisSuratToolStripMenuItem.Name = "JenisSuratToolStripMenuItem"
        Me.JenisSuratToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.JenisSuratToolStripMenuItem.Text = "Jenis Surat"
        '
        'OrganisasiToolStripMenuItem
        '
        Me.OrganisasiToolStripMenuItem.Name = "OrganisasiToolStripMenuItem"
        Me.OrganisasiToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.OrganisasiToolStripMenuItem.Text = "Organisasi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanNomorSuratToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanNomorSuratToolStripMenuItem
        '
        Me.LaporanNomorSuratToolStripMenuItem.Name = "LaporanNomorSuratToolStripMenuItem"
        Me.LaporanNomorSuratToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LaporanNomorSuratToolStripMenuItem.Text = "Laporan Nomor Surat"
        '
        'dgvFmu
        '
        Me.dgvFmu.AllowUserToAddRows = False
        Me.dgvFmu.AllowUserToDeleteRows = False
        Me.dgvFmu.BackgroundColor = System.Drawing.Color.White
        Me.dgvFmu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFmu.Location = New System.Drawing.Point(15, 114)
        Me.dgvFmu.Name = "dgvFmu"
        Me.dgvFmu.RowHeadersVisible = False
        Me.dgvFmu.Size = New System.Drawing.Size(695, 246)
        Me.dgvFmu.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnFmucari)
        Me.GroupBox1.Controls.Add(Me.nudFmu)
        Me.GroupBox1.Controls.Add(Me.cbFmu)
        Me.GroupBox1.Controls.Add(Me.txtFmubox)
        Me.GroupBox1.Controls.Add(Me.dtpFmu)
        Me.GroupBox1.Controls.Add(Me.cbFmufilter)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 81)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'btnFmucari
        '
        Me.btnFmucari.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttoncari
        Me.btnFmucari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFmucari.Location = New System.Drawing.Point(133, 46)
        Me.btnFmucari.Name = "btnFmucari"
        Me.btnFmucari.Size = New System.Drawing.Size(83, 35)
        Me.btnFmucari.TabIndex = 6
        Me.btnFmucari.Tag = "Cari"
        Me.btnFmucari.UseVisualStyleBackColor = True
        '
        'nudFmu
        '
        Me.nudFmu.Location = New System.Drawing.Point(133, 19)
        Me.nudFmu.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
        Me.nudFmu.Minimum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.nudFmu.Name = "nudFmu"
        Me.nudFmu.Size = New System.Drawing.Size(62, 20)
        Me.nudFmu.TabIndex = 5
        Me.nudFmu.Value = New Decimal(New Integer() {2020, 0, 0, 0})
        '
        'cbFmu
        '
        Me.cbFmu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFmu.FormattingEnabled = True
        Me.cbFmu.Location = New System.Drawing.Point(133, 18)
        Me.cbFmu.Name = "cbFmu"
        Me.cbFmu.Size = New System.Drawing.Size(215, 21)
        Me.cbFmu.TabIndex = 4
        '
        'txtFmubox
        '
        Me.txtFmubox.Location = New System.Drawing.Point(133, 20)
        Me.txtFmubox.Name = "txtFmubox"
        Me.txtFmubox.Size = New System.Drawing.Size(206, 20)
        Me.txtFmubox.TabIndex = 2
        '
        'dtpFmu
        '
        Me.dtpFmu.Location = New System.Drawing.Point(133, 19)
        Me.dtpFmu.Name = "dtpFmu"
        Me.dtpFmu.Size = New System.Drawing.Size(200, 20)
        Me.dtpFmu.TabIndex = 1
        '
        'cbFmufilter
        '
        Me.cbFmufilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFmufilter.FormattingEnabled = True
        Me.cbFmufilter.Location = New System.Drawing.Point(9, 19)
        Me.cbFmufilter.Name = "cbFmufilter"
        Me.cbFmufilter.Size = New System.Drawing.Size(121, 21)
        Me.cbFmufilter.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.KOP_SURAT_4g
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(344, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 106)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'labeltgl
        '
        Me.labeltgl.BackColor = System.Drawing.Color.Transparent
        Me.labeltgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltgl.Location = New System.Drawing.Point(502, 68)
        Me.labeltgl.Name = "labeltgl"
        Me.labeltgl.Size = New System.Drawing.Size(182, 22)
        Me.labeltgl.TabIndex = 4
        Me.labeltgl.Text = "dddd, dd MMMM yyyy"
        Me.labeltgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timerwaktu
        '
        Me.Timerwaktu.Enabled = True
        '
        'labeljam
        '
        Me.labeljam.BackColor = System.Drawing.Color.Transparent
        Me.labeljam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeljam.Location = New System.Drawing.Point(537, 92)
        Me.labeljam.Name = "labeljam"
        Me.labeljam.Size = New System.Drawing.Size(112, 20)
        Me.labeljam.TabIndex = 5
        Me.labeljam.Text = "00.00.00 MM"
        Me.labeljam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.logominus
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(703, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 6
        Me.Button1.Tag = "Minimize"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.formmenu
        Me.ClientSize = New System.Drawing.Size(728, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.labeljam)
        Me.Controls.Add(Me.labeltgl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvFmu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nomor Surat Rumah Sakit Onkologi Solo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvFmu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudFmu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputSuratBaruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JenisSuratToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrganisasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvFmu As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFmu As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbFmufilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtFmubox As System.Windows.Forms.TextBox
    Friend WithEvents cbFmu As System.Windows.Forms.ComboBox
    Friend WithEvents nudFmu As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnFmucari As System.Windows.Forms.Button
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanNomorSuratToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents labeltgl As System.Windows.Forms.Label
    Friend WithEvents Timerwaktu As System.Windows.Forms.Timer
    Friend WithEvents labeljam As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
