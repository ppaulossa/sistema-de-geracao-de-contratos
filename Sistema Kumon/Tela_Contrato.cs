using System;
using System.Drawing;
using System.Windows.Forms;
using modelo_contrato;
using System.Text.RegularExpressions;
using escrever_estenso;
using escrever_word;

namespace Sistema_Kumon
{
    public partial class Tela_Contrato : Form
    {
        private ModeloContrato contrato;
        private EscreverEstenso estenso;
        private EscreverWord word;
        private int tudoCerto;
        private bool materias;
        private String message;
        private Regex validacao;
        public Tela_Contrato()
        {
            InitializeComponent();
            contrato = new ModeloContrato();
            estenso = new EscreverEstenso();
            word = new EscreverWord();
        }

        private void linkLabelDesenvolvedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Nome : Paulo Henrique de Oliveira Sá \n" +
                            "E-mail : ppaulo.sa@hotmail.com \n" +
                            "Celular : 99634-2707 \n", "Desenvolvedor", MessageBoxButtons.OK, MessageBoxIcon.Information);        
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            message = string.Empty;
            tudoCerto = 0;
            progressBar.Value = 0;
            materias = false;

            message += "****** O FORMULÁRIO CONTÉM ERROS ****** \n\n";

            if(textBoxNomeAluno.TextLength == 0)
            {
                labelNomeAluno.ForeColor = Color.Red;
                message += "- Preencha o nome do aluno. \n";
            }else
            {
                labelNomeAluno.ForeColor = Color.Black;
                contrato.nomeAluno = textBoxNomeAluno.Text;
                tudoCerto++; // 1
            }

            progressBar.Value = 1;

            contrato.dataNascimentoAluno = dateTimeNascimento.Value.ToShortDateString();

            validacao = new Regex(expressaoRegularTelefone());

            if (validacao.IsMatch(maskedTextBoxTelefoneAluno.Text))
            {
                contrato.telefoneAluno = "Telefone: " +  maskedTextBoxTelefoneAluno.Text;
            }else
            {
                contrato.telefoneAluno = string.Empty;
            }

            progressBar.Value = 2;

            validacao = new Regex(expressaoRegularCelular());

            if (validacao.IsMatch(maskedTextBoxCelularAluno.Text))
            {
                contrato.celularAluno = "Celular: " + maskedTextBoxCelularAluno.Text;
            }else
            {
                contrato.celularAluno = string.Empty;
            }

            progressBar.Value = 3;

            if (textBoxNomeContratante.TextLength == 0)
            {
                labelNomeContratante.ForeColor = Color.Red;
                message += "- Preencha o nome do contratante. \n";
            }else
            {
                labelNomeContratante.ForeColor = Color.Black;
                contrato.nomeContratante = textBoxNomeContratante.Text;
                tudoCerto++; // 2
            }

            progressBar.Value = 4;

            validacao = new Regex(expressaoRegularTelefone());

            if (validacao.IsMatch(maskedTextBoxTelefoneContratante.Text))
            {
                contrato.telefoneContratante = "Telefone: " + maskedTextBoxTelefoneContratante.Text;
            }else
            {
                contrato.telefoneContratante = string.Empty;
            }

            progressBar.Value = 5;

           validacao = new Regex(expressaoRegularCelular());

            if (validacao.IsMatch(maskedTextBoxCelularContratante.Text))
            {
                contrato.celularContratante = "Celular: " + maskedTextBoxCelularContratante.Text;
            }else
            {
                contrato.celularContratante = string.Empty;
            }

            progressBar.Value = 6;

           validacao = new Regex(expressaoRegularRg());

            if (validacao.IsMatch(substituir(maskedTextBoxRGContratante.Text)))
            {
                labelRgContratante.ForeColor = Color.Black;
                contrato.rgContratante = substituir(maskedTextBoxRGContratante.Text);
                tudoCerto++; //3
            }else
            {
                labelRgContratante.ForeColor = Color.Red;
                message += "- O RG do contratante está inválido. \n";
            }

            progressBar.Value = 7;

           validacao = new Regex(expressaoRegularCpf());

            if (validacao.IsMatch(substituir(maskedTextBoxCPF.Text)))
            {
                labelCPF.ForeColor = Color.Black;
                contrato.cpfContratante = substituir(maskedTextBoxCPF.Text);
                tudoCerto++; //4
            }else
            {
                labelCPF.ForeColor = Color.Red;
                message += "- O CPF do contratante está inválido. \n";
            }

            progressBar.Value = 8;

            if (textBoxEndereco.TextLength == 0)
            {
                labelEndereco.ForeColor = Color.Red;
                message += "- Preencha o endereço do contratante. \n";
            }else
            {
                labelEndereco.ForeColor = Color.Black;
                contrato.enderecoContratante = textBoxEndereco.Text;
                tudoCerto++; //5
            }

            progressBar.Value = 9;

            if (checkBoxMatematica.Checked)
            {
                contrato.matematica = "X";
                materias = true;
            }else
            {
                contrato.matematica = " ";
            }

            progressBar.Value = 10;

            if (checkBoxPortugues.Checked)
            {
                contrato.portugues = "X";
                materias = true;
            }else
            {
                contrato.portugues = " ";
            }

            progressBar.Value = 11;

            if (checkBoxIngles.Checked)
            {
                contrato.ingles = "X";
                materias = true;
            }else
            {
                contrato.ingles = " ";
            }

            progressBar.Value = 12;

            if (materias == true)
            {
                checkBoxMatematica.ForeColor = Color.Black;
                checkBoxPortugues.ForeColor = Color.Black;
                checkBoxIngles.ForeColor = Color.Black;
                tudoCerto++; // 6
            }else
            {
                checkBoxMatematica.ForeColor = Color.Red;
                checkBoxPortugues.ForeColor = Color.Red;
                checkBoxIngles.ForeColor = Color.Red;
                message += "- Preencha no mínimo uma diciplina. \n";
            }

            progressBar.Value = 13;

            if (radioButton6Meses.Checked)
            {
                contrato.seisMeses = "X";
                contrato.dozeMeses = " ";
            }
            else
            {
                contrato.dozeMeses = "X";
                contrato.seisMeses = " ";
            }

            progressBar.Value = 14;

            contrato.inicioDoCurso = monthCalendarInicio.SelectionStart.Date.ToShortDateString();


           if (textBoxSemana.TextLength == 0)
            {
                labelSemana.ForeColor = Color.Red;
                message += "- Preencha os dias da semana. \n";
            }else
            {
                labelSemana.ForeColor = Color.Black;
                contrato.diasDaSemana = textBoxSemana.Text;
                tudoCerto++; // 7
            }

            progressBar.Value = 15;


           if (textBoxHorarios.TextLength == 0)
            {
                labelHorario.ForeColor = Color.Red;
                message += "- Preencha os horarios da semana. \n";
            }else
            {
                labelHorario.ForeColor = Color.Black;
                contrato.horarios = textBoxHorarios.Text;
                tudoCerto++; //8
            }
            progressBar.Value = 16;


            contrato.taxaMatricula = numericUpDownTaxaMatricula.Value.ToString("#,##0.00 R$");
            contrato.taxaMatriculaExtenso = estenso.toExtenso(numericUpDownTaxaMatricula.Value);
            contrato.mensalidade = numericUpDownMensalidade.Value.ToString("#,##0.00 R$");
            contrato.mensalidadeExtenso = estenso.toExtenso(numericUpDownMensalidade.Value);
            contrato.dataFinalContrato = dateTimePickerFinalContrato.Value.ToShortDateString();
            contrato.nomeTestemunha1 = textBoxNomeTestemunha1.Text;

            progressBar.Value = 17;

            validacao = new Regex(expressaoRegularRg());

            if (validacao.IsMatch(substituir(maskedTextBoxRgTestemunha1.Text)))
            {
                contrato.rgTestemunha1 = substituir(maskedTextBoxRgTestemunha1.Text);
            }else
            {
                contrato.rgTestemunha1 = string.Empty;
            }

            progressBar.Value = 18;

            contrato.nomeTestemunha2 = textBoxNomeTestemunha2.Text;
           
            if (validacao.IsMatch(substituir(maskedTextBoxRgTestemunha2.Text)))
            {
                contrato.rgTestemunha2 = substituir(maskedTextBoxRgTestemunha2.Text);
            }else
            {
                contrato.rgTestemunha2 = string.Empty;
            }

            progressBar.Value = 19;

            if (tudoCerto == 8)
            {
                progressBar.Value = 20;
                word.PreencherNoWord(contrato,progressBar);
                progressBar.Value = 100;
            }else
            {
                progressBar.Value = 0;
                MessageBox.Show(message, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }


        }

        public string substituir(string texto)
        {
            return texto.Replace(',','.');
        }

        public string expressaoRegularTelefone()
        {
            return @"^\([0-9]{2}\) [0-9]{4}\-[0-9]{4}$";
        }

        public string expressaoRegularCelular()
        {
            return @"^\([0-9]{2}\) [0-9]{5}\-[0-9]{4}$";
        }

        public string expressaoRegularRg()
        {
            return @"^[0-9]{2}\.[0-9]{3}\.[0-9]{3}\-[0-9]{1}$";
        }

        public string expressaoRegularCpf()
        {
            return @"^[0-9]{3}\.[0-9]{3}\.[0-9]{3}\-[0-9]{2}$";
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            labelNomeAluno.ForeColor = Color.Black;
            labelNomeContratante.ForeColor = Color.Black;
            labelRgContratante.ForeColor = Color.Black;
            labelCPF.ForeColor = Color.Black;
            labelEndereco.ForeColor = Color.Black;
            checkBoxMatematica.ForeColor = Color.Black;
            checkBoxPortugues.ForeColor = Color.Black;
            checkBoxIngles.ForeColor = Color.Black;
            labelSemana.ForeColor = Color.Black;
            labelHorario.ForeColor = Color.Black;
            textBoxNomeAluno.Text = string.Empty;
            dateTimeNascimento.Value = DateTime.Today;
            maskedTextBoxTelefoneAluno.Text = string.Empty;
            maskedTextBoxCelularAluno.Text = string.Empty;
            textBoxNomeContratante.Text = string.Empty;
            maskedTextBoxTelefoneContratante.Text = string.Empty;
            maskedTextBoxCelularContratante.Text = string.Empty;
            maskedTextBoxRGContratante.Text = string.Empty;
            maskedTextBoxCPF.Text = string.Empty;
            textBoxEndereco.Text = string.Empty;
            checkBoxMatematica.Checked = false;
            checkBoxPortugues.Checked = false;
            checkBoxIngles.Checked = false;
            radioButton6Meses.Checked = true;
            radioButton12Meses.Checked = false;
            monthCalendarInicio.SelectionStart = DateTime.Today;
            monthCalendarInicio.SelectionEnd = DateTime.Today;
            textBoxSemana.Text = string.Empty;
            textBoxHorarios.Text = string.Empty;
            numericUpDownTaxaMatricula.Value = (decimal)0.00;
            numericUpDownMensalidade.Value = (decimal)0.00;
            dateTimePickerFinalContrato.Value = DateTime.Today;
            textBoxNomeTestemunha1.Text = string.Empty;
            maskedTextBoxRgTestemunha1.Text = string.Empty;
            textBoxNomeTestemunha2.Text = string.Empty;
            maskedTextBoxRgTestemunha2.Text = string.Empty;
        }
    }
}
