<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Depts
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        DGV1 = New DataGridView()
        Label6 = New Label()
        TextBox3 = New TextBox()
        btn_save = New Button()
        GroupBox2 = New GroupBox()
        DGV2 = New DataGridView()
        Label7 = New Label()
        TextBox5 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DGV1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(btn_save)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(332, 558)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item info"
        ' 
        ' DGV1
        ' 
        DGV1.AccessibleRole = AccessibleRole.None
        DGV1.AllowUserToAddRows = False
        DGV1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle1.ForeColor = Color.White
        DGV1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV1.BackgroundColor = SystemColors.Control
        DGV1.BorderStyle = BorderStyle.None
        DGV1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DGV1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DGV1.DefaultCellStyle = DataGridViewCellStyle3
        DGV1.Dock = DockStyle.Bottom
        DGV1.EditMode = DataGridViewEditMode.EditOnKeystroke
        DGV1.EnableHeadersVisualStyles = False
        DGV1.GridColor = SystemColors.ActiveCaption
        DGV1.Location = New Point(3, 142)
        DGV1.MultiSelect = False
        DGV1.Name = "DGV1"
        DGV1.ReadOnly = True
        DGV1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV1.RowHeadersVisible = False
        DGV1.RowTemplate.Height = 25
        DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV1.Size = New Size(326, 413)
        DGV1.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(8, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 23)
        Label6.TabIndex = 13
        Label6.Text = "Code Fact :"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Control
        TextBox3.Location = New Point(107, 43)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(64, 23)
        TextBox3.TabIndex = 12
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Location = New Point(6, 82)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(323, 35)
        btn_save.TabIndex = 6
        btn_save.Text = "View all sales"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DGV2)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(DateTimePicker1)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Location = New Point(350, 24)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(670, 546)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Item info"
        ' 
        ' DGV2
        ' 
        DGV2.AccessibleRole = AccessibleRole.None
        DGV2.AllowUserToAddRows = False
        DGV2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle4.ForeColor = Color.White
        DGV2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DGV2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV2.BackgroundColor = SystemColors.Control
        DGV2.BorderStyle = BorderStyle.None
        DGV2.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DGV2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DGV2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        DGV2.DefaultCellStyle = DataGridViewCellStyle6
        DGV2.Dock = DockStyle.Bottom
        DGV2.EditMode = DataGridViewEditMode.EditOnKeystroke
        DGV2.EnableHeadersVisualStyles = False
        DGV2.GridColor = SystemColors.ActiveCaption
        DGV2.Location = New Point(3, 130)
        DGV2.MultiSelect = False
        DGV2.Name = "DGV2"
        DGV2.ReadOnly = True
        DGV2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV2.RowHeadersVisible = False
        DGV2.RowTemplate.Height = 25
        DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV2.Size = New Size(664, 413)
        DGV2.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(14, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 23)
        Label7.TabIndex = 18
        Label7.Text = "Name Customer :"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.Control
        TextBox5.Location = New Point(158, 25)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(459, 23)
        TextBox5.TabIndex = 17
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.AllowDrop = True
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.CalendarForeColor = SystemColors.Control
        DateTimePicker1.CalendarMonthBackground = SystemColors.Control
        DateTimePicker1.CalendarTitleBackColor = SystemColors.Control
        DateTimePicker1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(155, 65)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.ShowCheckBox = True
        DateTimePicker1.Size = New Size(185, 25)
        DateTimePicker1.TabIndex = 16
        DateTimePicker1.UseWaitCursor = True
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(14, 66)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 23)
        Label5.TabIndex = 15
        Label5.Text = "Date Shoping :" & vbCrLf
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Location = New Point(6, 100)
        Button1.Name = "Button1"
        Button1.Size = New Size(664, 35)
        Button1.TabIndex = 6
        Button1.Text = "View invoice details"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Depts
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 630)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Depts"
        Text = "Suuplier"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents DGV2 As DataGridView
End Class
