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
    public List<Double> Salidas; //las entradas de la capa... WTF!?
    //public int tipoCapa=0; //1: capa de entrada; 2: capa oculta; 3: capa de salida

    //metodos
   public Capas(List<Double> entradas, List<Perceptron> percepIn)
   {
       //int capa1 = 0, capa2 = 0, capa3 = 0;
       this.Neuronas = percepIn;
       //foreach (Perceptron p in this.Neuronas){
       //    if (p.GetPadres().Count == 0) capa1++;
       //    else
       //        if (p.GetHijos().Count == 0) capa3++;
       //        else
       //            capa2++;
       //}
       //if (capa1 == Neuronas.Count) tipoCapa = 1;
       //if (capa2 == Neuronas.Count) tipoCapa = 2;
       //if (capa3 == Neuronas.Count) tipoCapa = 3;
       //foreach (Double v in entradas)
       //{
       //    foreach (Perceptron p in this.Neuronas)
       //    {
       //        p.SetEntrada(v);
       //    }
       //}

      // TODO: implement
   }

   public Capas()
   {
   }

   public Capas(List<Perceptron> percepIn)
   {
       //int capa1 = 0, capa2 = 0, capa3 = 0;
       this.Neuronas = percepIn;
       //foreach (Perceptron p in this.Neuronas)
       //{
       //    if (p.GetPadres().Count == 0) capa1++;
       //    else
       //        if (p.GetHijos().Count == 0) capa3++;
       //        else
       //            capa2++;
       //}
       //if (capa1 == Neuronas.Count) tipoCapa = 1;
       //if (capa2 == Neuronas.Count) tipoCapa = 2;
       //if (capa3 == Neuronas.Count) tipoCapa = 3;
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
       List<Double> listaErrores= new List<double>();
       int x=0;
       Double error = 0;
       foreach (Perceptron p in this.Neuronas)
       {
           p.generarSalida();
           listaErrores.Add(p.calcularErrores(salidasEsperadas[x]));
           x++;
       }
       foreach (Double e in listaErrores)
       {
           error += e;
       }
       error += 0.5 * error;
       return error;
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
       int i = 0; 
       foreach (Perceptron p in Neuronas) {
            if (p.PerteneceACapaSalida())
                p.calcularErrores(salidasEsperadas[i]);
            p.CalcularGradiente(); 
            p.CalcularDeltaW();
            i = i + 1;
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