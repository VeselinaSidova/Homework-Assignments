function solve(input) {
    let result = input.map(row => Math.max(...row));
    console.log(Math.max(...result));
}

solve([[20, 50, 10],
    [8, 33, 145]]);