function dayOfWeek(input: string): void {
  enum DaysOfWeek {
    "Monday" = 1,
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday",
  }
  console.log(DaysOfWeek[input] ? DaysOfWeek[input] : "error");
}

dayOfWeek("Monday");
dayOfWeek("Friday");
dayOfWeek("Invalid");
