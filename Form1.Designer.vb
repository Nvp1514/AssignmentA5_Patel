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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        picComic = New PictureBox()
        lblTitle = New Label()
        lblGroup = New Label()
        txtGroup = New TextBox()
        GroupBox1 = New GroupBox()
        radThree = New RadioButton()
        radTwo = New RadioButton()
        radOne = New RadioButton()
        lblResults = New Label()
        lblCost = New Label()
        btnCal = New Button()
        btnClear = New Button()
        CType(picComic, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' picComic
        ' 
        picComic.Image = CType(resources.GetObject("picComic.Image"), Image)
        picComic.Location = New Point(-1, -1)
        picComic.Name = "picComic"
        picComic.Size = New Size(692, 168)
        picComic.SizeMode = PictureBoxSizeMode.StretchImage
        picComic.TabIndex = 0
        picComic.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Red
        lblTitle.Location = New Point(125, 194)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(478, 34)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Comic Convention Registration "
        ' 
        ' lblGroup
        ' 
        lblGroup.AutoSize = True
        lblGroup.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGroup.ForeColor = Color.Red
        lblGroup.Location = New Point(225, 250)
        lblGroup.Name = "lblGroup"
        lblGroup.Size = New Size(122, 21)
        lblGroup.TabIndex = 2
        lblGroup.Text = "Group Size:"
        ' 
        ' txtGroup
        ' 
        txtGroup.Location = New Point(384, 248)
        txtGroup.Name = "txtGroup"
        txtGroup.Size = New Size(85, 23)
        txtGroup.TabIndex = 3
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DeepSkyBlue
        GroupBox1.Controls.Add(radThree)
        GroupBox1.Controls.Add(radTwo)
        GroupBox1.Controls.Add(radOne)
        GroupBox1.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Red
        GroupBox1.Location = New Point(117, 306)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(486, 140)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Select Badge Type:"
        ' 
        ' radThree
        ' 
        radThree.AutoSize = True
        radThree.Location = New Point(66, 90)
        radThree.Name = "radThree"
        radThree.Size = New Size(146, 25)
        radThree.TabIndex = 2
        radThree.TabStop = True
        radThree.Text = "Convention "
        radThree.UseVisualStyleBackColor = True
        ' 
        ' radTwo
        ' 
        radTwo.AutoSize = True
        radTwo.Location = New Point(66, 59)
        radTwo.Name = "radTwo"
        radTwo.Size = New Size(283, 25)
        radTwo.TabIndex = 1
        radTwo.TabStop = True
        radTwo.Text = "Convention + Autographs "
        radTwo.UseVisualStyleBackColor = True
        ' 
        ' radOne
        ' 
        radOne.AutoSize = True
        radOne.Location = New Point(66, 28)
        radOne.Name = "radOne"
        radOne.Size = New Size(381, 25)
        radOne.TabIndex = 0
        radOne.TabStop = True
        radOne.Text = "Convention + Superhero Experience "
        radOne.UseVisualStyleBackColor = True
        ' 
        ' lblResults
        ' 
        lblResults.AutoSize = True
        lblResults.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResults.ForeColor = Color.Red
        lblResults.Location = New Point(223, 474)
        lblResults.Name = "lblResults"
        lblResults.Size = New Size(191, 21)
        lblResults.TabIndex = 5
        lblResults.Text = "Registration Cost: "
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCost.ForeColor = Color.Red
        lblCost.Location = New Point(420, 474)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(54, 21)
        lblCost.TabIndex = 6
        lblCost.Text = "$000"
        ' 
        ' btnCal
        ' 
        btnCal.BackColor = Color.DeepSkyBlue
        btnCal.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCal.Location = New Point(154, 527)
        btnCal.Name = "btnCal"
        btnCal.Size = New Size(175, 47)
        btnCal.TabIndex = 7
        btnCal.Text = "Calculate"
        btnCal.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DeepSkyBlue
        btnClear.Font = New Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(407, 527)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(175, 47)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(689, 593)
        Controls.Add(btnClear)
        Controls.Add(btnCal)
        Controls.Add(lblCost)
        Controls.Add(lblResults)
        Controls.Add(GroupBox1)
        Controls.Add(txtGroup)
        Controls.Add(lblGroup)
        Controls.Add(lblTitle)
        Controls.Add(picComic)
        Name = "Form1"
        Text = "Comic Convention Registration "
        CType(picComic, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radThree As RadioButton
    Friend WithEvents radTwo As RadioButton
    Friend WithEvents radOne As RadioButton
    Friend WithEvents lblResults As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnCal As Button
    Friend WithEvents btnClear As Button

End Class
