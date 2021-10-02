function solve(matrix) {

    let playField = [
        [false, false, false],
        [false, false, false],
        [false, false, false]
    ];

    let isPlayerX = true;

    for (let i = 0; i < matrix.length; i++) {
        let [row, col] = matrix[i].split(' ').map(x => Number(x));

        if (playField[row][col]) {
            console.log("This place is already taken. Please choose another!");
            continue;
        }
        
        playField[row][col] = isPlayerX ? 'X' : 'O';
        isPlayerX = !isPlayerX;
        let gameEnded = hasGameEnded(playField);

        if (gameEnded) {
            break;
        }
    }

    playField.forEach((el) => {
        console.log(el.join("\t"))
    });

    function hasGameEnded(field) {
        for (let row = 0; row < field.length; row++) {
            let isSameX = field[row].every(x => x === 'X');
            let isSameO = field[row].every(x => x === 'O');
            
            if (isSameX || isSameO) {
                console.log(`Player ${isSameX ? 'X' : 'O'} wins!`);
                return true;
            }
        }

        for (let col = 0; col < field.length; col++) {
           if (field[0][col] === field[col][col] &&
               field[col][1] === field[col][2] &&
               field[col][0] !== false &&
               field[col][1] !== false &&
               field[col][2] !== false) {
                console.log(`Player ${field[col][0]} wins!`);
                return true;
           }
        }

        if (field[0][0] === field[1][1] &&
            field[1][1] === field[2][2] &&
            field[0][0] !== false &&
            field[1][1] !== false &&
            field[2][2] !== false) {
                console.log(`Player ${field[0][0]} wins!`);
                return true;
        }

        if (field[2][0] === field[1][1] &&
            field[1][1] === field[0][2] &&
            field[2][0] !== false &&
            field[1][1] !== false &&
            field[0][2] !== false) {
                console.log(`Player ${field[2][0]} wins!`);
                return true;
        }

        if (field[0].every(x => x !== false) &&
            field[1].every(x => x !== false) &&
            field[2].every(x => x !== false)) {
                console.log("The game ended! Nobody wins :(");
                return true;
        }
        return false;
    }
}

solve(["0 0",
"0 0",
"0 1",
"1 1",
"0 2",]);