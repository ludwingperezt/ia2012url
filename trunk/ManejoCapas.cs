/***********************************************************************
 * Module:  ManejoCapas.cs
 * Author:  ROLANDO
 * Purpose: Definition of the Class ManejoCapas
 ***********************************************************************/

using System;
using System.Collections.Generic;


public class ManejoCapas
{
    //atributos estáticos y públicos
    public static Double constanteAprendizaje; //n
    public static List<Double> entradas; //es el patrón de entrada
    public static Random Rnd; //Generador de números aleatorios
    public static Double Emax; //el error cuadrático máximo tolerable...

    //atributos privados
    private List<Capas> capas; //Son cada una de las capas de la Red
    private List<Double> salidaEsperada; //las salidas que se esperan...
    

    //metodos
   public ManejoCapas(List<Double> entradas)
   {
      // TODO: implement
   }
   
   public void agregarCapa(int nNeuronas)
   {
      // TODO: implement
   }
   
   public List<Double> entrenar()
   {
      // TODO: implement
      return null;
   }
   
   public List<Double> evaluar()
   {
      // TODO: implement
      return null;
   }
   
   public void SetSalidasEsperadas(List<Double> targets)
   {
      // TODO: implement
   }
   
   public void OrganizarCapas()
   {
      // TODO: implement
   }
   
   public int ObtenerCapaDeSalida()
   {
      // TODO: implement
      return 0;
   }

   private List<Double> propagar()
   {
      // TODO: implement
      return null;
   }



}