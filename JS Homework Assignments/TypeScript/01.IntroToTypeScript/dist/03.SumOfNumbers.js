function sumOfNumbers(first, second) {
    const num1 = Number(first);
    const num2 = Number(second);
    let sum = 0;
    for (let i = num1; i <= num2; i++) {
        sum += i;
    }
    return sum;
}
console.log(sumOfNumbers("1", "5"));
console.log(sumOfNumbers("-8", "20"));
