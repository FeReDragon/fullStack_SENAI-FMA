function validarLogin(event) {
    event.preventDefault();  // evitar que a página seja recarregada

    var email = document.getElementById("email").value;
    var pwd = document.getElementById("pwd").value;

    // Pegar os dados do usuário do localStorage
    var storedEmail = localStorage.getItem("email");
    var storedPwd = localStorage.getItem("pwd");


    // Verificar se o email e a senha correspondem aos armazenados
    if (email === storedEmail && pwd === storedPwd) {
        // Se sim, redirecionar para a página inicial
        window.location.href = "home.html";
    } else {
        // Se não, exibir um alerta
        alert("Usuário não cadastrado ou informações inválidas.");
    }
}