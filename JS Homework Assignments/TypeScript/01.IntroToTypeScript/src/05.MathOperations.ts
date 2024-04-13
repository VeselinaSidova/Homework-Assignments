function calculator(num1: number, num2: number, symbol: string): number {
  switch (symbol) {
    case "+":
      return num1 + num2;
      break;
    case "-":
      return num1 - num2;
      break;
    case "*":
      return num1 * num2;
      break;
    case "/":
      return num1 / num2;
      break;
    case "%":
      return num1 % num2;
      break;
    case "**":
      return num1 ** num2;
      break;
    default:
      throw Error("Invalid operation");
      break;
  }
}

console.log(calculator(5, 6, "+"));
console.log(calculator(3, 5.5, "*"));
