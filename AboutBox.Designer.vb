﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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

  Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
  Friend WithEvents LabelProductName As System.Windows.Forms.Label
  Friend WithEvents LabelVersion As System.Windows.Forms.Label
  Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
  Friend WithEvents OKButton As System.Windows.Forms.Button
  Friend WithEvents LabelCopyright As System.Windows.Forms.Label

  'Windows フォーム デザイナーで必要です。
  Private components As System.ComponentModel.IContainer

  'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
  'Windows フォーム デザイナーを使用して変更できます。  
  'コード エディターを使って変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBox))
    Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
    Me.LabelProductName = New System.Windows.Forms.Label()
    Me.LabelVersion = New System.Windows.Forms.Label()
    Me.LabelCopyright = New System.Windows.Forms.Label()
    Me.TextBoxDescription = New System.Windows.Forms.TextBox()
    Me.OKButton = New System.Windows.Forms.Button()
    Me.TableLayoutPanel.SuspendLayout()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TableLayoutPanel
    '
    Me.TableLayoutPanel.ColumnCount = 2
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
    Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
    Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 1, 2)
    Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 3)
    Me.TableLayoutPanel.Controls.Add(Me.OKButton, 1, 4)
    Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel.Location = New System.Drawing.Point(9, 8)
    Me.TableLayoutPanel.Name = "TableLayoutPanel"
    Me.TableLayoutPanel.RowCount = 5
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel.Size = New System.Drawing.Size(396, 239)
    Me.TableLayoutPanel.TabIndex = 0
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
    Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.TableLayoutPanel.SetRowSpan(Me.LogoPictureBox, 5)
    Me.LogoPictureBox.Size = New System.Drawing.Size(124, 233)
    Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
    Me.LogoPictureBox.TabIndex = 0
    Me.LogoPictureBox.TabStop = False
    '
    'LabelProductName
    '
    Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelProductName.Location = New System.Drawing.Point(136, 0)
    Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 16)
    Me.LabelProductName.Name = "LabelProductName"
    Me.LabelProductName.Size = New System.Drawing.Size(257, 16)
    Me.LabelProductName.TabIndex = 0
    Me.LabelProductName.Text = "製品名"
    Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelVersion
    '
    Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelVersion.Location = New System.Drawing.Point(136, 26)
    Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 16)
    Me.LabelVersion.Name = "LabelVersion"
    Me.LabelVersion.Size = New System.Drawing.Size(257, 16)
    Me.LabelVersion.TabIndex = 0
    Me.LabelVersion.Text = "バージョン"
    Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LabelCopyright
    '
    Me.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
    Me.LabelCopyright.Location = New System.Drawing.Point(136, 52)
    Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelCopyright.MaximumSize = New System.Drawing.Size(0, 16)
    Me.LabelCopyright.Name = "LabelCopyright"
    Me.LabelCopyright.Size = New System.Drawing.Size(257, 16)
    Me.LabelCopyright.TabIndex = 0
    Me.LabelCopyright.Text = "著作権"
    Me.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'TextBoxDescription
    '
    Me.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TextBoxDescription.Location = New System.Drawing.Point(136, 81)
    Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
    Me.TextBoxDescription.Multiline = True
    Me.TextBoxDescription.Name = "TextBoxDescription"
    Me.TextBoxDescription.ReadOnly = True
    Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxDescription.Size = New System.Drawing.Size(257, 126)
    Me.TextBoxDescription.TabIndex = 0
    Me.TextBoxDescription.TabStop = False
    Me.TextBoxDescription.Text = "説明 :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(ランタイムに、ラベルのテキストはアプリケーションのアセンブリ情報に置き換えられます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "プロジェクト デザイナーの [アプリケーション] ペイン" &
    "で、アプリケーションのアセンブリ情報をカスタマイズします。)"
    '
    'OKButton
    '
    Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.OKButton.Location = New System.Drawing.Point(318, 215)
    Me.OKButton.Name = "OKButton"
    Me.OKButton.Size = New System.Drawing.Size(75, 21)
    Me.OKButton.TabIndex = 0
    Me.OKButton.Text = "&OK"
    '
    'AboutBox
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.OKButton
    Me.ClientSize = New System.Drawing.Size(414, 255)
    Me.Controls.Add(Me.TableLayoutPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "AboutBox"
    Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "AboutBox"
    Me.TableLayoutPanel.ResumeLayout(False)
    Me.TableLayoutPanel.PerformLayout()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

End Class
