<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.potBtn = New System.Windows.Forms.Button()
        Me.divBtn = New System.Windows.Forms.Button()
        Me.prodBtn = New System.Windows.Forms.Button()
        Me.difBtn = New System.Windows.Forms.Button()
        Me.sumBtn = New System.Windows.Forms.Button()
        Me.ProductoControl1 = New practicaFormularios.ProductoControl()
        Me.PotenciaControl1 = New practicaFormularios.PotenciaControl()
        Me.DivisionControl1 = New practicaFormularios.DivisionControl()
        Me.DiferenciaControl1 = New practicaFormularios.DiferenciaControl()
        Me.SumaControl1 = New practicaFormularios.SumaControl()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.potBtn)
        Me.Panel1.Controls.Add(Me.divBtn)
        Me.Panel1.Controls.Add(Me.prodBtn)
        Me.Panel1.Controls.Add(Me.difBtn)
        Me.Panel1.Controls.Add(Me.sumBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 561)
        Me.Panel1.TabIndex = 0
        '
        'potBtn
        '
        Me.potBtn.FlatAppearance.BorderSize = 0
        Me.potBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.potBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.potBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.potBtn.ForeColor = System.Drawing.Color.White
        Me.potBtn.Location = New System.Drawing.Point(0, 352)
        Me.potBtn.Name = "potBtn"
        Me.potBtn.Size = New System.Drawing.Size(200, 57)
        Me.potBtn.TabIndex = 1
        Me.potBtn.Text = "POTENCIA"
        Me.potBtn.UseVisualStyleBackColor = True
        '
        'divBtn
        '
        Me.divBtn.FlatAppearance.BorderSize = 0
        Me.divBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divBtn.ForeColor = System.Drawing.Color.White
        Me.divBtn.Location = New System.Drawing.Point(0, 289)
        Me.divBtn.Name = "divBtn"
        Me.divBtn.Size = New System.Drawing.Size(200, 57)
        Me.divBtn.TabIndex = 1
        Me.divBtn.Text = "DIVISION"
        Me.divBtn.UseVisualStyleBackColor = True
        '
        'prodBtn
        '
        Me.prodBtn.FlatAppearance.BorderSize = 0
        Me.prodBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.prodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.prodBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodBtn.ForeColor = System.Drawing.Color.White
        Me.prodBtn.Location = New System.Drawing.Point(0, 226)
        Me.prodBtn.Name = "prodBtn"
        Me.prodBtn.Size = New System.Drawing.Size(200, 57)
        Me.prodBtn.TabIndex = 1
        Me.prodBtn.Text = "PRODUCTO"
        Me.prodBtn.UseVisualStyleBackColor = True
        '
        'difBtn
        '
        Me.difBtn.FlatAppearance.BorderSize = 0
        Me.difBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.difBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.difBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.difBtn.ForeColor = System.Drawing.Color.White
        Me.difBtn.Location = New System.Drawing.Point(0, 163)
        Me.difBtn.Name = "difBtn"
        Me.difBtn.Size = New System.Drawing.Size(200, 57)
        Me.difBtn.TabIndex = 1
        Me.difBtn.Text = "DIFERENCIA"
        Me.difBtn.UseVisualStyleBackColor = True
        '
        'sumBtn
        '
        Me.sumBtn.FlatAppearance.BorderSize = 0
        Me.sumBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.sumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sumBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumBtn.ForeColor = System.Drawing.Color.White
        Me.sumBtn.Location = New System.Drawing.Point(0, 100)
        Me.sumBtn.Name = "sumBtn"
        Me.sumBtn.Size = New System.Drawing.Size(200, 57)
        Me.sumBtn.TabIndex = 1
        Me.sumBtn.Text = "SUMA"
        Me.sumBtn.UseVisualStyleBackColor = True
        '
        'ProductoControl1
        '
        Me.ProductoControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductoControl1.Location = New System.Drawing.Point(200, 0)
        Me.ProductoControl1.Name = "ProductoControl1"
        Me.ProductoControl1.Size = New System.Drawing.Size(684, 561)
        Me.ProductoControl1.TabIndex = 5
        '
        'PotenciaControl1
        '
        Me.PotenciaControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PotenciaControl1.Location = New System.Drawing.Point(200, 0)
        Me.PotenciaControl1.Name = "PotenciaControl1"
        Me.PotenciaControl1.Size = New System.Drawing.Size(684, 561)
        Me.PotenciaControl1.TabIndex = 4
        '
        'DivisionControl1
        '
        Me.DivisionControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DivisionControl1.Location = New System.Drawing.Point(200, 0)
        Me.DivisionControl1.Name = "DivisionControl1"
        Me.DivisionControl1.Size = New System.Drawing.Size(684, 561)
        Me.DivisionControl1.TabIndex = 3
        '
        'DiferenciaControl1
        '
        Me.DiferenciaControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DiferenciaControl1.Location = New System.Drawing.Point(200, 0)
        Me.DiferenciaControl1.Name = "DiferenciaControl1"
        Me.DiferenciaControl1.Size = New System.Drawing.Size(684, 561)
        Me.DiferenciaControl1.TabIndex = 2
        '
        'SumaControl1
        '
        Me.SumaControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SumaControl1.Location = New System.Drawing.Point(200, 0)
        Me.SumaControl1.Name = "SumaControl1"
        Me.SumaControl1.Size = New System.Drawing.Size(684, 561)
        Me.SumaControl1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.ProductoControl1)
        Me.Controls.Add(Me.PotenciaControl1)
        Me.Controls.Add(Me.DivisionControl1)
        Me.Controls.Add(Me.DiferenciaControl1)
        Me.Controls.Add(Me.SumaControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

        SumaControl1.Hide()
        DiferenciaControl1.Hide()
        ProductoControl1.Hide()
        DivisionControl1.Hide()
        PotenciaControl1.Hide()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents potBtn As Button
    Friend WithEvents divBtn As Button
    Friend WithEvents prodBtn As Button
    Friend WithEvents difBtn As Button
    Friend WithEvents sumBtn As Button
    Friend WithEvents SumaControl1 As SumaControl
    Friend WithEvents DiferenciaControl1 As DiferenciaControl
    Friend WithEvents DivisionControl1 As DivisionControl
    Friend WithEvents PotenciaControl1 As PotenciaControl
    Friend WithEvents ProductoControl1 As ProductoControl


End Class
