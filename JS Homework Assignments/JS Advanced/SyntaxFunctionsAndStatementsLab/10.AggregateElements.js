function solve(numbers) {
    const sum = function(numbers) {
        let result = 0;
        for (let number of numbers) {
            result += number;
        }
        return result;
    };

    const sumInverted = function(numbers) {
        let result = 0;
        for (let number of numbers) {
            result +=  1 / number;
        }
        return result;
    };

    const concat = function(numbers) {
        let result = numbers.join('');
        return result;
    }

    console.log(sum(numbers));
    console.log(sumInverted(numbers));
    console.log(concat(numbers));
}

solve([2, 4, 8, 16]);