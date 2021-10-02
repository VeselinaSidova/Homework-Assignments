function solve(numberInput, action1, action2, action3, action4, action5) {
    let number = Number(numberInput);

    const parser = {
        chop() { number /= 2; },
        dice() { number = Math.sqrt(number); },
        spice() { number++; },
        bake() { number *= 3; },
        fillet() { number *= 0.8; }
    }
        parser[action1]();
        console.log(number);
        parser[action2]();
        console.log(number);
        parser[action3]();
        console.log(number);
        parser[action4]();
        console.log(number);
        parser[action5]();
        console.log(number);
    }

    solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');