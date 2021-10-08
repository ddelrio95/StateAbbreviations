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
        Me.Button1_virginia = New System.Windows.Forms.Button()
        Me.Button2_northCarolina = New System.Windows.Forms.Button()
        Me.Button3_southcarolina = New System.Windows.Forms.Button()
        Me.Button4_georgia = New System.Windows.Forms.Button()
        Me.Button5_alabama = New System.Windows.Forms.Button()
        Me.Button6_florida = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.ext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1_virginia
        '
        Me.Button1_virginia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1_virginia.Location = New System.Drawing.Point(125, 301)
        Me.Button1_virginia.Name = "Button1_virginia"
        Me.Button1_virginia.Size = New System.Drawing.Size(125, 23)
        Me.Button1_virginia.TabIndex = 0
        Me.Button1_virginia.Text = "Virginia"
        Me.Button1_virginia.UseVisualStyleBackColor = True
        '
        'Button2_northCarolina
        '
        Me.Button2_northCarolina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2_northCarolina.Location = New System.Drawing.Point(357, 301)
        Me.Button2_northCarolina.Name = "Button2_northCarolina"
        Me.Button2_northCarolina.Size = New System.Drawing.Size(130, 23)
        Me.Button2_northCarolina.TabIndex = 1
        Me.Button2_northCarolina.Text = "North Carolina"
        Me.Button2_northCarolina.UseVisualStyleBackColor = True
        '
        'Button3_southcarolina
        '
        Me.Button3_southcarolina.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3_southcarolina.Location = New System.Drawing.Point(591, 301)
        Me.Button3_southcarolina.Name = "Button3_southcarolina"
        Me.Button3_southcarolina.Size = New System.Drawing.Size(124, 23)
        Me.Button3_southcarolina.TabIndex = 2
        Me.Button3_southcarolina.Text = "South Carolina"
        Me.Button3_southcarolina.UseVisualStyleBackColor = True
        '
        'Button4_georgia
        '
        Me.Button4_georgia.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4_georgia.Location = New System.Drawing.Point(125, 356)
        Me.Button4_georgia.Name = "Button4_georgia"
        Me.Button4_georgia.Size = New System.Drawing.Size(125, 23)
        Me.Button4_georgia.TabIndex = 3
        Me.Button4_georgia.Text = "Georgia"
        Me.Button4_georgia.UseVisualStyleBackColor = True
        '
        'Button5_alabama
        '
        Me.Button5_alabama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button5_alabama.Location = New System.Drawing.Point(357, 356)
        Me.Button5_alabama.Name = "Button5_alabama"
        Me.Button5_alabama.Size = New System.Drawing.Size(130, 23)
        Me.Button5_alabama.TabIndex = 4
        Me.Button5_alabama.Text = "Alabama"
        Me.Button5_alabama.UseVisualStyleBackColor = True
        '
        'Button6_florida
        '
        Me.Button6_florida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button6_florida.Location = New System.Drawing.Point(591, 356)
        Me.Button6_florida.Name = "Button6_florida"
        Me.Button6_florida.Size = New System.Drawing.Size(124, 23)
        Me.Button6_florida.TabIndex = 5
        Me.Button6_florida.Text = "Florida"
        Me.Button6_florida.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl.Location = New System.Drawing.Point(357, 146)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 37)
        Me.lbl.TabIndex = 6
        '
        'ext
        '
        Me.ext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ext.ForeColor = System.Drawing.Color.Red
        Me.ext.Location = New System.Drawing.Point(388, 415)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(75, 23)
        Me.ext.TabIndex = 7
        Me.ext.Text = "Exit"
        Me.ext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 450)
        Me.Controls.Add(Me.ext)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Button6_florida)
        Me.Controls.Add(Me.Button5_alabama)
        Me.Controls.Add(Me.Button4_georgia)
        Me.Controls.Add(Me.Button3_southcarolina)
        Me.Controls.Add(Me.Button2_northCarolina)
        Me.Controls.Add(Me.Button1_virginia)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1_virginia As Button
    Friend WithEvents Button2_northCarolina As Button
    Friend WithEvents Button3_southcarolina As Button
    Friend WithEvents Button4_georgia As Button
    Friend WithEvents Button5_alabama As Button
    Friend WithEvents Button6_florida As Button
    Friend WithEvents lbl As Label
    Friend WithEvents ext As Button
End Class
