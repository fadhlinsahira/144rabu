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
        Me.lblNamaHari = New System.Windows.Forms.Label()
        Me.lstjawap = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNamaHari
        '
        Me.lblNamaHari.AutoSize = True
        Me.lblNamaHari.Location = New System.Drawing.Point(472, 68)
        Me.lblNamaHari.Name = "lblNamaHari"
        Me.lblNamaHari.Size = New System.Drawing.Size(51, 17)
        Me.lblNamaHari.TabIndex = 0
        Me.lblNamaHari.Text = "Label1"
        '
        'lstjawap
        '
        Me.lstjawap.FormattingEnabled = True
        Me.lstjawap.ItemHeight = 16
        Me.lstjawap.Location = New System.Drawing.Point(589, 68)
        Me.lstjawap.Name = "lstjawap"
        Me.lstjawap.Size = New System.Drawing.Size(199, 180)
        Me.lstjawap.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(621, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstjawap)
        Me.Controls.Add(Me.lblNamaHari)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNamaHari As Label
    Friend WithEvents lstjawap As ListBox
    Friend WithEvents Button1 As Button
End Class
