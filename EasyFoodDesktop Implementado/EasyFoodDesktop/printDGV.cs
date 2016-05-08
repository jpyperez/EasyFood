using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Data;
using System.Text;

namespace EasyFoodDesktop
{
    class printDGV
    {

        private static StringFormat StrFormat;  // Servirá para "guardar" o conteúdo da TextBox Cell e apresentar o texto através do DrawString
        private static StringFormat StrFormatComboBox; // Holds content of a Boolean Cell to write by DrawImage
        private static Button CellButton;       // "Guarda" o conteúdo da célula referente ao botão 
        private static CheckBox CellCheckBox;   // "Guarda" o conteúdo da célula referente à CheckBox
        private static ComboBox CellComboBox;   // "Guarda" o conteúdo da célula referente à ComboBox 

        private static int TotalWidth;          // Soma o total de colunas
        private static int RowPos;              // Posição da linha na impressão 
        private static bool NewPage;            // Indica se é necessário se é necessário uma nova página
        private static int PageNo;              // Número de páginas para imprimir
        private static ArrayList ColumnLefts = new ArrayList();  // Coordenada esquerda das colunas
        private static ArrayList ColumnWidths = new ArrayList(); // Largura das colunas
        private static ArrayList ColumnTypes = new ArrayList();  // Tipo das colunas
        private static int CellHeight;          // Altura da célula do DataGrid
        private static int RowsPerPage;         // Número de linhas por página
        private static System.Drawing.Printing.PrintDocument printDoc =
                       new System.Drawing.Printing.PrintDocument();  // Tipo de objecto de documento de impressão para imprimir

        private static string PrintTitle = "";  // Cabeçalho das páginas
        private static DataGridView dgv;        // "Guarda" o objecto referente ao conteúdo da DataGridView
        private static List<string> SelectedColumns = new List<string>();   // As colunas seleccionadas pelo utilizador para imprimir.
        private static List<string> AvailableColumns = new List<string>();  // Todas as colunas disponíveis noDataGridView
        private static bool PrintAllRows = true;   // Este código não é necessário para este tutorial  
        private static bool FitToPageWidth = true; // Este código não é necessário para este tutorial    
        private static int HeaderHeight = 0;

        public static void Print_DataGridView(DataGridView dgv1)
        {
            PrintPreviewDialog ppvw;
            try
            {
                // Obtém objecto para imprimir do DataGridView
                dgv = dgv1;

                // Obtém todos os nomes das colunas da DataGridView
                AvailableColumns.Clear();
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    if (!c.Visible) continue;
                    AvailableColumns.Add(c.HeaderText);
                }

                // Mostra o form PrintOption 
                PrintOptions dlg = new PrintOptions(AvailableColumns);
                if (dlg.ShowDialog() != DialogResult.OK) return;

                PrintTitle = dlg.PrintTitle;
                SelectedColumns = dlg.GetSelectedColumns();

                RowsPerPage = 0;

                ppvw = new PrintPreviewDialog();
                ppvw.Document = printDoc;

                // Mostra o PrintPreview
                printDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(PrintDoc_BeginPrint);
                printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
                if (ppvw.ShowDialog() != DialogResult.OK)
                {
                    printDoc.BeginPrint -= new System.Drawing.Printing.PrintEventHandler(PrintDoc_BeginPrint);
                    printDoc.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
                    return;
                }

                // Imprime o documento
                printDoc.Print();
                printDoc.BeginPrint -= new System.Drawing.Printing.PrintEventHandler(PrintDoc_BeginPrint);
                printDoc.PrintPage -= new System.Drawing.Printing.PrintPageEventHandler(PrintDoc_PrintPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private static void PrintDoc_BeginPrint(object sender,
                    System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                // Formata o conteúdo das células para imprimir
                StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Near;
                StrFormat.LineAlignment = StringAlignment.Center;
                StrFormat.Trimming = StringTrimming.EllipsisCharacter;
                StrFormatComboBox = new StringFormat();
                StrFormatComboBox.LineAlignment = StringAlignment.Center;
                StrFormatComboBox.FormatFlags = StringFormatFlags.NoWrap;
                StrFormatComboBox.Trimming = StringTrimming.EllipsisCharacter;

                ColumnLefts.Clear();
                ColumnWidths.Clear();
                ColumnTypes.Clear();
                CellHeight = 0;
                RowsPerPage = 0;

                // Para vários tipos de colunas
                CellButton = new Button();
                CellCheckBox = new CheckBox();
                CellComboBox = new ComboBox();

                // Calcula a largura total
                TotalWidth = 0;
                foreach (DataGridViewColumn GridCol in dgv.Columns)
                {
                    if (!GridCol.Visible) continue;
                    if (!printDGV.SelectedColumns.Contains(GridCol.HeaderText)) continue;
                    TotalWidth += GridCol.Width;
                }
                PageNo = 1;
                NewPage = true;
                RowPos = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void PrintDoc_PrintPage(object sender,
                    System.Drawing.Printing.PrintPageEventArgs e)
        {
            int tmpWidth, i;
            int tmpTop = e.MarginBounds.Top;
            int tmpLeft = e.MarginBounds.Left;

            try
            {
                // Antes de indicar a primeira página, grava a altura e largura do cabeçalho e o tipo de coluna
                if (PageNo == 1)
                {
                    foreach (DataGridViewColumn GridCol in dgv.Columns)
                    {
                        if (!GridCol.Visible) continue;
                        // Ignora a coluna que não está seleccionada
                        if (!printDGV.SelectedColumns.Contains(GridCol.HeaderText)) continue;

                        // Determina se as colunas estão ajustadas à página
                        if (FitToPageWidth)
                            tmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)TotalWidth * (double)TotalWidth *
                                       ((double)e.MarginBounds.Width / (double)TotalWidth))));
                        else
                            tmpWidth = GridCol.Width;

                        HeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, tmpWidth).Height) + 11;

                        ColumnLefts.Add(tmpLeft);
                        ColumnWidths.Add(tmpWidth);
                        ColumnTypes.Add(GridCol.GetType());
                        tmpLeft += tmpWidth;
                    }
                }

                // Imprime a página linha por linha
                while (RowPos <= dgv.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dgv.Rows[RowPos];
                    if (GridRow.IsNewRow || (!PrintAllRows && !GridRow.Selected))
                    {
                        RowPos++;
                        continue;
                    }

                    CellHeight = GridRow.Height;

                    if (tmpTop + CellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        DrawFooter(e, RowsPerPage);
                        NewPage = true;
                        PageNo++;
                        e.HasMorePages = true;
                        return;
                    }
                    else
                    {
                        if (NewPage)
                        {
                            // Desenha o cabeçalho
                            e.Graphics.DrawString(PrintTitle, new Font(dgv.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                            e.Graphics.MeasureString(PrintTitle, new Font(dgv.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String s = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(s, new Font(dgv.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(s, new Font(dgv.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString(PrintTitle, new Font(new Font(dgv.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            // Desenha as colunas
                            tmpTop = e.MarginBounds.Top;
                            i = 0;
                            foreach (DataGridViewColumn GridCol in dgv.Columns)
                            {
                                if (!GridCol.Visible) continue;
                                if (!printDGV.SelectedColumns.Contains(GridCol.HeaderText))
                                    continue;

                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)ColumnLefts[i], tmpTop,
                                    (int)ColumnWidths[i], HeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)ColumnLefts[i], tmpTop,
                                    (int)ColumnWidths[i], HeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)ColumnLefts[i], tmpTop,
                                    (int)ColumnWidths[i], HeaderHeight), StrFormat);
                                i++;
                            }
                            NewPage = false;
                            tmpTop += HeaderHeight;
                        }

                        // Desenha o conteúdo das colunas
                        i = 0;
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (!Cel.OwningColumn.Visible) continue;
                            if (!SelectedColumns.Contains(Cel.OwningColumn.HeaderText))
                                continue;

                            // Para a coluna da TextBox
                            if (((Type)ColumnTypes[i]).Name == "DataGridViewTextBoxColumn" ||
                                ((Type)ColumnTypes[i]).Name == "DataGridViewLinkColumn")
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)ColumnLefts[i], (float)tmpTop,
                                        (int)ColumnWidths[i], (float)CellHeight), StrFormat);
                            }
                            // Para a coluna do botão
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewButtonColumn")
                            {
                                CellButton.Text = Cel.Value.ToString();
                                CellButton.Size = new Size((int)ColumnWidths[i], CellHeight);
                                Bitmap bmp = new Bitmap(CellButton.Width, CellButton.Height);
                                CellButton.DrawToBitmap(bmp, new Rectangle(0, 0,
                                        bmp.Width, bmp.Height));
                                e.Graphics.DrawImage(bmp, new Point((int)ColumnLefts[i], tmpTop));
                            }
                            // Para a coluna do CheckBox
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewCheckBoxColumn")
                            {
                                CellCheckBox.Size = new Size(14, 14);
                                CellCheckBox.Checked = (bool)Cel.Value;
                                Bitmap bmp = new Bitmap((int)ColumnWidths[i], CellHeight);
                                Graphics tmpGraphics = Graphics.FromImage(bmp);
                                tmpGraphics.FillRectangle(Brushes.White, new Rectangle(0, 0,
                                        bmp.Width, bmp.Height));
                                CellCheckBox.DrawToBitmap(bmp,
                                        new Rectangle((int)((bmp.Width - CellCheckBox.Width) / 2),
                                        (int)((bmp.Height - CellCheckBox.Height) / 2),
                                        CellCheckBox.Width, CellCheckBox.Height));
                                e.Graphics.DrawImage(bmp, new Point((int)ColumnLefts[i], tmpTop));
                            }
                            // Para a coluna do ComboBox
                            else if (((Type)ColumnTypes[i]).Name == "DataGridViewComboBoxColumn")
                            {
                                CellComboBox.Size = new Size((int)ColumnWidths[i], CellHeight);
                                Bitmap bmp = new Bitmap(CellComboBox.Width, CellComboBox.Height);
                                CellComboBox.DrawToBitmap(bmp, new Rectangle(0, 0,
                                        bmp.Width, bmp.Height));
                                e.Graphics.DrawImage(bmp, new Point((int)ColumnLefts[i], tmpTop));
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                        new SolidBrush(Cel.InheritedStyle.ForeColor),
                                        new RectangleF((int)ColumnLefts[i] + 1, tmpTop, (int)ColumnWidths[i]
                                        - 16, CellHeight), StrFormatComboBox);
                            }


                            // Desenha as margens das células
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)ColumnLefts[i],
                                    tmpTop, (int)ColumnWidths[i], CellHeight));

                            i++;

                        }
                        tmpTop += CellHeight;
                    }

                    RowPos++;
                    // Se for a primeira página, calcula o número de linhas por página
                    if (PageNo == 1) RowsPerPage++;
                }

                if (RowsPerPage == 0) return;

                // Desenha rodapé (número de página)
                DrawFooter(e, RowsPerPage);

                e.HasMorePages = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void DrawFooter(System.Drawing.Printing.PrintPageEventArgs e,
                    int RowsPerPage)
        {
            double cnt = 0;

            // Determina o número de linhas a imprimir
            if (PrintAllRows)
            {
                if (dgv.Rows[dgv.Rows.Count - 1].IsNewRow)
                    cnt = dgv.Rows.Count - 2; // Quando o DataGridView NÃO permite adicionar linhas
                else
                    cnt = dgv.Rows.Count - 1; // Quando o DataGridView permite adicionar linhas
            }
            else
                cnt = dgv.SelectedRows.Count;

            // Escreve o número da página
            string PageNum = PageNo.ToString() + " de " +
                Math.Ceiling((double)(cnt / RowsPerPage)).ToString();

            e.Graphics.DrawString(PageNum, dgv.Font, Brushes.Black,
                e.MarginBounds.Left + (e.MarginBounds.Width -
                e.Graphics.MeasureString(PageNum, dgv.Font,
                e.MarginBounds.Width).Width) / 2, e.MarginBounds.Top +
                e.MarginBounds.Height + 31);
        }
    }
}
