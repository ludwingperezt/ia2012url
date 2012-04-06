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
    //private List<Perceptron> capaAnterior; //padre, enlace a la capa anterior...
    //private List<Perceptron> capaSiguiente; //hijos, enlace a la capa siguiente

    

    //metodos
   public ManejoCapas(List<Double> entradasn)
   {
       entradas = entradasn;
       Rnd = new Random(DateTime.Now.Millisecond);// int aleat3 = r.Next(-1,1);
   }
   
   public void agregarCapa(int nNeuronas)
   {
       Capas capanueva = new Capas(); // realizo una instancia de la clase Capas.
       Perceptron padre= new Perceptron();// se crea el perceptron padre de la lista
       capanueva.AgregarNeurona(padre);// se agrega el padre de la lista 
       for (int i = 0; i < nNeuronas ; i++)//agrego el resto de neuronas
       {
           Perceptron perc = new Perceptron();
           capanueva.AgregarNeurona(perc);
       }
       this.capas.Add(capanueva);// hasta aqui  solo se a agregado la capa nueva sin aver enlazado la salida
       //de la anterior con  la entrada de la recien agregada
       if (capas.Count != 1) // comparamos para ver si es la capa inicial, donde la entrada es la que le coloquemos
       {
           int index = this.capas.Count - 1;// esta es la capa actual la que acamos de ingresar 
           //se maneja la capa anterior a la que ingresamos por eso se le vuelve a restar 1, y asi se realiza la conexion
           this.capas[index].Entradas = this.capas[index - 1].ObtenerSalidas(this.capas[index - 1].Entradas);
           //guardo las salidas ya que el anterior  las genera pero no las guarda en otro atributo, es algo redundante pero sirve.
           this.capas[index].Salidas = this.capas[index].ObtenerSalidas(this.capas[index].Entradas); 

       }
       else
       {
           this.capas[0].Entradas = entradas; // se concidera la capa inicial por lo que se le asignan los pesos del inicio.
       }


            
   }  

   
   public List<Double> entrenar() 
   {
      // TODO: implement
      return null;
   }
   
   public List<Double> evaluar()// este metodo para comparar las salidas de la red con las esperadas si no se inicia el entreno
   {
      // TODO: implement
      return null;
   }
   
   public void SetSalidasEsperadas(List<Double> targets)
   {
       this.salidaEsperada = targets; 
   }
   
   public void OrganizarCapas()
   {
      // TODO: implement
   }
   
   public int ObtenerCapaDeSalida() // se devuelve el tamaño como un int pide de retorno.
   {
       return capas.Count+1;
   }

   private List<Double> propagar()
   {
      // TODO: implement
      return null;
   }



}