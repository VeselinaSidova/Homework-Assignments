function solve(speed, area) {
    let limit = 0;
    let status;
    switch (area) {
        case 'motorway':
            limit = 130;
            break;
        case 'interstate':
            limit = 90;
            break;
        case 'city':
            limit = 50;
            break;
        case 'residential':
            limit = 20;
            break;
    }
    if (speed - limit <= 20 && speed - limit > 0) {
        status = 'speeding';
    }
    else if (speed - limit > 20 && speed - limit <= 40) {
        status = 'excessive speeding';
    }
    else if (speed - limit > 40) {
        status = 'reckless driving';
    }

    if (speed <= limit) {
        console.log(`Driving ${speed} km/h in a ${limit} zone`);
    } else {
        let difference = speed - limit;
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${limit} - ${status}`);
    }
}

solve(40, 'city')
solve(21, 'residential');
solve(120, 'interstate');
solve(200, 'motorway');
