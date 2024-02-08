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
        Label1 = New Label()
        pogi = New TextBox()
        love = New TextBox()
        Label2 = New Label()
        faisol = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 0
        Label1.Text = "txt1"
        ' 
        ' pogi
        ' 
        pogi.Location = New Point(12, 39)
        pogi.Name = "pogi"
        pogi.Size = New Size(100, 23)
        pogi.TabIndex = 1
        ' 
        ' love
        ' 
        love.Location = New Point(12, 149)
        love.Name = "love"
        love.Size = New Size(100, 23)
        love.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 15)
        Label2.TabIndex = 3
        Label2.Text = "txt2"
        ' 
        ' faisol
        ' 
        faisol.AutoSize = True
        faisol.Location = New Point(12, 260)
        faisol.Name = "faisol"
        faisol.Size = New Size(44, 15)
        faisol.TabIndex = 4
        faisol.Text = "answer"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(faisol)
        Controls.Add(Label2)
        Controls.Add(love)
        Controls.Add(pogi)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pogi As TextBox
    Friend WithEvents love As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents faisol As Label
    Friend WithEvents Button1 As Button
End Class
