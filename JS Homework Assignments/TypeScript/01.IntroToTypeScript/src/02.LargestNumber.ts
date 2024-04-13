function largestNumber(num1: number, num2: number, num3: number): number {
  let arr: number[] = [num1, num2, num3];
  return arr.sort((x, y) => x - y)[arr.length - 1];
}

console.log(`The largest number is ${largestNumber(5, -3, 16)}.`);
console.log(`The largest number is ${largestNumber(-3, -5, -22.5)}.`);
