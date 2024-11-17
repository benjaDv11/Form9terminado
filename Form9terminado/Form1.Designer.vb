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
        Panel1 = New Panel()
        BtnLimpiar = New Button()
        BtnBuscar = New Button()
        BtnActualizar = New Button()
        BtnBorrar = New Button()
        BtnGuardar = New Button()
        BtnVolver = New Button()
        DtpFecha = New DateTimePicker()
        DgvSolicitudes = New DataGridView()
        CmbEstado = New ComboBox()
        TxtSolicitudID = New TextBox()
        TxtRut = New TextBox()
        TxtDescripcion = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(DgvSolicitudes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(BtnLimpiar)
        Panel1.Controls.Add(BtnBuscar)
        Panel1.Controls.Add(BtnActualizar)
        Panel1.Controls.Add(BtnBorrar)
        Panel1.Controls.Add(BtnGuardar)
        Panel1.Controls.Add(BtnVolver)
        Panel1.Controls.Add(DtpFecha)
        Panel1.Controls.Add(DgvSolicitudes)
        Panel1.Controls.Add(CmbEstado)
        Panel1.Controls.Add(TxtSolicitudID)
        Panel1.Controls.Add(TxtRut)
        Panel1.Controls.Add(TxtDescripcion)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(44, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1038, 519)
        Panel1.TabIndex = 1
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.Location = New Point(249, 176)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(94, 30)
        BtnLimpiar.TabIndex = 26
        BtnLimpiar.Text = "Limpiar"
        BtnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.Location = New Point(249, 121)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(94, 49)
        BtnBuscar.TabIndex = 25
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = True
        ' 
        ' BtnActualizar
        ' 
        BtnActualizar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        BtnActualizar.Font = New Font("Yu Gothic", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnActualizar.Location = New Point(144, 407)
        BtnActualizar.Margin = New Padding(3, 4, 3, 4)
        BtnActualizar.Name = "BtnActualizar"
        BtnActualizar.Size = New Size(118, 47)
        BtnActualizar.TabIndex = 24
        BtnActualizar.Text = "ACTUALIZAR"
        BtnActualizar.UseVisualStyleBackColor = False
        ' 
        ' BtnBorrar
        ' 
        BtnBorrar.BackColor = Color.Red
        BtnBorrar.Font = New Font("Yu Gothic", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BtnBorrar.Location = New Point(268, 407)
        BtnBorrar.Margin = New Padding(3, 4, 3, 4)
        BtnBorrar.Name = "BtnBorrar"
        BtnBorrar.Size = New Size(118, 47)
        BtnBorrar.TabIndex = 23
        BtnBorrar.Text = "ELIMINAR"
        BtnBorrar.UseVisualStyleBackColor = False
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BtnGuardar.Font = New Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnGuardar.Location = New Point(23, 407)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(115, 47)
        BtnGuardar.TabIndex = 22
        BtnGuardar.Text = "Guardar"
        BtnGuardar.UseVisualStyleBackColor = False
        ' 
        ' BtnVolver
        ' 
        BtnVolver.Location = New Point(14, 16)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(94, 29)
        BtnVolver.TabIndex = 14
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = True
        ' 
        ' DtpFecha
        ' 
        DtpFecha.Location = New Point(153, 234)
        DtpFecha.Name = "DtpFecha"
        DtpFecha.Size = New Size(250, 27)
        DtpFecha.TabIndex = 13
        ' 
        ' DgvSolicitudes
        ' 
        DgvSolicitudes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvSolicitudes.Location = New Point(429, 162)
        DgvSolicitudes.Name = "DgvSolicitudes"
        DgvSolicitudes.RowHeadersWidth = 51
        DgvSolicitudes.Size = New Size(593, 190)
        DgvSolicitudes.TabIndex = 12
        ' 
        ' CmbEstado
        ' 
        CmbEstado.FormattingEnabled = True
        CmbEstado.Location = New Point(74, 104)
        CmbEstado.Name = "CmbEstado"
        CmbEstado.Size = New Size(141, 28)
        CmbEstado.TabIndex = 11
        ' 
        ' TxtSolicitudID
        ' 
        TxtSolicitudID.Location = New Point(109, 333)
        TxtSolicitudID.Name = "TxtSolicitudID"
        TxtSolicitudID.Size = New Size(125, 27)
        TxtSolicitudID.TabIndex = 10
        ' 
        ' TxtRut
        ' 
        TxtRut.Location = New Point(90, 162)
        TxtRut.Name = "TxtRut"
        TxtRut.Size = New Size(125, 27)
        TxtRut.TabIndex = 9
        ' 
        ' TxtDescripcion
        ' 
        TxtDescripcion.Location = New Point(180, 279)
        TxtDescripcion.Name = "TxtDescripcion"
        TxtDescripcion.Size = New Size(125, 27)
        TxtDescripcion.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 20)
        Label6.TabIndex = 5
        Label6.Text = "Estado"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 20)
        Label5.TabIndex = 4
        Label5.Text = "Descripción del vehiculo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 234)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 20)
        Label4.TabIndex = 3
        Label4.Text = "Fecha de la solicitud"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(14, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 20)
        Label3.TabIndex = 2
        Label3.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "Solicitud ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(326, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 31)
        Label1.TabIndex = 0
        Label1.Text = "SOLICITUD DE SERVICIO"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1183, 658)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DgvSolicitudes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnVolver As Button
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents DgvSolicitudes As DataGridView
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents TxtSolicitudID As TextBox
    Friend WithEvents TxtRut As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnLimpiar As Button

End Class
