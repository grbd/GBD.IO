﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDialog1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SerialPortConsoleCtrl1 = New Examples.PortTest1.App.SerialPortCtrl()
        Me.SerialPortConsoleCtrl2 = New Examples.PortTest1.App.SerialPortCtrl()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(621, 425)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SerialPortConsoleCtrl1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(613, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Serial Port 1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SerialPortConsoleCtrl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(613, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Serial Port 2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SerialPortConsoleCtrl1
        '
        Me.SerialPortConsoleCtrl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerialPortConsoleCtrl1.Location = New System.Drawing.Point(3, 3)
        Me.SerialPortConsoleCtrl1.Name = "SerialPortConsoleCtrl1"
        Me.SerialPortConsoleCtrl1.SPort = Nothing
        Me.SerialPortConsoleCtrl1.Size = New System.Drawing.Size(604, 390)
        Me.SerialPortConsoleCtrl1.TabIndex = 0
        '
        'SerialPortConsoleCtrl2
        '
        Me.SerialPortConsoleCtrl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SerialPortConsoleCtrl2.Location = New System.Drawing.Point(3, 3)
        Me.SerialPortConsoleCtrl2.Name = "SerialPortConsoleCtrl2"
        Me.SerialPortConsoleCtrl2.SPort = Nothing
        Me.SerialPortConsoleCtrl2.Size = New System.Drawing.Size(604, 390)
        Me.SerialPortConsoleCtrl2.TabIndex = 0
        '
        'MainDialog1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 442)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "MainDialog1"
        Me.Text = "Serial Port Test1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SerialPortConsoleCtrl1 As Examples.PortTest1.App.SerialPortCtrl
    Friend WithEvents SerialPortConsoleCtrl2 As Examples.PortTest1.App.SerialPortCtrl

End Class
