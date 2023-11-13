function solve(first, second) {
    let firstNumber = Number(first);
    let secondNumber = Number(second);
    let minNumber = Math.min(firstNumber, secondNumber);
    let maxNumber = Math.max(firstNumber, secondNumber);
    let greatestDivider = 1;

    for (let i = minNumber; i < maxNumber; i++) {
        if (maxNumber % i == 0 && minNumber % i == 0) {
            greatestDivider = i;
            break;
        }    
    }
    console.log(greatestDivider);
}

solve(15, 5);