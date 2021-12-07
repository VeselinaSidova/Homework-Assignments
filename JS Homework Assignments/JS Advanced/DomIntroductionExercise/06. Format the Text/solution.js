function solve() {
  let inputElement = document.getElementById('input');
  let text = inputElement.value;

  let sentences = text.split('.').filter(x => x !== '').map(x =>  x + '.');

  let paragraphRoof = Math.ceil(sentences.length / 3);

  let outputDivElement = document.getElementById('output');

  for (let i = 0; i < paragraphRoof; i++) {
    outputDivElement.innerHTML += `<p>${sentences.splice(0, 3).join('')}</p>`;
  }
}