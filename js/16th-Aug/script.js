
console.log("Hey there");

let numArr = [8, 4, 4, 36, 12, 40, 70, 160];
let stringArr = [
  "utkarsh",
  "harsh",
  "mohit",
  "mudit",
  "Abhishek",
];

// Using copyWithin()
console.log(
  "Copying and appending the first 2 elements of num array to the array itself: numArr = ",
  numArr.copyWithin(2)
);

// filtering the records in the array
console.log(
  "Filtering all the elements greater than 10 from an array: ",
  numArr.filter((value) => value >= 20)
);

//Using find()
console.log(
  "Finding the fisrt occurence of a particular record from an array using find method: ",
  stringArr.find((el) => el.length > 10)
);

// Using findIndex();
console.log(
  "Finding the index of first occuring element from an array: ",
  numArr.findIndex((el) => el > 10)
);

//forEach using callback function
stringArr.forEach(function (name) {
  console.log("Hello! " + name);
});

// sort method
console.log("sorted array: ", numArr.sort());

// Greet user using an Anonymous function
let greetUser = function () {
  console.log("WELCOME TO THIS JS TRAINING BOOTCAMP!!");
};
greetUser();

// Using setTimeout() with anonymous function
setTimeout(function () {
  console.log("This will trigger just after 5 seconds");
}, 5000);

// async/await

async function greet() {
  let promise = new Promise((resolve, reject) => {
    setTimeout(() => resolve("Hey there!! Hope You're doing good"), 7000);
  });

  let result = await promise;

  alert(result); //this will make an alert only after the promise gets resolved i.e. after 7 seconds.
}

greet();
