function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let inputElement = document.getElementById('searchField');
      let tableRowElements = Array.from(document.querySelectorAll('tbody tr'));

      tableRowElements.forEach(el => {
         let text = el.textContent.toLowerCase();
         if (text.includes(inputElement.value.toLowerCase())) {
            el.classList.add('select');
         } else {
            el.classList.remove('select');
         }
      });
      inputElement.value = '';
   }
}