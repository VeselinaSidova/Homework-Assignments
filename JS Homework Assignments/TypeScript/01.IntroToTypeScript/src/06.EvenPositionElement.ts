function evenPosition(arr: string[]): string {
  let evenElements: string = "";
  for (let i = 0; i < arr.length; i += 2) {
    evenElements += arr[i] + " ";
  }
  return evenElements;
}

console.log(evenPosition(["20", "30", "40", "50", "60"]));
