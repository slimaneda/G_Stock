<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_initial
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV = New DataGridView()
        txt_nameitme = New TextBox()
        GroupBox3 = New GroupBox()
        labl_name = New Label()
        btn_updating = New Button()
        btn_delete = New Button()
        btn_modify = New Button()
        btn_add = New Button()
        GroupBox2 = New GroupBox()
        btn_cancel = New Button()
        btn_save = New Button()
        Label3 = New Label()
        txt_selling = New TextBox()
        Label2 = New Label()
        txt_purchasing = New TextBox()
        Label1 = New Label()
        txt_name = New TextBox()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        txt_code = New TextBox()
        ToolTip1 = New ToolTip(components)
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.AccessibleRole = AccessibleRole.None
        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        DataGridViewCellStyle1.ForeColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGV.BackgroundColor = SystemColors.Control
        DGV.BorderStyle = BorderStyle.None
        DGV.CellBorderStyle = DataGridViewCellBorderStyle.Sunken
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle3
        DGV.Dock = DockStyle.Bottom
        DGV.EditMode = DataGridViewEditMode.EditOnKeystroke
        DGV.EnableHeadersVisualStyles = False
        DGV.GridColor = SystemColors.ActiveCaption
        DGV.Location = New Point(3, 89)
        DGV.MultiSelect = False
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DGV.RowHeadersVisible = False
        DGV.RowTemplate.Height = 25
        DGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV.Size = New Size(653, 378)
        DGV.TabIndex = 4
        ' 
        ' txt_nameitme
        ' 
        txt_nameitme.BackColor = SystemColors.ControlLight
        txt_nameitme.Location = New Point(135, 34)
        txt_nameitme.Multiline = True
        txt_nameitme.Name = "txt_nameitme"
        txt_nameitme.Size = New Size(168, 23)
        txt_nameitme.TabIndex = 2
        ToolTip1.SetToolTip(txt_nameitme, "Search name")
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(DGV)
        GroupBox3.Controls.Add(labl_name)
        GroupBox3.Controls.Add(txt_nameitme)
        GroupBox3.FlatStyle = FlatStyle.System
        GroupBox3.Location = New Point(358, 21)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(659, 470)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "info :"
        ' 
        ' labl_name
        ' 
        labl_name.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        labl_name.BorderStyle = BorderStyle.FixedSingle
        labl_name.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        labl_name.ForeColor = SystemColors.ControlLightLight
        labl_name.Location = New Point(27, 35)
        labl_name.Name = "labl_name"
        labl_name.Size = New Size(102, 23)
        labl_name.TabIndex = 3
        labl_name.Text = "Name itme :"
        ' 
        ' btn_updating
        ' 
        btn_updating.BackColor = Color.LimeGreen
        btn_updating.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_updating.ForeColor = SystemColors.ControlLightLight
        btn_updating.Location = New Point(6, 169)
        btn_updating.Name = "btn_updating"
        btn_updating.Size = New Size(328, 35)
        btn_updating.TabIndex = 9
        btn_updating.Text = "Updating data"
        btn_updating.UseVisualStyleBackColor = False
        ' 
        ' btn_delete
        ' 
        btn_delete.BackColor = Color.Red
        btn_delete.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_delete.ForeColor = SystemColors.ControlLightLight
        btn_delete.Location = New Point(8, 128)
        btn_delete.Name = "btn_delete"
        btn_delete.Size = New Size(326, 35)
        btn_delete.TabIndex = 8
        btn_delete.Text = "Delete data for then selected row" & vbCrLf
        btn_delete.UseVisualStyleBackColor = False
        ' 
        ' btn_modify
        ' 
        btn_modify.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btn_modify.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_modify.ForeColor = SystemColors.ControlLightLight
        btn_modify.Location = New Point(6, 84)
        btn_modify.Name = "btn_modify"
        btn_modify.Size = New Size(328, 35)
        btn_modify.TabIndex = 7
        btn_modify.Text = "Modify data for the selected row"
        btn_modify.UseVisualStyleBackColor = False
        ' 
        ' btn_add
        ' 
        btn_add.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        btn_add.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_add.ForeColor = SystemColors.ControlLightLight
        btn_add.Location = New Point(8, 43)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(326, 35)
        btn_add.TabIndex = 6
        btn_add.Text = "Add new item"
        btn_add.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btn_updating)
        GroupBox2.Controls.Add(btn_delete)
        GroupBox2.Controls.Add(btn_modify)
        GroupBox2.Controls.Add(btn_add)
        GroupBox2.Location = New Point(12, 271)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(340, 220)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Procedures"
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.Red
        btn_cancel.Location = New Point(172, 172)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(116, 35)
        btn_cancel.TabIndex = 7
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.LimeGreen
        btn_save.Location = New Point(32, 172)
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
        Label3.Location = New Point(8, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 23)
        Label3.TabIndex = 5
        Label3.Text = "Selling price :" & vbCrLf
        ' 
        ' txt_selling
        ' 
        txt_selling.BackColor = SystemColors.ControlLight
        txt_selling.Location = New Point(150, 130)
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
        Label2.Location = New Point(8, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 23)
        Label2.TabIndex = 3
        Label2.Text = "Purchasing price :"
        ' 
        ' txt_purchasing
        ' 
        txt_purchasing.BackColor = SystemColors.ControlLight
        txt_purchasing.Location = New Point(154, 95)
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
        Label1.Location = New Point(8, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 23)
        Label1.TabIndex = 1
        Label1.Text = "Name :"
        ' 
        ' txt_name
        ' 
        txt_name.BackColor = SystemColors.ControlLight
        txt_name.Cursor = Cursors.IBeam
        txt_name.Location = New Point(79, 64)
        txt_name.Multiline = True
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(255, 23)
        txt_name.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txt_code)
        GroupBox1.Controls.Add(btn_cancel)
        GroupBox1.Controls.Add(btn_save)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(txt_selling)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txt_purchasing)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txt_name)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(340, 225)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Item info"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(8, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 23)
        Label4.TabIndex = 9
        Label4.Text = "Code item :"
        ' 
        ' txt_code
        ' 
        txt_code.BackColor = SystemColors.ControlLight
        txt_code.Enabled = False
        txt_code.Location = New Point(110, 31)
        txt_code.Multiline = True
        txt_code.Name = "txt_code"
        txt_code.Size = New Size(80, 23)
        txt_code.TabIndex = 8
        ' 
        ' Stock_initial
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 630)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Stock_initial"
        Text = "Stock_initial"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txt_nameitme As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents labl_name As Label
    Friend WithEvents btn_updating As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_modify As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_selling As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_purchasing As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
