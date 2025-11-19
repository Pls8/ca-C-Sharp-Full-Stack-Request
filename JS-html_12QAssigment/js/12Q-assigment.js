//________________________________________________________________________________________1
console.log("//Q1 - Print first 10 even numbers");

let numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
for (let num of numbers) {
  if (num % 2 === 0) {
    console.log(`${num} is even`);
  }
}
console.log();
//________________________________________________________________________________________1 END



//________________________________________________________________________________________2
console.log("//Q2 - Print first 15 Fibonacci numbers");

let a = 0, b = 1, c;
console.log("15 Fibonacci numbers");

for (let i = 0; i < 15; i++) {
  c = a + b;
  a = b;
  b = c;
  console.log(`_${i+1} : ${c}`);
}
console.log();
//________________________________________________________________________________________2 END



//________________________________________________________________________________________3
console.log("//Q3 - Print first 10 powers of 2");

console.log("10 Number of Powers 2");
for (let i = 1; i <= 10; i++) {
  //let x = i * i;
  // let x = Math.pow(i, 2);
  let x = i ** 2;
  console.log(`_${i} : ${x}`);
}
console.log();
//________________________________________________________________________________________3 END



//________________________________________________________________________________________4
console.log("//Q4 - Find largest number in an array");

let numQ4 = [3, 4, 6, 2, 1, 7, 9];

let max = Math.max(...numQ4);
//let max = Math.max.apply(null, numQ4);
//let max = numQ4.reduce((a, b) => Math.max(a, b));
console.log(`MAX Number using Math.max: ${max}`);

let largest = 0;
for (let n of numQ4) {
  if (n >= largest) {
    largest = n;
  }
}
console.log(`Largest number by loop: ${largest}`);
console.log();
//________________________________________________________________________________________4 END



//________________________________________________________________________________________5
console.log("//Q5 - Print a square pattern using two loops");

for (let i = 0; i < 4; i++) { 
    let row = "";
    for (let j = 0; j < 8; j++) {   
        row += "*";
    }
    console.log(row);
}
//________________________________________________________________________________________5 END



//________________________________________________________________________________________6
console.log("//Q6 - Prime number check");

let primeArray = [7, 32, 45, 14, 13, 45, 67, 13, 15, 997];

for (let n of primeArray) {
  let isPrime = true;

  if (n <= 1) isPrime = false;

  for (let i = 2; i * i <= n; i++) {
    if (n % i === 0) {
      console.log(`${n} is NOT a prime number`);
      isPrime = false;
      break;
    }
  }

  if (isPrime) console.log(`${n} IS a prime number`);
}
console.log();
//________________________________________________________________________________________6 END



//________________________________________________________________________________________7
console.log("//Q7 - Sum of digits");

let digit = 4114;
let str = digit.toString();
let sum = 0;

for (let ch of str) {
  sum += Number(ch);
}

console.log(`Sum of digits in ${digit} = ${sum}`);
console.log();
//________________________________________________________________________________________7 END



//________________________________________________________________________________________8
console.log("//Q8 - Reverse a string");

let mStr = "TEST";
let reverseStr = "";

for (let i = mStr.length - 1; i >= 0; i--) {
  reverseStr += mStr[i];
}

console.log("The Reversed String: " + reverseStr);
console.log();
//________________________________________________________________________________________8 END



//________________________________________________________________________________________9
console.log("//Q9 - Count vowels in a string");

let vowStr = "makeen";
let vowelCount = 0;

for (let c of vowStr) {
  if ("aeiou".includes(c)) {
    vowelCount++;
  }
}

console.log(`Number of vowels in '${vowStr}': ${vowelCount}`);
console.log();
//________________________________________________________________________________________9 END



//________________________________________________________________________________________10
console.log("//Q10 - Sum of even numbers from 1 to 100");

let evenSum = 0;
for (let i = 0; i <= 100; i++) {
  if (i % 2 === 0) evenSum += i;
}
console.log(`Sum of all even numbers = ${evenSum}`);
console.log();
//________________________________________________________________________________________10 END



//________________________________________________________________________________________11
console.log("//Q11 - Factorial of a number");

let numberToFact = 4;
let fact = 1;

for (let i = 1; i <= numberToFact; i++) {
  fact *= i;
}

console.log(`Factorial of ${numberToFact} = ${fact}`);
console.log();
//________________________________________________________________________________________11 END



//________________________________________________________________________________________12
console.log("//Q12 - Sort an array ascending");

let unsorted = [4, 9, 2, 42, 12];

console.log("Unsorted array:");
console.log(unsorted);

console.log("Sorted array using sort():");
console.log([...unsorted].sort((a, b) => a - b)); // ... spread operator
console.log();

// Manual Selection Sort
console.log("Manual sort:");

// let arr = [...unsorted]; // ... spread operator
// let arr = unsorted.slice();
let arr = Array.from(unsorted); // Array.from() & unsorted.slice() are the same, ...
for (let i = 0; i < arr.length; i++) {
  let minIndex = i;

  for (let j = i + 1; j < arr.length; j++) {
    if (arr[j] < arr[minIndex]) {
      minIndex = j;
    }
  }

  let temp = arr[minIndex];
  arr[minIndex] = arr[i];
  arr[i] = temp;

  console.log(temp);
}
//________________________________________________________________________________________12 END
