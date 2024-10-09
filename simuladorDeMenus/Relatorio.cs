using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace simuladorDeMenus
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            ConfigurarDadosNoGrid();
            CarregarDadosNoGrid();
        }

        private void ConfigurarDadosNoGrid()
        {
            dgvRelatorio.ReadOnly = false;

            dgvRelatorio.AllowUserToAddRows = true;
            dgvRelatorio.AllowUserToDeleteRows = true;

            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void CarregarDadosNoGrid()
        {
            using (MemoryStream stream = new MemoryStream(Properties.Resources.dados))
            {
                using (ExcelPackage package = new ExcelPackage(stream))
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    DataTable dt = new DataTable();

                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Text);
                    }

                    for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                    {
                        DataRow dr = dt.NewRow();
                        for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                        {
                            dr[col - 1] = worksheet.Cells[row, col].Text;
                        }
                        dt.Rows.Add(dr);
                    }

                    dgvRelatorio.DataSource = dt;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgvRelatorio.Rows.Count == 0)
            {
                MessageBox.Show("Não há dados para salvar.");
                return;
            }

            string caminhoArquivoOriginal = @"C:\Users\darkg\source\repos\simuladorDeMenus\simuladorDeMenus\Resources\dados.xlsx";

            File.WriteAllBytes(caminhoArquivoOriginal, Properties.Resources.dados);

            using (ExcelPackage package = new ExcelPackage(new FileInfo(caminhoArquivoOriginal)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                for (int i = 0; i < dgvRelatorio.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvRelatorio.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvRelatorio.Rows[i].Cells[j].Value;
                    }
                }

                package.Save();

                MessageBox.Show("Dados salvos com sucesso!");
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Iniciou iniciou = new Iniciou();
            iniciou.Show();

            this.Close();
        }

        private void btnAtua_Click(object sender, EventArgs e)
        {
            CarregarDadosNoGrid();
        }
    }
}
