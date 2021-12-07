function sumTable() {
    let tableElements = document.querySelectorAll('td:nth-child(2n)');
    let sum = 0;

    for (let i = 0; i < tableElements.length - 1; i++) {
        sum += Number(tableElements[i].textContent);
    }
    document.getElementById('sum').textContent = sum;
}