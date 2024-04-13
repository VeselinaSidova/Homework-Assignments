function largestNumber(num1, num2, num3) {
    let arr = [num1, num2, num3];
    return arr.sort((x, y) => x - y)[arr.length - 1];
}
console.log(`The largest number is ${largestNumber(5, -3, 16)}.`);
console.log(`The largest number is ${largestNumber(-3, -5, -22.5)}.`);
