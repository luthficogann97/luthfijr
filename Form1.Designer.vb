<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Badditem = New System.Windows.Forms.Button()
        Me.CBkendaraan = New System.Windows.Forms.ComboBox()
        Me.CBjeniskendaraan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBmodelkendaraan = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kendaran"
        '
        'Badditem
        '
        Me.Badditem.Location = New System.Drawing.Point(184, 54)
        Me.Badditem.Name = "Badditem"
        Me.Badditem.Size = New System.Drawing.Size(75, 23)
        Me.Badditem.TabIndex = 2
        Me.Badditem.Text = "Add item"
        Me.Badditem.UseVisualStyleBackColor = True
        '
        'CBkendaraan
        '
        Me.CBkendaraan.FormattingEnabled = True
        Me.CBkendaraan.Location = New System.Drawing.Point(15, 54)
        Me.CBkendaraan.Name = "CBkendaraan"
        Me.CBkendaraan.Size = New System.Drawing.Size(163, 21)
        Me.CBkendaraan.TabIndex = 3
        '
        'CBjeniskendaraan
        '
        Me.CBjeniskendaraan.FormattingEnabled = True
        Me.CBjeniskendaraan.Location = New System.Drawing.Point(123, 119)
        Me.CBjeniskendaraan.Name = "CBjeniskendaraan"
        Me.CBjeniskendaraan.Size = New System.Drawing.Size(121, 21)
        Me.CBjeniskendaraan.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Jenis Kendaran"
        '
        'CBmodelkendaraan
        '
        Me.CBmodelkendaraan.FormattingEnabled = True
        Me.CBmodelkendaraan.Location = New System.Drawing.Point(123, 167)
        Me.CBmodelkendaraan.Name = "CBmodelkendaraan"
        Me.CBmodelkendaraan.Size = New System.Drawing.Size(121, 21)
        Me.CBmodelkendaraan.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mobil Kendaraan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CBmodelkendaraan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBjeniskendaraan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBkendaraan)
        Me.Controls.Add(Me.Badditem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Badditem As System.Windows.Forms.Button
    Friend WithEvents CBkendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents CBjeniskendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CBmodelkendaraan As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
