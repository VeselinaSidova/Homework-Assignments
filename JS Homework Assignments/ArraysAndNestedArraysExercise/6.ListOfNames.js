function solve(input) {
    input
        .sort((a, b) => a.localeCompare(b))
        .forEach((e, i) => console.log(`${[i + 1]}.${input[i]}`));
}

solve(["John", "Bob", "Christina", "Ema"]);