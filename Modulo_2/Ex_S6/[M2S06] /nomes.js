export async function getNomes() {
    let response = await fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking");
    let data = await response.json();
    return data;
}

export function filtrarNomesComA(nomes) {
    return nomes.filter(item => item.nome.toLowerCase().includes('a'));
}

export function filtrarNomesSemA(nomes) {
    return nomes.filter(item => !item.nome.toLowerCase().includes('a'));
}

export function filtrarNomesComMenosDeSeisLetras(nomes) {
    return nomes.filter(item => item.nome.length < 6);
}
