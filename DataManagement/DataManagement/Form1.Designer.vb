<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataManagement))
        Me.lblStory = New System.Windows.Forms.Label()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.radA = New System.Windows.Forms.RadioButton()
        Me.radC = New System.Windows.Forms.RadioButton()
        Me.radD = New System.Windows.Forms.RadioButton()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.picInformation = New System.Windows.Forms.PictureBox()
        Me.picCharacter = New System.Windows.Forms.PictureBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.picFinal = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStory
        '
        Me.lblStory.BackColor = System.Drawing.Color.Transparent
        Me.lblStory.Font = New System.Drawing.Font("Power Red and Blue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStory.Location = New System.Drawing.Point(250, 9)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(735, 220)
        Me.lblStory.TabIndex = 0
        Me.lblStory.Text = resources.GetString("lblStory.Text")
        Me.lblStory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radB
        '
        Me.radB.BackColor = System.Drawing.Color.Transparent
        Me.radB.Font = New System.Drawing.Font("Power Green Small", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radB.ForeColor = System.Drawing.Color.White
        Me.radB.Location = New System.Drawing.Point(290, 464)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(195, 146)
        Me.radB.TabIndex = 2
        Me.radB.TabStop = True
        Me.radB.Text = "4^4"
        Me.radB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radB.UseVisualStyleBackColor = False
        '
        'radA
        '
        Me.radA.BackColor = System.Drawing.Color.Transparent
        Me.radA.Font = New System.Drawing.Font("Power Green Small", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radA.ForeColor = System.Drawing.Color.White
        Me.radA.Location = New System.Drawing.Point(98, 465)
        Me.radA.Name = "radA"
        Me.radA.Size = New System.Drawing.Size(186, 146)
        Me.radA.TabIndex = 1
        Me.radA.TabStop = True
        Me.radA.Text = "4!"
        Me.radA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radA.UseVisualStyleBackColor = False
        '
        'radC
        '
        Me.radC.BackColor = System.Drawing.Color.Transparent
        Me.radC.Font = New System.Drawing.Font("Power Green Small", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radC.ForeColor = System.Drawing.Color.White
        Me.radC.Location = New System.Drawing.Point(491, 464)
        Me.radC.Name = "radC"
        Me.radC.Size = New System.Drawing.Size(214, 146)
        Me.radC.TabIndex = 3
        Me.radC.TabStop = True
        Me.radC.Text = "4*3*2*1"
        Me.radC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radC.UseVisualStyleBackColor = False
        '
        'radD
        '
        Me.radD.BackColor = System.Drawing.Color.Transparent
        Me.radD.Font = New System.Drawing.Font("Power Green Small", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radD.ForeColor = System.Drawing.Color.White
        Me.radD.Location = New System.Drawing.Point(711, 464)
        Me.radD.Name = "radD"
        Me.radD.Size = New System.Drawing.Size(195, 146)
        Me.radD.TabIndex = 4
        Me.radD.TabStop = True
        Me.radD.Text = "A and C"
        Me.radD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radD.UseVisualStyleBackColor = False
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnCheck.Font = New System.Drawing.Font("Power Clear", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(1067, 495)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(140, 95)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check Answer!"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'picInformation
        '
        Me.picInformation.BackColor = System.Drawing.Color.Transparent
        Me.picInformation.Location = New System.Drawing.Point(691, 241)
        Me.picInformation.Name = "picInformation"
        Me.picInformation.Size = New System.Drawing.Size(350, 218)
        Me.picInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picInformation.TabIndex = 7
        Me.picInformation.TabStop = False
        '
        'picCharacter
        '
        Me.picCharacter.BackColor = System.Drawing.Color.Transparent
        Me.picCharacter.Image = Global.DataManagement.My.Resources.Resources._10079856_201444522_1_s1_v1
        Me.picCharacter.Location = New System.Drawing.Point(234, 241)
        Me.picCharacter.Name = "picCharacter"
        Me.picCharacter.Size = New System.Drawing.Size(350, 218)
        Me.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCharacter.TabIndex = 6
        Me.picCharacter.TabStop = False
        '
        'lblFinal
        '
        Me.lblFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblFinal.Font = New System.Drawing.Font("Power Red and Blue", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.ForeColor = System.Drawing.Color.Maroon
        Me.lblFinal.Location = New System.Drawing.Point(37, -34)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(1213, 308)
        Me.lblFinal.TabIndex = 8
        Me.lblFinal.Text = "CONGRATULATIONS!!! YOU HAVE COMPLETED THE STORY. "
        Me.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblFinal.Visible = False
        '
        'picFinal
        '
        Me.picFinal.BackColor = System.Drawing.Color.Transparent
        Me.picFinal.BackgroundImage = Global.DataManagement.My.Resources.Resources.congrats
        Me.picFinal.Location = New System.Drawing.Point(444, 241)
        Me.picFinal.Name = "picFinal"
        Me.picFinal.Size = New System.Drawing.Size(396, 384)
        Me.picFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFinal.TabIndex = 9
        Me.picFinal.TabStop = False
        Me.picFinal.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Power Green", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1067, 494)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 96)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Check Solutions"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'DataManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1271, 622)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picFinal)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.picInformation)
        Me.Controls.Add(Me.picCharacter)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.radD)
        Me.Controls.Add(Me.radC)
        Me.Controls.Add(Me.radA)
        Me.Controls.Add(Me.radB)
        Me.Controls.Add(Me.lblStory)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "DataManagement"
        Me.Text = "Data Management"
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblStory As System.Windows.Forms.Label
    Friend WithEvents radB As System.Windows.Forms.RadioButton
    Friend WithEvents radA As System.Windows.Forms.RadioButton
    Friend WithEvents radC As System.Windows.Forms.RadioButton
    Friend WithEvents radD As System.Windows.Forms.RadioButton
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents picCharacter As System.Windows.Forms.PictureBox
    Friend WithEvents picInformation As System.Windows.Forms.PictureBox
    Friend WithEvents lblFinal As System.Windows.Forms.Label
    Friend WithEvents picFinal As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
