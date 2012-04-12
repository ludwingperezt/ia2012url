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
       List<double> datosS;
       datosS=new List<double>();
       for (int x=0; x<Neuronas.Count;x++)
               datosS.Add(Neuronas[x].generarSalida());
      return datosS;
   }
   
   public Double CalcularErrorCuadratico(List<Double> salidasEsperadas)
   {
      // TODO: implement
      return 0;
   }
   
   public void AgregarNeurona(Perceptron padre)
   {
       Neuronas.Add(padre);
   }
   
   public int NumeroNeuronas()
   {
      // TODO: implement
       return(Neuronas.Count);
   }
   
   public Perceptron GetNeurona(int index)
   {
      // TODO: implement
       return (Neuronas[index]);
   }
   
   public void RetroPropagar(List<Double> salidasEsperadas)
   {
      // TODO: implement
       int salida = 0;
       bool dato;
       for (int x = 0; x < Neuronas.Count; x++)
       {
           dato = Neuronas[x].PerteneceACapaSalida();
           if (dato==true) //conteo neuronas si son de la capa de salida o no
           {
               salida = salida+1;
               x = Neuronas.Count;
           }
       }
       if (salida == Neuronas.Count)
       {
           List<double> errores;
           errores = new List<double>();
           List<double> gradientes;
           gradientes = new List<double>();
           List<double> deltaW;
           deltaW = new List<double>();
           for (int x = 0; x < Neuronas.Count; x++)
           {
               errores.Add(Neuronas[x].calcularErrores(salidasEsperadas[x]));
               gradientes.Add(Neuronas[x].CalcularGradiente());
               deltaW.Add(Neuronas[x].CalcularDeltaW());
           }
       }

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

   //aplicable solo en la capa de entrada
   public void inicializarCapa(List<Double> listaIngreso)
   {
       // como se trata de una red arquitectura feed-forward, cada una de las salidas entran a cada una de las neuronas...
       for (int i = 0; i < listaIngreso.Count; i++)
       {
           foreach (Perceptron p in Neuronas)
               p.SetEntrada(listaIngreso[i]);
       }
   }

   public void limpiarEntradasNeuronas()
   {
       foreach (Perceptron p in Neuronas)
           p.clearEntradas();
   }

}