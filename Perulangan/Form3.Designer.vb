<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TextBoxMatrik1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxOperasi = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxMatrik2 = New System.Windows.Forms.TextBox()
        Me.Proses = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'TextBoxMatrik1
        '
        Me.TextBoxMatrik1.Location = New System.Drawing.Point(66, 30)
        Me.TextBoxMatrik1.Multiline = True
        Me.TextBoxMatrik1.Name = "TextBoxMatrik1"
        Me.TextBoxMatrik1.Size = New System.Drawing.Size(363, 73)
        Me.TextBoxMatrik1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'ComboBoxOperasi
        '
        Me.ComboBoxOperasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxOperasi.FormattingEnabled = True
        Me.ComboBoxOperasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.ComboBoxOperasi.Location = New System.Drawing.Point(66, 126)
        Me.ComboBoxOperasi.Name = "ComboBoxOperasi"
        Me.ComboBoxOperasi.Size = New System.Drawing.Size(363, 21)
        Me.ComboBoxOperasi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'TextBoxMatrik2
        '
        Me.TextBoxMatrik2.Location = New System.Drawing.Point(66, 164)
        Me.TextBoxMatrik2.Multiline = True
        Me.TextBoxMatrik2.Name = "TextBoxMatrik2"
        Me.TextBoxMatrik2.Size = New System.Drawing.Size(363, 82)
        Me.TextBoxMatrik2.TabIndex = 5
        '
        'Proses
        '
        Me.Proses.Location = New System.Drawing.Point(314, 361)
        Me.Proses.Name = "Proses"
        Me.Proses.Size = New System.Drawing.Size(95, 29)
        Me.Proses.TabIndex = 6
        Me.Proses.Text = "Proses"
        Me.Proses.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'TextBoxHasil
        '
        Me.TextBoxHasil.Location = New System.Drawing.Point(66, 257)
        Me.TextBoxHasil.Multiline = True
        Me.TextBoxHasil.Name = "TextBoxHasil"
        Me.TextBoxHasil.Size = New System.Drawing.Size(363, 88)
        Me.TextBoxHasil.TabIndex = 9
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.TextBoxHasil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Proses)
        Me.Controls.Add(Me.TextBoxMatrik2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxOperasi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxMatrik1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMatrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxOperasi As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMatrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Proses As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxHasil As System.Windows.Forms.TextBox
End Class
