<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        GroupBox1 = New GroupBox()
        Button1 = New Button()
        btn_save = New Button()
        Label3 = New Label()
        txt_selling = New TextBox()
        Label2 = New Label()
        txt_purchasing = New TextBox()
        Label1 = New Label()
        txt_name = New TextBox()
        GroupBox2 = New GroupBox()
        Button4 = New Button()
        Button5 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox3 = New GroupBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AccessibleRole = AccessibleRole.None
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Dock = DockStyle.Bottom
        DataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = SystemColors.ActiveCaption
        DataGridView1.Location = New Point(3, 89)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(653, 378)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Code item"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Name item"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Purchasing Price"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Selling Price"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Estimated profit"
        Column5.Name = "Column5"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(btn_save)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txt_selling)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txt_purchasing)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txt_name)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(340, 220)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item info"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Location = New Point(187, 170)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 35)
        Button1.TabIndex = 7
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Location = New Point(47, 170)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(116, 35)
        btn_save.TabIndex = 6
        btn_save.Text = "Save"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(8, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 23)
        Label3.TabIndex = 5
        Label3.Text = "Selling price :" & vbCrLf
        ' 
        ' txt_selling
        ' 
        txt_selling.BackColor = SystemColors.Control
        txt_selling.Location = New Point(148, 118)
        txt_selling.Multiline = True
        txt_selling.Name = "txt_selling"
        txt_selling.Size = New Size(186, 23)
        txt_selling.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(8, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 23)
        Label2.TabIndex = 3
        Label2.Text = "Purchasing price :"
        ' 
        ' txt_purchasing
        ' 
        txt_purchasing.BackColor = SystemColors.Control
        txt_purchasing.Location = New Point(154, 83)
        txt_purchasing.Multiline = True
        txt_purchasing.Name = "txt_purchasing"
        txt_purchasing.Size = New Size(180, 23)
        txt_purchasing.TabIndex = 2
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
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button5)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Location = New Point(12, 271)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(340, 220)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Procedures"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LimeGreen
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = SystemColors.ControlLightLight
        Button4.Location = New Point(6, 169)
        Button4.Name = "Button4"
        Button4.Size = New Size(328, 35)
        Button4.TabIndex = 9
        Button4.Text = "Updating data"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Red
        Button5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = SystemColors.ControlLightLight
        Button5.Location = New Point(8, 128)
        Button5.Name = "Button5"
        Button5.Size = New Size(326, 35)
        Button5.TabIndex = 8
        Button5.Text = "Delete data for then selected row" & vbCrLf
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlLightLight
        Button2.Location = New Point(6, 84)
        Button2.Name = "Button2"
        Button2.Size = New Size(328, 35)
        Button2.TabIndex = 7
        Button2.Text = "Modify data for the selected row"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ControlLightLight
        Button3.Location = New Point(8, 43)
        Button3.Name = "Button3"
        Button3.Size = New Size(326, 35)
        Button3.TabIndex = 6
        Button3.Text = "Add new item"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(DataGridView1)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.FlatStyle = FlatStyle.System
        GroupBox3.Location = New Point(358, 21)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(659, 470)
        GroupBox3.TabIndex = 9
        GroupBox3.TabStop = False
        GroupBox3.Text = "GroupBox3"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(27, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 23)
        Label4.TabIndex = 3
        Label4.Text = "Name itme :"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.Control
        TextBox4.Location = New Point(135, 34)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(505, 23)
        TextBox4.TabIndex = 2
        ' 
        ' Stock
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 630)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Stock"
        Text = "Stock"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_selling As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_purchasing As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
