function solve(numberInput, action1, action2, action3, action4, action5) {
    let number = Number(numberInput);

        switch(action1) {
            case 'chop': number /= 2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number++; break;
            case 'bake': number *= 3; break;
            case 'fillet': number *= 0.8; break;
        }
        console.log(number);
        switch(action2) {
            case 'chop': number /= 2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number++; break;
            case 'bake': number *= 3; break;
            case 'fillet': number *= 0.8; break;
        }
        console.log(number);
        switch(action3) {
            case 'chop': number /= 2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number++; break;
            case 'bake': number *= 3; break;
            case 'fillet': number *= 0.8; break;
        }
        console.log(number);
        switch(action4) {
            case 'chop': number /= 2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number++; break;
            case 'bake': number *= 3; break;
            case 'fillet': number *= 0.8; break;
        }
        console.log(number);
        switch(action5) {
            case 'chop': number /= 2; break;
            case 'dice': number = Math.sqrt(number); break;
            case 'spice': number++; break;
            case 'bake': number *= 3; break;
            case 'fillet': number *= 0.8; break;
        }
        console.log(number);
    }

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');