function search() {
   let divElements = document.querySelectorAll('ul li');
   let citiesElements = Array.from(divElements).map(x => x.textContent);
   let inputElement = document.getElementById('searchText');
   let counterElement = document.getElementById('result');
   let counter = 0;

   for (let i = 0; i < citiesElements.length; i++) {
      if (citiesElements[i].includes(inputElement.value)) {
         divElements[i].style.textDecoration = 'underline';
         divElements[i].style.fontWeight = 'bold';
         counter++;
      }
   }

   counterElement.textContent = `${counter} matches found`;
   inputElement.value = '';
}
