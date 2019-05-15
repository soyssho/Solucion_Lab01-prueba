using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Lab01
{
    public class CMinisterio
    {
        public static List<CCuartel> ListaCuarteles { get; set; }
        public static List<CSoldado> ListaSoldados { get; set; }
        public CMinisterio()
        {
            if (ListaCuarteles == null)
                ListaCuarteles = new List<CCuartel>();
            if (ListaSoldados == null)
                ListaSoldados = new List<CSoldado>();
        }
        public bool ExisteCuartel(string codigo)
        {
            return ListaCuarteles.Exists(p => p.Codigo == codigo);
        }
        public bool ExisteSoldado(string dni)
        {
            return ListaSoldados.Exists(p => p.DNI ==dni);
            //return ListaSoldados.Exists(delegate (CSoldado value)
            //{
            //    return value.DNI == dni;
            //});
        }
        public void RegistrarCuartel(CCuartel cuartel)
        {
            ListaCuarteles.Add(cuartel);
        }
        public void RegistrarSoldado(string codigo, CSoldado soldado)
        {
            CCuartel cuartelencontrado = ListaCuarteles.Find(p => p.Codigo == codigo);
            if (cuartelencontrado != null)
            {
                cuartelencontrado.Soldados.Add(soldado);
                ListaSoldados.Add(soldado);
            }
        }
        public int MenorEdad()
        {
            int menor = 1000;
            foreach (CSoldado soldado in ListaSoldados)
                if (soldado.Edad < menor)
                    menor = soldado.Edad;
            return menor;
        }
        public List<CCuartel> CuartelesSoldadosMenorEdad()
        {
            int menor = MenorEdad();
            List<CCuartel> cuartelesencontrados = new List<CCuartel>();
            foreach (CCuartel cuartel in ListaCuarteles)
                if (cuartel.Soldados.Exists(p => p.Edad == menor))
                    cuartelesencontrados.Add(cuartel);
            return cuartelesencontrados;
        }
        public int CantidadSoldadosEspecialidadEnUnCuartel(CCuartel cuartel, string especialidad)
        {
            int contador = 0;
            foreach (CSoldado soldado in cuartel.Soldados)
                if (soldado.Especialidad == especialidad)
                    contador++;
            return contador;
        }
        public List<CCuartel>CuartelesMenorCantidadDeUnaEspecialidad(string especialidad)
        {
            List<CCuartel> listadocuarteles = new List<CCuartel>();
            int menor = CantidadSoldadosEspecialidadEnUnCuartel(ListaCuarteles.ElementAt(0), especialidad);
            foreach (CCuartel cuartel in ListaCuarteles)
                if (CantidadSoldadosEspecialidadEnUnCuartel(cuartel, especialidad) < menor)
                    menor = CantidadSoldadosEspecialidadEnUnCuartel(cuartel, especialidad);
            foreach (CCuartel cuartel in ListaCuarteles)
                if (CantidadSoldadosEspecialidadEnUnCuartel(cuartel, especialidad) == menor)
                   listadocuarteles.Add(cuartel);
            return listadocuarteles;
        }
        public int CantidadTotalSoldadosDeEspecialidad(string especialidad)
        {
            int total = 0;
            foreach (CCuartel cuartel in ListaCuarteles)
                total = total + CantidadSoldadosEspecialidadEnUnCuartel(cuartel, especialidad);
            return total;
        }
        public double PromedioEdadEspecialidad(string especialidad)
        {
            double sumaedad = 0;
            int contador = 0;
            foreach(CSoldado soldado in ListaSoldados)
                if(soldado.Especialidad==especialidad)
                {
                    sumaedad += soldado.Edad;
                    contador++; 
                }
            if (contador > 0)
                return sumaedad / contador;
            else
                return 0;
        }
    }
}
