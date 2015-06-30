> public Capas(List

&lt;Double&gt;

 entradas)
> {
> > this.entradas = entradas;
> > Neuronas = new List

&lt;Perceptron&gt;

(entradas.Count);

> }

> public void retroPropagar(List

&lt;Double&gt;

 esperadas)
> {
> > int i = 0;
> > foreach (Perceptron p in Neuronas)
> > {
> > > if (p.perteneceACapaSalida())
> > > > p.calcularError(esperadas[i](i.md));

> > > p.calcularGradiente();
> > > p.calcularDeltaW();
> > > i = i + 1;

> > }

> }

> public Double CalcularErrorCuadratico(List

&lt;Double&gt;

 salidasEsperadas)
> {
> > // TODO: implement
> > Double acum = 0;
> > for (int i = 0; i < salidasEsperadas.Count; i++)
> > {
> > > acum = acum + Math.Pow(Neuronas[i](i.md).calcularError(salidasEsperadas[i](i.md)), 2);

> > }
> > acum = acum **0.5;
> > return acum;

> }**

> public List

&lt;Double&gt;

 ObtenerSalidas()
> {
> > // TODO: implement
> > List

&lt;Double&gt;

 salidas = new List

&lt;Double&gt;

();
> > for (int i = 0; i < Neuronas.Count; i++)
> > > salidas.Add(Neuronas[i](i.md).generarSalida());


> return salidas;
> }