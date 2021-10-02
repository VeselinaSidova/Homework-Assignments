function solve(n, k) {
    let element = 1; 
    let sequence = [];
    sequence.push(element);

    for (let i = 1; i < n; i++) {
        for (let j = 0; j < k; j++) {
            if (sequence.length > 1) {
                element += sequence[j];
            }
        }
        sequence.push(element);
    }
    console.log(sequence);
}

solve(6, 3);