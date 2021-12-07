function generateReport() {
    let boxes = document.querySelectorAll('input');
    let tableRows = document.getElementsByTagName('tr');
    let output = document.querySelector('#output');

    let result = [];

   for (let i = 1; i < tableRows.length; i++) {
       let report = {};

       for (let k = 0; k < boxes.length; k++) {
            if (boxes[k].checked) {
                report[boxes[k].name] = tableRows[i].children[k].textContent;
            }
       }
       result.push(report);
   }
   output.textContent = JSON.stringify(result);
}

