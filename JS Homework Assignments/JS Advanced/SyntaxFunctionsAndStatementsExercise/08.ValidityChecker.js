function solve(number1, number2, number3, number4) {
    let x1 = Number(number1);
    let y1 = Number(number2);
    let x2 = Number(number3);
    let y2 = Number(number4);

    console.log(`{${x1}, ${y1}} to {0, 0} is ${checkValidity(isValid(x1, y1, 0, 0))}`);
    console.log(`{${x2}, ${y2}} to {0, 0} is ${checkValidity(isValid(x2, y2, 0, 0))}`);
    console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${checkValidity(isValid(x1, y1, x2, y2))}`);

    function isValid(x1, y1, x2, y2) {
        let value = Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2);
        return Number.isInteger(value);
    }
    
    function checkValidity(validity) {
        return validity ? 'valid' : 'invalid';
    }
}

solve(3, 0, 0, 4);