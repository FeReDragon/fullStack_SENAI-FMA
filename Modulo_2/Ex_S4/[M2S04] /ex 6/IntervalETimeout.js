// Função exibe "Olá, Mundo!" na console após 3 segundos
function saudacao() {
    setTimeout(() => {
        console.log("Olá, Mundo!");
    }, 3000);
}

saudacao();

// Função exibe um numero apos cada segundo ate completar 10 segundos
function contar() {
    let contador = 1;
    let intervalo = setInterval(() => {
        console.log(contador);

        if (contador === 10) {
            clearInterval(intervalo);
        }

        contador++;
    }, 1000);
}

contar();
