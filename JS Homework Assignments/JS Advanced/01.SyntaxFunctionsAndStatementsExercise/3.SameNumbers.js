function solve(number) {
    let numberAsString = String(number);
    let isSame = true;
    let isFalseCount = 0;
    let sum = numberAsString.length > 0 ? Number(numberAsString[0]) : 0;

    for (let i = 0; i < numberAsString.length - 1; i++) {

        if (numberAsString[0] !== numberAsString[i + 1]) {
            isFalseCount++;
        } 
        sum += Number(numberAsString[i + 1]);
    }
    if (isFalseCount > 0) {
        isSame = false;
    }

    console.log(isSame);
    console.log(sum);
}

solve(2222222);
