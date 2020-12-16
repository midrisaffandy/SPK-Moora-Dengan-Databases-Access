<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerhitunganMooraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAlternatifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerhitunganMooraToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(126, 46)
        Me.ProsesToolStripMenuItem.Text = "Proses"
        '
        'PerhitunganMooraToolStripMenuItem
        '
        Me.PerhitunganMooraToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PerhitunganMooraToolStripMenuItem.Name = "PerhitunganMooraToolStripMenuItem"
        Me.PerhitunganMooraToolStripMenuItem.Size = New System.Drawing.Size(379, 46)
        Me.PerhitunganMooraToolStripMenuItem.Text = "Perhitungan Moora"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.White
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1040, 50)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataAlternatifToolStripMenuItem, Me.DataKriteriaToolStripMenuItem})
        Me.DataToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(98, 46)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'DataAlternatifToolStripMenuItem
        '
        Me.DataAlternatifToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.DataAlternatifToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataAlternatifToolStripMenuItem.Name = "DataAlternatifToolStripMenuItem"
        Me.DataAlternatifToolStripMenuItem.Size = New System.Drawing.Size(311, 46)
        Me.DataAlternatifToolStripMenuItem.Text = "Data Alternatif"
        '
        'DataKriteriaToolStripMenuItem
        '
        Me.DataKriteriaToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.DataKriteriaToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataKriteriaToolStripMenuItem.Name = "DataKriteriaToolStripMenuItem"
        Me.DataKriteriaToolStripMenuItem.Size = New System.Drawing.Size(311, 46)
        Me.DataKriteriaToolStripMenuItem.Text = "Data Kriteria"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(131, 46)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 39)
        Me.Label1.TabIndex = 7
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(174, 322)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1089, 84)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Sistem Pendukung Keputusan Dengan Menggunkan Metode " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MOORA (Multi-Objective Opti" & _
            "mization on The Basis of Ratio)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1040, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.DoubleBuffered = True
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerhitunganMooraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataAlternatifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
