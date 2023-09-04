<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        txt_sellitms = New TextBox()
        PictureBox3 = New PictureBox()
        txt_dept = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        txt_stock = New TextBox()
        TextBox5 = New TextBox()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt_sellitms
        ' 
        txt_sellitms.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        txt_sellitms.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_sellitms.ForeColor = SystemColors.ControlLightLight
        txt_sellitms.Location = New Point(305, 72)
        txt_sellitms.Name = "txt_sellitms"
        txt_sellitms.Size = New Size(140, 33)
        txt_sellitms.TabIndex = 10
        txt_sellitms.Text = "Sell ​​Item"
        txt_sellitms.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.output_onlinepngtools
        PictureBox3.Location = New Point(260, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(222, 210)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' txt_dept
        ' 
        txt_dept.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        txt_dept.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_dept.ForeColor = SystemColors.ControlLightLight
        txt_dept.Location = New Point(557, 72)
        txt_dept.Name = "txt_dept"
        txt_dept.Size = New Size(123, 33)
        txt_dept.TabIndex = 8
        txt_dept.Text = "Depts"
        txt_dept.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.output_onlinepngtools
        PictureBox2.Location = New Point(505, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(222, 210)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Enabled = False
        PictureBox1.Image = My.Resources.Resources.output_onlinepngtools
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 210)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' txt_stock
        ' 
        txt_stock.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        txt_stock.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_stock.ForeColor = Color.White
        txt_stock.Location = New Point(64, 72)
        txt_stock.Name = "txt_stock"
        txt_stock.Size = New Size(123, 33)
        txt_stock.TabIndex = 11
        txt_stock.Text = "Stock"
        txt_stock.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox5.BackColor = Color.FromArgb(CByte(104), CByte(160), CByte(235))
        TextBox5.BorderStyle = BorderStyle.None
        TextBox5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Pixel)
        TextBox5.ForeColor = Color.White
        TextBox5.HideSelection = False
        TextBox5.Location = New Point(52, 111)
        TextBox5.Multiline = True
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(115, 78)
        TextBox5.TabIndex = 12
        TextBox5.Text = "items and property available for sale"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Accueil
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1029, 630)
        Controls.Add(TextBox5)
        Controls.Add(txt_sellitms)
        Controls.Add(txt_stock)
        Controls.Add(PictureBox3)
        Controls.Add(txt_dept)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Accueil"
        Text = "Accueil"
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_sellitms As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_dept As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
