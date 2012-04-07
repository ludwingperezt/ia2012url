/***********************************************************************
 * Module:  Perceptron.cs
 * Author:  ROLANDO
 * Purpose: Definition of the Class Perceptron
 ***********************************************************************/

using System;
using System.Collections.Generic;

public class Perceptron
{
//atributos
   private List<Double> peso;  //lista con los pesos de la neurona, peso[1] corresponde con entrada[1]...
   private Double salida; //Energía Neta
   private List<Double> entrada; //las entradas de la neurona, recordar que entrada[x] debe corresponder con peso[x]
   private List<Perceptron> raiz; //padre, enlace a la capa anterior...
   private List<Perceptron> hijos; //hijos, enlace a la capa siguiente
   private Double error; //t-a
   private List<Double> DeltaW; //n*e[k]
   private Double Gradiente; //Se debe calcular si es capa de salida o para las capas ocultas...
   private Double Ganancia; //b
   private Queue<Double> ColaPesos; //la cola sirve cuando se hace la retropropagación, se van obteniendo los pesos en orden, si está vacía se debe llenar, con el array peso
//metodos
   public Perceptron()
   {
      // TODO: implement
       peso = new List<double>();
       entrada = new List<double>();
       raiz = new List<Perceptron>();
       hijos = new List<Perceptron>();
       DeltaW = new List<double>();
       ColaPesos = new Queue<double>();
   }
   
   public Double generarSalida()
   {
       salida = 0;
       for (int i = 0; i < peso.Count; i++)
       {
            salida += peso[i]*entrada[i];
       }

   }

   public void corregirPesos()
   {
      // TODO: implement
   }
   
   public Double calcularErrores(Double SalidaEsperada)
   {
       error = SalidaEsperada - salida;
   }
   
   public Double CalcularGradiente()
   {
      // TODO: implement
      return null;
   }
   
   public Double getError()
   {
       return error;
   }
   
   public Double GetEntrada(int index)
   {
       return entrada[i];
   }
   
   public void SetEntrada(Double valor)
   {
      // TODO: implement
   }
   
   public Double GetGradiente()
   {
       return Gradiente;
   }
   
   public Double CalcularDeltaW()
   {
       DeltaW = ManejoCapas.constanteAprendizaje * salida * Gradiente;
       return DeltaW;
   }
   
   public void AgregarPadre(Perceptron padre)
   {
       Random rm = new Random();
       this.raiz.Add(padre);
       peso.Add(rm.Next());
   }
   public void AgregarHijo(Perceptron hijo)
   {
       hijos.Add(hijo);
   }
   public void NuevoPeso()
   {
      // TODO: implement
       Random rm = new Random();
       peso.Add(rm.Next());
   }
   public void NuevoPeso(double nuevo)
   {
       peso.Add(nuevo);
   }
   public List<Double> GetPesos()
   {
       return peso;
   }
   
   public bool PerteneceACapaSalida()
   {
       if (hijos.Count > 0)
           return false;
       return true;
   }
   
   public void ClearEntradas()
   {
       entrada.Clear();
   }
   
   public Double DesencolarPeso()
   {
       return (ColaPesos.Dequeue());
   }
   
   public List<Perceptron> GetHijos()
   {
       return hijos;
   }
   
   public List<Perceptron> GetPadres()
   {
       return raiz;
   }
}