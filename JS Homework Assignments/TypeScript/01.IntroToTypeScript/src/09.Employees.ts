const employeeNumberCreator = (employees: string[]): void => {
  let employeeNumber: number = 0;
  let employee: string = "";

  for (let i = 0; i < employees.length; i++) {
    employee = employees[i];
    employeeNumber = employees[i].length;
    console.log(`Name: ${employee} -- Personal Number: ${employees[i].length}`);
  }
};

employeeNumberCreator([
  "Silas Butler",
  "Adnaan Buckley",
  "Juan Peterson",
  "Brendan Villarreal",
]);
