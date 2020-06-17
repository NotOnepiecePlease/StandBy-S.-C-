﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Word
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using PFC___StandBy_CSharp.Properties;
using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;

namespace PFC___StandBy_CSharp.Forms
{
    public partial class form_WordNota : Form
    {
        string diretorioArquivoPadrao = Settings.Default.diretorio_default_word;
        string diretorioPadrao = @".\NotaWord";
        int[] corGeral = { 0, 0, 0 };
        List<int> processosAntes;
        List<int> processosDepois;
        form_OrdensServ_Edit ordensServ;

        public form_WordNota(form_OrdensServ_Edit _ordensServ, int[] _corRgb)
        {
            InitializeComponent();
            tFilename.Text = diretorioArquivoPadrao;
            DirectoryInfo directoryInfo = new DirectoryInfo(diretorioArquivoPadrao);
            ordensServ = _ordensServ;
            corGeral = _corRgb;
            CentralizarLabels();
            MudarCores();
        }
        public form_WordNota()
        {
            InitializeComponent();
            tFilename.Text = diretorioArquivoPadrao;
            DirectoryInfo directoryInfo = new DirectoryInfo(diretorioArquivoPadrao);
            corGeral = new int[] { 255, 0, 103 };
            CentralizarLabels();
            MudarCores();
        }

        public void MudarCores()
        {
            tFilename.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCarregarWord.OnPressedColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnPastaPadrao.OnPressedColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCriarWord.BaseColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            btnCriarWord.OnHoverBaseColor = Color.FromArgb(120, corGeral[0], corGeral[1],corGeral[2]);
            btnCriarWord.OnPressedColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            lblImpressoraPdrao.ForeColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtCliente.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtCPF.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtModelo.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtServico.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);
            txtValor.FocusedLineColor = Color.FromArgb(corGeral[0], corGeral[1], corGeral[2]);

        }
        private void CentralizarLabels()
        {
            var configImpressora = new PrinterSettings();
            lblImpressoraPdrao.Text = configImpressora.PrinterName;
            lblImpressoraPdrao.Left = (this.Width / 2) - (lblImpressoraPdrao.Width / 2);
            lblArquivoPadrao.Left = (this.Width / 2) - (lblArquivoPadrao.Width / 2);
        }
        //Methode Find and Replace:
        private void FindAndReplace(Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }



        string pathImage = null;
        //Methode Create the document :
        private void CreateWordDocument(object filename, object savaAs)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            //string tempPath=null;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            try
            {
                if (File.Exists((string)filename))
                {
                    DateTime today = DateTime.Now;

                    object readOnly = false; //default
                    object isVisible = false;

                    wordApp.Visible = false;

                    aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing,
                                                ref missing, ref missing, ref missing, ref missing);

                    aDoc.Activate();

                    //Find and replace:
                    //MessageBox.Show("Alterando Strings");
                    this.FindAndReplace(wordApp, "<serviço>", txtServico.Text);
                    this.FindAndReplace(wordApp, "<aparelho>", txtModelo.Text);
                    this.FindAndReplace(wordApp, "<valor>", txtValor.Text);
                    this.FindAndReplace(wordApp, "<cliente>", txtCliente.Text);
                    this.FindAndReplace(wordApp, "<cpf>", txtCPF.Text);
                    this.FindAndReplace(wordApp, "<data>", DateTime.Now.ToShortDateString());

                    //insert the picture:
                    //Image img = resizeImage(pathImage, new Size(200, 90));
                    //tempPath = System.Windows.Forms.Application.StartupPath + "\\Images\\~Temp\\temp.jpg";
                    //img.Save(tempPath);

                    //Object oMissed = aDoc.Paragraphs[1].Range; //the position you want to insert
                    //Object oLinkToFile = false;  //default
                    //Object oSaveWithDocument = true;//default
                    //aDoc.InlineShapes.AddPicture(tempPath, ref  oLinkToFile, ref  oSaveWithDocument, ref oMissed);

                    #region Print Document :
                    //object copies = "1";
                    //object pages = "1";
                    //object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                    //object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                    //object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                    //object oTrue = true;
                    //object oFalse = false;

                    //Word.Document document = aDoc;
                    //object nullobj = Missing.Value;
                    //int dialogResult = wordApp.Dialogs[Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                    //wordApp.Visible = false;
                    //if (dialogResult == 1)
                    //{
                    //    document.PrintOut(
                    //    ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                    //    ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                    //    ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                    //}

                    #endregion

                }
                else
                {
                    MessageBox.Show("O Arquivo word de nota fiscal não existe ou esta corrompido.\n\n");
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("O Arquivo word de nota fiscal não existe ou esta corrompido.\n\n\nErro: " + e);
            }


            //Save as: filename
            //MessageBox.Show("Salvando arquivo...");
            aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);
            //File.Delete(tempPath);
            //MessageBox.Show("Arquivo Criado.");
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }


        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            //Percorre a lista de processos depois de criar o doc
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                //percorre a lista de processos antes de criar o doc
                foreach (int pidbefore in processesbeforegen)
                {
                    //Se o processo de antes for igual aos depois.
                    if (pidafter == pidbefore)
                    {
                        //Processo encontrado
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    try
                    {
                        Process clsProcess = Process.GetProcessById(pidafter);
                        clsProcess.Kill();
                    }
                    catch (Exception)
                    {
                    }   
                }
            }
        }

        //Méthode Enabled Controles:
        private void tEnabled(bool state)
        {
            txtCliente.Enabled = state;
            txtCPF.Enabled = state;
            txtModelo.Enabled = state;
            txtServico.Enabled = state;
            txtValor.Enabled = state;
        }

        private void btnCarregarWord_Click(object sender, EventArgs e)
        {
            if (LoadDoc.ShowDialog() == DialogResult.OK)
            {
                //txt Recebe o caminho do arquivo carregado
                tFilename.Text = LoadDoc.FileName;
                //Salvo esse caminho nas configuracoes
                Settings.Default.diretorio_default_word = LoadDoc.FileName;
                //e Salvo esse caminho tambem na variavel global de diretorio
                diretorioArquivoPadrao = Settings.Default.diretorio_default_word;
                //Salvo.
                Settings.Default.Save();
                tEnabled(true);
            }
        }
        public bool VerificarArquivoEmUso(string caminhoArquivo)
        {
            try
            {
                FileStream fs = File.OpenWrite(caminhoArquivo);
                fs.Close();
                return false;
            }
            catch (IOException ex)
            {
                DirectoryInfo nomeDoc = new DirectoryInfo(caminhoArquivo);
                MessageBox.Show("O Documento: '" + nomeDoc.Name + "' está aberto, por favor feche antes de seguir", "Documento Aberto",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
        }
        private void btnCriarWord_Click(object sender, EventArgs e)
        {
            Imprimir();   
        }

        public void Imprimir()
        {
            if (File.Exists(tFilename.Text))
            {
                DirectoryInfo diretorioDaLabel = new DirectoryInfo(tFilename.Text);
                DirectoryInfo directoryInfo = new DirectoryInfo(@".\NotaWord");
                if (Directory.Exists(directoryInfo.FullName))
                {
                    //Aqui eu pego o caminho completo até o arquivo ~cliente1.docx~
                    DirectoryInfo directorySave = new DirectoryInfo(@".\NotaWord\cliente1.docx");
                    SaveDoc.FileName = directorySave.FullName;
                    //Se o documento nao estiver aberto, aparece o erro.
                    if (!VerificarArquivoEmUso(diretorioDaLabel.FullName) == true)
                    {
                        //Criar o documento
                        CreateWordDocument(diretorioDaLabel.FullName, SaveDoc.FileName);

                        //Pego uma lista de processos antes de abrir o word pra imprimir
                        //pra poder fechar o processo correto quando terminar de imprimir.
                        processosAntes = getRunningProcesses();
                        Word.Application application = new Word.Application();
                        string caminhoContrato = directorySave.FullName;
                        Document document = application.Documents.Open(caminhoContrato);
                        document.Activate();
                        document.PrintPreview();
                        document.PrintOut();
                        processosDepois = getRunningProcesses();
                        ordensServ.ImprimiuAlgumaNota = 1;
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("A Pasta 'NotaWord' não existia nos arquivos do sistema StandBy\nmas nós criamos ela para você, clique em 'Imprimir' novamente.", "Diretorio Nao Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Directory.CreateDirectory(directoryInfo.FullName);
                    //MessageBox.Show("Diretorio Criado!: \n\n" + directoryInfo.FullName + "\n\nColoque o documento word de notas dentro dele!", "Diretorio Criado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("O Documento word usado como padrao nao foi encontrado, por favor, encontre o arquivo manualmente a seguir...",
                    "Arquivo nao encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (LoadDoc.ShowDialog() == DialogResult.OK)
                {
                    tFilename.Text = LoadDoc.FileName;
                    Settings.Default.diretorio_default_word = LoadDoc.FileName;
                    Settings.Default.Save();
                    tEnabled(true);
                    MessageBox.Show("Pode imprimir normalmente!", "Tudo certo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnPastaPadrao_Click(object sender, EventArgs e)
        {
            diretorioArquivoPadrao = @".\NotaWord\Cupom fiscal.docx";
            Settings.Default.diretorio_default_word = diretorioArquivoPadrao;
            Settings.Default.Save();
            tFilename.Text = diretorioArquivoPadrao;
            tEnabled(true);
        }

        private void form_WordNota_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (processosAntes != null || processosDepois != null)
            {
                killProcesses(processosAntes, processosDepois);
            }
            try
            {
                //DirectoryInfo directorySave = new DirectoryInfo(@".\NotaWord\cliente1.docx");
                //File.Delete(directorySave.FullName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void form_WordNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                //ordensServ.ImprimiuAlgumaNota = 0;
            }
        }

        private void form_WordNota_Load(object sender, EventArgs e)
        {
            
        }

        public void DeletarArquivoNoInicio()
        {
            DirectoryInfo directorySave = new DirectoryInfo(@".\NotaWord\cliente1.docx");
            File.Delete(directorySave.FullName);
        }

        private void iconClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}