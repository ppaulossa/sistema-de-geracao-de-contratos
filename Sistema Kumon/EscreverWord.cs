using Word = Microsoft.Office.Interop;
using modelo_contrato;
using System.Windows.Forms;


namespace escrever_word
{
    class EscreverWord
    {
        public void PreencherNoWord(ModeloContrato modeloContrato, ProgressBar progressBar)
        {
            progressBar.Value = 23;
            object campoBranco = System.Reflection.Missing.Value;

            Word.Word.Application oApp = new Word.Word.Application();

            object caminhoContrato = System.IO.Path.GetFullPath("Contrato.doc");
            Word.Word.Document contrato = oApp.Documents.Add(ref caminhoContrato, false, ref campoBranco, false);

            progressBar.Value = 26;

            mudar(contrato, campoBranco, modeloContrato.nomeAluno, "[nomeAluno]");
            progressBar.Value = 29;
            mudar(contrato, campoBranco, modeloContrato.dataNascimentoAluno, "[dataNascimentoAluno]");
            progressBar.Value = 32;
            mudar(contrato, campoBranco, modeloContrato.telefoneAluno, "[telefoneAluno]");
            progressBar.Value = 35;
            mudar(contrato, campoBranco, modeloContrato.celularAluno, "[celularAluno]");
            progressBar.Value = 38;
            mudar(contrato, campoBranco, modeloContrato.nomeContratante, "[nomeContratante]");
            progressBar.Value = 41;
            mudar(contrato, campoBranco, modeloContrato.nomeContratante, "[nomeContratante]");
            progressBar.Value = 44;
            mudar(contrato, campoBranco, modeloContrato.telefoneContratante, "[telefoneContratante]");
            progressBar.Value = 47;
            mudar(contrato, campoBranco, modeloContrato.celularContratante, "[celularContratante]");
            progressBar.Value = 50;
            mudar(contrato, campoBranco, modeloContrato.rgContratante, "[rgContratante]");
            progressBar.Value = 53;
            mudar(contrato, campoBranco, modeloContrato.cpfContratante, "[cpfContratante]");
            progressBar.Value = 56;
            mudar(contrato, campoBranco, modeloContrato.enderecoContratante, "[enderecoContratante]");
            progressBar.Value = 59;
            mudar(contrato, campoBranco, modeloContrato.matematica, "[matematica]");
            progressBar.Value = 62;
            mudar(contrato, campoBranco, modeloContrato.portugues, "[portugues]");
            progressBar.Value = 65;
            mudar(contrato, campoBranco, modeloContrato.ingles, "[ingles]");
            progressBar.Value = 68;
            mudar(contrato, campoBranco, modeloContrato.seisMeses, "[seisMeses]");
            progressBar.Value = 71;
            mudar(contrato, campoBranco, modeloContrato.dozeMeses, "[dozeMeses]");
            progressBar.Value = 74;
            mudar(contrato, campoBranco, modeloContrato.inicioDoCurso, "[inicioDoCurso]");
            progressBar.Value = 77;
            mudar(contrato, campoBranco, modeloContrato.diasDaSemana, "[diasDaSemana]");
            progressBar.Value = 80;
            mudar(contrato, campoBranco, modeloContrato.horarios, "[horarios]");
            progressBar.Value = 82;
            mudar(contrato, campoBranco, modeloContrato.taxaMatricula, "[taxaMatricula]");
            progressBar.Value = 84;
            mudar(contrato, campoBranco, modeloContrato.taxaMatriculaExtenso, "[taxaMatriculaExtenso]");
            progressBar.Value = 86;
            mudar(contrato, campoBranco, modeloContrato.mensalidade, "[mensalidade]");
            progressBar.Value = 88;
            mudar(contrato, campoBranco, modeloContrato.mensalidadeExtenso, "[mensalidadeExtenso]");
            progressBar.Value = 90;
            mudar(contrato, campoBranco, modeloContrato.dataFinalContrato, "[dataFinalContrato]");
            progressBar.Value = 92;
            mudar(contrato, campoBranco, modeloContrato.nomeTestemunha1, "[nomeTestemunha1]");
            progressBar.Value = 94;
            mudar(contrato, campoBranco, modeloContrato.rgTestemunha1, "[rgTestemunha1]");
            progressBar.Value = 96;
            mudar(contrato, campoBranco, modeloContrato.nomeTestemunha2, "[nomeTestemunha2]");
            progressBar.Value = 98;
            mudar(contrato, campoBranco, modeloContrato.rgTestemunha2, "[rgTestemunha2]");
            progressBar.Value = 99;

            oApp.Visible = true;
        }

        public void mudar(Word.Word.Document contrato, object branco , string substituir ,string encontrarTexto)
        {
            Word.Word.Range mudar = contrato.Range(ref branco, ref branco);

            object FindText = encontrarTexto;
            object ReplaceWith = substituir;
            object MatchWholeWord = true;
            object Forward = false;

            mudar.Find.Execute(ref FindText, ref branco, ref MatchWholeWord, ref branco, ref branco, ref branco, ref Forward, ref branco, ref branco,
                              ref ReplaceWith, ref branco, ref branco, ref branco, ref branco);
        }
    }
}
