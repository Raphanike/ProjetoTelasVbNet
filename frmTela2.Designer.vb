<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTela2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmpCliente1 = New GesPlacas.cmpCliente()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nomeDoc = New System.Windows.Forms.TextBox()
        Me.cmbSituacao = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnCadastro = New System.Windows.Forms.Button()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.dgvTela = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Usuario :"
        '
        'CmpCliente1
        '
        Me.CmpCliente1.AceitarClienteGenérico = LDN_REGRAS.Modelos.SimNao.Não
        Me.CmpCliente1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CmpCliente1.DescriçãoDoLabel = Nothing
        Me.CmpCliente1.ÉFranquia = False
        Me.CmpCliente1.EntidadeObrigatória = LDN_REGRAS.Modelos.SimNao.Sim
        Me.CmpCliente1.ErroDeValidação = ""
        Me.CmpCliente1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CmpCliente1.ForeColor = System.Drawing.Color.Black
        Me.CmpCliente1.IgnorarValidaçãoDeCrédito = LDN_REGRAS.Modelos.SimNao.Não
        Me.CmpCliente1.Location = New System.Drawing.Point(45, 9)
        Me.CmpCliente1.Name = "CmpCliente1"
        Me.CmpCliente1.NrdeParcelasDaVenda = CType(0, Short)
        Me.CmpCliente1.ProgramaOrigem = Nothing
        Me.CmpCliente1.Size = New System.Drawing.Size(451, 43)
        Me.CmpCliente1.SolicitaLiberação = LDN_REGRAS.Modelos.SimNao.Sim
        Me.CmpCliente1.SomenteLeitura = False
        Me.CmpCliente1.TabIndex = 40
        Me.CmpCliente1.TipoDeEntidade = LDN_REGRAS.Modelos.TiposDeEntidade.Cliente
        Me.CmpCliente1.TipoDePessoa = LDN_REGRAS.Modelos.TiposDePessoasSelecao.Todos
        Me.CmpCliente1.TipoDeProblemaNoCrédito = LDN_REGRAS.Modelos.TiposDeProblemaComCrédito.Sem_problemas_Liberado
        Me.CmpCliente1.Valor = 0
        Me.CmpCliente1.ValorDaVendaParaLimite = 0R
        Me.CmpCliente1.VizualizaNomeFantasia = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(242, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Nome Documento :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tipo do Documento :"
        '
        'nomeDoc
        '
        Me.nomeDoc.Location = New System.Drawing.Point(242, 73)
        Me.nomeDoc.Name = "nomeDoc"
        Me.nomeDoc.Size = New System.Drawing.Size(268, 20)
        Me.nomeDoc.TabIndex = 37
        '
        'cmbSituacao
        '
        Me.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSituacao.FormattingEnabled = True
        Me.cmbSituacao.Location = New System.Drawing.Point(45, 73)
        Me.cmbSituacao.Name = "cmbSituacao"
        Me.cmbSituacao.Size = New System.Drawing.Size(130, 21)
        Me.cmbSituacao.TabIndex = 36
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(602, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 100)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(80, 124)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(219, 20)
        Me.txtNome.TabIndex = 34
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(325, 124)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 33
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.IndianRed
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.Location = New System.Drawing.Point(283, 183)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(100, 25)
        Me.btnSair.TabIndex = 32
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnCadastro
        '
        Me.btnCadastro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCadastro.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastro.ForeColor = System.Drawing.Color.White
        Me.btnCadastro.Location = New System.Drawing.Point(128, 185)
        Me.btnCadastro.Name = "btnCadastro"
        Me.btnCadastro.Size = New System.Drawing.Size(129, 23)
        Me.btnCadastro.TabIndex = 31
        Me.btnCadastro.Text = "Gravar"
        Me.btnCadastro.UseVisualStyleBackColor = False
        '
        'btnPesquisar
        '
        Me.btnPesquisar.BackgroundImage = Global.GesPlacas.My.Resources.Resources.lupa
        Me.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPesquisar.FlatAppearance.BorderSize = 0
        Me.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPesquisar.ForeColor = System.Drawing.Color.Black
        Me.btnPesquisar.Location = New System.Drawing.Point(564, 71)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(20, 20)
        Me.btnPesquisar.TabIndex = 30
        Me.btnPesquisar.Text = "..."
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'dgvTela
        '
        Me.dgvTela.AllowUserToAddRows = False
        Me.dgvTela.AllowUserToDeleteRows = False
        Me.dgvTela.AllowUserToOrderColumns = True
        Me.dgvTela.AllowUserToResizeRows = False
        Me.dgvTela.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTela.Location = New System.Drawing.Point(63, 232)
        Me.dgvTela.MultiSelect = False
        Me.dgvTela.Name = "dgvTela"
        Me.dgvTela.ReadOnly = True
        Me.dgvTela.RowHeadersVisible = False
        Me.dgvTela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTela.Size = New System.Drawing.Size(653, 209)
        Me.dgvTela.TabIndex = 29
        '
        'frmTela2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmpCliente1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nomeDoc)
        Me.Controls.Add(Me.cmbSituacao)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCadastro)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.dgvTela)
        Me.Name = "frmTela2"
        Me.Text = "frmTela2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CmpCliente1 As cmpCliente
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nomeDoc As TextBox
    Friend WithEvents cmbSituacao As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSair As Button
    Friend WithEvents btnCadastro As Button
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents dgvTela As DataGridView
End Class
