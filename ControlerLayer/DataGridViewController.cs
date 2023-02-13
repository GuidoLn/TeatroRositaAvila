using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.ViewLayer;

namespace ProyectoFinal.ControlerLayer
{
    public class DataGridViewController
    {
        public void crearColumnas(DataGridView dgv, string[] datos)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            foreach (string items in datos)
            {
                dgv.Columns.Add(items, items);
                if (items == "Id")
                {
                    dgv.Columns["Id"].Visible = false;
                }

            }
        }
        public void crearColumnasCompras(DataGridView dgv, string[] datos)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Seleccionar Asientos";
            buttonColumn.Width = 150;
            
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.Name = "Cantidad entradas";
            comboColumn.Width = 100;
            comboColumn.DataSource = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboColumn.DisplayMember = "";
            comboColumn.ValueMember = "";
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            foreach (string items in datos)
            {
                if (items != "Cantidad entradas")
                {
                    dgv.Columns.Add(items, items);
                    if (items == "Id")
                    {
                        dgv.Columns["Id"].Visible = false;
                    }
                } else if (items != "Cantidad entradas")
                {
                    dgv.Columns.Add(buttonColumn);
                    //dgv.CellClick += new DataGridViewCellEventHandler(dgv_CellClick);
                }
                else
                {
                    dgv.Columns.Add(comboColumn);
                }

            }
        }

    }
}
