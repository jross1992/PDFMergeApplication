using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace mergePdf
{
    public partial class PDFMERGE : Form
    {
        public PDFMERGE()
        {
            InitializeComponent();
        }


        protected void btnMerge_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Select PDFFile";
            saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
            string pdfFile1 = Path.GetFullPath(textBoxPdfFile1Path.Text);
            string[] filenames = { pdfFile1 };
            string outputFileName = System.IO.Path.GetRandomFileName() + ".pdf"; ;
            string outputPath = saveFileDialog1.FileName;
            
            FileInfo fileInfo = new FileInfo(outputPath);
            Console.WriteLine(fileInfo.DirectoryName);

           
            Document doc = new Document();
            PdfCopy writer = new PdfCopy(doc, new FileStream(outputPath, FileMode.Create));
            if (writer == null)
            {
                return;
            }
            doc.Open();
            foreach (var filename in listBox1.Items)
            {
                PdfReader reader = new PdfReader(filename.ToString());
                reader.ConsolidateNamedDestinations();
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    PdfImportedPage page = writer.GetImportedPage(reader, i);
                    writer.AddPage(page);
                }

                reader.Close();
            }

            writer.Close();
            doc.Close();
            System.Diagnostics.Process.Start(outputPath);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnSelectFile1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            ofd.Multiselect = true;
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPdfFile1Path.Text = ofd.FileName;
                string[] files = ofd.FileNames;
                listBox1.Items.AddRange(files);
            }
        }
        private void button1Clr_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }

        }

  
        private void buttonUp_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            int numberOfSelectedItems = listBox1.SelectedItems.Count;
            for (int i = 0; i < numberOfSelectedItems; i++)
            {
                // only if it's not the first item
                if (listBox1.SelectedIndices[i] > 0)
                {
                    // the index of the item above the item that we wanna move up
                    int indexToInsertIn = listBox1.SelectedIndices[i] - 1;
                    // insert UP the item that we want to move up
                    listBox1.Items.Insert(indexToInsertIn, listBox1.SelectedItems[i]);
                    // removing it from its old place
                    listBox1.Items.RemoveAt(indexToInsertIn + 2);
                    // highlighting it in its new place
                    listBox1.SelectedItem = listBox1.Items[indexToInsertIn];
                }
            }
            listBox1.EndUpdate();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            int numberOfSelectedItems = listBox1.SelectedItems.Count;
            // when going down, instead of moving through the selected items from top to bottom
            // we'll go from bottom to top, it's easier to handle this way.
            for (int i = numberOfSelectedItems - 1; i >= 0; i--)
            {
                // only if it's not the last item
                if (listBox1.SelectedIndices[i] < listBox1.Items.Count - 1)
                {
                    // the index of the item that is currently below the selected item
                    int indexToInsertIn = listBox1.SelectedIndices[i] + 2;
                    // insert DOWN the item that we want to move down
                    listBox1.Items.Insert(indexToInsertIn, listBox1.SelectedItems[i]);
                    // removing it from its old place
                    listBox1.Items.RemoveAt(indexToInsertIn - 2);
                    // highlighting it in its new place
                    listBox1.SelectedItem = listBox1.Items[indexToInsertIn - 1];
                }
            }
            listBox1.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void button1clrAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
