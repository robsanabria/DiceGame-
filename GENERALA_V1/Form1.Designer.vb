<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cubilete = New System.Windows.Forms.PictureBox()
        Me.Dado = New System.Windows.Forms.PictureBox()
        Me.Dado2 = New System.Windows.Forms.PictureBox()
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cubilete
        '
        Me.Cubilete.BackColor = System.Drawing.Color.Transparent
        Me.Cubilete.Location = New System.Drawing.Point(505, 45)
        Me.Cubilete.Name = "Cubilete"
        Me.Cubilete.Size = New System.Drawing.Size(267, 219)
        Me.Cubilete.TabIndex = 1
        Me.Cubilete.TabStop = False
        '
        'Dado
        '
        Me.Dado.BackgroundImage = Global.GENERALA_V1.My.Resources.Resources.dado6
        Me.Dado.Location = New System.Drawing.Point(154, 326)
        Me.Dado.Name = "Dado"
        Me.Dado.Size = New System.Drawing.Size(92, 97)
        Me.Dado.TabIndex = 2
        Me.Dado.TabStop = False
        '
        'Dado2
        '
        Me.Dado2.Image = Global.GENERALA_V1.My.Resources.Resources.dado2
        Me.Dado2.Location = New System.Drawing.Point(380, 326)
        Me.Dado2.Name = "Dado2"
        Me.Dado2.Size = New System.Drawing.Size(90, 97)
        Me.Dado2.TabIndex = 3
        Me.Dado2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GENERALA_V1.My.Resources.Resources.mesa
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.Controls.Add(Me.Dado2)
        Me.Controls.Add(Me.Dado)
        Me.Controls.Add(Me.Cubilete)
        Me.Name = "Form1"
        Me.Text = "Apretene el cubilete para tirar los dados"
        CType(Me.Cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cubilete As PictureBox
    Friend WithEvents Dado As PictureBox
    Friend WithEvents Dado2 As PictureBox
End Class
