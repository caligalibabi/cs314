<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MOKANDataSet1 = New MOKAN.MOKANDataSet1()
        Me.GeneralInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralInfoTableAdapter = New MOKAN.MOKANDataSet1TableAdapters.GeneralInfoTableAdapter()
        Me.SSN4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrefixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuffixDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreferredNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomePhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOKANDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SSN4DataGridViewTextBoxColumn, Me.PrefixDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.MiddleNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.SuffixDataGridViewTextBoxColumn, Me.PreferredNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.STDataGridViewTextBoxColumn, Me.ZIPDataGridViewTextBoxColumn, Me.CountyDataGridViewTextBoxColumn, Me.CountryDataGridViewTextBoxColumn, Me.HomePhoneDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GeneralInfoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(579, 182)
        Me.DataGridView1.TabIndex = 0
        '
        'MOKANDataSet1
        '
        Me.MOKANDataSet1.DataSetName = "MOKANDataSet1"
        Me.MOKANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralInfoBindingSource
        '
        Me.GeneralInfoBindingSource.DataMember = "GeneralInfo"
        Me.GeneralInfoBindingSource.DataSource = Me.MOKANDataSet1
        '
        'GeneralInfoTableAdapter
        '
        Me.GeneralInfoTableAdapter.ClearBeforeFill = True
        '
        'SSN4DataGridViewTextBoxColumn
        '
        Me.SSN4DataGridViewTextBoxColumn.DataPropertyName = "SSN4"
        Me.SSN4DataGridViewTextBoxColumn.HeaderText = "SSN4"
        Me.SSN4DataGridViewTextBoxColumn.Name = "SSN4DataGridViewTextBoxColumn"
        '
        'PrefixDataGridViewTextBoxColumn
        '
        Me.PrefixDataGridViewTextBoxColumn.DataPropertyName = "Prefix"
        Me.PrefixDataGridViewTextBoxColumn.HeaderText = "Prefix"
        Me.PrefixDataGridViewTextBoxColumn.Name = "PrefixDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'MiddleNameDataGridViewTextBoxColumn
        '
        Me.MiddleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName"
        Me.MiddleNameDataGridViewTextBoxColumn.Name = "MiddleNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'SuffixDataGridViewTextBoxColumn
        '
        Me.SuffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.HeaderText = "Suffix"
        Me.SuffixDataGridViewTextBoxColumn.Name = "SuffixDataGridViewTextBoxColumn"
        '
        'PreferredNameDataGridViewTextBoxColumn
        '
        Me.PreferredNameDataGridViewTextBoxColumn.DataPropertyName = "PreferredName"
        Me.PreferredNameDataGridViewTextBoxColumn.HeaderText = "PreferredName"
        Me.PreferredNameDataGridViewTextBoxColumn.Name = "PreferredNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'STDataGridViewTextBoxColumn
        '
        Me.STDataGridViewTextBoxColumn.DataPropertyName = "ST"
        Me.STDataGridViewTextBoxColumn.HeaderText = "ST"
        Me.STDataGridViewTextBoxColumn.Name = "STDataGridViewTextBoxColumn"
        '
        'ZIPDataGridViewTextBoxColumn
        '
        Me.ZIPDataGridViewTextBoxColumn.DataPropertyName = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.HeaderText = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.Name = "ZIPDataGridViewTextBoxColumn"
        '
        'CountyDataGridViewTextBoxColumn
        '
        Me.CountyDataGridViewTextBoxColumn.DataPropertyName = "County"
        Me.CountyDataGridViewTextBoxColumn.HeaderText = "County"
        Me.CountyDataGridViewTextBoxColumn.Name = "CountyDataGridViewTextBoxColumn"
        '
        'CountryDataGridViewTextBoxColumn
        '
        Me.CountryDataGridViewTextBoxColumn.DataPropertyName = "Country"
        Me.CountryDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.CountryDataGridViewTextBoxColumn.Name = "CountryDataGridViewTextBoxColumn"
        '
        'HomePhoneDataGridViewTextBoxColumn
        '
        Me.HomePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone"
        Me.HomePhoneDataGridViewTextBoxColumn.HeaderText = "HomePhone"
        Me.HomePhoneDataGridViewTextBoxColumn.Name = "HomePhoneDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 368)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOKANDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MOKANDataSet1 As MOKAN.MOKANDataSet1
    Friend WithEvents GeneralInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralInfoTableAdapter As MOKAN.MOKANDataSet1TableAdapters.GeneralInfoTableAdapter
    Friend WithEvents SSN4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrefixDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuffixDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreferredNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HomePhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
