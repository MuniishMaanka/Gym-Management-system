using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iText.Layout;
using iText.Kernel.Pdf;

namespace Gym_Management_system
{
    public partial class ReportForm : Form
    {
        DataGridView? GridData;
        List<DataGridView>? GridList;

        private string Filename = "";
        private string ReportTitle;
        iTextSharp.text.Rectangle pageOri;

        //Constructor OverLoading Two  constructor with same name but different Parameter
        //Single Grid
        public ReportForm(DataGridView griddata)
        {
            InitializeComponent();
            GridData = griddata;
        }

        //List of Grids
        public ReportForm(List<DataGridView> griddata)
        {
            InitializeComponent();
            GridList = griddata;
        }


        public void FileTitle_textChanged(object sender, EventArgs e)
        {
            if (FileTitle != null)
            {
                 ReportTitle = FileTitle.Text;
            }
        }

        public void FileName_TextChanged(object sender, EventArgs e)
        {
            if (Filename != null)
            {
                Filename = FileName.Text;
            }
        }


        private void CreatePDF(DataGridView GridData)
        {
            if (GridData.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = Filename.Length > 0 ? $"{Filename}.pdf" : "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to wride data in disk" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            //Table
                            PdfPTable pTable = new PdfPTable(GridData.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;


                            //Title
                            iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 32);
                            Paragraph Title = new Paragraph($"\n{ReportTitle}\n", titleFont);
                            Title.Alignment = Element.ALIGN_CENTER;

                            //Date
                            iTextSharp.text.Font DateFont = FontFactory.GetFont("Arial", 14);
                            Paragraph DateCreated = new Paragraph(DateTime.Now.ToString(), DateFont);
                            DateCreated.Alignment = Element.ALIGN_RIGHT;


                            foreach (DataGridViewColumn col in GridData.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in GridData.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {

                                if (comboBox1.SelectedText == "portrait")
                                {
                                    pageOri = PageSize.A4;
                                    Console.WriteLine("portraitm");
                                }
                                else
                                {
                                    pageOri = PageSize.A4.Rotate();
                                    Console.WriteLine("LandScape");
                                }

                                iTextSharp.text.Document document = new iTextSharp.text.Document(pageOri, 8f, 16f, 16f, 8f);

                                iTextSharp.text.pdf.PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(DateCreated);
                                document.Add(Title);
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("PDF Created Successfully", "info");

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");

            }
        }




        private void CreatePDF(List<DataGridView> GridData)
        {
         
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = Filename.Length > 0 ? $"{Filename}.pdf" : "Result.pdf";
            bool ErrorMessage = false;
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(save.FileName))
                {
                    try
                    {
                        File.Delete(save.FileName);
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage = true;
                        MessageBox.Show("Unable to wride data in disk" + ex.Message);
                    }
                }
                if (!ErrorMessage)
                {
                    try
                    {
                        //Title
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 32);
                        Paragraph Title = new Paragraph($"\n{ReportTitle}\n\n", titleFont);
                        Title.Alignment = Element.ALIGN_CENTER;

                        //Date
                        iTextSharp.text.Font DateFont = FontFactory.GetFont("Arial", 14);
                        Paragraph DateCreated = new Paragraph(DateTime.Now.ToString(), DateFont);
                        DateCreated.Alignment = Element.ALIGN_RIGHT;

                        List<PdfPTable> Table = new List<PdfPTable>();
                        foreach (DataGridView g in GridList)
                        {

                            //Table
                            PdfPTable pTable = new PdfPTable(g.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pTable.SpacingAfter = 20;

                            foreach (DataGridViewColumn col in g.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in g.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            Table.Add(pTable);
                        }


                        using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                        {

                            if (comboBox1.SelectedText == "portrait")
                            {
                                pageOri = PageSize.A4;
                                Console.WriteLine("portraitm");
                            }
                            else
                            {
                                pageOri = PageSize.A4.Rotate();
                                Console.WriteLine("LandScape");
                            }

                            iTextSharp.text.Document document = new iTextSharp.text.Document(pageOri, 8f, 16f, 16f, 8f);

                            iTextSharp.text.pdf.PdfWriter.GetInstance(document, fileStream);
                            document.Open();
                            document.Add(DateCreated);
                            document.Add(Title);
                            foreach (PdfPTable table in Table)
                            {
                                document.Add(table);
                            }
                            //document.Add(pTable);
                            document.Close();
                            fileStream.Close();
                        }
                        MessageBox.Show("PDF Created Successfully", "info");

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Error while exporting Data" + ex.Message);
                    }
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if(GridData != null)
            {
                CreatePDF(GridData);
            }
            if(GridList != null) 
            {
                Console.WriteLine("List of Grids");
                CreatePDF(GridList);
            }
        }
            
    }
}
