using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.ControlerLayer;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ViewLayer
{
    public partial class ABMLUsuarios : Form
    {
        public ABMLUsuarios()
        {
            InitializeComponent();
            btnModificarUsuario.Enabled = false;
            tbBusqUsuario.Text = "Nombre del Usuario";
            tbBusqUsuario.ForeColor = Color.Gray;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ABMLUsuarios_Load(object sender, EventArgs e)
        {
            List<Cuenta> cuentas = new CuentaController().GetCuentas();

            CargarGrilla(cuentas);
        }

        private void CargarGrilla(List<Cuenta> cuentas)
        {
            DGUsuarios.Columns.Clear();
            DGUsuarios.Rows.Clear();


            DGUsuarios.Columns.Add("Nombre", "Nombre del Usuario");
            DGUsuarios.Columns.Add("Clave", "Clave del Usuario");
            DGUsuarios.Columns.Add("Id", "Id");
            DGUsuarios.Columns["Id"].Visible = false;

            foreach (var item1 in cuentas)
            {
                if (item1.Estado != false && (item1.TipoUsuario == "admin" || item1.TipoUsuario == "empleado"))
                {
                    DGUsuarios.Rows.Add(item1.Usuario, item1.Contraseña, item1.Id);
                }
            }
        }


        private void CambiarEstadoTB(bool estado)
        {
            tbUsuario.Enabled = estado;
            tbClave.Enabled = estado;
            tbTipoUsuario.Enabled = estado;
            tbNombreApellido.Enabled = estado;
            tbDNI.Enabled = estado;
            tbTelefono.Enabled = estado;
            tbEmail.Enabled = estado;
        }

        private void LimpiarTB()
        {
            tbIdUsuario.Text = string.Empty;
            tbUsuario.Text = string.Empty;
            tbClave.Text = string.Empty;
            tbTipoUsuario.Text = string.Empty;
            tbNombreApellido.Text = string.Empty;
            tbDNI.Text = string.Empty;
            tbTelefono.Text = string.Empty;
            tbEmail.Text = string.Empty;
        }


        private bool ValidacionesFormUsuarios()
        {
            bool condicion1 = tbUsuario.Text == "" || tbClave.Text == "" || tbTipoUsuario.Text == "" || tbNombreApellido.Text == "";
            bool condicion2 = !tbEmail.Text.Contains("@") && tbEmail.Text != "";
            bool condicion3 = tbTipoUsuario.Text == "admin" || tbTipoUsuario.Text == "empleado";

            try
            {
                long number = long.Parse(tbDNI.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puso un numero en DNI. Error");
                return true;
            }

            if (condicion1)
            {
                MessageBox.Show("Los items con '*' no pueden estar vacios. Error");
                return true;
            }
            else if (condicion2)
            {
                MessageBox.Show("El email no tiene @. Error");
                return true;
            }
            else if (!condicion3)
            {
                MessageBox.Show("No existe ese tipo de usuario. Error");
                return true;
            }

            return false;
        }


        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Enabled == false)
            {
                LimpiarTB();
                CambiarEstadoTB(true);
            }
            else
            {
                if (ValidacionesFormUsuarios()) return;

                Cuenta cuenta = new Cuenta();
                cuenta.Usuario = tbUsuario.Text;
                cuenta.Contraseña = tbClave.Text;
                cuenta.TipoUsuario = tbTipoUsuario.Text;
                cuenta.Estado = true;

                Persona persona = new Persona();
                persona.NombreYApellido = tbNombreApellido.Text;
                persona.Documento = long.Parse(tbDNI.Text);
                persona.Telefono = tbTelefono.Text;
                persona.mail = tbEmail.Text;

                bool result = new CuentaController().Registrar(persona, cuenta);

                if (result)
                {
                    CambiarEstadoTB(false);
                    LimpiarTB();

                    btnUsToMenu.Visible = false;
                    lbUsAgregagoId.Text = cuenta.Usuario;
                    lbUsAgregagoClave.Text = cuenta.Contraseña;
                    pAgregadoUsuario.Visible = true;
                    pAgregadoUsuario.BringToFront();

                    List<Cuenta> cuentas = new CuentaController().GetCuentas();

                    CargarGrilla(cuentas);

                }
                else MessageBox.Show("No se cargo con exito al usuario {1} . Error", cuenta.Usuario);
            }
        }

        private void DGUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CambiarEstadoTB(false);
            btnModificarUsuario.Enabled = true;
            int fila = e.RowIndex;

            if (fila >= DGUsuarios.RowCount - 1) fila = e.RowIndex - 1;

            Cuenta c = new CuentaController().GetByIdCuenta(long.Parse(DGUsuarios.Rows[fila].Cells["Id"].Value.ToString()));
            Empleado emp = new EmpleadoController().GetByIdCEmpleado(c.Id);
            Persona p = new PersonaController().GetByIdPersona(emp.Personaid);

            // extrayendo iinformación de la grilla
            tbIdUsuario.Text = DGUsuarios.Rows[fila].Cells["Id"].Value.ToString();
            tbUsuario.Text = c.Usuario;
            tbClave.Text = c.Contraseña;
            tbTipoUsuario.Text = c.TipoUsuario;
            tbNombreApellido.Text = p.NombreYApellido;
            tbDNI.Text = p.Documento.ToString();
            tbTelefono.Text = p.Telefono;
            tbEmail.Text = p.mail;
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resultDialog;
            if (tbUsuario.Enabled == false && btnModificarUsuario.Text == "Modificar")
            {
                CambiarEstadoTB(true);
                btnModificarUsuario.Text = "Guardar";
            }
            else if (tbUsuario.Enabled == true && btnModificarUsuario.Text == "Guardar")
            {
                resultDialog = MessageBox.Show("¿Desea aplicar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.Yes)
                {
                    if (ValidacionesFormUsuarios()) return;
                    if (tbIdUsuario.Text == "") return;

                    Cuenta cuenta = new CuentaController().GetByIdCuenta(long.Parse(tbIdUsuario.Text));
                    Empleado emp = new EmpleadoController().GetByIdCEmpleado(cuenta.Id);
                    Persona persona = new PersonaController().GetByIdPersona(emp.Personaid);

                    cuenta.Usuario = tbUsuario.Text;
                    cuenta.Contraseña = tbClave.Text;
                    cuenta.TipoUsuario = tbTipoUsuario.Text;
                    cuenta.Estado = true;

                    persona.NombreYApellido = tbNombreApellido.Text;
                    persona.Documento = long.Parse(tbDNI.Text);
                    persona.Telefono = tbTelefono.Text;
                    persona.mail = tbEmail.Text;

                    bool result = new CuentaController().Modificar(persona, cuenta);

                    if (result)
                    {
                        CambiarEstadoTB(false);


                        MessageBox.Show("Se modifico con exito al usuario ");
                        btnModificarUsuario.Text = "Modificar";
                        btnModificarUsuario.Enabled = true;


                        List<Cuenta> cuentas = new CuentaController().GetCuentas();

                        CargarGrilla(cuentas);

                    }
                    else MessageBox.Show("No se pudo realizar la modificacion . Error", cuenta.Usuario);
                    {
                        btnModificarUsuario.Text = "Modificar";                        
                    }
                    
                }

            }


        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (tbIdUsuario.Text != "")
            {
                lbUsEliminarId.Text = tbUsuario.Text;
                lbUsEliminarClave.Text = tbClave.Text;                
                if (long.Parse(tbIdUsuario.Text) != ContLogin.GetInstance().UsuarioLogueadoid)
                {
                    pUsEliminar.BringToFront();
                    pUsEliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el Usuario logueado");
                }
              
                
            }
        }

        private void btnUsAtras_Click(object sender, EventArgs e)
        {
            pAgregadoUsuario.Visible = false;
            btnUsToMenu.Visible = true;
        }

        private void btnUsMenu_Click(object sender, EventArgs e)
        {
            btnUsToMenu.Visible = true;
            new Admin().Show();
            this.Close();
        }

        private void btnUsEliminarNo_Click(object sender, EventArgs e)
        {
            pUsEliminar.Visible = false;
        }

        private void btnUsEliminarOk_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new CuentaController().GetByIdCuenta(long.Parse(tbIdUsuario.Text));
            Empleado emp = new EmpleadoController().GetByIdCEmpleado(cuenta.Id);
            Persona persona = new PersonaController().GetByIdPersona(emp.Personaid);

            cuenta.Usuario = tbUsuario.Text;
            cuenta.Contraseña = tbClave.Text;
            cuenta.TipoUsuario = tbTipoUsuario.Text;
            cuenta.Estado = false;

            persona.NombreYApellido = tbNombreApellido.Text;
            persona.Documento = long.Parse(tbDNI.Text);
            persona.Telefono = tbTelefono.Text;
            persona.mail = tbEmail.Text;

            bool result = new CuentaController().Modificar(persona, cuenta);

            if (result)
            {
                CambiarEstadoTB(false);

                MessageBox.Show("Se Elimino el usuario con exito ");

                List<Cuenta> cuentas = new CuentaController().GetCuentas();

                CargarGrilla(cuentas);
                pUsEliminar.Visible = false;
                LimpiarTB();

            }
            else MessageBox.Show("No se pudo Eliminar. Error", cuenta.Usuario);
        }

        private void btnUsToMenu_Click(object sender, EventArgs e)
        {
            new Admin().Show();
            this.Close();
        }

        private void btnBusqUsuario_Click(object sender, EventArgs e)
        {
            if (tbBusqUsuario.Text == "")
            {
                List<Cuenta> cuentas = new CuentaController().GetCuentas();
                CargarGrilla(cuentas);
            }

            List<Cuenta> busqCuentas = new CuentaController().GetCuentas().Where(x => x.Usuario.Contains(tbBusqUsuario.Text)).ToList();

            CargarGrilla(busqCuentas);
        }

        private void tbBusqUsuario_TextChanged(object sender, EventArgs e)
        {
            if (tbBusqUsuario.Text != "Nombre del Usuario")
            new PropsTexBox().txtBusquedaNombre_TextChanged(sender, e, tbBusqUsuario, DGUsuarios, "Nombre");
        }

        private void tbBusqUsuario_MouseEnter(object sender, EventArgs e)
        {
            if (tbBusqUsuario.Text == "Nombre del Usuario")
            {
                tbBusqUsuario.Text = string.Empty;
                tbBusqUsuario.ForeColor = Color.Black;
            }
        }

        private void tbBusqUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (tbBusqUsuario.Text == "" && !tbBusqUsuario.Focused)
            {
                tbBusqUsuario.Text = "Nombre del Usuario";
                tbBusqUsuario.ForeColor = Color.Gray;
            }
        }
        private void tbBusqUsuario_Enter(object sender, EventArgs e)
        {
            if (tbBusqUsuario.Text == "Nombre del Usuario")
            {
                tbBusqUsuario.Text = "";
                tbBusqUsuario.ForeColor = Color.Black;
            }
        }

        private void tbBusqUsuario_Leave(object sender, EventArgs e)
        {
            if (tbBusqUsuario.Text == "")
            {
                tbBusqUsuario.Text = "Nombre del Usuario";
                tbBusqUsuario.ForeColor = Color.Gray;
            }
        }
    }
}
