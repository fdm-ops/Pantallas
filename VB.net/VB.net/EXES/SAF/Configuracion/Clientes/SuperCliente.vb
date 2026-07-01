Public Class SuperCliente
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PBImagen As System.Windows.Forms.PictureBox
    Friend WithEvents cmbModificar As System.Windows.Forms.Button
    Friend WithEvents cmbLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmbEliminar As System.Windows.Forms.Button
    Friend WithEvents cmbAgregar As System.Windows.Forms.Button
    Friend WithEvents CBConexiones As MulticolumCombo.MulticolumnCombo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSuperCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtContrato As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtImagen As System.Windows.Forms.TextBox
    Friend WithEvents cmbImagen As System.Windows.Forms.Button
    Friend WithEvents OFImagen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GDSuperCliente As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbBorraImagen As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBConexiones = New MulticolumCombo.MulticolumnCombo()
        Me.cmbImagen = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbModificar = New System.Windows.Forms.Button()
        Me.TxtContrato = New System.Windows.Forms.TextBox()
        Me.cmbLimpiar = New System.Windows.Forms.Button()
        Me.TxtImagen = New System.Windows.Forms.TextBox()
        Me.cmbEliminar = New System.Windows.Forms.Button()
        Me.TxtSuperCliente = New System.Windows.Forms.TextBox()
        Me.cmbAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PBImagen = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GDSuperCliente = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
        Me.OFImagen = New System.Windows.Forms.OpenFileDialog()
        Me.cmbBorraImagen = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CBConexiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GDSuperCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(481, 491)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbBorraImagen)
        Me.GroupBox3.Controls.Add(Me.CBConexiones)
        Me.GroupBox3.Controls.Add(Me.cmbImagen)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cmbModificar)
        Me.GroupBox3.Controls.Add(Me.TxtContrato)
        Me.GroupBox3.Controls.Add(Me.cmbLimpiar)
        Me.GroupBox3.Controls.Add(Me.TxtImagen)
        Me.GroupBox3.Controls.Add(Me.cmbEliminar)
        Me.GroupBox3.Controls.Add(Me.TxtSuperCliente)
        Me.GroupBox3.Controls.Add(Me.cmbAgregar)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.PBImagen)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 315)
        Me.GroupBox3.TabIndex = 101
        Me.GroupBox3.TabStop = False
        '
        'CBConexiones
        '
        Me.CBConexiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBConexiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBConexiones.Location = New System.Drawing.Point(9, 32)
        Me.CBConexiones.Name = "CBConexiones"
        Me.CBConexiones.Size = New System.Drawing.Size(316, 21)
        Me.CBConexiones.TabIndex = 1
        '
        'cmbImagen
        '
        Me.cmbImagen.Location = New System.Drawing.Point(354, 150)
        Me.cmbImagen.Name = "cmbImagen"
        Me.cmbImagen.Size = New System.Drawing.Size(88, 27)
        Me.cmbImagen.TabIndex = 9
        Me.cmbImagen.Text = "Imagen"
        Me.cmbImagen.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Contrato SuperCliente :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Imagen:"
        '
        'cmbModificar
        '
        Me.cmbModificar.Location = New System.Drawing.Point(354, 57)
        Me.cmbModificar.Name = "cmbModificar"
        Me.cmbModificar.Size = New System.Drawing.Size(88, 27)
        Me.cmbModificar.TabIndex = 6
        Me.cmbModificar.Text = "Modificar"
        Me.cmbModificar.Visible = False
        '
        'TxtContrato
        '
        Me.TxtContrato.Location = New System.Drawing.Point(6, 74)
        Me.TxtContrato.Name = "TxtContrato"
        Me.TxtContrato.Size = New System.Drawing.Size(118, 20)
        Me.TxtContrato.TabIndex = 2
        '
        'cmbLimpiar
        '
        Me.cmbLimpiar.Location = New System.Drawing.Point(354, 119)
        Me.cmbLimpiar.Name = "cmbLimpiar"
        Me.cmbLimpiar.Size = New System.Drawing.Size(88, 27)
        Me.cmbLimpiar.TabIndex = 8
        Me.cmbLimpiar.Text = "Limpiar"
        Me.cmbLimpiar.Visible = False
        '
        'TxtImagen
        '
        Me.TxtImagen.Enabled = False
        Me.TxtImagen.Location = New System.Drawing.Point(6, 161)
        Me.TxtImagen.Name = "TxtImagen"
        Me.TxtImagen.Size = New System.Drawing.Size(319, 20)
        Me.TxtImagen.TabIndex = 4
        Me.TxtImagen.TabStop = False
        '
        'cmbEliminar
        '
        Me.cmbEliminar.Location = New System.Drawing.Point(354, 88)
        Me.cmbEliminar.Name = "cmbEliminar"
        Me.cmbEliminar.Size = New System.Drawing.Size(88, 27)
        Me.cmbEliminar.TabIndex = 7
        Me.cmbEliminar.Text = "Eliminar"
        Me.cmbEliminar.Visible = False
        '
        'TxtSuperCliente
        '
        Me.TxtSuperCliente.Location = New System.Drawing.Point(6, 117)
        Me.TxtSuperCliente.Name = "TxtSuperCliente"
        Me.TxtSuperCliente.Size = New System.Drawing.Size(319, 20)
        Me.TxtSuperCliente.TabIndex = 3
        '
        'cmbAgregar
        '
        Me.cmbAgregar.Location = New System.Drawing.Point(354, 26)
        Me.cmbAgregar.Name = "cmbAgregar"
        Me.cmbAgregar.Size = New System.Drawing.Size(88, 27)
        Me.cmbAgregar.TabIndex = 5
        Me.cmbAgregar.Text = "Agregar"
        Me.cmbAgregar.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 14)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Nombre del SuperCliente :"
        '
        'PBImagen
        '
        Me.PBImagen.Location = New System.Drawing.Point(6, 196)
        Me.PBImagen.Name = "PBImagen"
        Me.PBImagen.Size = New System.Drawing.Size(172, 112)
        Me.PBImagen.TabIndex = 19
        Me.PBImagen.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 28)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Base de Datos :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GDSuperCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 323)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 164)
        Me.GroupBox1.TabIndex = 100
        Me.GroupBox1.TabStop = False
        '
        'GDSuperCliente
        '
        Me.GDSuperCliente.AllowDragSelectedCols = True
        Me.GDSuperCliente.EnableAddNew = False
        Me.GDSuperCliente.EnableEdit = False
        Me.GDSuperCliente.EnableRemove = False
        Me.GDSuperCliente.Location = New System.Drawing.Point(7, 19)
        Me.GDSuperCliente.Name = "GDSuperCliente"
        Me.GDSuperCliente.OptimizeInsertRemoveCells = True
        Me.GDSuperCliente.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.GDSuperCliente.Size = New System.Drawing.Size(450, 136)
        Me.GDSuperCliente.SmartSizeBox = False
        Me.GDSuperCliente.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.GDSuperCliente.TabIndex = 10
        Me.GDSuperCliente.TabStop = False
        Me.GDSuperCliente.Text = "GridDataBoundGrid1"
        Me.GDSuperCliente.UseListChangedEvent = True
        '
        'OFImagen
        '
        Me.OFImagen.Filter = "Imagenes jpg|*.jpg|Imagenes gif|*.gif|Imagenes png|*.png"
        Me.OFImagen.Title = "Imagen"
        '
        'cmbBorraImagen
        '
        Me.cmbBorraImagen.Location = New System.Drawing.Point(354, 181)
        Me.cmbBorraImagen.Name = "cmbBorraImagen"
        Me.cmbBorraImagen.Size = New System.Drawing.Size(88, 27)
        Me.cmbBorraImagen.TabIndex = 101
        Me.cmbBorraImagen.Text = "Borra Imagen"
        Me.cmbBorraImagen.Visible = False
        '
        'SuperCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 499)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "SuperCliente"
        Me.Text = "Super Clientes"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CBConexiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GDSuperCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub SuperCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lsError As String = ""
        Dim lsSql As String = ""
        Dim lds As New DataSet()
        Dim lsS As String = ""

        On Error GoTo Errores

        LLenaConexiones(CBConexiones)
        If Not LLenaSuperCliente(lsError) Then GoTo Errores

        'Revisar si perfil tiene acceso a datos sensibles
        lsSql = "30"
        lsSql = lsSql & ",@giIdUsuario='" & glIdUsuario & "'"
        lsSql = lsSql & ",@OrigenPeticion='" & gsOrigenPeticion & "'"
        If Not ConexionBaseDatos("103", lsSql, lds, , True, , lsError) Then GoTo Errores
        lsS = lds.Tables(0).Rows.Item(0).Item("accesoDatosSensibles")

        If lsS = "S" Then
            TxtSuperCliente.UseSystemPasswordChar = False
        Else
            TxtSuperCliente.UseSystemPasswordChar = True
        End If

        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "SuperCliente_Load", Me.Name, 1, lsError)
        End If
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)
    End Sub

    Private Function LLenaSuperCliente(ByRef psError As String) As Boolean
        Dim lsSql As String
        Dim lds As New DataSet()
        Dim objFilterBar As New Syncfusion.Windows.Forms.Grid.GridFilterBar
        Dim Lix As Integer
        On Error GoTo Errores

        lsSql = "11,@IdConexion=" & CBConexiones.SelectedValue
        If Not ConexionBaseDatos("3", lsSql, lds, , True, , psError) Then GoTo Errores
        GDSuperCliente.DataSource = lds.Tables(0)

        objFilterBar.WireGrid(GDSuperCliente)
        objFilterBar.ResetFilterRow(GDSuperCliente)

        GDSuperCliente.Model.ColWidths(2) = 150
        GDSuperCliente.Model.ColWidths(3) = 150
        GDSuperCliente.Model.ColWidths(5) = 150

        GDSuperCliente.SetColHidden(1, 1, True)
        GDSuperCliente.SetColHidden(4, 4, True)
        GDSuperCliente.SetColHidden(6, 6, True)
        GDSuperCliente.SetColHidden(7, 7, True)
        GDSuperCliente.TableStyle.CellType = "Static"

        For Lix = 1 To GDSuperCliente.Model.RowCount
            If Trim(GDSuperCliente(Lix, 5).Text) <> "" Then
                If Dir(gsPathDirectorioTrabajo & gsPathImagenes & GDSuperCliente(Lix, 5).Text) = "" Then
                    If Not TraeArchivoServidor(GDSuperCliente(Lix, 5).Text, GDSuperCliente(Lix, 5).Text, gsPathImagenes, gsPathDirectorioTrabajo & gsPathImagenes, psError) Then GoTo Errores
                End If
            Else
                If Dir(gsPathDirectorioTrabajo & gsPathImagenes & gsLogoSitema) = "" Then
                    If Not TraeArchivoServidor(gsLogoSitema, gsLogoSitema, gsPathImagenes, gsPathDirectorioTrabajo & gsPathImagenes, psError) Then GoTo Errores
                End If
            End If
        Next

        If Not LLenaDatos(2, psError) Then GoTo Errores

        LLenaSuperCliente = True
        Exit Function
Errores:
        If psError = "" Then
            gobjEventos.Evento(Err, "LLenaSuperCliente", Me.Name, 1, psError)
        End If

    End Function

    Private Sub Limpiar()
        TxtContrato.Text = ""
        TxtSuperCliente.Text = ""
        TxtImagen.Text = ""
    End Sub
    Public Function LLenaDatos(ByVal piRenglon As Integer, ByRef psError As String) As Boolean
        On Error GoTo Errores
        Limpiar()

        If GDSuperCliente.Model.RowCount > 1 Then
            If piRenglon = 1 Then LLenaDatos = True : Exit Function
            TxtContrato.Text = Trim(GDSuperCliente(piRenglon, 2).Text)
            TxtSuperCliente.Text = Trim(GDSuperCliente(piRenglon, 7).Text)
            If Not objHerramientas.BuscaItem(CBConexiones, GDSuperCliente(piRenglon, 4).Text, psError) Then GoTo Errores
            TxtImagen.Text = Trim(GDSuperCliente(piRenglon, 5).Text)

            If Trim(GDSuperCliente(piRenglon, 5).Text) <> "" Then
                If Dir(gsPathDirectorioTrabajo & gsPathImagenes & GDSuperCliente(piRenglon, 5).Text) = "" Then
                    If Not TraeArchivoServidor(GDSuperCliente(piRenglon, 5).Text, GDSuperCliente(piRenglon, 5).Text, gsPathImagenes, gsPathDirectorioTrabajo & gsPathImagenes, psError) Then GoTo Errores
                End If
                PBImagen.Image = System.Drawing.Image.FromFile(gsPathDirectorioTrabajo & gsPathImagenes & GDSuperCliente(piRenglon, 5).Text)
            Else
                If Dir(gsPathDirectorioTrabajo & gsPathImagenes & gsLogoSitema) = "" Then
                    If Not TraeArchivoServidor(gsLogoSitema, gsLogoSitema, gsPathImagenes, gsPathDirectorioTrabajo & gsPathImagenes, psError) Then GoTo Errores
                End If
                PBImagen.Image = System.Drawing.Image.FromFile(gsPathDirectorioTrabajo & gsPathImagenes & gsLogoSitema)
            End If

        End If

        LLenaDatos = True
        Exit Function
Errores:
        If psError = "" Then
            gobjEventos.Evento(Err, "LLenaDatos", Me.Name, 1, psError)
        End If
    End Function

    Private Sub GDSuperCliente_RowEnter(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridRowEventArgs) Handles GDSuperCliente.RowEnter
        Dim lsError As String = ""
        Dim lsSql As String
        On Error GoTo Errores
        Me.Cursor = Cursors.WaitCursor

        If GDSuperCliente.Model.RowCount And e.RowIndex <= 0 Then Exit Sub

        If GDSuperCliente.Model.RowCount And e.RowIndex > 0 Then
            GDSuperCliente.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Column.Equals(2)
            GDSuperCliente.Selections.Clear()
            GDSuperCliente.Selections.Add(GDSuperCliente.Model.Rows.CreateRangeFromTo(e.RowIndex, e.RowIndex))
            If Not LLenaDatos(e.RowIndex, lsError) Then GoTo Errores
        End If

        Me.Cursor = Cursors.Default
        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "GDSuperCliente_RowEnter", Me.Name, 1, lsError)
        End If
        Me.Cursor = Cursors.Default
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)
    End Sub

    Private Sub cmbAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAgregar.Click
        Dim lsSql As String
        Dim lds As New DataSet()
        Dim lsError As String = ""
        Dim llIdSuperCliente As Long
        On Error GoTo Errores
        Me.Cursor = Cursors.WaitCursor

        If Trim(TxtContrato.Text) = "" Or Trim(TxtSuperCliente.Text) = "" Or CBConexiones.SelectedIndex < 0 Then Me.Cursor = Cursors.Default : Exit Sub

        lsSql = "5"
        lsSql = lsSql & ",@NumSuperCliente='" & TxtContrato.Text & "'"
        If Not ConexionBDFuncion(Me, sender, "3", lsSql, lds, , True, , lsError) Then GoTo Errores

        If lds.Tables(0).Rows.Item(0).Item("valida") = 0 Then lsError = "Ya existe un supercliente con este contrato." : GoTo Errores



        lsSql = "3"
        lsSql = lsSql & ",@NumSuperCliente='" & TxtContrato.Text & "'"
        lsSql = lsSql & ",@Nombre='" & TxtSuperCliente.Text & "'"
        lsSql = lsSql & ",@IdConexion=" & CBConexiones.SelectedValue
        lsSql = lsSql & ",@Imagen='" & TxtImagen.Text & "'"
        lsSql = lsSql & ",@IdUsuario=" & CStr(glIdUsuario)
        If Not ConexionBDFuncion(Me, sender, "3", lsSql, lds, , True, , lsError) Then GoTo Errores
        llIdSuperCliente = lds.Tables(0).Rows.Item(0).Item(0)



        lsSql = "3"
        lsSql = lsSql & ",@IdSuperCliente=" & llIdSuperCliente
        lsSql = lsSql & ",@NumSuperCliente='" & TxtContrato.Text & "'"
        lsSql = lsSql & ",@Nombre='" & TxtSuperCliente.Text & "'"
        lsSql = lsSql & ",@Imagen='" & TxtImagen.Text & "'"
        lsSql = lsSql & ",@giIdUsuario=" & CStr(glIdUsuario)
        If Not ConexionBDFuncion(Me, sender, "60", lsSql, , , , CBConexiones, lsError) Then GoTo Errores


        If Not LLenaSuperCliente(lsError) Then GoTo Errores

        Me.Cursor = Cursors.Default
        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "cmbAgregar_Click_1", Me.Name, 1, lsError)
        End If
        Me.Cursor = Cursors.Default
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)

    End Sub

    Private Sub cmbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEliminar.Click
        Dim lsSql As String
        Dim lds As New DataSet()
        Dim lsError As String = ""
        Dim lobj As New Login()
        On Error GoTo Errores
        Me.Cursor = Cursors.WaitCursor

        If GDSuperCliente.Model.RowCount <= 1 Or GDSuperCliente.CurrentCell.RowIndex <= 1 Then Me.Cursor = Cursors.Default : Exit Sub

        'lsMensaje = "Al borrar el Super Cliente se borraran los clientes asociados a este supercliente." & Chr(13)
        'lsMensaje = lsMensaje & "Esta seguro de Borrarlo?."
        If MsgBox(ObtenMensaje(24), MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        lobj.ShowDialog()

        If Not GbValidaUsuario Then
            lsError = "Usuario o password Incorrecto"
            GoTo Errores
        End If

        lsSql = "4"
        lsSql = lsSql & ",@IdSuperCliente=" & GDSuperCliente(GDSuperCliente.CurrentCell.RowIndex, 1).Text
        lsSql = lsSql & ",@giIdUsuario=" & CStr(glIdUsuario)
        If Not ConexionBDFuncion(Me, sender, "60", lsSql, , 1000, , CBConexiones, lsError) Then GoTo Errores

        lsSql = "4"
        lsSql = lsSql & ",@IdSuperCliente=" & GDSuperCliente(GDSuperCliente.CurrentCell.RowIndex, 1).Text
        If Not ConexionBDFuncion(Me, sender, "3", lsSql, lds, 1000, True, , lsError) Then GoTo Errores

        If Not LLenaSuperCliente(lsError) Then GoTo Errores

        Me.Cursor = Cursors.Default
        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "cmbEliminar_Click", Me.Name, 1, lsError)
        End If
        Me.Cursor = Cursors.Default
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)

    End Sub

    Private Sub cmbImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbImagen.Click
        Dim lsArchivo As String
        Dim lsPathImagen As String
        Dim lsSesion As String
        Dim lsError As String = ""
        On Error GoTo Errores
        Me.Cursor = Cursors.WaitCursor
        lsSesion = Format(Now, "yyyyMMddmmss")

        If OFImagen.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Me.Cursor = Cursors.Default : Exit Sub

        lsPathImagen = Mid(OFImagen.FileName, 1, InStrRev(OFImagen.FileName, "\"))
        lsArchivo = Mid(OFImagen.FileName, InStrRev(OFImagen.FileName, "\") + 1)
        TxtImagen.Text = lsSesion & " - " & lsArchivo
        FileCopy(lsPathImagen & lsArchivo, gsPathDirectorioTrabajo & gsPathImagenes & TxtImagen.Text)
        If Not EnviaArchivoServidor(TxtImagen.Text, TxtImagen.Text, gsPathDirectorioTrabajo & gsPathImagenes, gsPathImagenes, lsError) Then GoTo Errores
        PBImagen.Image = System.Drawing.Image.FromFile(gsPathDirectorioTrabajo & gsPathImagenes & TxtImagen.Text)

        Me.Cursor = Cursors.Default
        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "cmbEliminar_Click", Me.Name, 1, lsError)
        End If
        Me.Cursor = Cursors.Default
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)

    End Sub

    Private Sub cmbModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModificar.Click
        Dim lsSql As String
        Dim lds As New DataSet()
        Dim lsError As String = ""
        On Error GoTo Errores
        Me.Cursor = Cursors.WaitCursor

        If Trim(TxtContrato.Text) = "" Or Trim(TxtSuperCliente.Text) = "" Or CBConexiones.SelectedIndex < 0 Or GDSuperCliente.CurrentCell.RowIndex <= 1 Then Me.Cursor = Cursors.Default : Exit Sub

        lsSql = "6"
        lsSql = lsSql & ",@IdSuperCliente=" & GDSuperCliente(GDSuperCliente.CurrentCell.RowIndex, 1).Text
        lsSql = lsSql & ",@NumSuperCliente='" & TxtContrato.Text & "'"
        If Not objConexionBD.SqlConsultaCod(GiIdConexion, 1, "3", lsSql, lds, lsError) Then GoTo Errores
        If lds.Tables(0).Rows.Item(0).Item("valida") <> 1 Then lsError = "No existe un supercliente con este contrato." : GoTo Errores

        lsSql = "2"
        lsSql = lsSql & ",@IdSuperCliente=" & GDSuperCliente(GDSuperCliente.CurrentCell.RowIndex, 1).Text
        lsSql = lsSql & ",@NumSuperCliente='" & TxtContrato.Text & "'"
        lsSql = lsSql & ",@Nombre='" & TxtSuperCliente.Text & "'"
        lsSql = lsSql & ",@Imagen='" & TxtImagen.Text & "'"
        lsSql = lsSql & ",@giIdUsuario=" & CStr(glIdUsuario)
        If Not ConexionBDFuncion(Me, sender, "60", lsSql, , , , CBConexiones, lsError) Then GoTo Errores

        lsSql = "2"
        lsSql = lsSql & ",@IdSuperCliente=" & GDSuperCliente(GDSuperCliente.CurrentCell.RowIndex, 1).Text
        lsSql = lsSql & ",@NumSuperCliente='" & TxtContrato.Text & "'"
        lsSql = lsSql & ",@Nombre='" & TxtSuperCliente.Text & "'"
        lsSql = lsSql & ",@IdConexion=" & CBConexiones.SelectedValue
        lsSql = lsSql & ",@Imagen='" & TxtImagen.Text & "'"
        lsSql = lsSql & ",@IdUsuario=" & CStr(glIdUsuario)
        If Not ConexionBDFuncion(Me, sender, "3", lsSql, lds, , True, , lsError) Then GoTo Errores
        If Not LLenaSuperCliente(lsError) Then GoTo Errores
        MsgBox(ObtenMensaje(11), MsgBoxStyle.Information, Me.Text) 'Cambios realizados correctamente
        Me.Cursor = Cursors.Default
        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "cmbModificar_Click_1", Me.Name, 1, lsError)
        End If
        Me.Cursor = Cursors.Default
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)
    End Sub

    Private Sub cmbLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLimpiar.Click
        Limpiar()
    End Sub


    Private Sub CBConexiones_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBConexiones.SelectionChangeCommitted
        Dim lsError As String = ""

        On Error GoTo Errores

        If Not LLenaSuperCliente(lsError) Then GoTo Errores

        Exit Sub
Errores:
        If lsError = "" Then
            gobjEventos.Evento(Err, "CBConexiones_SelectionChangeCommitted", Me.Name, 1, lsError)
        End If
        MsgBox("Error. " & lsError, MsgBoxStyle.Critical, Me.text)
    End Sub

    Private Sub cmbBorraImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBorraImagen.Click
        TxtImagen.Text = ""
    End Sub
End Class
