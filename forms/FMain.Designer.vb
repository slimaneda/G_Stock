<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMain
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FMain))
        Panel_menu = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Btn_Selling = New Button()
        btn_Depts = New Button()
        Btn_stock = New Button()
        Btn_Accueil = New Button()
        Panel_Accueil = New Panel()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        btn_setting = New Button()
        Panel_menu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel_menu
        ' 
        Panel_menu.BackColor = SystemColors.Control
        Panel_menu.Controls.Add(btn_setting)
        Panel_menu.Controls.Add(Button2)
        Panel_menu.Controls.Add(Button1)
        Panel_menu.Controls.Add(Label1)
        Panel_menu.Controls.Add(PictureBox1)
        Panel_menu.Controls.Add(Btn_Selling)
        Panel_menu.Controls.Add(btn_Depts)
        Panel_menu.Controls.Add(Btn_stock)
        Panel_menu.Controls.Add(Btn_Accueil)
        Panel_menu.Dock = DockStyle.Left
        Panel_menu.Location = New Point(0, 0)
        Panel_menu.Margin = New Padding(4)
        Panel_menu.Name = "Panel_menu"
        Panel_menu.Size = New Size(208, 628)
        Panel_menu.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(1, 448)
        Button2.Name = "Button2"
        Button2.Size = New Size(201, 66)
        Button2.TabIndex = 16
        Button2.Text = "Setting"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(0, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(201, 66)
        Button1.TabIndex = 15
        Button1.Text = "Customers"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 598)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 21)
        Label1.TabIndex = 14
        Label1.Text = "Created by slimane"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(10, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(188, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Btn_Selling
        ' 
        Btn_Selling.BackColor = SystemColors.Control
        Btn_Selling.BackgroundImage = CType(resources.GetObject("Btn_Selling.BackgroundImage"), Image)
        Btn_Selling.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Selling.FlatAppearance.BorderSize = 0
        Btn_Selling.FlatStyle = FlatStyle.Flat
        Btn_Selling.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Selling.ForeColor = SystemColors.Control
        Btn_Selling.Location = New Point(2, 232)
        Btn_Selling.Name = "Btn_Selling"
        Btn_Selling.Size = New Size(201, 66)
        Btn_Selling.TabIndex = 12
        Btn_Selling.Text = "New Sale"
        Btn_Selling.UseVisualStyleBackColor = False
        ' 
        ' btn_Depts
        ' 
        btn_Depts.BackColor = SystemColors.Control
        btn_Depts.BackgroundImage = CType(resources.GetObject("btn_Depts.BackgroundImage"), Image)
        btn_Depts.BackgroundImageLayout = ImageLayout.Stretch
        btn_Depts.FlatAppearance.BorderSize = 0
        btn_Depts.FlatStyle = FlatStyle.Flat
        btn_Depts.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Depts.ForeColor = SystemColors.Control
        btn_Depts.Location = New Point(-1, 304)
        btn_Depts.Name = "btn_Depts"
        btn_Depts.Size = New Size(201, 66)
        btn_Depts.TabIndex = 11
        btn_Depts.Text = "The Sales"
        btn_Depts.UseVisualStyleBackColor = False
        ' 
        ' Btn_stock
        ' 
        Btn_stock.BackColor = SystemColors.Control
        Btn_stock.BackgroundImage = CType(resources.GetObject("Btn_stock.BackgroundImage"), Image)
        Btn_stock.BackgroundImageLayout = ImageLayout.Stretch
        Btn_stock.FlatAppearance.BorderSize = 0
        Btn_stock.FlatStyle = FlatStyle.Flat
        Btn_stock.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_stock.ForeColor = SystemColors.Control
        Btn_stock.Location = New Point(2, 162)
        Btn_stock.Name = "Btn_stock"
        Btn_stock.Size = New Size(201, 66)
        Btn_stock.TabIndex = 10
        Btn_stock.Text = "Assetes"
        Btn_stock.UseVisualStyleBackColor = False
        ' 
        ' Btn_Accueil
        ' 
        Btn_Accueil.BackColor = SystemColors.Control
        Btn_Accueil.BackgroundImage = CType(resources.GetObject("Btn_Accueil.BackgroundImage"), Image)
        Btn_Accueil.BackgroundImageLayout = ImageLayout.Stretch
        Btn_Accueil.FlatAppearance.BorderSize = 0
        Btn_Accueil.FlatStyle = FlatStyle.Flat
        Btn_Accueil.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Accueil.ForeColor = SystemColors.Control
        Btn_Accueil.Location = New Point(-1, 95)
        Btn_Accueil.Name = "Btn_Accueil"
        Btn_Accueil.Size = New Size(201, 66)
        Btn_Accueil.TabIndex = 8
        Btn_Accueil.Text = "Dashbord"
        Btn_Accueil.UseVisualStyleBackColor = False
        ' 
        ' Panel_Accueil
        ' 
        Panel_Accueil.BackColor = SystemColors.Control
        Panel_Accueil.Dock = DockStyle.Fill
        Panel_Accueil.Location = New Point(208, 0)
        Panel_Accueil.Name = "Panel_Accueil"
        Panel_Accueil.Size = New Size(1063, 628)
        Panel_Accueil.TabIndex = 1
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1000
        ' 
        ' btn_setting
        ' 
        btn_setting.BackColor = SystemColors.Control
        btn_setting.BackgroundImage = CType(resources.GetObject("btn_setting.BackgroundImage"), Image)
        btn_setting.BackgroundImageLayout = ImageLayout.Stretch
        btn_setting.FlatAppearance.BorderSize = 0
        btn_setting.FlatStyle = FlatStyle.Flat
        btn_setting.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_setting.ForeColor = SystemColors.Control
        btn_setting.Location = New Point(12, 448)
        btn_setting.Name = "btn_setting"
        btn_setting.Size = New Size(201, 66)
        btn_setting.TabIndex = 17
        btn_setting.Text = "Setting"
        btn_setting.UseVisualStyleBackColor = False
        ' 
        ' FMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1271, 628)
        Controls.Add(Panel_Accueil)
        Controls.Add(Panel_menu)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "FMain"
        Text = "Main"
        Panel_menu.ResumeLayout(False)
        Panel_menu.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub



    Friend WithEvents Panel_menu As Panel
    Friend WithEvents Btn_Accueil As Button
    Friend WithEvents Panel_Accueil As Panel
    Friend WithEvents Btn_Selling As Button
    Friend WithEvents btn_Depts As Button
    Friend WithEvents Btn_stock As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_setting As Button
End Class
