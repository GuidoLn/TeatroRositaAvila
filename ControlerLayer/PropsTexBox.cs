using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.ControlerLayer
{
    public class PropsTexBox
    {
        public void txtBusquedaNombre_TextChanged(object sender, EventArgs e, TextBox txtBusquedaNombre, DataGridView dgvAsientos, string backText)
        {
            string searchText = txtBusquedaNombre.Text.ToLower();
            string cellValue = "";
            backText = backText.ToLower();
            if (searchText != "")
            {
                if (searchText != backText)
                {
                    foreach (DataGridViewRow item in dgvAsientos.Rows)
                    {
                        if (item.Cells[backText].Value != null && !item.IsNewRow)
                        {
                            cellValue = item.Cells[backText].Value.ToString().ToLower();
                            if (cellValue.StartsWith(searchText))
                            {
                                item.Visible = true;
                            }
                            else
                            {
                                item.Visible = false;
                            }
                        }

                    }
                }

            }
            else
            {
                foreach (DataGridViewRow item in dgvAsientos.Rows)
                {
                    if (!item.IsNewRow)
                        item.Visible = true;
                }
            }

        }

    }
}
