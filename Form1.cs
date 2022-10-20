using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Newtonsoft.Json;
using org.mariuszgromada.math.mxparser;

namespace myexcel
{
    public partial class Excel : Form
    {
        public Excel()
        {
            InitializeComponent();
            GridSetup();
        }
        DataTable table = new DataTable();
        string[,,] id_values =  new string[100,100,2];
        int row_num = 0;
        int col_num = 0;

        private void GridSetup()
        {
            if (col_num == 0)
            {
                while (row_num < 4)
                {
                    table.Columns.Add();
                    col_num += 1;
                    table.Rows.Add();
                    row_num += 1;
                }
                for (int x = 0; x < id_values.GetLength(0); x++)
                {
                    for (int y = 0; y < id_values.GetLength(1); y++)
                    {   
                        for(int z = 0; z < id_values.GetLength(2); z++)
                        id_values[x, y, z] = "";
                    }
                }
            }
            dataGridView1.DataSource = table;
        }
        private void add_row_Click(object sender, EventArgs e)
        {
            table.Rows.Add();
            row_num += 1;
        }

        private void add_col_Click(object sender, EventArgs e)
        {
            table.Columns.Add();
            col_num += 1;
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerformat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerformat);
        }

        private void remove_row_Click(object sender, EventArgs e)
        {
            if (row_num > 1)
            {
                int curr_row = dataGridView1.CurrentCell.RowIndex;
                int x = curr_row;
                if (x == -1) x = 0;
                for (; x < id_values.GetLength(0) - 1; x++)
                {
                    for (int y = 0; y < id_values.GetLength(1); y++)
                    {
                        for (int z = 0; z < 2; z++)
                            id_values[x, y, z] = id_values[x+1, y ,z];
                    }
                }
                table.Rows.RemoveAt(curr_row);
                row_num -= 1;
            }
        }
        private void remove_col_Click(object sender, EventArgs e)
        {
            if (col_num > 1)
            {
                int curr_col = dataGridView1.Columns.Count-1;
                for (int x = 0; x < id_values.GetLength(0); x++)
                {
                    for (int z = 0; z < id_values.GetLength(2); z++)
                        id_values[x, curr_col, z] = "";
                }
                table.Columns.RemoveAt(curr_col);
                col_num -= 1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textBox1.Text = id_values[e.RowIndex, e.ColumnIndex, 0] + "";
                textBox2.Text = "r" + (e.RowIndex+1).ToString() + "c" + (e.ColumnIndex+1).ToString();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value.ToString() != "")
            {
                id_values[e.RowIndex, e.ColumnIndex, 0] = dataGridView1.CurrentCell.Value.ToString();
                string base_str = dataGridView1.CurrentCell.Value.ToString();
                if (base_str.IndexOf("r") != -1)
                {
                    string final_str = base_str;
                    while (final_str.IndexOf("r") != -1)
                    {
                        string temp1_str = final_str.Substring(0, final_str.IndexOf("r"));
                        string temp2_str = final_str.Substring(final_str.IndexOf("r") + 1, final_str.IndexOf("c") - final_str.IndexOf("r") - 1);
                        string temp3_str = final_str.Substring(final_str.IndexOf("c") + 1, final_str.Length - final_str.IndexOf("c") - 1);
                        string temp4_str;
                        if (temp3_str.IndexOf(" ") == -1)
                        {
                            temp4_str = temp3_str.Substring(0, temp3_str.Length);
                        }
                        else
                        {
                            temp4_str = temp3_str.Substring(0, temp3_str.IndexOf(" "));
                        }
                        string t2_trimmed = String.Concat(temp2_str.Where(c => !Char.IsWhiteSpace(c)));
                        string t4_trimmed = String.Concat(temp4_str.Where(c => !Char.IsWhiteSpace(c)));
                        //string temp5_str = string.Concat(temp1_str, id_values[Int32.Parse(t2_trimmed) - 1, Int32.Parse(t4_trimmed) - 1, 1], temp3_str.Substring(temp3_str.IndexOf(" "), temp3_str.Length - temp3_str.IndexOf(" ")));
                        final_str = string.Concat(temp1_str, id_values[Int32.Parse(t2_trimmed) - 1, Int32.Parse(t4_trimmed) - 1, 1], temp3_str.Substring(temp3_str.IndexOf(" "), temp3_str.Length - temp3_str.IndexOf(" ")));
                        //final_str = String.Concat(temp5_str.Where(c => !Char.IsWhiteSpace(c)));
                    }
                   // dataGridView1.CurrentCell.Value = final_str;
                    Expression exp = new Expression(final_str);
                    dataGridView1.CurrentCell.Value = exp.calculate().ToString();
                    id_values[e.RowIndex, e.ColumnIndex, 1] = dataGridView1.CurrentCell.Value.ToString();
                    textBox1.Text = exp.getExpressionString()+"";
                    id_values[e.RowIndex, e.ColumnIndex, 0] = exp.getExpressionString();
                }
                else
                {
                    Expression exp = new Expression(dataGridView1.CurrentCell.Value.ToString());
                    dataGridView1.CurrentCell.Value = exp.calculate().ToString();
                    id_values[e.RowIndex, e.ColumnIndex, 1] = dataGridView1.CurrentCell.Value.ToString();
                    textBox1.Text = exp.getExpressionString()+"";
                    id_values[e.RowIndex, e.ColumnIndex, 0] = exp.getExpressionString();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Users\\gorle\\Downloads\\excel.txt", JsonConvert.SerializeObject(id_values));
        }
    }
}
