<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Pnl1 = New System.Windows.Forms.Panel()
        Me.Rdo12 = New System.Windows.Forms.RadioButton()
        Me.Rdo11 = New System.Windows.Forms.RadioButton()
        Me.Pnl2 = New System.Windows.Forms.Panel()
        Me.Rdo22 = New System.Windows.Forms.RadioButton()
        Me.Rdo21 = New System.Windows.Forms.RadioButton()
        Me.PnlBody1 = New System.Windows.Forms.Panel()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.PnlBody2 = New System.Windows.Forms.Panel()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.Pnl1.SuspendLayout()
        Me.Pnl2.SuspendLayout()
        Me.PnlBody1.SuspendLayout()
        Me.PnlBody2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl1
        '
        Me.Pnl1.Controls.Add(Me.Rdo12)
        Me.Pnl1.Controls.Add(Me.Rdo11)
        Me.Pnl1.Location = New System.Drawing.Point(33, 41)
        Me.Pnl1.Name = "Pnl1"
        Me.Pnl1.Size = New System.Drawing.Size(172, 78)
        Me.Pnl1.TabIndex = 0
        '
        'Rdo12
        '
        Me.Rdo12.AutoSize = True
        Me.Rdo12.Location = New System.Drawing.Point(86, 26)
        Me.Rdo12.Name = "Rdo12"
        Me.Rdo12.Size = New System.Drawing.Size(65, 28)
        Me.Rdo12.TabIndex = 1
        Me.Rdo12.Text = "有"
        Me.Rdo12.UseVisualStyleBackColor = True
        '
        'Rdo11
        '
        Me.Rdo11.AutoSize = True
        Me.Rdo11.Checked = True
        Me.Rdo11.Location = New System.Drawing.Point(15, 26)
        Me.Rdo11.Name = "Rdo11"
        Me.Rdo11.Size = New System.Drawing.Size(65, 28)
        Me.Rdo11.TabIndex = 0
        Me.Rdo11.TabStop = True
        Me.Rdo11.Text = "無"
        Me.Rdo11.UseVisualStyleBackColor = True
        '
        'Pnl2
        '
        Me.Pnl2.Controls.Add(Me.Rdo22)
        Me.Pnl2.Controls.Add(Me.Rdo21)
        Me.Pnl2.Location = New System.Drawing.Point(33, 168)
        Me.Pnl2.Name = "Pnl2"
        Me.Pnl2.Size = New System.Drawing.Size(172, 78)
        Me.Pnl2.TabIndex = 2
        '
        'Rdo22
        '
        Me.Rdo22.AutoSize = True
        Me.Rdo22.Location = New System.Drawing.Point(86, 26)
        Me.Rdo22.Name = "Rdo22"
        Me.Rdo22.Size = New System.Drawing.Size(65, 28)
        Me.Rdo22.TabIndex = 1
        Me.Rdo22.Text = "有"
        Me.Rdo22.UseVisualStyleBackColor = True
        '
        'Rdo21
        '
        Me.Rdo21.AutoSize = True
        Me.Rdo21.Checked = True
        Me.Rdo21.Location = New System.Drawing.Point(15, 26)
        Me.Rdo21.Name = "Rdo21"
        Me.Rdo21.Size = New System.Drawing.Size(65, 28)
        Me.Rdo21.TabIndex = 0
        Me.Rdo21.TabStop = True
        Me.Rdo21.Text = "無"
        Me.Rdo21.UseVisualStyleBackColor = True
        '
        'PnlBody1
        '
        Me.PnlBody1.Controls.Add(Me.cmbSize)
        Me.PnlBody1.Controls.Add(Me.Txt1)
        Me.PnlBody1.Location = New System.Drawing.Point(243, 41)
        Me.PnlBody1.Name = "PnlBody1"
        Me.PnlBody1.Size = New System.Drawing.Size(369, 81)
        Me.PnlBody1.TabIndex = 1
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(25, 26)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 31)
        Me.Txt1.TabIndex = 0
        '
        'PnlBody2
        '
        Me.PnlBody2.Controls.Add(Me.Txt2)
        Me.PnlBody2.Location = New System.Drawing.Point(243, 165)
        Me.PnlBody2.Name = "PnlBody2"
        Me.PnlBody2.Size = New System.Drawing.Size(200, 81)
        Me.PnlBody2.TabIndex = 3
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(25, 26)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 31)
        Me.Txt2.TabIndex = 0
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Location = New System.Drawing.Point(166, 26)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(167, 32)
        Me.cmbSize.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 450)
        Me.Controls.Add(Me.PnlBody2)
        Me.Controls.Add(Me.PnlBody1)
        Me.Controls.Add(Me.Pnl2)
        Me.Controls.Add(Me.Pnl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Pnl1.ResumeLayout(False)
        Me.Pnl1.PerformLayout()
        Me.Pnl2.ResumeLayout(False)
        Me.Pnl2.PerformLayout()
        Me.PnlBody1.ResumeLayout(False)
        Me.PnlBody1.PerformLayout()
        Me.PnlBody2.ResumeLayout(False)
        Me.PnlBody2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl1 As Panel
    Friend WithEvents Rdo12 As RadioButton
    Friend WithEvents Rdo11 As RadioButton
    Friend WithEvents Pnl2 As Panel
    Friend WithEvents Rdo22 As RadioButton
    Friend WithEvents Rdo21 As RadioButton
    Friend WithEvents PnlBody1 As Panel
    Friend WithEvents Txt1 As TextBox
    Friend WithEvents PnlBody2 As Panel
    Friend WithEvents Txt2 As TextBox
    Friend WithEvents cmbSize As ComboBox
End Class
