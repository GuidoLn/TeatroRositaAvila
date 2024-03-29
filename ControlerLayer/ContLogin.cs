﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoFinal.DataLayer;

namespace ProyectoFinal.ControlerLayer
{
    public class ContLogin
    {
        private string usuarioLogueado;
        private long usuarioLogueadoid;
        private static ContLogin _instance;

        public string UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }
        public long UsuarioLogueadoid { get => usuarioLogueadoid; set => usuarioLogueadoid = value; }

        private ContLogin() { }
        public static ContLogin GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ContLogin();
            }
            return _instance;
        }
        public string verificarCuenta(string usuario, string clave)
        {
            string resultado = string.Empty;
            resultado = new CuentaController().verificarCuenta(usuario, clave);
            if (resultado != string.Empty)
            {
                usuarioLogueadoid = new CuentaController().traerCuentaidByNombre(usuario);
            }
            return resultado;
        }
        public string verificarCuenta(string userName)
        {
            string resultado = string.Empty;
            resultado = new CuentaController().verificarCuenta(userName);
            return resultado;
        }
        public string verificarCuenta()
        {
            string resultado = string.Empty;
            resultado = new CuentaController().verificarCuenta(usuarioLogueado);
            return resultado;
        }


    }
}
