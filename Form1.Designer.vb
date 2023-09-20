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
        txtID = New TextBox()
        txtVerify = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter ID"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(400, 64)
        txtID.Name = "txtID"
        txtID.Size = New Size(150, 31)
        txtID.TabIndex = 1
        ' 
        ' txtVerify
        ' 
        txtVerify.Location = New Point(156, 189)
        txtVerify.Name = "txtVerify"
        txtVerify.Size = New Size(112, 34)
        txtVerify.TabIndex = 2
        txtVerify.Text = "Verify"
        txtVerify.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtVerify)
        Controls.Add(txtID)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtVerify As Button
End Class
