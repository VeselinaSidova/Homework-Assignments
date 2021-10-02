function solve(input) {
    let sorted = input.sort((a,b) => a - b);
    let result = 0;
    if (input.length % 2 == 0) {
        result = sorted.slice(sorted.length / 2);
    } else {
        result = sorted.slice(Math.round(sorted.length / 2 - 1));
    }
    return result;
}

solve([4, 7, 2, 5]);
solve([3, 19, 14, 7, 2, 19, 6]);