const aggregateElements = (numbers) => {
    const sum = sumNumbers(numbers);
    const sumInverse = sumInverseValues(numbers);
    const concat = concatNumbers(numbers);
    console.log(sum);
    console.log(sumInverse);
    console.log(concat);
};
const sumNumbers = (numbers) => {
    let sum = 0;
    numbers.forEach((num) => {
        sum += num;
    });
    return sum;
};
const sumInverseValues = (numbers) => {
    let sumInverse = 0;
    numbers.forEach((num) => {
        sumInverse += 1 / num;
    });
    return sumInverse;
};
const concatNumbers = (numbers) => {
    let concat = "";
    numbers.forEach((num) => {
        concat += num.toString();
    });
    return concat;
};
aggregateElements([1, 2, 3]);
aggregateElements([2, 4, 8, 16]);
