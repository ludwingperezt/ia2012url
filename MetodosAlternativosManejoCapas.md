> public ManejoCapas( )
> {
> > rnd = new Random(DateTime.Now.Millisecond);
> > capas = new List

&lt;Capas&gt;

();

> }


> public List

&lt;double&gt;

 entrenar( )
> {
> > // TODO: implement
> > limpiarTodasEntradasNeuronas( );
> > propagar( );


> //Debido a que los pesos no se deben cambiar, hasta encontrar las gradientes de las capas ocultas... primero se encuentran
> //todas las gradientes y delta's W, luego se vuelve a iterar capa a capa para corregir pesos...
> for (int i = capas.Count - 1; i >= 0; i--)
> > capas[i](i.md).retroPropagar(salidaEsperada);


> //Luego de haber encontrado las gradientes de cada neurona de cada capa, se procede a corregir los pesos...
> for (int i = capas.Count - 1; i >= 0; i--)
> > capas[i](i.md).corregirPesos( );


> limpiarTodasEntradasNeuronas( );
> return propagar( );
> }

> private List

&lt;Double&gt;

 propagar( )
> {
> > List

&lt;Double&gt;

 salidas=entradas;
> > foreach (Capas unaCapa in capas)
> > > salidas = unaCapa.ObtenerSalidas();


> return salidas;
> }