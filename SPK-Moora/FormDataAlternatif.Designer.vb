<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAlternatif
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
        Me.cbjenis = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVKriteria = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.cbefektivitas = New System.Windows.Forms.ComboBox()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbtenaga = New System.Windows.Forms.ComboBox()
        Me.cbpendapatan = New System.Windows.Forms.ComboBox()
        Me.cbkepemimpinan = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtefektivitas = New System.Windows.Forms.TextBox()
        Me.txttenaga = New System.Windows.Forms.TextBox()
        Me.txtkepemimpinan = New System.Windows.Forms.TextBox()
        Me.txtpendapatan = New System.Windows.Forms.TextBox()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbjenis
        '
        Me.cbjenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbjenis.FormattingEnabled = True
        Me.cbjenis.Items.AddRange(New Object() {"Simpan Pinjam", "Peternakan", "Bumdesmart", "Modal Pertanian", "Alat Pesta"})
        Me.cbjenis.Location = New System.Drawing.Point(205, 225)
        Me.cbjenis.Name = "cbjenis"
        Me.cbjenis.Size = New System.Drawing.Size(220, 28)
        Me.cbjenis.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Jenis Usaha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LVKriteria)
        Me.GroupBox1.Location = New System.Drawing.Point(566, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 230)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nilai Kriteria"
        '
        'LVKriteria
        '
        Me.LVKriteria.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11})
        Me.LVKriteria.FullRowSelect = True
        Me.LVKriteria.Location = New System.Drawing.Point(6, 19)
        Me.LVKriteria.Name = "LVKriteria"
        Me.LVKriteria.Size = New System.Drawing.Size(304, 205)
        Me.LVKriteria.TabIndex = 112
        Me.LVKriteria.UseCompatibleStateImageBehavior = False
        Me.LVKriteria.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Nama Kriteria"
        Me.ColumnHeader10.Width = 183
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Bobot"
        Me.ColumnHeader11.Width = 81
        '
        'btnbatal
        '
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.Location = New System.Drawing.Point(133, 278)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(100, 33)
        Me.btnbatal.TabIndex = 160
        Me.btnbatal.Text = "BATAL"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'cbefektivitas
        '
        Me.cbefektivitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbefektivitas.FormattingEnabled = True
        Me.cbefektivitas.Items.AddRange(New Object() {"Sangat Baik", "Baik", "Cukup Baik", "Buruk", "Sangat Buruk"})
        Me.cbefektivitas.Location = New System.Drawing.Point(205, 191)
        Me.cbefektivitas.Name = "cbefektivitas"
        Me.cbefektivitas.Size = New System.Drawing.Size(220, 28)
        Me.cbefektivitas.TabIndex = 158
        '
        'btnkeluar
        '
        Me.btnkeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnkeluar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnkeluar.Location = New System.Drawing.Point(776, 278)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(100, 33)
        Me.btnkeluar.TabIndex = 149
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.Location = New System.Drawing.Point(364, 278)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(100, 33)
        Me.btnhapus.TabIndex = 148
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.Location = New System.Drawing.Point(249, 278)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(100, 33)
        Me.btnubah.TabIndex = 147
        Me.btnubah.Text = "UBAH"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.Location = New System.Drawing.Point(16, 278)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(100, 33)
        Me.btntambah.TabIndex = 146
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Nama"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(205, 57)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(284, 26)
        Me.txtnama.TabIndex = 145
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Id Alternatif"
        '
        'cbtenaga
        '
        Me.cbtenaga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtenaga.FormattingEnabled = True
        Me.cbtenaga.Items.AddRange(New Object() {"Sangat Memadai", "Memadai", "Cukup Memadai", "Kurang Memadai", "Sangat Kurang Memadai"})
        Me.cbtenaga.Location = New System.Drawing.Point(205, 157)
        Me.cbtenaga.Name = "cbtenaga"
        Me.cbtenaga.Size = New System.Drawing.Size(220, 28)
        Me.cbtenaga.TabIndex = 157
        '
        'cbpendapatan
        '
        Me.cbpendapatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpendapatan.FormattingEnabled = True
        Me.cbpendapatan.Items.AddRange(New Object() {">Rp 5.000.000", "≥Rp 4.000.000 – Rp 5.000.000", "≥Rp 3.000.000 – Rp 3.900.000", "≥Rp 2.000.000 – Rp 2.900.000", "< Rp 2.000.000"})
        Me.cbpendapatan.Location = New System.Drawing.Point(205, 123)
        Me.cbpendapatan.Name = "cbpendapatan"
        Me.cbpendapatan.Size = New System.Drawing.Size(220, 28)
        Me.cbpendapatan.TabIndex = 156
        '
        'cbkepemimpinan
        '
        Me.cbkepemimpinan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkepemimpinan.FormattingEnabled = True
        Me.cbkepemimpinan.Items.AddRange(New Object() {"Sangat Baik", "Baik", "Cukup Baik", "Buruk", "Sangat Buruk"})
        Me.cbkepemimpinan.Location = New System.Drawing.Point(205, 89)
        Me.cbkepemimpinan.Name = "cbkepemimpinan"
        Me.cbkepemimpinan.Size = New System.Drawing.Size(220, 28)
        Me.cbkepemimpinan.TabIndex = 155
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 19)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Efektivitas Produk dan Jasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 19)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "Tenaga Kerja"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 19)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Pendapatan"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Pendapatan"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 98
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tenaga kerja"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 128
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Efektivitas Produk dan Jasa"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 158
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 19)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Kepemimpinan"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Kepemimpinan"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Jenis Usaha"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 126
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LV.FullRowSelect = True
        Me.LV.Location = New System.Drawing.Point(12, 326)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(870, 223)
        Me.LV.TabIndex = 150
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No"
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Id"
        Me.ColumnHeader2.Width = 51
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nama"
        Me.ColumnHeader3.Width = 137
        '
        'txtefektivitas
        '
        Me.txtefektivitas.BackColor = System.Drawing.Color.White
        Me.txtefektivitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtefektivitas.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtefektivitas.ForeColor = System.Drawing.Color.Black
        Me.txtefektivitas.Location = New System.Drawing.Point(431, 191)
        Me.txtefektivitas.Multiline = True
        Me.txtefektivitas.Name = "txtefektivitas"
        Me.txtefektivitas.Size = New System.Drawing.Size(58, 28)
        Me.txtefektivitas.TabIndex = 243
        Me.txtefektivitas.Text = "0"
        Me.txtefektivitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttenaga
        '
        Me.txttenaga.BackColor = System.Drawing.Color.White
        Me.txttenaga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttenaga.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenaga.ForeColor = System.Drawing.Color.Black
        Me.txttenaga.Location = New System.Drawing.Point(431, 157)
        Me.txttenaga.Multiline = True
        Me.txttenaga.Name = "txttenaga"
        Me.txttenaga.Size = New System.Drawing.Size(58, 28)
        Me.txttenaga.TabIndex = 240
        Me.txttenaga.Text = "0"
        Me.txttenaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtkepemimpinan
        '
        Me.txtkepemimpinan.BackColor = System.Drawing.Color.White
        Me.txtkepemimpinan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtkepemimpinan.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkepemimpinan.ForeColor = System.Drawing.Color.Black
        Me.txtkepemimpinan.Location = New System.Drawing.Point(431, 89)
        Me.txtkepemimpinan.Multiline = True
        Me.txtkepemimpinan.Name = "txtkepemimpinan"
        Me.txtkepemimpinan.Size = New System.Drawing.Size(58, 31)
        Me.txtkepemimpinan.TabIndex = 242
        Me.txtkepemimpinan.Text = "0"
        Me.txtkepemimpinan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtpendapatan
        '
        Me.txtpendapatan.BackColor = System.Drawing.Color.White
        Me.txtpendapatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpendapatan.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpendapatan.ForeColor = System.Drawing.Color.Black
        Me.txtpendapatan.Location = New System.Drawing.Point(431, 123)
        Me.txtpendapatan.Multiline = True
        Me.txtpendapatan.Name = "txtpendapatan"
        Me.txtpendapatan.Size = New System.Drawing.Size(58, 28)
        Me.txtpendapatan.TabIndex = 241
        Me.txtpendapatan.Text = "0"
        Me.txtpendapatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtjenis
        '
        Me.txtjenis.BackColor = System.Drawing.Color.White
        Me.txtjenis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtjenis.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjenis.ForeColor = System.Drawing.Color.Black
        Me.txtjenis.Location = New System.Drawing.Point(431, 225)
        Me.txtjenis.Multiline = True
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(58, 28)
        Me.txtjenis.TabIndex = 244
        Me.txtjenis.Text = "0"
        Me.txtjenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtcari.Location = New System.Drawing.Point(521, 278)
        Me.txtcari.Multiline = True
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(240, 33)
        Me.txtcari.TabIndex = 246
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(474, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 245
        Me.Label1.Text = "Cari"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(205, 20)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(109, 26)
        Me.txtid.TabIndex = 247
        '
        'FormDataAlternatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(894, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtjenis)
        Me.Controls.Add(Me.txtefektivitas)
        Me.Controls.Add(Me.txttenaga)
        Me.Controls.Add(Me.txtkepemimpinan)
        Me.Controls.Add(Me.txtpendapatan)
        Me.Controls.Add(Me.cbjenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.cbefektivitas)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbtenaga)
        Me.Controls.Add(Me.cbpendapatan)
        Me.Controls.Add(Me.cbkepemimpinan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LV)
        Me.Name = "FormDataAlternatif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPenilaian"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbjenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LVKriteria As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents cbefektivitas As System.Windows.Forms.ComboBox
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbtenaga As System.Windows.Forms.ComboBox
    Friend WithEvents cbpendapatan As System.Windows.Forms.ComboBox
    Friend WithEvents cbkepemimpinan As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtefektivitas As System.Windows.Forms.TextBox
    Friend WithEvents txttenaga As System.Windows.Forms.TextBox
    Friend WithEvents txtkepemimpinan As System.Windows.Forms.TextBox
    Friend WithEvents txtpendapatan As System.Windows.Forms.TextBox
    Friend WithEvents txtjenis As System.Windows.Forms.TextBox
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
End Class
