using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;

namespace WibergNykLibary
{
    public static class Reciept
    {
        public static bool Create(string pdfLocation, string verksamhet, Nyckel nyckel, Person person)
        {
            try
            {
                var FilePath = pdfLocation + "\\" + person.Fornamn + " " + person.Efternamn + DateTime.Now.Ticks.ToString() + ".pdf";
                if (Directory.Exists(pdfLocation))
                {
                    var doc1 = new Document();

                    var streamObj = new FileStream(FilePath, FileMode.CreateNew);
                    PdfWriter.GetInstance(doc1, streamObj);
                    doc1.Open();
                    doc1.Add(new Paragraph($"WibergNyk - Nyckel Kvittens"));
                    doc1.Add(new Paragraph("Verksamhet: " + verksamhet));


                    Chunk linebreak = new Chunk(new LineSeparator());

                    doc1.Add(linebreak);

                    PdfPTable table = new PdfPTable(2);
                    PdfPTable table2 = new PdfPTable(2);
                    PdfPTable table3 = new PdfPTable(1);

                    Phrase ph = new Phrase("Nyckel", new Font(Font.FontFamily.TIMES_ROMAN, 14f, Font.BOLD, BaseColor.BLACK));
                    Phrase ph2 = new Phrase("Person", new Font(Font.FontFamily.TIMES_ROMAN, 14f, Font.BOLD, BaseColor.BLACK));
                    Phrase ph3 = new Phrase("Underskrift", new Font(Font.FontFamily.TIMES_ROMAN, 14f, Font.BOLD, BaseColor.BLACK));

                    PdfPCell cell = new PdfPCell(ph)
                    {
                        Colspan = 2,
                        HorizontalAlignment = 1,
                        VerticalAlignment = 1,
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };

                    PdfPCell cell2 = new PdfPCell(ph2)
                    {
                        Colspan = 2,
                        HorizontalAlignment = 1,
                        VerticalAlignment = 1,
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };

                    PdfPCell cell3 = new PdfPCell(ph3)
                    {
                        Colspan = 2,
                        HorizontalAlignment = 1,
                        VerticalAlignment = 1,
                        BackgroundColor = BaseColor.LIGHT_GRAY
                    };

                    table.AddCell(cell);
                    table2.AddCell(cell2);
                    table3.AddCell(cell3);

                    //Second row
                    table.AddCell(new PdfPCell(new Phrase("Id", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table.AddCell(nyckel.ID.ToString());

                    table.AddCell(new PdfPCell(new Phrase("Typ", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table.AddCell(nyckel.Typ);

                    //Third row
                    table.AddCell(new PdfPCell(new Phrase("Serie", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table.AddCell(nyckel.Serie);

                    table.AddCell(new PdfPCell(new Phrase("Nummer", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table.AddCell(nyckel.Nummer);

                    table2.AddCell(new PdfPCell(new Phrase("Förnamn", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table2.AddCell(person.Fornamn);

                    //Third row
                    table2.AddCell(new PdfPCell(new Phrase("Efternamn", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table2.AddCell(person.Efternamn);

                    table2.AddCell(new PdfPCell(new Phrase("PersonNr", new Font(Font.FontFamily.TIMES_ROMAN, 12f, Font.BOLD))));
                    table2.AddCell(person.PersNr);

                    table3.AddCell(new PdfPCell(new Phrase("Utgivare:", new Font(Font.FontFamily.TIMES_ROMAN, 16f, Font.BOLD))));

                    table3.AddCell(new PdfPCell(new Phrase("Mottagare:", new Font(Font.FontFamily.TIMES_ROMAN, 16f, Font.BOLD))));

                    doc1.Add(table2);
                    doc1.Add(table);
                    doc1.Add(table3);

                    doc1.Add(linebreak);
                    doc1.Add(new Paragraph("Datum: " + DateTime.Now.ToShortDateString()));

                    doc1.Close();

                    System.Diagnostics.Process.Start(FilePath);
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
