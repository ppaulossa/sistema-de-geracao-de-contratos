namespace Sistema_Kumon
{
    partial class Tela_Contrato
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Contrato));
            this.labelNomeAluno = new System.Windows.Forms.Label();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelTelefoneAluno = new System.Windows.Forms.Label();
            this.groupBoxAluno = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCelularAluno = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefoneAluno = new System.Windows.Forms.MaskedTextBox();
            this.labelCelularAluno = new System.Windows.Forms.Label();
            this.groupBoxResponsavel = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRGContratante = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelularContratante = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefoneContratante = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRgContratante = new System.Windows.Forms.Label();
            this.labelCelularContratante = new System.Windows.Forms.Label();
            this.labelTelefoneContratante = new System.Windows.Forms.Label();
            this.textBoxNomeContratante = new System.Windows.Forms.TextBox();
            this.labelNomeContratante = new System.Windows.Forms.Label();
            this.labelDiciplina = new System.Windows.Forms.Label();
            this.checkBoxMatematica = new System.Windows.Forms.CheckBox();
            this.checkBoxPortugues = new System.Windows.Forms.CheckBox();
            this.checkBoxIngles = new System.Windows.Forms.CheckBox();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.radioButton6Meses = new System.Windows.Forms.RadioButton();
            this.radioButton12Meses = new System.Windows.Forms.RadioButton();
            this.labelInicio = new System.Windows.Forms.Label();
            this.monthCalendarInicio = new System.Windows.Forms.MonthCalendar();
            this.labelSemana = new System.Windows.Forms.Label();
            this.textBoxSemana = new System.Windows.Forms.TextBox();
            this.labelHorario = new System.Windows.Forms.Label();
            this.textBoxHorarios = new System.Windows.Forms.TextBox();
            this.labelTaxaMatricula = new System.Windows.Forms.Label();
            this.labelMensalidade = new System.Windows.Forms.Label();
            this.labelSp = new System.Windows.Forms.Label();
            this.dateTimePickerFinalContrato = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTestemunha = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxRgTestemunha2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRgTestemunha1 = new System.Windows.Forms.MaskedTextBox();
            this.labelRgTestemunha2 = new System.Windows.Forms.Label();
            this.textBoxNomeTestemunha2 = new System.Windows.Forms.TextBox();
            this.labelNomeTestemunha2 = new System.Windows.Forms.Label();
            this.labelRgTestemunha = new System.Windows.Forms.Label();
            this.textBoxNomeTestemunha1 = new System.Windows.Forms.TextBox();
            this.labelNomeTestemunha1 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.numericUpDownTaxaMatricula = new System.Windows.Forms.NumericUpDown();
            this.labelReaisUm = new System.Windows.Forms.Label();
            this.numericUpDownMensalidade = new System.Windows.Forms.NumericUpDown();
            this.labelReaisDois = new System.Windows.Forms.Label();
            this.linkLabelDesenvolvedor = new System.Windows.Forms.LinkLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.groupBoxAluno.SuspendLayout();
            this.groupBoxResponsavel.SuspendLayout();
            this.groupBoxTestemunha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxaMatricula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomeAluno
            // 
            this.labelNomeAluno.AutoSize = true;
            this.labelNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAluno.Location = new System.Drawing.Point(8, 19);
            this.labelNomeAluno.Name = "labelNomeAluno";
            this.labelNomeAluno.Size = new System.Drawing.Size(41, 13);
            this.labelNomeAluno.TabIndex = 0;
            this.labelNomeAluno.Text = "Nome :";
            this.labelNomeAluno.UseWaitCursor = true;
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNomeAluno.Location = new System.Drawing.Point(55, 16);
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(615, 20);
            this.textBoxNomeAluno.TabIndex = 1;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(8, 45);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(110, 13);
            this.labelDataNascimento.TabIndex = 2;
            this.labelDataNascimento.Text = "Data de Nascimento :";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(122, 42);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(100, 20);
            this.dateTimeNascimento.TabIndex = 2;
            // 
            // labelTelefoneAluno
            // 
            this.labelTelefoneAluno.AutoSize = true;
            this.labelTelefoneAluno.Location = new System.Drawing.Point(228, 45);
            this.labelTelefoneAluno.Name = "labelTelefoneAluno";
            this.labelTelefoneAluno.Size = new System.Drawing.Size(55, 13);
            this.labelTelefoneAluno.TabIndex = 4;
            this.labelTelefoneAluno.Text = "Telefone :";
            this.labelTelefoneAluno.UseWaitCursor = true;
            // 
            // groupBoxAluno
            // 
            this.groupBoxAluno.Controls.Add(this.maskedTextBoxCelularAluno);
            this.groupBoxAluno.Controls.Add(this.maskedTextBoxTelefoneAluno);
            this.groupBoxAluno.Controls.Add(this.labelCelularAluno);
            this.groupBoxAluno.Controls.Add(this.labelNomeAluno);
            this.groupBoxAluno.Controls.Add(this.textBoxNomeAluno);
            this.groupBoxAluno.Controls.Add(this.labelTelefoneAluno);
            this.groupBoxAluno.Controls.Add(this.labelDataNascimento);
            this.groupBoxAluno.Controls.Add(this.dateTimeNascimento);
            this.groupBoxAluno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAluno.Name = "groupBoxAluno";
            this.groupBoxAluno.Size = new System.Drawing.Size(688, 75);
            this.groupBoxAluno.TabIndex = 6;
            this.groupBoxAluno.TabStop = false;
            this.groupBoxAluno.Text = "DADOS DO BENEFICIÁRIO (ALUNO) ";
            // 
            // maskedTextBoxCelularAluno
            // 
            this.maskedTextBoxCelularAluno.Location = new System.Drawing.Point(506, 42);
            this.maskedTextBoxCelularAluno.Mask = "(99) 00000-0000";
            this.maskedTextBoxCelularAluno.Name = "maskedTextBoxCelularAluno";
            this.maskedTextBoxCelularAluno.Size = new System.Drawing.Size(164, 20);
            this.maskedTextBoxCelularAluno.TabIndex = 4;
            // 
            // maskedTextBoxTelefoneAluno
            // 
            this.maskedTextBoxTelefoneAluno.Location = new System.Drawing.Point(287, 42);
            this.maskedTextBoxTelefoneAluno.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefoneAluno.Name = "maskedTextBoxTelefoneAluno";
            this.maskedTextBoxTelefoneAluno.Size = new System.Drawing.Size(160, 20);
            this.maskedTextBoxTelefoneAluno.TabIndex = 3;
            // 
            // labelCelularAluno
            // 
            this.labelCelularAluno.AutoSize = true;
            this.labelCelularAluno.Location = new System.Drawing.Point(455, 45);
            this.labelCelularAluno.Name = "labelCelularAluno";
            this.labelCelularAluno.Size = new System.Drawing.Size(45, 13);
            this.labelCelularAluno.TabIndex = 6;
            this.labelCelularAluno.Text = "Celular :";
            // 
            // groupBoxResponsavel
            // 
            this.groupBoxResponsavel.Controls.Add(this.maskedTextBoxCPF);
            this.groupBoxResponsavel.Controls.Add(this.maskedTextBoxRGContratante);
            this.groupBoxResponsavel.Controls.Add(this.maskedTextBoxCelularContratante);
            this.groupBoxResponsavel.Controls.Add(this.maskedTextBoxTelefoneContratante);
            this.groupBoxResponsavel.Controls.Add(this.textBoxEndereco);
            this.groupBoxResponsavel.Controls.Add(this.labelEndereco);
            this.groupBoxResponsavel.Controls.Add(this.labelCPF);
            this.groupBoxResponsavel.Controls.Add(this.labelRgContratante);
            this.groupBoxResponsavel.Controls.Add(this.labelCelularContratante);
            this.groupBoxResponsavel.Controls.Add(this.labelTelefoneContratante);
            this.groupBoxResponsavel.Controls.Add(this.textBoxNomeContratante);
            this.groupBoxResponsavel.Controls.Add(this.labelNomeContratante);
            this.groupBoxResponsavel.Location = new System.Drawing.Point(12, 93);
            this.groupBoxResponsavel.Name = "groupBoxResponsavel";
            this.groupBoxResponsavel.Size = new System.Drawing.Size(688, 105);
            this.groupBoxResponsavel.TabIndex = 7;
            this.groupBoxResponsavel.TabStop = false;
            this.groupBoxResponsavel.Text = "QUALIFICAÇÃO DO CONTRATANTE E RESPONSÁVEL FINANCEIRO";
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(50, 70);
            this.maskedTextBoxCPF.Mask = "000.000.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(151, 20);
            this.maskedTextBoxCPF.TabIndex = 9;
            // 
            // maskedTextBoxRGContratante
            // 
            this.maskedTextBoxRGContratante.Location = new System.Drawing.Point(491, 44);
            this.maskedTextBoxRGContratante.Mask = "00.000.000-0";
            this.maskedTextBoxRGContratante.Name = "maskedTextBoxRGContratante";
            this.maskedTextBoxRGContratante.Size = new System.Drawing.Size(179, 20);
            this.maskedTextBoxRGContratante.TabIndex = 8;
            // 
            // maskedTextBoxCelularContratante
            // 
            this.maskedTextBoxCelularContratante.Location = new System.Drawing.Point(292, 45);
            this.maskedTextBoxCelularContratante.Mask = "(99) 00000-0000";
            this.maskedTextBoxCelularContratante.Name = "maskedTextBoxCelularContratante";
            this.maskedTextBoxCelularContratante.Size = new System.Drawing.Size(157, 20);
            this.maskedTextBoxCelularContratante.TabIndex = 7;
            // 
            // maskedTextBoxTelefoneContratante
            // 
            this.maskedTextBoxTelefoneContratante.Location = new System.Drawing.Point(70, 45);
            this.maskedTextBoxTelefoneContratante.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefoneContratante.Name = "maskedTextBoxTelefoneContratante";
            this.maskedTextBoxTelefoneContratante.Size = new System.Drawing.Size(166, 20);
            this.maskedTextBoxTelefoneContratante.TabIndex = 6;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(275, 71);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(395, 20);
            this.textBoxEndereco.TabIndex = 10;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(207, 74);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(62, 13);
            this.labelEndereco.TabIndex = 10;
            this.labelEndereco.Text = "Endereço : ";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(8, 74);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(36, 13);
            this.labelCPF.TabIndex = 8;
            this.labelCPF.Text = "CPF : ";
            // 
            // labelRgContratante
            // 
            this.labelRgContratante.AutoSize = true;
            this.labelRgContratante.Location = new System.Drawing.Point(455, 49);
            this.labelRgContratante.Name = "labelRgContratante";
            this.labelRgContratante.Size = new System.Drawing.Size(29, 13);
            this.labelRgContratante.TabIndex = 6;
            this.labelRgContratante.Text = "RG :";
            // 
            // labelCelularContratante
            // 
            this.labelCelularContratante.AutoSize = true;
            this.labelCelularContratante.Location = new System.Drawing.Point(245, 49);
            this.labelCelularContratante.Name = "labelCelularContratante";
            this.labelCelularContratante.Size = new System.Drawing.Size(45, 13);
            this.labelCelularContratante.TabIndex = 4;
            this.labelCelularContratante.Text = "Celular :";
            // 
            // labelTelefoneContratante
            // 
            this.labelTelefoneContratante.AutoSize = true;
            this.labelTelefoneContratante.Location = new System.Drawing.Point(6, 49);
            this.labelTelefoneContratante.Name = "labelTelefoneContratante";
            this.labelTelefoneContratante.Size = new System.Drawing.Size(58, 13);
            this.labelTelefoneContratante.TabIndex = 2;
            this.labelTelefoneContratante.Text = "Telefone : ";
            this.labelTelefoneContratante.UseMnemonic = false;
            // 
            // textBoxNomeContratante
            // 
            this.textBoxNomeContratante.Location = new System.Drawing.Point(55, 20);
            this.textBoxNomeContratante.Name = "textBoxNomeContratante";
            this.textBoxNomeContratante.Size = new System.Drawing.Size(615, 20);
            this.textBoxNomeContratante.TabIndex = 5;
            // 
            // labelNomeContratante
            // 
            this.labelNomeContratante.AutoSize = true;
            this.labelNomeContratante.Location = new System.Drawing.Point(8, 23);
            this.labelNomeContratante.Name = "labelNomeContratante";
            this.labelNomeContratante.Size = new System.Drawing.Size(44, 13);
            this.labelNomeContratante.TabIndex = 0;
            this.labelNomeContratante.Text = "Nome : ";
            // 
            // labelDisciplina
            // 
            this.labelDiciplina.AutoSize = true;
            this.labelDiciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiciplina.Location = new System.Drawing.Point(18, 211);
            this.labelDiciplina.Name = "labelDisciplina";
            this.labelDiciplina.Size = new System.Drawing.Size(61, 13);
            this.labelDiciplina.TabIndex = 8;
            this.labelDiciplina.Text = "Disciplinas : ";
            // 
            // checkBoxMatematica
            // 
            this.checkBoxMatematica.AutoSize = true;
            this.checkBoxMatematica.Location = new System.Drawing.Point(86, 211);
            this.checkBoxMatematica.Name = "checkBoxMatematica";
            this.checkBoxMatematica.Size = new System.Drawing.Size(81, 17);
            this.checkBoxMatematica.TabIndex = 11;
            this.checkBoxMatematica.Text = "Matemática";
            this.checkBoxMatematica.UseVisualStyleBackColor = true;
            // 
            // checkBoxPortugues
            // 
            this.checkBoxPortugues.AutoSize = true;
            this.checkBoxPortugues.Location = new System.Drawing.Point(174, 211);
            this.checkBoxPortugues.Name = "checkBoxPortugues";
            this.checkBoxPortugues.Size = new System.Drawing.Size(74, 17);
            this.checkBoxPortugues.TabIndex = 12;
            this.checkBoxPortugues.Text = "Português";
            this.checkBoxPortugues.UseVisualStyleBackColor = true;
            // 
            // checkBoxIngles
            // 
            this.checkBoxIngles.AutoSize = true;
            this.checkBoxIngles.Location = new System.Drawing.Point(255, 211);
            this.checkBoxIngles.Name = "checkBoxIngles";
            this.checkBoxIngles.Size = new System.Drawing.Size(54, 17);
            this.checkBoxIngles.TabIndex = 13;
            this.checkBoxIngles.Text = "Inglês";
            this.checkBoxIngles.UseVisualStyleBackColor = true;
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracao.Location = new System.Drawing.Point(315, 211);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(178, 13);
            this.labelDuracao.TabIndex = 12;
            this.labelDuracao.Text = "O Curso terá a duração mínima de : ";
            // 
            // radioButton6Meses
            // 
            this.radioButton6Meses.AutoSize = true;
            this.radioButton6Meses.Checked = true;
            this.radioButton6Meses.Location = new System.Drawing.Point(497, 211);
            this.radioButton6Meses.Name = "radioButton6Meses";
            this.radioButton6Meses.Size = new System.Drawing.Size(64, 17);
            this.radioButton6Meses.TabIndex = 14;
            this.radioButton6Meses.TabStop = true;
            this.radioButton6Meses.Text = "6 meses";
            this.radioButton6Meses.UseVisualStyleBackColor = true;
            // 
            // radioButton12Meses
            // 
            this.radioButton12Meses.AutoSize = true;
            this.radioButton12Meses.Location = new System.Drawing.Point(568, 211);
            this.radioButton12Meses.Name = "radioButton12Meses";
            this.radioButton12Meses.Size = new System.Drawing.Size(70, 17);
            this.radioButton12Meses.TabIndex = 15;
            this.radioButton12Meses.Text = "12 meses";
            this.radioButton12Meses.UseVisualStyleBackColor = true;
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(20, 237);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(38, 13);
            this.labelInicio.TabIndex = 15;
            this.labelInicio.Text = "Inicio :";
            // 
            // monthCalendarInicio
            // 
            this.monthCalendarInicio.Location = new System.Drawing.Point(70, 240);
            this.monthCalendarInicio.Name = "monthCalendarInicio";
            this.monthCalendarInicio.ShowTodayCircle = false;
            this.monthCalendarInicio.TabIndex = 16;
            // 
            // labelSemana
            // 
            this.labelSemana.AutoSize = true;
            this.labelSemana.Location = new System.Drawing.Point(313, 248);
            this.labelSemana.Name = "labelSemana";
            this.labelSemana.Size = new System.Drawing.Size(91, 13);
            this.labelSemana.TabIndex = 17;
            this.labelSemana.Text = "Dias da Semana :";
            // 
            // textBoxSemana
            // 
            this.textBoxSemana.Location = new System.Drawing.Point(316, 265);
            this.textBoxSemana.Name = "textBoxSemana";
            this.textBoxSemana.Size = new System.Drawing.Size(384, 20);
            this.textBoxSemana.TabIndex = 17;
            // 
            // labelHorario
            // 
            this.labelHorario.AutoSize = true;
            this.labelHorario.Location = new System.Drawing.Point(313, 288);
            this.labelHorario.Name = "labelHorario";
            this.labelHorario.Size = new System.Drawing.Size(55, 13);
            this.labelHorario.TabIndex = 19;
            this.labelHorario.Text = "Horarios : ";
            // 
            // textBoxHorarios
            // 
            this.textBoxHorarios.Location = new System.Drawing.Point(316, 304);
            this.textBoxHorarios.Name = "textBoxHorarios";
            this.textBoxHorarios.Size = new System.Drawing.Size(383, 20);
            this.textBoxHorarios.TabIndex = 18;
            // 
            // labelTaxaMatricula
            // 
            this.labelTaxaMatricula.AutoSize = true;
            this.labelTaxaMatricula.Location = new System.Drawing.Point(313, 327);
            this.labelTaxaMatricula.Name = "labelTaxaMatricula";
            this.labelTaxaMatricula.Size = new System.Drawing.Size(86, 13);
            this.labelTaxaMatricula.TabIndex = 21;
            this.labelTaxaMatricula.Text = "Taxa Matricula : ";
            this.labelTaxaMatricula.UseMnemonic = false;
            // 
            // labelMensalidade
            // 
            this.labelMensalidade.AutoSize = true;
            this.labelMensalidade.Location = new System.Drawing.Point(421, 325);
            this.labelMensalidade.Name = "labelMensalidade";
            this.labelMensalidade.Size = new System.Drawing.Size(76, 13);
            this.labelMensalidade.TabIndex = 23;
            this.labelMensalidade.Text = "Mensalidade : ";
            // 
            // labelSp
            // 
            this.labelSp.AutoSize = true;
            this.labelSp.Location = new System.Drawing.Point(315, 377);
            this.labelSp.Name = "labelSp";
            this.labelSp.Size = new System.Drawing.Size(65, 13);
            this.labelSp.TabIndex = 25;
            this.labelSp.Text = "São Paulo , ";
            // 
            // dateTimePickerFinalContrato
            // 
            this.dateTimePickerFinalContrato.Location = new System.Drawing.Point(382, 371);
            this.dateTimePickerFinalContrato.Name = "dateTimePickerFinalContrato";
            this.dateTimePickerFinalContrato.Size = new System.Drawing.Size(318, 20);
            this.dateTimePickerFinalContrato.TabIndex = 21;
            // 
            // groupBoxTestemunha
            // 
            this.groupBoxTestemunha.Controls.Add(this.maskedTextBoxRgTestemunha2);
            this.groupBoxTestemunha.Controls.Add(this.maskedTextBoxRgTestemunha1);
            this.groupBoxTestemunha.Controls.Add(this.labelRgTestemunha2);
            this.groupBoxTestemunha.Controls.Add(this.textBoxNomeTestemunha2);
            this.groupBoxTestemunha.Controls.Add(this.labelNomeTestemunha2);
            this.groupBoxTestemunha.Controls.Add(this.labelRgTestemunha);
            this.groupBoxTestemunha.Controls.Add(this.textBoxNomeTestemunha1);
            this.groupBoxTestemunha.Controls.Add(this.labelNomeTestemunha1);
            this.groupBoxTestemunha.Location = new System.Drawing.Point(12, 415);
            this.groupBoxTestemunha.Name = "groupBoxTestemunha";
            this.groupBoxTestemunha.Size = new System.Drawing.Size(688, 102);
            this.groupBoxTestemunha.TabIndex = 27;
            this.groupBoxTestemunha.TabStop = false;
            this.groupBoxTestemunha.Text = "Testemunhas";
            // 
            // maskedTextBoxRgTestemunha2
            // 
            this.maskedTextBoxRgTestemunha2.Location = new System.Drawing.Point(357, 73);
            this.maskedTextBoxRgTestemunha2.Mask = "00.000.000-0";
            this.maskedTextBoxRgTestemunha2.Name = "maskedTextBoxRgTestemunha2";
            this.maskedTextBoxRgTestemunha2.Size = new System.Drawing.Size(197, 20);
            this.maskedTextBoxRgTestemunha2.TabIndex = 25;
            // 
            // maskedTextBoxRgTestemunha1
            // 
            this.maskedTextBoxRgTestemunha1.Location = new System.Drawing.Point(11, 74);
            this.maskedTextBoxRgTestemunha1.Mask = "00.000.000-0";
            this.maskedTextBoxRgTestemunha1.Name = "maskedTextBoxRgTestemunha1";
            this.maskedTextBoxRgTestemunha1.Size = new System.Drawing.Size(211, 20);
            this.maskedTextBoxRgTestemunha1.TabIndex = 23;
            // 
            // labelRgTestemunha2
            // 
            this.labelRgTestemunha2.AutoSize = true;
            this.labelRgTestemunha2.Location = new System.Drawing.Point(354, 59);
            this.labelRgTestemunha2.Name = "labelRgTestemunha2";
            this.labelRgTestemunha2.Size = new System.Drawing.Size(32, 13);
            this.labelRgTestemunha2.TabIndex = 6;
            this.labelRgTestemunha2.Text = "RG : ";
            // 
            // textBoxNomeTestemunha2
            // 
            this.textBoxNomeTestemunha2.Location = new System.Drawing.Point(357, 36);
            this.textBoxNomeTestemunha2.Name = "textBoxNomeTestemunha2";
            this.textBoxNomeTestemunha2.Size = new System.Drawing.Size(313, 20);
            this.textBoxNomeTestemunha2.TabIndex = 24;
            // 
            // labelNomeTestemunha2
            // 
            this.labelNomeTestemunha2.AutoSize = true;
            this.labelNomeTestemunha2.Location = new System.Drawing.Point(354, 20);
            this.labelNomeTestemunha2.Name = "labelNomeTestemunha2";
            this.labelNomeTestemunha2.Size = new System.Drawing.Size(41, 13);
            this.labelNomeTestemunha2.TabIndex = 4;
            this.labelNomeTestemunha2.Text = "Nome :";
            // 
            // labelRgTestemunha
            // 
            this.labelRgTestemunha.AutoSize = true;
            this.labelRgTestemunha.Location = new System.Drawing.Point(8, 59);
            this.labelRgTestemunha.Name = "labelRgTestemunha";
            this.labelRgTestemunha.Size = new System.Drawing.Size(32, 13);
            this.labelRgTestemunha.TabIndex = 2;
            this.labelRgTestemunha.Text = "RG : ";
            // 
            // textBoxNomeTestemunha1
            // 
            this.textBoxNomeTestemunha1.Location = new System.Drawing.Point(11, 36);
            this.textBoxNomeTestemunha1.Name = "textBoxNomeTestemunha1";
            this.textBoxNomeTestemunha1.Size = new System.Drawing.Size(313, 20);
            this.textBoxNomeTestemunha1.TabIndex = 22;
            // 
            // labelNomeTestemunha1
            // 
            this.labelNomeTestemunha1.AutoSize = true;
            this.labelNomeTestemunha1.Location = new System.Drawing.Point(8, 20);
            this.labelNomeTestemunha1.Name = "labelNomeTestemunha1";
            this.labelNomeTestemunha1.Size = new System.Drawing.Size(44, 13);
            this.labelNomeTestemunha1.TabIndex = 0;
            this.labelNomeTestemunha1.Text = "Nome : ";
            // 
            // buttonOK
            // 
            this.buttonOK.FlatAppearance.BorderSize = 2;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonOK.Location = new System.Drawing.Point(624, 523);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 28;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // numericUpDownTaxaMatricula
            // 
            this.numericUpDownTaxaMatricula.DecimalPlaces = 2;
            this.numericUpDownTaxaMatricula.Location = new System.Drawing.Point(316, 343);
            this.numericUpDownTaxaMatricula.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numericUpDownTaxaMatricula.Name = "numericUpDownTaxaMatricula";
            this.numericUpDownTaxaMatricula.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownTaxaMatricula.TabIndex = 19;
            this.numericUpDownTaxaMatricula.Tag = "";
            this.numericUpDownTaxaMatricula.ThousandsSeparator = true;
            // 
            // labelReaisUm
            // 
            this.labelReaisUm.AutoSize = true;
            this.labelReaisUm.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReaisUm.Location = new System.Drawing.Point(396, 343);
            this.labelReaisUm.Name = "labelReaisUm";
            this.labelReaisUm.Size = new System.Drawing.Size(22, 16);
            this.labelReaisUm.TabIndex = 32;
            this.labelReaisUm.Text = "R$";
            // 
            // numericUpDownMensalidade
            // 
            this.numericUpDownMensalidade.DecimalPlaces = 2;
            this.numericUpDownMensalidade.Location = new System.Drawing.Point(424, 340);
            this.numericUpDownMensalidade.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.numericUpDownMensalidade.Name = "numericUpDownMensalidade";
            this.numericUpDownMensalidade.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownMensalidade.TabIndex = 20;
            // 
            // labelReaisDois
            // 
            this.labelReaisDois.AutoSize = true;
            this.labelReaisDois.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReaisDois.Location = new System.Drawing.Point(503, 343);
            this.labelReaisDois.Name = "labelReaisDois";
            this.labelReaisDois.Size = new System.Drawing.Size(22, 16);
            this.labelReaisDois.TabIndex = 34;
            this.labelReaisDois.Text = "R$";
            // 
            // linkLabelDesenvolvedor
            // 
            this.linkLabelDesenvolvedor.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabelDesenvolvedor.AutoSize = true;
            this.linkLabelDesenvolvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDesenvolvedor.LinkColor = System.Drawing.Color.Black;
            this.linkLabelDesenvolvedor.Location = new System.Drawing.Point(12, 528);
            this.linkLabelDesenvolvedor.Name = "linkLabelDesenvolvedor";
            this.linkLabelDesenvolvedor.Size = new System.Drawing.Size(69, 12);
            this.linkLabelDesenvolvedor.TabIndex = 35;
            this.linkLabelDesenvolvedor.TabStop = true;
            this.linkLabelDesenvolvedor.Text = "Desenvolvedor";
            this.linkLabelDesenvolvedor.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabelDesenvolvedor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDesenvolvedor_LinkClicked);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(243, 522);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(294, 23);
            this.progressBar.TabIndex = 36;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(543, 522);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 37;
            this.buttonLimpar.Text = "LIMPAR";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Tela_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 549);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.linkLabelDesenvolvedor);
            this.Controls.Add(this.labelReaisDois);
            this.Controls.Add(this.numericUpDownMensalidade);
            this.Controls.Add(this.labelReaisUm);
            this.Controls.Add(this.numericUpDownTaxaMatricula);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxTestemunha);
            this.Controls.Add(this.dateTimePickerFinalContrato);
            this.Controls.Add(this.labelSp);
            this.Controls.Add(this.labelMensalidade);
            this.Controls.Add(this.labelTaxaMatricula);
            this.Controls.Add(this.textBoxHorarios);
            this.Controls.Add(this.labelHorario);
            this.Controls.Add(this.textBoxSemana);
            this.Controls.Add(this.labelSemana);
            this.Controls.Add(this.monthCalendarInicio);
            this.Controls.Add(this.labelInicio);
            this.Controls.Add(this.radioButton12Meses);
            this.Controls.Add(this.radioButton6Meses);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.checkBoxIngles);
            this.Controls.Add(this.checkBoxPortugues);
            this.Controls.Add(this.checkBoxMatematica);
            this.Controls.Add(this.labelDiciplina);
            this.Controls.Add(this.groupBoxResponsavel);
            this.Controls.Add(this.groupBoxAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Contrato";
            this.Opacity = 0.98D;
            this.Text = "Imprimir Contrato";
            this.groupBoxAluno.ResumeLayout(false);
            this.groupBoxAluno.PerformLayout();
            this.groupBoxResponsavel.ResumeLayout(false);
            this.groupBoxResponsavel.PerformLayout();
            this.groupBoxTestemunha.ResumeLayout(false);
            this.groupBoxTestemunha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTaxaMatricula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMensalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeAluno;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label labelTelefoneAluno;
        private System.Windows.Forms.GroupBox groupBoxAluno;
        private System.Windows.Forms.Label labelCelularAluno;
        private System.Windows.Forms.GroupBox groupBoxResponsavel;
        private System.Windows.Forms.Label labelNomeContratante;
        private System.Windows.Forms.TextBox textBoxNomeContratante;
        private System.Windows.Forms.Label labelTelefoneContratante;
        private System.Windows.Forms.Label labelCelularContratante;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRgContratante;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelDiciplina;
        private System.Windows.Forms.CheckBox checkBoxMatematica;
        private System.Windows.Forms.CheckBox checkBoxPortugues;
        private System.Windows.Forms.CheckBox checkBoxIngles;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.RadioButton radioButton6Meses;
        private System.Windows.Forms.RadioButton radioButton12Meses;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.MonthCalendar monthCalendarInicio;
        private System.Windows.Forms.Label labelSemana;
        private System.Windows.Forms.TextBox textBoxSemana;
        private System.Windows.Forms.Label labelHorario;
        private System.Windows.Forms.TextBox textBoxHorarios;
        private System.Windows.Forms.Label labelTaxaMatricula;
        private System.Windows.Forms.Label labelMensalidade;
        private System.Windows.Forms.Label labelSp;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinalContrato;
        private System.Windows.Forms.GroupBox groupBoxTestemunha;
        private System.Windows.Forms.Label labelRgTestemunha2;
        private System.Windows.Forms.TextBox textBoxNomeTestemunha2;
        private System.Windows.Forms.Label labelNomeTestemunha2;
        private System.Windows.Forms.Label labelRgTestemunha;
        private System.Windows.Forms.TextBox textBoxNomeTestemunha1;
        private System.Windows.Forms.Label labelNomeTestemunha1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneAluno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularAluno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCPF;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRGContratante;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelularContratante;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefoneContratante;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRgTestemunha2;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRgTestemunha1;
        private System.Windows.Forms.NumericUpDown numericUpDownTaxaMatricula;
        private System.Windows.Forms.Label labelReaisUm;
        private System.Windows.Forms.NumericUpDown numericUpDownMensalidade;
        private System.Windows.Forms.Label labelReaisDois;
        private System.Windows.Forms.LinkLabel linkLabelDesenvolvedor;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonLimpar;
    }
}

