<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.components = New System.ComponentModel.Container()
        Me.txtGissa = New System.Windows.Forms.TextBox()
        Me.lblOrd = New System.Windows.Forms.Label()
        Me.btnHoppa = New System.Windows.Forms.Button()
        Me.btnKontroll = New System.Windows.Forms.Button()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.lblPoang = New System.Windows.Forms.Label()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lblTid = New System.Windows.Forms.Label()
        Me.lblInfo3 = New System.Windows.Forms.Label()
        Me.lblGrans = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnAvsluta = New System.Windows.Forms.Button()
        Me.timTid = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtGissa
        '
        Me.txtGissa.Location = New System.Drawing.Point(13, 32)
        Me.txtGissa.Name = "txtGissa"
        Me.txtGissa.Size = New System.Drawing.Size(100, 20)
        Me.txtGissa.TabIndex = 0
        '
        'lblOrd
        '
        Me.lblOrd.AutoSize = True
        Me.lblOrd.Location = New System.Drawing.Point(13, 13)
        Me.lblOrd.Name = "lblOrd"
        Me.lblOrd.Size = New System.Drawing.Size(0, 13)
        Me.lblOrd.TabIndex = 1
        Me.lblOrd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnHoppa
        '
        Me.btnHoppa.Enabled = False
        Me.btnHoppa.Location = New System.Drawing.Point(16, 58)
        Me.btnHoppa.Name = "btnHoppa"
        Me.btnHoppa.Size = New System.Drawing.Size(97, 40)
        Me.btnHoppa.TabIndex = 2
        Me.btnHoppa.Text = "&Hoppa över"
        Me.btnHoppa.UseVisualStyleBackColor = True
        '
        'btnKontroll
        '
        Me.btnKontroll.Enabled = False
        Me.btnKontroll.Location = New System.Drawing.Point(16, 105)
        Me.btnKontroll.Name = "btnKontroll"
        Me.btnKontroll.Size = New System.Drawing.Size(97, 23)
        Me.btnKontroll.TabIndex = 3
        Me.btnKontroll.Text = "&Kontroll"
        Me.btnKontroll.UseVisualStyleBackColor = True
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo1.Location = New System.Drawing.Point(149, 13)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(40, 15)
        Me.lblInfo1.TabIndex = 4
        Me.lblInfo1.Text = "Poäng"
        Me.lblInfo1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPoang
        '
        Me.lblPoang.AutoSize = True
        Me.lblPoang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPoang.Location = New System.Drawing.Point(149, 32)
        Me.lblPoang.Name = "lblPoang"
        Me.lblPoang.Size = New System.Drawing.Size(15, 15)
        Me.lblPoang.TabIndex = 5
        Me.lblPoang.Text = "0"
        Me.lblPoang.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo2.Location = New System.Drawing.Point(220, 13)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(24, 15)
        Me.lblInfo2.TabIndex = 6
        Me.lblInfo2.Text = "Tid"
        Me.lblInfo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTid
        '
        Me.lblTid.AutoSize = True
        Me.lblTid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTid.Location = New System.Drawing.Point(220, 32)
        Me.lblTid.Name = "lblTid"
        Me.lblTid.Size = New System.Drawing.Size(15, 15)
        Me.lblTid.TabIndex = 7
        Me.lblTid.Text = "0"
        Me.lblTid.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInfo3
        '
        Me.lblInfo3.AutoSize = True
        Me.lblInfo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo3.Location = New System.Drawing.Point(124, 58)
        Me.lblInfo3.Name = "lblInfo3"
        Me.lblInfo3.Size = New System.Drawing.Size(65, 15)
        Me.lblInfo3.TabIndex = 8
        Me.lblInfo3.Text = "Bonusgräns"
        '
        'lblGrans
        '
        Me.lblGrans.AutoSize = True
        Me.lblGrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrans.Location = New System.Drawing.Point(149, 83)
        Me.lblGrans.Name = "lblGrans"
        Me.lblGrans.Size = New System.Drawing.Size(21, 15)
        Me.lblGrans.TabIndex = 9
        Me.lblGrans.Text = "20"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(220, 58)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 40)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnAvsluta
        '
        Me.btnAvsluta.Location = New System.Drawing.Point(220, 104)
        Me.btnAvsluta.Name = "btnAvsluta"
        Me.btnAvsluta.Size = New System.Drawing.Size(75, 23)
        Me.btnAvsluta.TabIndex = 11
        Me.btnAvsluta.Text = "&Avsluta"
        Me.btnAvsluta.UseVisualStyleBackColor = True
        '
        'timTid
        '
        Me.timTid.Interval = 1000
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 138)
        Me.Controls.Add(Me.btnAvsluta)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblGrans)
        Me.Controls.Add(Me.lblInfo3)
        Me.Controls.Add(Me.lblTid)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.lblPoang)
        Me.Controls.Add(Me.lblInfo1)
        Me.Controls.Add(Me.btnKontroll)
        Me.Controls.Add(Me.btnHoppa)
        Me.Controls.Add(Me.lblOrd)
        Me.Controls.Add(Me.txtGissa)
        Me.Name = "formMain"
        Me.Text = "Ordlek"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGissa As System.Windows.Forms.TextBox
    Friend WithEvents lblOrd As System.Windows.Forms.Label
    Friend WithEvents btnHoppa As System.Windows.Forms.Button
    Friend WithEvents btnKontroll As System.Windows.Forms.Button
    Friend WithEvents lblInfo1 As System.Windows.Forms.Label
    Friend WithEvents lblPoang As System.Windows.Forms.Label
    Friend WithEvents lblInfo2 As System.Windows.Forms.Label
    Friend WithEvents lblTid As System.Windows.Forms.Label
    Friend WithEvents lblInfo3 As System.Windows.Forms.Label
    Friend WithEvents lblGrans As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnAvsluta As System.Windows.Forms.Button
    Friend WithEvents timTid As System.Windows.Forms.Timer

End Class
