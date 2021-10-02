function solve(firstElement, secondElement) {
    let firstNumber = Number(firstElement);
    let secondNumber = Number(secondElement);
    let sum = 0;

    for (let i = firstNumber; i <= secondNumber; i++) {
        sum += i;
    }

    console.log(sum);
}

solve('1', '5');