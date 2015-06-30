calcularGradiente()
Calcula el gradiente de la neurona, si no tiene hijos se trata de la capa de salida y se aplica (a-a²)×e
Si tiene hijos se trata de cualquier otra capa oculta, y se aplica: (a-a²)×SUMATORIA(pesosNeuronaHija\*gradienteNeuronaHija)La sumatoria es para cada neurona hija...

> public Double calcularGradiente()
> {
> > // Se efectúa la sumatoria...
> > > gradiente = 0;
> > > if (hijos.Count > 0)
> > > {
> > > > Double w;
> > > > Double gradHijo;
> > > > Double Acum = 0;
> > > > foreach (Perceptron hijo in hijos)
> > > > {
> > > > > w = hijo.DequeueW();
> > > > > gradHijo = hijo.getGradiente();
> > > > > Acum = Acum + w **gradHijo;

> > > > }
> > > > gradiente = (salida - Math.Pow(salida, 2))** Acum;

> > > }
> > > else
> > > > gradiente = error **(salida - Math.Pow(salida, 2));**


> return gradiente;
> }

calcularDeltaW()
deltaW=n\*gradiente\*salida
> public Double calcularDeltaW()
> {
> > deltaW = ManejoCapas.constanteAprendizaje **gradiente ;
> > return deltaW;

> }**

> /// Corrige los pesos de esta neurona, asumiendo que ya se ha calculado el deltaW para cada entrada de la neurona...
> > public void corregirPesos()

> {
> > for (int i = 0; i < peso.Count; i++)
> > {
> > > peso[i](i.md) = peso[i](i.md) + deltaW\*entrada[i](i.md);

> > }
> > ganancia = ganancia + deltaW;


> }