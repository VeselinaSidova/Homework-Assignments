function solve() {
  let input = document.getElementById('text').value;
  let currentCase = document.getElementById('naming-convention').value;
  let resultElement = document.getElementById('result');
  let result = '';
  let words = [];
  
  input = input.toLowerCase();

  if (currentCase == 'Camel Case') {
    words = input.split(' ');
    result += words[0];

    for (let i = 1; i < words.length; i++) {
      let wordToTransform = words[i];
      wordToTransform = wordToTransform.charAt(0).toUpperCase() + wordToTransform.slice(1);
      result += wordToTransform;
    }
  } else if (currentCase == 'Pascal Case') {
    words = input.split(' ');

    for (let i = 0; i < words.length; i++) {
      let wordToTransform = words[i];
      wordToTransform = wordToTransform.charAt(0).toUpperCase() + wordToTransform.slice(1);
      result += wordToTransform;
    }
  } else {
    result = 'Error!';
  }
  resultElement.textContent = result;
}