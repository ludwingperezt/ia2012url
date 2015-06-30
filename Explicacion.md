metodo AgregarCapa:
dentro del primer ciclo haga otro ciclo, pero obtenga la capa anterior, y no es necesario que se asegure que esa existe xq a puro tubo cuando se agrega una nueva capa la capa de entrada ya debe existir, es la primera en crearse... entonces para obtener la última capa (sin importar si es capa oculta o capa de entrada) use ultima=capas[capas.count-1] luego dentro del primer ciclo crea otro, pero este va a hacer iteraciones de las neuronas de la capa ultima (utilice ultima.numeroNeuronas())



metodo propagar:
solo tiene que llamar al método obtenerSalidas() de cada capa... ese método se debe enkrgar de lo demás... este método retorna las salidas de la ultima capa... tons para no complicarse vaya wardando las salidas de cada capa, al finalizar el ciclo tendrá las salidas de la ultima capa (es decir, 4 las de la capa de salida)

metodo organizarcapas:
Como entradas para cada neurona serán los pixeles de la imagen... entonces vamos a usar 65 capas ocultas 1 de entrada y una de salida (puede que sean 1 ó 2 menos de ocultas... ya lo cambiaremos si no es tan eficiente el algoritmo... pero al hacer pruebas!) entonces, organizarCapas CREA LA PRIMERA CAPA o de entrada y por cada elemento del array entrada se crea un nuevo peso (neurona.nuevoPeso() aleatoriamente seteará un nuevo peso para esa neurona) esa primera capa se agrega al array capas... luego se va creando una por una, las 65 capas... pero ojo, q es bien importante el numero de neuronas q tendra cada capa, se va disminuyendo ese num... y al final quedarán 4 en la capa de salida... no he pensado en como ir haciendo la disminución del num de capas, creo q será a ensayo y error, x el momento puede elegir alguna combinación que crea conveniente... puede hacer un ciclo, o hacer 66 copy/paste de agregarCapa(numeroDeNeuronasDeLaCapa);
para eso era muy importante crear ese método, xq asi ya no se complik uno tanto la vida en estar haciendo conexiones =O) y las hace ese método!!!