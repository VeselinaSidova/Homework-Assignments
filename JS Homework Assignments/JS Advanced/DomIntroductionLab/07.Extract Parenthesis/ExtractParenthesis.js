function extract(content) {
    let textElement = document.getElementById(content).textContent; 
    let pattern = /\(([^)]+)\)/g;
    let result = [];

    let match = pattern.exec(textElement);
    while (match) {
        result.push(match[1]);
        match = pattern.exec(textElement);
    }

    return result.join('; ');
}