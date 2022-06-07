<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.checkFr = New System.Windows.Forms.CheckBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New Nomor_Surat.CrystalReport1()
        Me.pnlFrblnthn = New System.Windows.Forms.Panel()
        Me.Labelthn = New System.Windows.Forms.Label()
        Me.Labelbln = New System.Windows.Forms.Label()
        Me.nudFrthn = New System.Windows.Forms.NumericUpDown()
        Me.cbFrbln = New System.Windows.Forms.ComboBox()
        Me.pnlFrtgl = New System.Windows.Forms.Panel()
        Me.dtpFr = New System.Windows.Forms.DateTimePicker()
        Me.pnlFrcb = New System.Windows.Forms.Panel()
        Me.cbFr = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFrcari = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbFrnosurat = New System.Windows.Forms.RadioButton()
        Me.rbFrthn = New System.Windows.Forms.RadioButton()
        Me.rbFrbln = New System.Windows.Forms.RadioButton()
        Me.rbFrorg = New System.Windows.Forms.RadioButton()
        Me.rbFrjs = New System.Windows.Forms.RadioButton()
        Me.rbFrdtp = New System.Windows.Forms.RadioButton()
        Me.pnlFrblnthn.SuspendLayout()
        CType(Me.nudFrthn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFrtgl.SuspendLayout()
        Me.pnlFrcb.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkFr
        '
        Me.checkFr.AutoSize = True
        Me.checkFr.Location = New System.Drawing.Point(503, 12)
        Me.checkFr.Name = "checkFr"
        Me.checkFr.Size = New System.Drawing.Size(141, 17)
        Me.checkFr.TabIndex = 5
        Me.checkFr.Text = "Sembunyikan Parameter"
        Me.checkFr.UseVisualStyleBackColor = True
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1098, 460)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'pnlFrblnthn
        '
        Me.pnlFrblnthn.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.form_js_org
        Me.pnlFrblnthn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlFrblnthn.Controls.Add(Me.Labelthn)
        Me.pnlFrblnthn.Controls.Add(Me.Labelbln)
        Me.pnlFrblnthn.Controls.Add(Me.nudFrthn)
        Me.pnlFrblnthn.Controls.Add(Me.cbFrbln)
        Me.pnlFrblnthn.Location = New System.Drawing.Point(0, 245)
        Me.pnlFrblnthn.Name = "pnlFrblnthn"
        Me.pnlFrblnthn.Size = New System.Drawing.Size(201, 68)
        Me.pnlFrblnthn.TabIndex = 4
        '
        'Labelthn
        '
        Me.Labelthn.AutoSize = True
        Me.Labelthn.BackColor = System.Drawing.Color.Transparent
        Me.Labelthn.Location = New System.Drawing.Point(132, 12)
        Me.Labelthn.Name = "Labelthn"
        Me.Labelthn.Size = New System.Drawing.Size(45, 13)
        Me.Labelthn.TabIndex = 3
        Me.Labelthn.Text = "TAHUN"
        '
        'Labelbln
        '
        Me.Labelbln.AutoSize = True
        Me.Labelbln.BackColor = System.Drawing.Color.Transparent
        Me.Labelbln.Location = New System.Drawing.Point(3, 12)
        Me.Labelbln.Name = "Labelbln"
        Me.Labelbln.Size = New System.Drawing.Size(43, 13)
        Me.Labelbln.TabIndex = 2
        Me.Labelbln.Text = "BULAN"
        '
        'nudFrthn
        '
        Me.nudFrthn.Location = New System.Drawing.Point(135, 31)
        Me.nudFrthn.Name = "nudFrthn"
        Me.nudFrthn.Size = New System.Drawing.Size(60, 20)
        Me.nudFrthn.TabIndex = 1
        '
        'cbFrbln
        '
        Me.cbFrbln.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrbln.FormattingEnabled = True
        Me.cbFrbln.Location = New System.Drawing.Point(4, 30)
        Me.cbFrbln.Name = "cbFrbln"
        Me.cbFrbln.Size = New System.Drawing.Size(102, 21)
        Me.cbFrbln.TabIndex = 0
        '
        'pnlFrtgl
        '
        Me.pnlFrtgl.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.form_js_org
        Me.pnlFrtgl.Controls.Add(Me.dtpFr)
        Me.pnlFrtgl.Location = New System.Drawing.Point(0, 248)
        Me.pnlFrtgl.Name = "pnlFrtgl"
        Me.pnlFrtgl.Size = New System.Drawing.Size(201, 53)
        Me.pnlFrtgl.TabIndex = 2
        '
        'dtpFr
        '
        Me.dtpFr.Location = New System.Drawing.Point(3, 15)
        Me.dtpFr.Name = "dtpFr"
        Me.dtpFr.Size = New System.Drawing.Size(195, 20)
        Me.dtpFr.TabIndex = 0
        '
        'pnlFrcb
        '
        Me.pnlFrcb.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.form_js_org
        Me.pnlFrcb.Controls.Add(Me.cbFr)
        Me.pnlFrcb.Location = New System.Drawing.Point(0, 263)
        Me.pnlFrcb.Name = "pnlFrcb"
        Me.pnlFrcb.Size = New System.Drawing.Size(201, 53)
        Me.pnlFrcb.TabIndex = 3
        '
        'cbFr
        '
        Me.cbFr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFr.FormattingEnabled = True
        Me.cbFr.Location = New System.Drawing.Point(4, 17)
        Me.cbFr.Name = "cbFr"
        Me.cbFr.Size = New System.Drawing.Size(191, 21)
        Me.cbFr.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.forminputsurat
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.btnFrcari)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 213)
        Me.Panel1.TabIndex = 1
        '
        'btnFrcari
        '
        Me.btnFrcari.BackgroundImage = Global.Nomor_Surat.My.Resources.Resources.buttoncari
        Me.btnFrcari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFrcari.Location = New System.Drawing.Point(102, 170)
        Me.btnFrcari.Name = "btnFrcari"
        Me.btnFrcari.Size = New System.Drawing.Size(83, 35)
        Me.btnFrcari.TabIndex = 1
        Me.btnFrcari.Tag = "Cari"
        Me.btnFrcari.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rbFrnosurat)
        Me.GroupBox1.Controls.Add(Me.rbFrthn)
        Me.GroupBox1.Controls.Add(Me.rbFrbln)
        Me.GroupBox1.Controls.Add(Me.rbFrorg)
        Me.GroupBox1.Controls.Add(Me.rbFrjs)
        Me.GroupBox1.Controls.Add(Me.rbFrdtp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'rbFrnosurat
        '
        Me.rbFrnosurat.AutoSize = True
        Me.rbFrnosurat.Location = New System.Drawing.Point(19, 134)
        Me.rbFrnosurat.Name = "rbFrnosurat"
        Me.rbFrnosurat.Size = New System.Drawing.Size(106, 17)
        Me.rbFrnosurat.TabIndex = 5
        Me.rbFrnosurat.TabStop = True
        Me.rbFrnosurat.Text = "NOMOR SURAT"
        Me.rbFrnosurat.UseVisualStyleBackColor = True
        '
        'rbFrthn
        '
        Me.rbFrthn.AutoSize = True
        Me.rbFrthn.Location = New System.Drawing.Point(19, 111)
        Me.rbFrthn.Name = "rbFrthn"
        Me.rbFrthn.Size = New System.Drawing.Size(63, 17)
        Me.rbFrthn.TabIndex = 4
        Me.rbFrthn.TabStop = True
        Me.rbFrthn.Text = "TAHUN"
        Me.rbFrthn.UseVisualStyleBackColor = True
        '
        'rbFrbln
        '
        Me.rbFrbln.AutoSize = True
        Me.rbFrbln.Location = New System.Drawing.Point(19, 88)
        Me.rbFrbln.Name = "rbFrbln"
        Me.rbFrbln.Size = New System.Drawing.Size(61, 17)
        Me.rbFrbln.TabIndex = 3
        Me.rbFrbln.TabStop = True
        Me.rbFrbln.Text = "BULAN"
        Me.rbFrbln.UseVisualStyleBackColor = True
        '
        'rbFrorg
        '
        Me.rbFrorg.AutoSize = True
        Me.rbFrorg.Location = New System.Drawing.Point(19, 65)
        Me.rbFrorg.Name = "rbFrorg"
        Me.rbFrorg.Size = New System.Drawing.Size(91, 17)
        Me.rbFrorg.TabIndex = 2
        Me.rbFrorg.TabStop = True
        Me.rbFrorg.Text = "ORGANISASI"
        Me.rbFrorg.UseVisualStyleBackColor = True
        '
        'rbFrjs
        '
        Me.rbFrjs.AutoSize = True
        Me.rbFrjs.Location = New System.Drawing.Point(19, 42)
        Me.rbFrjs.Name = "rbFrjs"
        Me.rbFrjs.Size = New System.Drawing.Size(95, 17)
        Me.rbFrjs.TabIndex = 1
        Me.rbFrjs.TabStop = True
        Me.rbFrjs.Text = "JENIS SURAT"
        Me.rbFrjs.UseVisualStyleBackColor = True
        '
        'rbFrdtp
        '
        Me.rbFrdtp.AutoSize = True
        Me.rbFrdtp.Location = New System.Drawing.Point(19, 19)
        Me.rbFrdtp.Name = "rbFrdtp"
        Me.rbFrdtp.Size = New System.Drawing.Size(76, 17)
        Me.rbFrdtp.TabIndex = 0
        Me.rbFrdtp.TabStop = True
        Me.rbFrdtp.Text = "TANGGAL"
        Me.rbFrdtp.UseVisualStyleBackColor = True
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 460)
        Me.Controls.Add(Me.checkFr)
        Me.Controls.Add(Me.pnlFrblnthn)
        Me.Controls.Add(Me.pnlFrtgl)
        Me.Controls.Add(Me.pnlFrcb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Nomor Surat"
        Me.pnlFrblnthn.ResumeLayout(False)
        Me.pnlFrblnthn.PerformLayout()
        CType(Me.nudFrthn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFrtgl.ResumeLayout(False)
        Me.pnlFrcb.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As Nomor_Surat.CrystalReport1
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnFrcari As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbFrnosurat As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrthn As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrbln As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrorg As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrjs As System.Windows.Forms.RadioButton
    Friend WithEvents rbFrdtp As System.Windows.Forms.RadioButton
    Friend WithEvents pnlFrtgl As System.Windows.Forms.Panel
    Friend WithEvents dtpFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlFrcb As System.Windows.Forms.Panel
    Friend WithEvents cbFr As System.Windows.Forms.ComboBox
    Friend WithEvents pnlFrblnthn As System.Windows.Forms.Panel
    Friend WithEvents Labelthn As System.Windows.Forms.Label
    Friend WithEvents Labelbln As System.Windows.Forms.Label
    Friend WithEvents nudFrthn As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbFrbln As System.Windows.Forms.ComboBox
    Friend WithEvents checkFr As System.Windows.Forms.CheckBox
End Class
