function validarFormulario(event) {
    event.preventDefault();  // evitar que a página seja recarregada

    var email = document.getElementById("email").value;
    var pwd = document.getElementById("pwd").value;
    var confirm_pwd = document.getElementById("confirm_pwd").value;

    // Verificar se o email tem um formato válido
    var emailRegex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    if (!emailRegex.test(email)) {
        alert("Por favor, insira um email válido.");
        return;
    }

    // Verificar se a senha tem pelo menos 10 caracteres
    if (pwd.length < 10) {
        alert("A senha deve ter pelo menos 10 caracteres.");
        return;
    }

    // Verificar se as senhas correspondem
    if (pwd !== confirm_pwd) {
        alert("As senhas não correspondem.");
        return;
    }

    // Armazenar o usuário na sessionStorage e redirecionar para a página inicial
  // Armazenar o usuário no localStorage e redirecionar para a página inicial
    localStorage.setItem("email", email);
    localStorage.setItem("pwd", pwd);

    window.location.href = "home.html";
}