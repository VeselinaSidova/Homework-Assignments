function solve(matrix) {
    let magicSum = Number.MIN_SAFE_INTEGER;
    let isMagicMatrix = true;

    for (let row = 0; row < matrix.length; row++) {
        let sum = matrix[row].reduce((acc, el) => acc + el);
        
        if (magicSum === Number.MIN_SAFE_INTEGER) {
            magicSum = sum;
        }

        if (sum != magicSum) {
            isMagicMatrix = false;
        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let sum = 0;
        for (let row = 0; row < matrix.length; row++) {
            let el = matrix[row][col];
            sum += el;
        }
        
        if (sum != magicSum) {
            isMagicMatrix = false;
        }
    }

    console.log(isMagicMatrix);
}

solve([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]);