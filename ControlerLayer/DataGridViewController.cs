using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.DataLayer;
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
        public void llenarGrillaComprasRealizadas(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();

            using (TeatroEntities db = new TeatroEntities())
            {
                foreach (KeyValuePair<DateTime, List<Compra>> kvp in Diccionario.CompraByFechaCache)
                {
                    List<Compra> comprasFechaActual = kvp.Value;

                    var datosCompras = from compra in comprasFechaActual
                                       join localidadEspectaculo in db.LocalidadEspectaculo
                                           on compra.LocalidadEspectaculoid equals localidadEspectaculo.Id
                                       //join espectaculo in db.Espectaculo
                                       //    on localidadEspectaculo.Espectaculoid equals espectaculo.Id
                                       join cuenta in db.Cuenta
                                           on compra.Cuentaid equals cuenta.Id
                                       select new
                                       {
                                           Usuario = cuenta.Usuario,
                                           FechaYHora = compra.FechaHora,
                                           Precio = localidadEspectaculo.Precio,
                                           Asientos = new CompraController().convertirCompraEnLocalidadAsiento(comprasFechaActual),
                                           NumeroDeTicket = compra.Id,
                                           Id = compra.Id
                                       };

                    foreach (var datos in datosCompras)
                    {
                        dataGridView.Rows.Add(
                            datos.Usuario,
                            datos.FechaYHora,
                            datos.Precio,
                            datos.Asientos,
                            datos.NumeroDeTicket,
                            datos.Id
                        );
                    }
                }
            }
            
        }


        public List<object> GetComprasConDetalles()
        {
            using (TeatroEntities dbContext = new TeatroEntities()) {
                var comprasDetalles = (from c in dbContext.Compra
                                       join le in dbContext.LocalidadEspectaculo on c.LocalidadEspectaculoid equals le.Id
                                       join u in dbContext.Cuenta on c.Cuentaid equals u.Id
                                       select new
                                       {
                                           Usuario = u.Usuario,
                                           FechaYHora = c.FechaHora,
                                           Precio = le.Precio,
                                           Asientos = le.LocalidadAsiento.NumeroAsiento,
                                           NumeroDeTicket = c.Id,
                                           Id = c.Id
                                       }).ToList<object>();
                return comprasDetalles;
            }
        }


    }
}
