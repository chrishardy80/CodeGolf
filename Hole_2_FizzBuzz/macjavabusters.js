for (i = 1; i < 101; i++) {
var a = 0;

  if (i % 3 == 0) {
  console.log("Fizz ");
  a = 1;
  }
  if(i % 5 == 0) {

  console.log("Buzz");
  a = 1;
  }
  if (a == 0) {
  console.log(i);
  }

}
