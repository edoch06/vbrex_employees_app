<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDICornea
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDICornea))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeMasterDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeWorkStationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JobCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeGuardianRelationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeGuardianRelationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeRecruitmentReportingBossToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeBranchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeGuardianReligionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeGuardianNationalityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeGuardianRelationToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeRecruitmentModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.AddEditEmployeesDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintEmployeesLabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SystemSecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MachineOperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApplicationLogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ApplicationExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.tsb_fileupload = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.lbl_items = New System.Windows.Forms.ToolStripLabel
        Me.lbl_connect = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.HelpMenu, Me.ReportsToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.WindowsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeMasterDetailToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'EmployeeMasterDetailToolStripMenuItem
        '
        Me.EmployeeMasterDetailToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.upload_24
        Me.EmployeeMasterDetailToolStripMenuItem.Name = "EmployeeMasterDetailToolStripMenuItem"
        Me.EmployeeMasterDetailToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EmployeeMasterDetailToolStripMenuItem.Text = "&Employee Master Detail"
        Me.EmployeeMasterDetailToolStripMenuItem.ToolTipText = "Click to upload file"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeWorkStationToolStripMenuItem, Me.JobCategoryToolStripMenuItem, Me.EmployeeGuardianRelationToolStripMenuItem, Me.EmployeeGuardianRelationToolStripMenuItem1, Me.EmployeeRecruitmentReportingBossToolStripMenuItem, Me.EmployeeBranchToolStripMenuItem, Me.EmployeeGuardianReligionToolStripMenuItem, Me.EmployeeGuardianNationalityToolStripMenuItem, Me.EmployeeGuardianRelationToolStripMenuItem2, Me.EmployeeRecruitmentModeToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(93, 20)
        Me.EditMenu.Text = "&Master Details"
        '
        'EmployeeWorkStationToolStripMenuItem
        '
        Me.EmployeeWorkStationToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.construction_16
        Me.EmployeeWorkStationToolStripMenuItem.Name = "EmployeeWorkStationToolStripMenuItem"
        Me.EmployeeWorkStationToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeWorkStationToolStripMenuItem.Text = "&Employee WorkStation"
        '
        'JobCategoryToolStripMenuItem
        '
        Me.JobCategoryToolStripMenuItem.Name = "JobCategoryToolStripMenuItem"
        Me.JobCategoryToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.JobCategoryToolStripMenuItem.Text = "&Employee Designation"
        '
        'EmployeeGuardianRelationToolStripMenuItem
        '
        Me.EmployeeGuardianRelationToolStripMenuItem.Name = "EmployeeGuardianRelationToolStripMenuItem"
        Me.EmployeeGuardianRelationToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeGuardianRelationToolStripMenuItem.Text = "&Employee Branch"
        '
        'EmployeeGuardianRelationToolStripMenuItem1
        '
        Me.EmployeeGuardianRelationToolStripMenuItem1.Name = "EmployeeGuardianRelationToolStripMenuItem1"
        Me.EmployeeGuardianRelationToolStripMenuItem1.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeGuardianRelationToolStripMenuItem1.Text = "&Employee Department"
        '
        'EmployeeRecruitmentReportingBossToolStripMenuItem
        '
        Me.EmployeeRecruitmentReportingBossToolStripMenuItem.Name = "EmployeeRecruitmentReportingBossToolStripMenuItem"
        Me.EmployeeRecruitmentReportingBossToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeRecruitmentReportingBossToolStripMenuItem.Text = "&Employee Country"
        '
        'EmployeeBranchToolStripMenuItem
        '
        Me.EmployeeBranchToolStripMenuItem.Name = "EmployeeBranchToolStripMenuItem"
        Me.EmployeeBranchToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeBranchToolStripMenuItem.Text = "&Employee Blood Group"
        '
        'EmployeeGuardianReligionToolStripMenuItem
        '
        Me.EmployeeGuardianReligionToolStripMenuItem.Name = "EmployeeGuardianReligionToolStripMenuItem"
        Me.EmployeeGuardianReligionToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeGuardianReligionToolStripMenuItem.Text = "&Employee Religion"
        '
        'EmployeeGuardianNationalityToolStripMenuItem
        '
        Me.EmployeeGuardianNationalityToolStripMenuItem.Name = "EmployeeGuardianNationalityToolStripMenuItem"
        Me.EmployeeGuardianNationalityToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeGuardianNationalityToolStripMenuItem.Text = "&Employee Nationality"
        '
        'EmployeeGuardianRelationToolStripMenuItem2
        '
        Me.EmployeeGuardianRelationToolStripMenuItem2.Name = "EmployeeGuardianRelationToolStripMenuItem2"
        Me.EmployeeGuardianRelationToolStripMenuItem2.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeGuardianRelationToolStripMenuItem2.Text = "&Employee Recruitment Mode"
        '
        'EmployeeRecruitmentModeToolStripMenuItem
        '
        Me.EmployeeRecruitmentModeToolStripMenuItem.Name = "EmployeeRecruitmentModeToolStripMenuItem"
        Me.EmployeeRecruitmentModeToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.EmployeeRecruitmentModeToolStripMenuItem.Text = "&Employee Working Shift"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditEmployeesDetailsToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(46, 20)
        Me.ViewMenu.Text = "&Tasks"
        '
        'AddEditEmployeesDetailsToolStripMenuItem
        '
        Me.AddEditEmployeesDetailsToolStripMenuItem.Name = "AddEditEmployeesDetailsToolStripMenuItem"
        Me.AddEditEmployeesDetailsToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.AddEditEmployeesDetailsToolStripMenuItem.Text = "Add && Edit Employees Details"
        '
        'HelpMenu
        '
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        Me.HelpMenu.Visible = False
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintEmployeesLabelsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        Me.ReportsToolStripMenuItem.Visible = False
        '
        'PrintEmployeesLabelsToolStripMenuItem
        '
        Me.PrintEmployeesLabelsToolStripMenuItem.Name = "PrintEmployeesLabelsToolStripMenuItem"
        Me.PrintEmployeesLabelsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PrintEmployeesLabelsToolStripMenuItem.Text = "&Print Employees Labels"
        Me.PrintEmployeesLabelsToolStripMenuItem.ToolTipText = "Click to extract employee labels"
        Me.PrintEmployeesLabelsToolStripMenuItem.Visible = False
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseConnectionsToolStripMenuItem, Me.CompanyDetailToolStripMenuItem, Me.SystemSecurityToolStripMenuItem, Me.MachineOperationsToolStripMenuItem, Me.ApplicationLogoutToolStripMenuItem, Me.ApplicationExitToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        Me.SettingsToolStripMenuItem.Visible = False
        '
        'DatabaseConnectionsToolStripMenuItem
        '
        Me.DatabaseConnectionsToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.link_24
        Me.DatabaseConnectionsToolStripMenuItem.Name = "DatabaseConnectionsToolStripMenuItem"
        Me.DatabaseConnectionsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DatabaseConnectionsToolStripMenuItem.Text = "&Database Connections"
        '
        'CompanyDetailToolStripMenuItem
        '
        Me.CompanyDetailToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.building_48
        Me.CompanyDetailToolStripMenuItem.Name = "CompanyDetailToolStripMenuItem"
        Me.CompanyDetailToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CompanyDetailToolStripMenuItem.Text = "&Company Detail"
        '
        'SystemSecurityToolStripMenuItem
        '
        Me.SystemSecurityToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.warningshield_24
        Me.SystemSecurityToolStripMenuItem.Name = "SystemSecurityToolStripMenuItem"
        Me.SystemSecurityToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SystemSecurityToolStripMenuItem.Text = "&System Security"
        '
        'MachineOperationsToolStripMenuItem
        '
        Me.MachineOperationsToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.automation_24
        Me.MachineOperationsToolStripMenuItem.Name = "MachineOperationsToolStripMenuItem"
        Me.MachineOperationsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.MachineOperationsToolStripMenuItem.Text = "&Machine Operations"
        '
        'ApplicationLogoutToolStripMenuItem
        '
        Me.ApplicationLogoutToolStripMenuItem.Image = Global.Cornea.My.Resources.Resources.doorhanger_24
        Me.ApplicationLogoutToolStripMenuItem.Name = "ApplicationLogoutToolStripMenuItem"
        Me.ApplicationLogoutToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ApplicationLogoutToolStripMenuItem.Text = "&Application Logout"
        '
        'ApplicationExitToolStripMenuItem
        '
        Me.ApplicationExitToolStripMenuItem.Name = "ApplicationExitToolStripMenuItem"
        Me.ApplicationExitToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ApplicationExitToolStripMenuItem.Text = "&Application Exit"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        Me.WindowsMenu.Visible = False
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'ToolStrip
        '
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsb_fileupload, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(632, 37)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'tsb_fileupload
        '
        Me.tsb_fileupload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_fileupload.Image = Global.Cornea.My.Resources.Resources.upload_48
        Me.tsb_fileupload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_fileupload.Name = "tsb_fileupload"
        Me.tsb_fileupload.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.tsb_fileupload.Size = New System.Drawing.Size(50, 34)
        Me.tsb_fileupload.Text = "Click to upload employee master file"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Cornea.My.Resources.Resources.construction_48
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 34)
        Me.ToolStripButton1.Text = "Click to add edit employee records"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.ToolStrip3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 429)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(632, 24)
        Me.Panel6.TabIndex = 184
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_items, Me.lbl_connect, Me.ToolStripLabel1})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(630, 25)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'lbl_items
        '
        Me.lbl_items.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_items.Name = "lbl_items"
        Me.lbl_items.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lbl_items.Size = New System.Drawing.Size(42, 22)
        Me.lbl_items.Text = "Status"
        '
        'lbl_connect
        '
        Me.lbl_connect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lbl_connect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_connect.Name = "lbl_connect"
        Me.lbl_connect.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.lbl_connect.Size = New System.Drawing.Size(66, 22)
        Me.lbl_connect.Text = "Connected"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStripLabel1.Size = New System.Drawing.Size(142, 22)
        Me.ToolStripLabel1.Text = "                                            "
        '
        'MDICornea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDICornea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDI Employee"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseConnectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompanyDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemSecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MachineOperationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationLogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplicationExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents lbl_items As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lbl_connect As System.Windows.Forms.ToolStripLabel
    Friend WithEvents JobCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeWorkStationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeGuardianRelationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeGuardianReligionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeGuardianNationalityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeGuardianRelationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeGuardianRelationToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeBranchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeRecruitmentReportingBossToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditEmployeesDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeMasterDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsb_fileupload As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintEmployeesLabelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents EmployeeRecruitmentModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
