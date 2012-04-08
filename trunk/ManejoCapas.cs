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
    private Capas ultima = new Capas();// para la  ultima capa
    

    

    //metodos
   public ManejoCapas(List<Double> entradasn)
   {
       entradas = entradasn;
       Rnd = new Random(DateTime.Now.Millisecond);// int aleat3 = r.Next(-1,1);
   }
   
   public void agregarCapa(int nNeuronas)
   {
       Capas capanueva = new Capas(); // realizo una instancia de la clase Capas.
       ultima = capas[capas.Count - 1]; //asigno la  ultima capa 
       for (int i = 0; i < nNeuronas ; i++)//agrego las neuronas de la nueva capa
       {
           Perceptron perc = new Perceptron();
           for (int m = 0; m < ultima.NumeroNeuronas(); m++)//le asigno a cada padre su nuevo hijo
           {
               Perceptron padre = ultima.GetNeurona(m); //asigno la neurona padre de la capa anterior
               padre.AgregarHijo(perc);//le agrego su hijo   al padre de la capa anterior
               perc.AgregarPadre(padre);// le agrego el padre al perceptron que estoy por agregar a la nueva capa
           }          
          
           capanueva.AgregarNeurona(perc);// agrego el perceptron hijo a la nueva capa
       }

       capas.Add(capanueva);  //ya que se le ah ingresado todos los perceptrones a la capa esta se agrega a la lista.          
   }  

   
   public List<Double> entrenar() 
   {
       Capas aux = new Capas();
       for ( int l = capas .Count-1  ; l >= 0; l--)//ciclo que recorre todas las capas de la red de la ultima a la primera
       {
           aux.RetroPropagar(salidaEsperada );
       }
       for (int x = capas.Count - 1; x >= 0; x--)//ciclo que recorre todas las capas de la red de la ultima a la primera
       {
           capas[x].CorregirPesos();// este corrige los pesos capa por capa.
       }
       return propagar();
   }
   
   public List<Double> evaluar()// este metodo para comparar las salidas de la red con las esperadas si no se inicia el entreno
   {
      return propagar();
   }
   
   public void SetSalidasEsperadas(List<Double> targets)
   {
       this.salidaEsperada = targets; 
   }
   
   public void OrganizarCapas()
   {
      // TODO: implement
   }

   public Capas ObtenerCapaDeSalida() // se devuelve la ultima capa
   {
       Capas  ultima = this.capas[capas.Count - 1];// uso ultima para  especificar la capa que retorno
       return ultima;
   }

   private List<Double> propagar()
   {
       List<Double> capasalida; //este me servira para guardar las salidas de la capa  en proceso
       capasalida = null; 
       for (int i = 0; i < capas.Count; i++)//recorro todas las capas
       {
          capasalida =  capas[i].ObtenerSalidas(capas[i].Entradas);// obtengo las salidas y las guardo en la lista
       }
       return capasalida; //al terminar las iteraciones se queda almacenada la de la ultima capa.
   }



}