<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selling
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
        GroupBox3 = New GroupBox()
        btn_Update = New Button()
        DGV1 = New DataGridView()
        Label4 = New Label()
        TextBox4 = New TextBox()
        GroupBox1 = New GroupBox()
        DGV2 = New DataGridView()
        date_shoping = New DateTimePicker()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txt_codefact = New TextBox()
        Label7 = New Label()
        txt_num_cstmer = New TextBox()
        Label2 = New Label()
        Txt_qty = New TextBox()
        btn_save = New Button()
        Label3 = New Label()
        txt_selling = New TextBox()
        txt_name = New TextBox()
        GroupBox2 = New GroupBox()
        btn_print = New Button()
        btn_delete = New Button()
        btn_modifier = New Button()
        btn_addnew = New Button()
        btn_showall = New Button()
        GroupBox3.SuspendLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btn_Update)
        GroupBox3.Controls.Add(DGV1)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.FlatStyle = FlatStyle.System
        GroupBox3.Location = New Point(12, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(329, 606)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "List of available materials"
        ' 
        ' btn_Update
        ' 
        btn_Update.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        btn_Update.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Update.ForeColor = SystemColors.ControlLightLight
        btn_Update.Location = New Point(10, 71)
        btn_Update.Name = "btn_Update"
        btn_Update.Size = New Size(72, 35)
        btn_Update.TabIndex = 11
        btn_Update.Text = "Update"
        btn_Update.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_Update.UseVisualStyleBackColor = False
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
        DGV1.Location = New Point(3, 112)
        DGV1.MultiSelect = False
        DGV1.Name = "DGV1"
        DGV1.ReadOnly = True
        DGV1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV1.RowHeadersVisible = False
        DGV1.RowTemplate.Height = 25
        DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV1.Size = New Size(323, 491)
        DGV1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(10, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 23)
        Label4.TabIndex = 3
        Label4.Text = "Name itme :"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Control
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(123, 34)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(202, 23)
        TextBox4.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DGV2)
        GroupBox1.Controls.Add(date_shoping)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txt_codefact)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txt_num_cstmer)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Txt_qty)
        GroupBox1.Controls.Add(btn_save)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txt_selling)
        GroupBox1.Controls.Add(txt_name)
        GroupBox1.Location = New Point(347, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(670, 512)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item info :"
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
        DGV2.Location = New Point(3, 193)
        DGV2.MultiSelect = False
        DGV2.Name = "DGV2"
        DGV2.ReadOnly = True
        DGV2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV2.RowHeadersVisible = False
        DGV2.RowTemplate.Height = 25
        DGV2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV2.Size = New Size(664, 316)
        DGV2.TabIndex = 12
        ' 
        ' date_shoping
        ' 
        date_shoping.AllowDrop = True
        date_shoping.CalendarFont = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        date_shoping.CalendarForeColor = SystemColors.Control
        date_shoping.CalendarMonthBackground = SystemColors.Control
        date_shoping.CalendarTitleBackColor = SystemColors.Control
        date_shoping.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        date_shoping.Format = DateTimePickerFormat.Custom
        date_shoping.Location = New Point(479, 110)
        date_shoping.Name = "date_shoping"
        date_shoping.ShowCheckBox = True
        date_shoping.Size = New Size(185, 25)
        date_shoping.TabIndex = 16
        date_shoping.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(8, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 23)
        Label1.TabIndex = 1
        Label1.Text = "Name :"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(338, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 23)
        Label5.TabIndex = 15
        Label5.Text = "Date Shoping :" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(339, 78)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 23)
        Label6.TabIndex = 13
        Label6.Text = "Code Fact :"
        ' 
        ' txt_codefact
        ' 
        txt_codefact.BackColor = SystemColors.Window
        txt_codefact.BorderStyle = BorderStyle.FixedSingle
        txt_codefact.Location = New Point(479, 77)
        txt_codefact.Multiline = True
        txt_codefact.Name = "txt_codefact"
        txt_codefact.Size = New Size(186, 23)
        txt_codefact.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label7.BorderStyle = BorderStyle.FixedSingle
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(339, 43)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 23)
        Label7.TabIndex = 11
        Label7.Text = "Name Customer :"
        ' 
        ' txt_num_cstmer
        ' 
        txt_num_cstmer.BackColor = Color.White
        txt_num_cstmer.BorderStyle = BorderStyle.FixedSingle
        txt_num_cstmer.Location = New Point(478, 42)
        txt_num_cstmer.Multiline = True
        txt_num_cstmer.Name = "txt_num_cstmer"
        txt_num_cstmer.Size = New Size(187, 23)
        txt_num_cstmer.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(7, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 23)
        Label2.TabIndex = 9
        Label2.Text = "Quantity :"
        ' 
        ' Txt_qty
        ' 
        Txt_qty.BackColor = Color.White
        Txt_qty.BorderStyle = BorderStyle.FixedSingle
        Txt_qty.Location = New Point(147, 109)
        Txt_qty.Multiline = True
        Txt_qty.Name = "Txt_qty"
        Txt_qty.Size = New Size(186, 23)
        Txt_qty.TabIndex = 8
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Location = New Point(6, 152)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(664, 35)
        btn_save.TabIndex = 6
        btn_save.Text = "Add to shopping list"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(8, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 23)
        Label3.TabIndex = 5
        Label3.Text = "Selling price :" & vbCrLf
        ' 
        ' txt_selling
        ' 
        txt_selling.BackColor = Color.White
        txt_selling.BorderStyle = BorderStyle.FixedSingle
        txt_selling.Location = New Point(148, 76)
        txt_selling.Multiline = True
        txt_selling.Name = "txt_selling"
        txt_selling.Size = New Size(186, 23)
        txt_selling.TabIndex = 4
        ' 
        ' txt_name
        ' 
        txt_name.AcceptsTab = True
        txt_name.BackColor = Color.White
        txt_name.BorderStyle = BorderStyle.FixedSingle
        txt_name.Enabled = False
        txt_name.Location = New Point(78, 42)
        txt_name.Multiline = True
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(256, 23)
        txt_name.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btn_print)
        GroupBox2.Controls.Add(btn_delete)
        GroupBox2.Controls.Add(btn_modifier)
        GroupBox2.Controls.Add(btn_addnew)
        GroupBox2.Location = New Point(344, 564)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(673, 51)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Procedures"
        ' 
        ' btn_print
        ' 
        btn_print.BackColor = Color.Red
        btn_print.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_print.ForeColor = SystemColors.ControlLightLight
        btn_print.Location = New Point(501, 12)
        btn_print.Name = "btn_print"
        btn_print.Size = New Size(98, 35)
        btn_print.TabIndex = 10
        btn_print.Text = "Imprimer"
        btn_print.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Red
        btn_delete.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_delete.ForeColor = SystemColors.ControlLightLight
        btn_delete.Location = New Point(381, 12)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(114, 35)
        btn_delete.TabIndex = 8
        btn_delete.Text = "Delete data"
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_modifier
        ' 
        btn_modifier.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_modifier.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_modifier.ForeColor = SystemColors.ControlLightLight
        btn_modifier.Location = New Point(261, 10)
        btn_modifier.Name = "btn_modifier"
        btn_modifier.Size = New Size(114, 35)
        btn_modifier.TabIndex = 7
        btn_modifier.Text = "Modify data "
        btn_modifier.UseVisualStyleBackColor = False
        ' 
        ' btn_addnew
        ' 
        btn_addnew.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        btn_addnew.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_addnew.ForeColor = SystemColors.ControlLightLight
        btn_addnew.Location = New Point(156, 12)
        btn_addnew.Name = "btn_addnew"
        btn_addnew.Size = New Size(101, 35)
        btn_addnew.TabIndex = 6
        btn_addnew.Text = "Add new "
        btn_addnew.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_addnew.UseVisualStyleBackColor = False
        ' 
        ' btn_showall
        ' 
        btn_showall.BackColor = Color.LimeGreen
        btn_showall.Location = New Point(350, 530)
        btn_showall.Name = "btn_showall"
        btn_showall.Size = New Size(664, 35)
        btn_showall.TabIndex = 17
        btn_showall.Text = "Show all"
        btn_showall.UseVisualStyleBackColor = False
        ' 
        ' Selling
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1444, 641)
        Controls.Add(btn_showall)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(4)
        Name = "Selling"
        Text = "Selling"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DGV1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DGV2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_codefact As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_num_cstmer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_qty As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_selling As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents date_shoping As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_addnew As Button
    Friend WithEvents btn_print As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents btn_Update As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents btn_showall As Button
End Class
