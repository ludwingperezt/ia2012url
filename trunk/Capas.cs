/***********************************************************************
 * Module:  Capas.cs
 * Author:  ROLANDO
 * Purpose: Definition of the Class Capas
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Capas
{
    //atributos

    public  List<Perceptron> Neuronas; //Son todas las neuronas que pertenecen a la capa
    public List<Double> Entradas; //las entradas de la capa...
    public List<Double> Salidas; //las entradas de la capa...

    //metodos
   public Capas(List<Double> entradas)
   {
      // TODO: implement
   }
   
   public Capas()
   {
      // TODO: implement
   }
   
   public List<Double> ObtenerSalidas(List<Double> entradas)
   {
      // TODO: implement
      return null;
   }
   
   public Double CalcularErrorCuadratico(List<Double> salidasEsperadas)
   {
      // TODO: implement
      return null;
   }
   
   public void AgregarNeurona(Perceptron padre)
   {
       Neuronas.Add(padre);
   }
   
   public int NumeroNeuronas()
   {
      // TODO: implement
      return 0;
   }
   
   public Perceptron GetNeurona(int index)
   {
      // TODO: implement
      return null;
   }
   
   public void RetroPropagar(List<Double> salidasEsperadas)
   {
      // TODO: implement
   }
   
   public Capas ObtenerCapaSalida()
   {
      // TODO: implement
      return null;
   }
   
   public void CorregirPesos()
   {
      // TODO: implement
   }
   
   public void InicializarCapa()
   {
      // TODO: implement
   }


}