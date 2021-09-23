function solve(firstNumber, secondNumber, operationSign) {
    let result = 0;
    switch (operationSign) {
        case '+':
            result = firstNumber + secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '/':
           result = firstNumber / secondNumber;
            break;
        case '%':
            result = firstNumber % secondNumber;
            break;
        case '**':
            result = firstNumber ** secondNumber;
             break;
    }
    console.log(result);
}

solve(5, 6, '+');