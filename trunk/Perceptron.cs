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
   }
   
   public Double generarSalida()
   {
      // TODO: implement
      return null;
   }
   
   public void corregirPesos()
   {
      // TODO: implement
   }
   
   public Double calcularErrores(Double SalidaEsperada)
   {
      // TODO: implement
      return null;
   }
   
   public Double CalcularGradiente()
   {
      // TODO: implement
      return null;
   }
   
   public Double getError()
   {
      // TODO: implement
      return null;
   }
   
   public Double GetEntrada(int index)
   {
      // TODO: implement
      return null;
   }
   
   public void SetEntrada(Double valor)
   {
      // TODO: implement
   }
   
   public Double GetGradiente()
   {
      // TODO: implement
      return null;
   }
   
   public Double CalcularDeltaW()
   {
      // TODO: implement
      return null;
   }
   
   public void AgregarPadre(Perceptron padre)
   {
      // TODO: implement
   }
   
   public void AgregarHijo(Perceptron hijo)
   {
      // TODO: implement
   }
   
   public void NuevoPeso()
   {
      // TODO: implement
   }
   
   public List<Double> GetPesos()
   {
      // TODO: implement
      return null;
   }
   
   public bool PerteneceACapaSalida()
   {
      // TODO: implement
      return false;
   }
   
   public void ClearEntradas()
   {
      // TODO: implement
   }
   
   public Double DesencolarPeso()
   {
      // TODO: implement
      return null;
   }
   
   public List<Perceptron> GetHijos()
   {
      // TODO: implement
      return null;
   }
   
   public List<Perceptron> GetPadres()
   {
      // TODO: implement
      return null;
   }
}