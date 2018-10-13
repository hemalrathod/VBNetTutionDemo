<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrid
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrid))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MOBILEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BIRTHDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New Introduction.DS()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.USERSTableAdapter = New Introduction.DSTableAdapters.USERSTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIRSTNAMEDataGridViewTextBoxColumn, Me.LASTNAMEDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.MOBILEDataGridViewTextBoxColumn, Me.BIRTHDATEDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.USERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 575)
        Me.DataGridView1.TabIndex = 0
        '
        'FIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.FIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRSTNAME"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.Name = "FIRSTNAMEDataGridViewTextBoxColumn"
        Me.FIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LASTNAMEDataGridViewTextBoxColumn
        '
        Me.LASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME"
        Me.LASTNAMEDataGridViewTextBoxColumn.Name = "LASTNAMEDataGridViewTextBoxColumn"
        Me.LASTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MOBILEDataGridViewTextBoxColumn
        '
        Me.MOBILEDataGridViewTextBoxColumn.DataPropertyName = "MOBILE"
        Me.MOBILEDataGridViewTextBoxColumn.HeaderText = "MOBILE"
        Me.MOBILEDataGridViewTextBoxColumn.Name = "MOBILEDataGridViewTextBoxColumn"
        Me.MOBILEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BIRTHDATEDataGridViewTextBoxColumn
        '
        Me.BIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "BIRTHDATE"
        Me.BIRTHDATEDataGridViewTextBoxColumn.HeaderText = "BIRTHDATE"
        Me.BIRTHDATEDataGridViewTextBoxColumn.Name = "BIRTHDATEDataGridViewTextBoxColumn"
        Me.BIRTHDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(947, 593)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'frmGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 628)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DS As DS
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As DSTableAdapters.USERSTableAdapter
    Friend WithEvents FIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MOBILEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
