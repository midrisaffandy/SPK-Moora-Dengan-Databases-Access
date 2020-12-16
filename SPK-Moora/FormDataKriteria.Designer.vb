<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataKriteria
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
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.txtjenis = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbobot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnkeluar
        '
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnkeluar.Location = New System.Drawing.Point(652, 416)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(100, 33)
        Me.btnkeluar.TabIndex = 106
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnbatal.Location = New System.Drawing.Point(406, 131)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(346, 45)
        Me.btnbatal.TabIndex = 105
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnubah.Location = New System.Drawing.Point(17, 131)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(346, 45)
        Me.btnubah.TabIndex = 104
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'txtjenis
        '
        Me.txtjenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenis.FormattingEnabled = True
        Me.txtjenis.Items.AddRange(New Object() {"Cost", "Benefit"})
        Me.txtjenis.Location = New System.Drawing.Point(495, 35)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(257, 28)
        Me.txtjenis.TabIndex = 103
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Jenis"
        '
        'txtbobot
        '
        Me.txtbobot.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbobot.Location = New System.Drawing.Point(495, 69)
        Me.txtbobot.Name = "txtbobot"
        Me.txtbobot.Size = New System.Drawing.Size(83, 26)
        Me.txtbobot.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(394, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Bobot"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(118, 60)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(257, 26)
        Me.txtnama.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nama Kriteria"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 47
        '
        'txtkode
        '
        Me.txtkode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(118, 28)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(83, 26)
        Me.txtkode.TabIndex = 97
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(17, 194)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(735, 205)
        Me.ListView1.TabIndex = 95
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Kode"
        Me.ColumnHeader2.Width = 97
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama Kriteria"
        Me.ColumnHeader3.Width = 233
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Bobot"
        Me.ColumnHeader4.Width = 168
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Jenis"
        Me.ColumnHeader5.Width = 164
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 19)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Kode"
        '
        'FormDataKriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(764, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.txtjenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbobot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FormDataKriteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Kriteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents txtjenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbobot As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
