const aggregateElements = (numbers: number[]): void => {
  const sum: number = sumNumbers(numbers);
  const sumInverse: number = sumInverseValues(numbers);
  const concat: string = concatNumbers(numbers);

  console.log(sum);
  console.log(sumInverse);
  console.log(concat);
};

const sumNumbers = (numbers: number[]): number => {
  let sum: number = 0;

  numbers.forEach((num) => {
    sum += num;
  });

  return sum;
};

const sumInverseValues = (numbers: number[]): number => {
  let sumInverse: number = 0;

  numbers.forEach((num) => {
    sumInverse += 1 / num;
  });

  return sumInverse;
};

const concatNumbers = (numbers: number[]): string => {
  let concat: string = "";

  numbers.forEach((num) => {
    concat += num.toString();
  });

  return concat;
};

aggregateElements([1, 2, 3]);
aggregateElements([2, 4, 8, 16]);
