$(document).ready(function(){
    $("#factorial").click(function(){
        var x=fact(5);
        alert(x);
        document.getElementById("div1").innerText=x;
    })
});

function fact(x){
    if(x==1)
    return 1;
    else
    return x*fact(x-1);
}

// sum
$(document).ready(function(){
    $("#sum1").click(function(){
        var x=sum(5,6);
        alert(x);
        document.getElementById("sum").innerText=x;
    })
});

function sum(x,y){
    return x+y;
}

//closure 

// Initiate counter
let counter = 0;

// Function to increment counter
function add() {
  counter += 1;
}

// Call add() 3 times
add();
add();
add();

// The counter should now be 3
$(document).ready(function(){
    $("#closure1").click(function(){
        document.getElementById("closure").innerHTML = counter;

    })
});

//spread

$(document).ready(function(){
    $("#spread1").click(function(){
        num1 = [1, 3, 4];
        var x= sum(...num1);
        document.getElementById("spread").innerHTML = x;
    })
});
function sum(x, y ,z) {
    return x+y+z;
}



