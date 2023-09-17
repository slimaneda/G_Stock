<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSetting
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        txt_code = New TextBox()
        btn_cancel = New Button()
        btn_save = New Button()
        Label3 = New Label()
        txt_selling = New TextBox()
        Label7 = New Label()
        txt_purchasing = New TextBox()
        Label10 = New Label()
        txt_name = New TextBox()
        GroupBox2 = New GroupBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label6 = New Label()
        TextBox4 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txt_code)
        GroupBox1.Controls.Add(btn_cancel)
        GroupBox1.Controls.Add(btn_save)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txt_selling)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txt_purchasing)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txt_name)
        GroupBox1.Location = New Point(15, 17)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(437, 315)
        GroupBox1.TabIndex = 136
        GroupBox1.TabStop = False
        GroupBox1.Text = "Print link info"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(104, 160, 235)
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(10, 43)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 23)
        Label4.TabIndex = 9
        Label4.Text = "Code item :"
        ' 
        ' txt_code
        ' 
        txt_code.BackColor = SystemColors.Window
        txt_code.Enabled = False
        txt_code.Location = New Point(141, 43)
        txt_code.Margin = New Padding(4)
        txt_code.Multiline = True
        txt_code.Name = "txt_code"
        txt_code.Size = New Size(102, 31)
        txt_code.TabIndex = 8
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.Red
        btn_cancel.Location = New Point(221, 241)
        btn_cancel.Margin = New Padding(4)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(149, 49)
        btn_cancel.TabIndex = 7
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Location = New Point(41, 241)
        btn_save.Margin = New Padding(4)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(149, 49)
        btn_save.TabIndex = 6
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(104, 160, 235)
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(10, 183)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(179, 31)
        Label3.TabIndex = 5
        Label3.Text = "Selling price :" + vbCrLf
        ' 
        ' txt_selling
        ' 
        txt_selling.BackColor = SystemColors.Window
        txt_selling.Location = New Point(193, 182)
        txt_selling.Margin = New Padding(4)
        txt_selling.Multiline = True
        txt_selling.Name = "txt_selling"
        txt_selling.Size = New Size(238, 31)
        txt_selling.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(104, 160, 235)
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(10, 134)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 23)
        Label7.TabIndex = 3
        Label7.Text = "Purchasing price :"
        ' 
        ' txt_purchasing
        ' 
        txt_purchasing.BackColor = SystemColors.Window
        txt_purchasing.Location = New Point(198, 133)
        txt_purchasing.Margin = New Padding(4)
        txt_purchasing.Multiline = True
        txt_purchasing.Name = "txt_purchasing"
        txt_purchasing.Size = New Size(230, 31)
        txt_purchasing.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(104, 160, 235)
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = SystemColors.ControlLightLight
        Label10.Location = New Point(10, 90)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 23)
        Label10.TabIndex = 1
        Label10.Text = "Name :"
        ' 
        ' txt_name
        ' 
        txt_name.BackColor = SystemColors.Window
        txt_name.Cursor = Cursors.IBeam
        txt_name.Location = New Point(102, 90)
        txt_name.Margin = New Padding(4)
        txt_name.Multiline = True
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(327, 31)
        txt_name.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(CheckBox5)
        GroupBox2.Controls.Add(CheckBox4)
        GroupBox2.Controls.Add(CheckBox3)
        GroupBox2.Controls.Add(CheckBox2)
        GroupBox2.Controls.Add(CheckBox1)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Location = New Point(480, 17)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(433, 315)
        GroupBox2.TabIndex = 137
        GroupBox2.TabStop = False
        GroupBox2.Text = "Users information"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox5.Location = New Point(77, 199)
        CheckBox5.Margin = New Padding(4)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(88, 24)
        CheckBox5.TabIndex = 14
        CheckBox5.Text = "the Sales"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox4.Location = New Point(291, 144)
        CheckBox4.Margin = New Padding(4)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(93, 24)
        CheckBox4.TabIndex = 13
        CheckBox4.Text = "Customer"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox3.Location = New Point(221, 199)
        CheckBox3.Margin = New Padding(4)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(76, 24)
        CheckBox3.TabIndex = 12
        CheckBox3.Text = "Setting"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox2.Location = New Point(141, 146)
        CheckBox2.Margin = New Padding(4)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(91, 24)
        CheckBox2.TabIndex = 11
        CheckBox2.Text = "New Sale"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBox1.Location = New Point(8, 143)
        CheckBox1.Margin = New Padding(4)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(77, 24)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Assetes"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(104, 160, 235)
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(10, 43)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 9
        Label1.Text = "User name :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Window
        TextBox1.Enabled = False
        TextBox1.Location = New Point(141, 43)
        TextBox1.Margin = New Padding(4)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(287, 31)
        TextBox1.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LimeGreen
        Button2.Location = New Point(10, 258)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(400, 49)
        Button2.TabIndex = 6
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(104, 160, 235)
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(10, 90)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 23)
        Label6.TabIndex = 1
        Label6.Text = "Password  :"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Window
        TextBox4.Cursor = Cursors.IBeam
        TextBox4.Location = New Point(141, 90)
        TextBox4.Margin = New Padding(4)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(287, 31)
        TextBox4.TabIndex = 0
        ' 
        ' FSetting
        ' 
        AutoScaleDimensions = New SizeF(9.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 641)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(5, 4, 5, 4)
        Name = "FSetting"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmcalc"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_selling As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_purchasing As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
End Class
