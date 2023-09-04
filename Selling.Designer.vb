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
        Dim DataGridView1 As DataGridView
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridView2 As DataGridView
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        GroupBox3 = New GroupBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox4 = New TextBox()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        btn_save = New Button()
        Label3 = New Label()
        txt_selling = New TextBox()
        Label1 = New Label()
        txt_name = New TextBox()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AccessibleRole = AccessibleRole.None
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column2, Column4})
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle10.BackColor = SystemColors.Control
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = SystemColors.ActiveCaption
        DataGridView1.Location = New Point(3, 78)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(323, 525)
        DataGridView1.TabIndex = 4
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name item"
        Column2.Name = "Column2"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Selling Price"
        Column4.Name = "Column4"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(DataGridView1)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(TextBox2)
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.FlatStyle = FlatStyle.System
        GroupBox3.Location = New Point(12, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(329, 606)
        GroupBox3.TabIndex = 10
        GroupBox3.TabStop = False
        GroupBox3.Text = "List of available materials"
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
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Control
        TextBox2.Location = New Point(139, 177)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 23)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Control
        TextBox4.Location = New Point(123, 34)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(202, 23)
        TextBox4.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DataGridView2)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(btn_save)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txt_selling)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txt_name)
        GroupBox1.Location = New Point(347, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(670, 546)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item info"
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
        DateTimePicker1.Location = New Point(479, 110)
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
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Control
        TextBox3.Location = New Point(479, 77)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(186, 23)
        TextBox3.TabIndex = 12
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
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.Control
        TextBox5.Location = New Point(478, 42)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(187, 23)
        TextBox5.TabIndex = 10
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
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.Location = New Point(147, 109)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(186, 23)
        TextBox1.TabIndex = 8
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
        txt_selling.BackColor = SystemColors.Control
        txt_selling.Location = New Point(148, 76)
        txt_selling.Multiline = True
        txt_selling.Name = "txt_selling"
        txt_selling.Size = New Size(186, 23)
        txt_selling.TabIndex = 4
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
        ' txt_name
        ' 
        txt_name.BackColor = SystemColors.Control
        txt_name.Location = New Point(72, 41)
        txt_name.Multiline = True
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(262, 23)
        txt_name.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AccessibleRole = AccessibleRole.None
        DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle11.ForeColor = Color.White
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = SystemColors.Control
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column5, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle12.BackColor = SystemColors.Control
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        DataGridView2.DefaultCellStyle = DataGridViewCellStyle12
        DataGridView2.Dock = DockStyle.Bottom
        DataGridView2.EditMode = DataGridViewEditMode.EditOnKeystroke
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.GridColor = SystemColors.ActiveCaption
        DataGridView2.Location = New Point(3, 199)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowTemplate.Height = 25
        DataGridView2.Size = New Size(664, 344)
        DataGridView2.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Code Fact"
        Column1.Name = "Column1"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "designation"
        Column3.Name = "Column3"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Quantity"
        Column5.Name = "Column5"
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Name Customer"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Total"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Location = New Point(344, 564)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(673, 51)
        GroupBox2.TabIndex = 12
        GroupBox2.TabStop = False
        GroupBox2.Text = "Procedures"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LimeGreen
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(220, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(96, 35)
        Button4.TabIndex = 9
        Button4.Text = "Save"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Red
        Button5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(442, 12)
        Button5.Name = "Button5"
        Button5.Size = New Size(114, 35)
        Button5.TabIndex = 8
        Button5.Text = "Delete data"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(322, 10)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 35)
        Button2.TabIndex = 7
        Button2.Text = "Modify data "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(113, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 35)
        Button3.TabIndex = 6
        Button3.Text = "Add new "
        Button3.TextImageRelation = TextImageRelation.ImageBeforeText
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(562, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 35)
        Button1.TabIndex = 10
        Button1.Text = "Imprimer"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Selling
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 641)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Selling"
        Text = "Selling"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_selling As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
