<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPrincipal))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbLIBROS = New System.Windows.Forms.RadioButton()
        Me.rbSM = New System.Windows.Forms.RadioButton()
        Me.rbHL = New System.Windows.Forms.RadioButton()
        Me.rbCA16 = New System.Windows.Forms.RadioButton()
        Me.rbVG = New System.Windows.Forms.RadioButton()
        Me.rbSG = New System.Windows.Forms.RadioButton()
        Me.rbLX = New System.Windows.Forms.RadioButton()
        Me.rbTM = New System.Windows.Forms.RadioButton()
        Me.rb5D = New System.Windows.Forms.RadioButton()
        Me.rbMO = New System.Windows.Forms.RadioButton()
        Me.rbMA = New System.Windows.Forms.RadioButton()
        Me.rbRZ = New System.Windows.Forms.RadioButton()
        Me.rbMD = New System.Windows.Forms.RadioButton()
        Me.rbPE = New System.Windows.Forms.RadioButton()
        Me.rbPA = New System.Windows.Forms.RadioButton()
        Me.rbCO = New System.Windows.Forms.RadioButton()
        Me.btnSeleccionarFicheros = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkSaltoFinal = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbLIBROS)
        Me.GroupBox1.Controls.Add(Me.rbSM)
        Me.GroupBox1.Controls.Add(Me.rbHL)
        Me.GroupBox1.Controls.Add(Me.rbCA16)
        Me.GroupBox1.Controls.Add(Me.rbVG)
        Me.GroupBox1.Controls.Add(Me.rbSG)
        Me.GroupBox1.Controls.Add(Me.rbLX)
        Me.GroupBox1.Controls.Add(Me.rbTM)
        Me.GroupBox1.Controls.Add(Me.rb5D)
        Me.GroupBox1.Controls.Add(Me.rbMO)
        Me.GroupBox1.Controls.Add(Me.rbMA)
        Me.GroupBox1.Controls.Add(Me.rbRZ)
        Me.GroupBox1.Controls.Add(Me.rbMD)
        Me.GroupBox1.Controls.Add(Me.rbPE)
        Me.GroupBox1.Controls.Add(Me.rbPA)
        Me.GroupBox1.Controls.Add(Me.rbCO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 125)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Publicación"
        '
        'rbLIBROS
        '
        Me.rbLIBROS.AutoSize = True
        Me.rbLIBROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbLIBROS.Location = New System.Drawing.Point(389, 93)
        Me.rbLIBROS.Name = "rbLIBROS"
        Me.rbLIBROS.Size = New System.Drawing.Size(101, 17)
        Me.rbLIBROS.TabIndex = 16
        Me.rbLIBROS.TabStop = True
        Me.rbLIBROS.Text = "Libros (LIBROS)"
        Me.rbLIBROS.UseVisualStyleBackColor = True
        '
        'rbSM
        '
        Me.rbSM.AutoSize = True
        Me.rbSM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbSM.Location = New System.Drawing.Point(389, 70)
        Me.rbSM.Name = "rbSM"
        Me.rbSM.Size = New System.Drawing.Size(89, 17)
        Me.rbSM.TabIndex = 15
        Me.rbSM.TabStop = True
        Me.rbSM.Text = "Semana (SM)"
        Me.rbSM.UseVisualStyleBackColor = True
        '
        'rbHL
        '
        Me.rbHL.AutoSize = True
        Me.rbHL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbHL.Location = New System.Drawing.Point(389, 47)
        Me.rbHL.Name = "rbHL"
        Me.rbHL.Size = New System.Drawing.Size(70, 17)
        Me.rbHL.TabIndex = 14
        Me.rbHL.TabStop = True
        Me.rbHL.Text = "Hola (HL)"
        Me.rbHL.UseVisualStyleBackColor = True
        '
        'rbCA16
        '
        Me.rbCA16.AutoSize = True
        Me.rbCA16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbCA16.Location = New System.Drawing.Point(389, 24)
        Me.rbCA16.Name = "rbCA16"
        Me.rbCA16.Size = New System.Drawing.Size(110, 17)
        Me.rbCA16.TabIndex = 13
        Me.rbCA16.TabStop = True
        Me.rbCA16.Text = "Cambio 16 (CA16)"
        Me.rbCA16.UseVisualStyleBackColor = True
        '
        'rbVG
        '
        Me.rbVG.AutoSize = True
        Me.rbVG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbVG.Location = New System.Drawing.Point(259, 24)
        Me.rbVG.Name = "rbVG"
        Me.rbVG.Size = New System.Drawing.Size(118, 17)
        Me.rbVG.TabIndex = 12
        Me.rbVG.TabStop = True
        Me.rbVG.Text = "La Vanguardia (VG)"
        Me.rbVG.UseVisualStyleBackColor = True
        '
        'rbSG
        '
        Me.rbSG.AutoSize = True
        Me.rbSG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbSG.Location = New System.Drawing.Point(259, 47)
        Me.rbSG.Name = "rbSG"
        Me.rbSG.Size = New System.Drawing.Size(72, 17)
        Me.rbSG.TabIndex = 11
        Me.rbSG.TabStop = True
        Me.rbSG.Text = "Siglo (SG)"
        Me.rbSG.UseVisualStyleBackColor = True
        '
        'rbLX
        '
        Me.rbLX.AutoSize = True
        Me.rbLX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbLX.Location = New System.Drawing.Point(259, 70)
        Me.rbLX.Name = "rbLX"
        Me.rbLX.Size = New System.Drawing.Size(92, 17)
        Me.rbLX.TabIndex = 10
        Me.rbLX.TabStop = True
        Me.rbLX.Text = "L'Express (LX)"
        Me.rbLX.UseVisualStyleBackColor = True
        '
        'rbTM
        '
        Me.rbTM.AutoSize = True
        Me.rbTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbTM.Location = New System.Drawing.Point(259, 93)
        Me.rbTM.Name = "rbTM"
        Me.rbTM.Size = New System.Drawing.Size(73, 17)
        Me.rbTM.TabIndex = 9
        Me.rbTM.TabStop = True
        Me.rbTM.Text = "Time (TM)"
        Me.rbTM.UseVisualStyleBackColor = True
        '
        'rb5D
        '
        Me.rb5D.AutoSize = True
        Me.rb5D.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rb5D.Location = New System.Drawing.Point(141, 93)
        Me.rb5D.Name = "rb5D"
        Me.rb5D.Size = New System.Drawing.Size(101, 17)
        Me.rb5D.TabIndex = 8
        Me.rb5D.TabStop = True
        Me.rb5D.Text = "Cinco Días (5D)"
        Me.rb5D.UseVisualStyleBackColor = True
        '
        'rbMO
        '
        Me.rbMO.AutoSize = True
        Me.rbMO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbMO.Location = New System.Drawing.Point(141, 70)
        Me.rbMO.Name = "rbMO"
        Me.rbMO.Size = New System.Drawing.Size(99, 17)
        Me.rbMO.TabIndex = 7
        Me.rbMO.TabStop = True
        Me.rbMO.Text = "Le Monde (MO)"
        Me.rbMO.UseVisualStyleBackColor = True
        '
        'rbMA
        '
        Me.rbMA.AutoSize = True
        Me.rbMA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbMA.Location = New System.Drawing.Point(141, 47)
        Me.rbMA.Name = "rbMA"
        Me.rbMA.Size = New System.Drawing.Size(80, 17)
        Me.rbMA.TabIndex = 6
        Me.rbMA.TabStop = True
        Me.rbMA.Text = "Marca (MA)"
        Me.rbMA.UseVisualStyleBackColor = True
        '
        'rbRZ
        '
        Me.rbRZ.AutoSize = True
        Me.rbRZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbRZ.Location = New System.Drawing.Point(141, 24)
        Me.rbRZ.Name = "rbRZ"
        Me.rbRZ.Size = New System.Drawing.Size(95, 17)
        Me.rbRZ.TabIndex = 5
        Me.rbRZ.TabStop = True
        Me.rbRZ.Text = "La Razón (RZ)"
        Me.rbRZ.UseVisualStyleBackColor = True
        '
        'rbMD
        '
        Me.rbMD.AutoSize = True
        Me.rbMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbMD.Location = New System.Drawing.Point(20, 93)
        Me.rbMD.Name = "rbMD"
        Me.rbMD.Size = New System.Drawing.Size(96, 17)
        Me.rbMD.TabIndex = 4
        Me.rbMD.TabStop = True
        Me.rbMD.Text = "El Mundo (MD)"
        Me.rbMD.UseVisualStyleBackColor = True
        '
        'rbPE
        '
        Me.rbPE.AutoSize = True
        Me.rbPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbPE.Location = New System.Drawing.Point(20, 70)
        Me.rbPE.Name = "rbPE"
        Me.rbPE.Size = New System.Drawing.Size(103, 17)
        Me.rbPE.TabIndex = 3
        Me.rbPE.TabStop = True
        Me.rbPE.Text = "P. Cataluña (PE)"
        Me.rbPE.UseVisualStyleBackColor = True
        '
        'rbPA
        '
        Me.rbPA.AutoSize = True
        Me.rbPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbPA.Location = New System.Drawing.Point(20, 24)
        Me.rbPA.Name = "rbPA"
        Me.rbPA.Size = New System.Drawing.Size(82, 17)
        Me.rbPA.TabIndex = 1
        Me.rbPA.TabStop = True
        Me.rbPA.Text = "El País (PA)"
        Me.rbPA.UseVisualStyleBackColor = True
        '
        'rbCO
        '
        Me.rbCO.AutoSize = True
        Me.rbCO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.rbCO.Location = New System.Drawing.Point(20, 47)
        Me.rbCO.Name = "rbCO"
        Me.rbCO.Size = New System.Drawing.Size(80, 17)
        Me.rbCO.TabIndex = 2
        Me.rbCO.TabStop = True
        Me.rbCO.Text = "Correo (CO)"
        Me.rbCO.UseVisualStyleBackColor = True
        '
        'btnSeleccionarFicheros
        '
        Me.btnSeleccionarFicheros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSeleccionarFicheros.Location = New System.Drawing.Point(12, 355)
        Me.btnSeleccionarFicheros.Name = "btnSeleccionarFicheros"
        Me.btnSeleccionarFicheros.Size = New System.Drawing.Size(518, 36)
        Me.btnSeleccionarFicheros.TabIndex = 6
        Me.btnSeleccionarFicheros.Text = "Seleccionar Ficheros TXT"
        Me.btnSeleccionarFicheros.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Logo_Doc_it
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(251, 187)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.Logo_RTVE
        Me.PictureBox2.Location = New System.Drawing.Point(318, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(172, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'chkSaltoFinal
        '
        Me.chkSaltoFinal.AutoSize = True
        Me.chkSaltoFinal.Location = New System.Drawing.Point(304, 207)
        Me.chkSaltoFinal.Name = "chkSaltoFinal"
        Me.chkSaltoFinal.Size = New System.Drawing.Size(226, 17)
        Me.chkSaltoFinal.TabIndex = 9
        Me.chkSaltoFinal.Text = "Salto de página al final (OCR con Acrobat)"
        Me.chkSaltoFinal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(493, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "v1.0.1"
        '
        'FormularioPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 410)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkSaltoFinal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSeleccionarFicheros)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormularioPrincipal"
        Me.Text = "Aplicación para la Numeración de Ficheros TXT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLIBROS As RadioButton
    Friend WithEvents rbSM As RadioButton
    Friend WithEvents rbHL As RadioButton
    Friend WithEvents rbCA16 As RadioButton
    Friend WithEvents rbVG As RadioButton
    Friend WithEvents rbSG As RadioButton
    Friend WithEvents rbLX As RadioButton
    Friend WithEvents rbTM As RadioButton
    Friend WithEvents rb5D As RadioButton
    Friend WithEvents rbMO As RadioButton
    Friend WithEvents rbMA As RadioButton
    Friend WithEvents rbRZ As RadioButton
    Friend WithEvents rbMD As RadioButton
    Friend WithEvents rbPE As RadioButton
    Friend WithEvents rbPA As RadioButton
    Friend WithEvents rbCO As RadioButton
    Friend WithEvents btnSeleccionarFicheros As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkSaltoFinal As CheckBox
    Friend WithEvents Label1 As Label
End Class
