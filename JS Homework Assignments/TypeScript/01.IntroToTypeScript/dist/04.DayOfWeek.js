function dayOfWeek(input) {
    let DaysOfWeek;
    (function (DaysOfWeek) {
        DaysOfWeek[DaysOfWeek["Monday"] = 1] = "Monday";
        DaysOfWeek[DaysOfWeek["Tuesday"] = 2] = "Tuesday";
        DaysOfWeek[DaysOfWeek["Wednesday"] = 3] = "Wednesday";
        DaysOfWeek[DaysOfWeek["Thursday"] = 4] = "Thursday";
        DaysOfWeek[DaysOfWeek["Friday"] = 5] = "Friday";
        DaysOfWeek[DaysOfWeek["Saturday"] = 6] = "Saturday";
        DaysOfWeek[DaysOfWeek["Sunday"] = 7] = "Sunday";
    })(DaysOfWeek || (DaysOfWeek = {}));
    console.log(DaysOfWeek[input] ? DaysOfWeek[input] : "error");
}
dayOfWeek("Monday");
dayOfWeek("Friday");
dayOfWeek("Invalid");
