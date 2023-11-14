function solve(input) {
    let words = input.match(/[A-Za-z0-9]+/g);
    console.log(words.join(', ').toUpperCase());
}

solve('Hi, how are you?');