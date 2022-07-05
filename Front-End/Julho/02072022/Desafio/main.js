document.getElementById('formulario').addEventListener('submit', function (e) {
    e.preventDefault();
    document.getElementById('tabela-dados').classList.remove('d-none');
    envioTabela();
});

const termosAceiteElement = document.getElementById('Aceite')

termosAceiteElement.addEventListener('scroll', () => {
    if (termosAceiteElement.offsetHeight + termosAceiteElement.scrollTop >= termosAceiteElement.scrollHeight) {
        document.getElementById("i-aceite").disabled = false;
    }
})

document.getElementById('Nome').addEventListener('keyup', gerarLogin);
document.getElementById('Sobrenome').addEventListener('keyup', gerarLogin);

function gerarLogin() {
    const nome = document.getElementById('Nome').value;
    const sobrenome = document.getElementById('Sobrenome').value;
    const login = nome + '.' + sobrenome;
    document.getElementById('Login').value = login.toLowerCase();
}

function pesquisacep() {
    var cep = document.getElementById('CEP').value.replace(/\D/g, '');

    if (cep != "") {

        var validacep = /^[0-9]{8}$/;

        if (validacep.test(cep)) {
            const url = 'https://viacep.com.br/ws/' + cep + '/json/';
            fetch(url)
                .then(response => response.json())
                .then(json => {
                    if (json.logradouro) {
                        document.getElementById('Endereco').value = json.logradouro;
                        document.getElementById('Bairro').value = json.bairro;
                        document.getElementById('Cidade').value = json.localidade;
                        document.getElementById('Estado').value = json.uf;
                        document.getElementById('Complemento').value = json.complemento;
                    } else {
                        alert("CEP NÃO ENCONTRADO")
                    }
                })
        } else {
            alert("CEP INVÁLIDO")
        }
    }
}

function envioTabela() {
    //Copiando os valores para a tabela
    document.getElementById('t-nome').innerHTML = document.getElementById('Nome').value;
    document.getElementById('t-sobrenome').innerHTML = document.getElementById('Sobrenome').value;
    document.getElementById('t-email').innerHTML = document.getElementById('Email').value;
    document.getElementById('t-login').innerHTML = document.getElementById('Login').value;
    document.getElementById('t-senha').innerHTML = document.getElementById('Senha').value;
    document.getElementById('t-cep').innerHTML = document.getElementById('CEP').value;
    document.getElementById('t-endereco').innerHTML = document.getElementById('Endereco').value;
    document.getElementById('t-complemento').innerHTML = document.getElementById('Complemento').value;
    document.getElementById('t-bairro').innerHTML = document.getElementById('Bairro').value;
    document.getElementById('t-cidade').innerHTML = document.getElementById('Cidade').value;
    document.getElementById('t-estado').innerHTML = document.getElementById('Estado').value;
    document.getElementById('t-github').innerHTML = document.getElementById('perfilgithub').value;
    var iAcademia = document.getElementById("academia");
    document.getElementById('t-academia').innerHTML = iAcademia.options[iAcademia.selectedIndex].text;
    var iProfessor = document.getElementById("professor");
    document.getElementById('t-professor').innerHTML = iProfessor.options[iProfessor.selectedIndex].text;
    document.getElementById('t-aceite').innerHTML = document.getElementById('i-aceite').value == "on" ? 'Sim' : 'Não'
    document.getElementById('t-info').innerHTML = document.querySelector('input[name=info]:checked') == "on" ? 'Sim' : 'Não'
};