﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Discordsetting
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBoxToken = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextboxChannel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxToken
        '
        Me.TextBoxToken.Location = New System.Drawing.Point(109, 9)
        Me.TextBoxToken.Name = "TextBoxToken"
        Me.TextBoxToken.Size = New System.Drawing.Size(554, 30)
        Me.TextBoxToken.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Token:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextboxChannel
        '
        Me.TextboxChannel.Location = New System.Drawing.Point(180, 51)
        Me.TextboxChannel.Name = "TextboxChannel"
        Me.TextboxChannel.Size = New System.Drawing.Size(258, 30)
        Me.TextboxChannel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "要廣播的頻道ID:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 41)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "取消"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(560, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 41)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "確認"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Discordsetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 96)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextboxChannel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxToken)
        Me.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Discordsetting"
        Me.Text = "Discordsetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxToken As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextboxChannel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
