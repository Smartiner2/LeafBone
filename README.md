# CARACTERISTICA INVESTIGADA 1:
## Zonas Contaminadas que Reducen la Velocidad del Jugador

Esta caracteristica consiste en crear zonas contaminadas dentro del mapa que afectan temporalmente 
al personaje cuando entra en ellas. La idea es usar áreas invisibles con un Box Collider 2D configurado 
como Is Trigger, para que el jugador pueda atravesarlas normalmente mientras el juego detecta su entrada 
y salida. Cuando el personaje entra a una de estas zonas, un script reduce su velocidad de movimiento para 
simular que la contaminación o el ambiente tóxico lo está afectando, y cuando sale, la velocidad vuelve a la 
normalidad. Esta mecánica ayuda a que el juego se sienta más dinámico y acorde con la temática ambiental o 
peligrosa del mapa, además de añadir un pequeño reto al jugador sin ser demasiado complicada de implementar en Unity.

# CARACTERISTICA INVESTIGADA 2:
## Mecánica de Doble Salto para Mayor Movilidad y Exploración

La mecánica de doble salto permite que el personaje realice un segundo salto mientras se encuentra en el aire, 
brindando mayor movilidad y control durante el desplazamiento. Esta característica amplía las posibilidades de 
exploración y facilita superar obstáculos, plataformas elevadas y zonas de difícil acceso. Además, aporta dinamismo 
a la jugabilidad y hace que el movimiento del personaje se sienta más fluido e interactivo.

# CARACTERISTICA INVESTIGADA 3:
## Sistema de Persecución del Enemigo y Pantalla de Derrota

Implementamos una mecánica de persecución usando un script llamado Enemigo, el cual permite que el enemigo siga 
al jugador durante la partida. También se creó una pantalla de “Game Over” dentro de un Canvas desactivado inicialmente, 
que se activa cuando el enemigo toca al jugador. Para detectar la colisión correctamente, el enemigo fue configurado 
con un Collider 2D en modo Is Trigger y un Rigidbody 2D Kinematic. Finalmente, al colisionar con el jugador, el personaje 
desaparece y se muestra la pantalla de derrota.
