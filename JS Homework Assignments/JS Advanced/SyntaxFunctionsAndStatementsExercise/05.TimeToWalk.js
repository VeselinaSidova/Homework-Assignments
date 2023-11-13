function solve(steps, footprint, speed) {
    let meters = steps * footprint;
    let timeInSeconds = Math.round((meters / 1000) / speed * 3600);
    let stops = Math.floor(meters / 500);
    let totalTimeInSeconds = (stops * 60) + timeInSeconds;

    let hours = Math.floor(totalTimeInSeconds / 3600);
    let minutes = Math.floor(totalTimeInSeconds / 60);
    let seconds = totalTimeInSeconds % 60;

    console.log(`${hours < 10 ? 0 : ""}${hours}:${minutes < 10 ? 0 : ""}${minutes}:${seconds < 10 ? 0 : ""}${seconds}`);
}

solve(4000, 0.60, 5);
solve(2564, 0.70, 5.5);