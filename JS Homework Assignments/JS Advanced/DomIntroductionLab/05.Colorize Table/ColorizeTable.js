function colorize() {
    let tableElements = document.querySelectorAll('tr:nth-child(2n)');

    for (const tableElement of tableElements) {
        tableElement.style.background = 'teal';
    }
}